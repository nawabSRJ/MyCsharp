use sample;

create table ImageCaptcha(
	ImgName varchar(20) not null,
	ImgPath varchar(20) not null
)
INSERT INTO ImageCaptcha Values ('Car','car1.jpg'),('Car' , 'car2.jpg'),('Car','car3.jpg'),
('Road','road1.jpg'),('Road','road2.jpg'),('Road','road3.jpg');

SELECT * FROM ImageCaptcha;
--UPDATE ImageCaptcha SET ImgPath = 'car1.jpg' where ImgPath = 'car1.webp';

-- Admin Table
CREATE TABLE ADMIN(
	admin_id int not null ,
	admin_name varchar(20) not null,
	admin_email varchar(50) not null unique,
	admin_phone DECIMAL(10, 0) not null unique,
	admin_address Varchar(50) not null,
);
INSERT INTO ADMIN VALUES(101 , 'Srajan Saxena' , 'srajan@gmail.com' , 9838726101 ,
'E-0000 , Rajajipuram,Lucknow');

SELECT * FROM ADMIN;
-- Task - ALTER TABLE AND ADD A COLUMN WITH PASSWORD
