CREATE DATABASE RestaurantMSdb;
use RestaurantMSdb;
CREATE TABLE users(
	id int PRIMARY KEY AUTO_INCREMENT,
	username NVARCHAR(255) not NULL UNIQUE,
    password NVARCHAR(255) not NULL ,
    status NVARCHAR(100) null,
    date_create DATE DEFAULT (current_date)
);

CREATE TABLE categories(
	id int PRIMARY KEY AUTO_INCREMENT,
	category NVARCHAR(255) null,
    status NVARCHAR(100) null,
    date_create DATE DEFAULT (current_date)
);


ALTER TABLE categories 
RENAME COLUMN date_create TO date_insert;

SELECT * FROM categories;

INSERT into users (username,password,status) VALUE ('Admin','123','admin');

CREATE TABLE products(
	id int PRIMARY KEY AUTO_INCREMENT,
    productid varchar(100) null,
    productname VARCHAR(255) null,
    category VARCHAR(255) null,
    stock int null,
    price DECIMAL null,
	status NVARCHAR(100) null,
    date_create DATE DEFAULT (current_date),
    date_update date  null
);

ALTER TABLE products MODIFY COLUMN image VARCHAR(255);

CREATE TABLE orders (
    id INT PRIMARY KEY AUTO_INCREMENT,
    customerId VARCHAR(255) null,
    productIds VARCHAR(255) null,
    quantities VARCHAR(255) null,
    prices VARCHAR(255) null,  
    total VARCHAR(255) null,
    date_order DATE NULL
);


SELECT * from orders;
SELECT * FROM products;









