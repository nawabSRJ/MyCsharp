use sample;

create table captcha (
	id int primary key identity(1, 1),
	text nvarchar(10),
	path nvarchar(100)
);

insert into captcha(text, path) values ('12AV', 'images\image1.png'),('12AX', 'images\image2.png'),
('VBM', 'images\image3.png');

select * from captcha;