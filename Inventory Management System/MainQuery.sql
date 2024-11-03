use sample;

create table ImageCaptcha(
	imgId INT not null,
	ImgName varchar(20) not null,
	ImgPath varchar(20) not null unique,
)

INSERT INTO ImageCaptcha (imgId, ImgName, ImgPath) VALUES 
(1, 'Car', 'car4.jpg'),
(2, 'Road', 'road7.jpg'),
(3, 'Road', 'road3.jpg'),
(4, 'Car', 'car1.jpg'),
(5, 'Car', 'car8.jpg'),
(6, 'Road', 'road1.jpg'),
(7, 'Car', 'car6.jpg'),
(8, 'Car', 'car5.jpg'),
(9, 'Road', 'road5.jpg'),
(10, 'Road', 'road2.jpg'),
(11, 'Car', 'car3.jpg'),
(12, 'Road', 'road10.jpg'),
(13, 'Road', 'road8.jpg'),
(14, 'Car', 'car9.jpg'),
(15, 'Road', 'road4.jpg'),
(16, 'Car', 'car2.jpg'),
(17, 'Road', 'road9.jpg'),
(18, 'Car', 'car7.jpg'),
(19, 'Road', 'road6.jpg'),
(20, 'Car', 'car10.jpg');


SELECT * FROM ImageCaptcha;

--UPDATE ImageCaptcha SET ImgPath = 'car1.jpg' where ImgPath = 'car1.webp';

-- Admin Table
CREATE TABLE ADMIN(
	admin_id int not null ,
	admin_name varchar(20) not null,
	admin_email varchar(50) not null unique,
	admin_password varchar(50) not null,
	admin_phone DECIMAL(10, 0) not null unique,
	admin_address Varchar(50) not null,
);
INSERT INTO ADMIN VALUES(101 , 'Srajan Saxena' , 'srajan@gmail.com','srj12345' , 9838726101 ,
'E-0000 , Rajajipuram,Lucknow');

SELECT * FROM ADMIN;
-- Task - ALTER TABLE AND ADD A COLUMN WITH PASSWORD

-- Customer Table


CREATE TABLE CUSTOMER(
	customer_id int IDENTITY(1,1) PRIMARY KEY,
	customer_name varchar(20) not null,
	customer_email varchar(50) not null unique,
	customer_password varchar(20) not null ,
	customer_phone decimal(10 , 0) not null unique,
	customer_address varchar(50) not null,
)

INSERT INTO CUSTOMER VALUES 
('John Doe', 'john.doe@example.com', 'password123', 9876543210, '123 Main St'),
('Jane Smith', 'jane.smith@example.com', 'password456', 9123456789, '456 Oak St'),
('Alice Johnson', 'alice.j@example.com', 'password789', 9234567890, '789 Pine St'),
('Bob Brown', 'bob.b@example.com', 'password101', 9345678901, '101 Maple St'),
('Charlie Davis', 'charlie.d@example.com', 'password202', 9456789012, '202 Birch St');

SELECT * FROM CUSTOMER;

CREATE TABLE STOCK(
	product_id int IDENTITY(1,1) PRIMARY KEY,
	product_name varchar(30) not null,
	product_quantity int not null,
	product_price int not null,
	product_description varchar(100) not null
);

INSERT INTO STOCK VALUES 
    ('Rin Bar', 50, 20, 'Laundry detergent bar for stain removal'),
    ('Dettol Handwash', 30, 65, 'Liquid handwash with antibacterial properties'),
    ('Lays Chips', 100, 10, 'Classic salted potato chips'),
    ('Parle-G Biscuits', 200, 5, 'Popular glucose biscuits in India'),
    ('Tata Salt', 80, 25, 'Iodized salt for cooking');

SELECT * FROM STOCK;

-- Order Table and some data

CREATE TABLE Orders (								-- since 'Order is a keyword'
    order_number INT IDENTITY(1,1) PRIMARY KEY,
    customer_name VARCHAR(50) NOT NULL,
    order_amount INT NOT NULL,
    order_date DATE NOT NULL
);

INSERT INTO Orders (customer_name, order_amount, order_date) VALUES
    ('John Doe', 500, '2024-10-15'),
    ('Jane Smith', 1200, '2024-10-16'),
    ('Alice Johnson', 750, '2024-10-17'),
    ('Bob Brown', 1500, '2024-10-18'),
    ('Charlie Davis', 300, '2024-10-19');

SELECT * FROM Orders;


--------------------------- Purchase Table and PurchaseDetails Table

CREATE TABLE Purchase (
    purchase_id INT IDENTITY(1,1) PRIMARY KEY,
    supplier_name VARCHAR(50) NOT NULL,
    date_of_supply DATE NOT NULL,
    total_payment DECIMAL(10, 2) NOT NULL
);
SELECT * FROM Purchase;
SELECT * FROM Purchase where total_payment between 500 AND 2000;
-- no need to set product id here as it will be set automatically in STOCK table
-- no need for supplier name also as it can be evaluated from the purchase table
CREATE TABLE PurchaseDetails (
    purchase_id INT FOREIGN KEY REFERENCES Purchase(purchase_id) ON DELETE CASCADE,
    product_name VARCHAR(50) NOT NULL,
    product_quantity INT NOT NULL,
    product_price DECIMAL(10, 2) NOT NULL,
    product_description VARCHAR(100),
    total_payment AS (product_quantity * product_price) -- calculated column
); -- after insertion in this table -> stock table should be updated

SELECT * FROM PurchaseDetails;



