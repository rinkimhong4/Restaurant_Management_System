using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class ReceiptPrinter
{
    private DataGridView dataGridView;
    private PrintDocument printDoc = new PrintDocument();
    private int currentRowIndex = 0;
    private string totalPrice;
    private string amountPaid;
    private string change;

    public ReceiptPrinter(DataGridView dgv, string total, string amount, string change)
    {
        dataGridView = dgv;
        totalPrice = total;
        amountPaid = amount;
        this.change = change;

        // Event handlers for printing
        printDoc.PrintPage += new PrintPageEventHandler(PrintReceiptPage);
        printDoc.EndPrint += new PrintEventHandler(EndPrint);
    }

    public void Print()
    {
        PrintDialog printDialog = new PrintDialog();
        printDialog.Document = printDoc;

        // Show print dialog
        if (printDialog.ShowDialog() == DialogResult.OK)
        {
            currentRowIndex = 0; // Reset row index for fresh print
            printDoc.Print(); // Start printing
        }
    }

    private void PrintReceiptPage(object sender, PrintPageEventArgs e)
    {
        const int colWidth = 120;
        const int headerMargin = 20;
        const int tableMargin = 15;
        const int footerMargin = 40;

        using (Font headerFont = new Font("Arial", 18, FontStyle.Bold))
        using (Font columnFont = new Font("Arial", 12, FontStyle.Bold))
        using (Font contentFont = new Font("Arial", 10))
        using (Font summaryFont = new Font("Arial", 12, FontStyle.Bold))
        using (StringFormat centerFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        })
        using (StringFormat leftFormat = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center
        })
        {
            float yPos = e.MarginBounds.Top;
            Rectangle pageBounds = e.MarginBounds;

            // Print Header
            DrawHeader(e, headerFont, centerFormat, ref yPos, pageBounds, headerMargin);

            // Print Column Headers
            DrawColumnHeaders(e, columnFont, centerFormat, ref yPos, pageBounds, colWidth, tableMargin);

            // Print Rows
            yPos = DrawDataRows(e, contentFont, centerFormat, ref yPos, pageBounds, colWidth, tableMargin, footerMargin);

            // Print Footer (only on last page)
            if (currentRowIndex >= dataGridView.Rows.Count)
            {
                DrawFooter(e, summaryFont, leftFormat, ref yPos, pageBounds, footerMargin);
            }

            e.HasMorePages = currentRowIndex < dataGridView.Rows.Count;
        }
    }

    private void DrawHeader(PrintPageEventArgs e, Font font, StringFormat format, ref float y, Rectangle bounds, int margin)
    {
        string headerText = "BoyHong's Restaurant";
        e.Graphics.DrawString(headerText, font, Brushes.Black,
            new RectangleF(bounds.Left, y, bounds.Width, font.Height), format);
        y += font.Height + margin;
    }

    private void DrawColumnHeaders(PrintPageEventArgs e, Font font, StringFormat format, ref float y, Rectangle bounds, int colWidth, int margin)
    {
        string[] headers = { "PID", "Product Name", "Quantity", "Price" };
        float x = bounds.Left;

        foreach (string header in headers)
        {
            e.Graphics.DrawString(header, font, Brushes.Black,
                new RectangleF(x, y, colWidth, font.Height), format);
            x += colWidth;
        }
        y += font.Height + margin;
    }

    private float DrawDataRows(PrintPageEventArgs e, Font font, StringFormat format, ref float y, Rectangle bounds, int colWidth, int margin, int footerHeight)
    {
        float rowHeight = font.GetHeight(e.Graphics) + margin;

        while (currentRowIndex < dataGridView.Rows.Count)
        {
            DataGridViewRow row = dataGridView.Rows[currentRowIndex];
            float x = bounds.Left;

            if (y + rowHeight + footerHeight > bounds.Bottom)
            {
                break; // Prevent footer overlap
            }

            foreach (DataGridViewCell cell in row.Cells)
            {
                string value = cell.Value?.ToString() ?? string.Empty;
                e.Graphics.DrawString(value, font, Brushes.Black,
                    new RectangleF(x, y, colWidth, font.Height), format);
                x += colWidth;
            }

            y += rowHeight;
            currentRowIndex++;
        }
        return y;
    }

    private void DrawFooter(PrintPageEventArgs e, Font font, StringFormat format, ref float y, Rectangle bounds, int margin)
    {
        float summaryWidth = 200;
        float x = bounds.Right - summaryWidth;
        y = bounds.Bottom - margin - (font.Height * 5);

        string[] summary = {
            $"Total Price: \t{totalPrice}",
            $"Amount Paid: \t{amountPaid}",
            "--------------------------------",
            $"Change: \t{change}"
        };

        foreach (string line in summary)
        {
            e.Graphics.DrawString(line, font, Brushes.Black,
                new RectangleF(x, y, summaryWidth, font.Height), format);
            y += font.Height;
        }

        // Print timestamp
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        e.Graphics.DrawString(timestamp, font, Brushes.Black,
            new RectangleF(bounds.Left, y + margin, bounds.Width, font.Height),
            new StringFormat { Alignment = StringAlignment.Center });
    }

    private void EndPrint(object sender, PrintEventArgs e)
    {
        currentRowIndex = 0; // Reset for future prints
    }
}
