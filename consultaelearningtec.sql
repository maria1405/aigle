CREATE DATABASE elearningtec
-- drop database elearningtec
CREATE TABLE Users(
	id integer primary key identity(1,1),
	name char(15) not null,
	last_name char(25) not null,
	email varchar(50) not null,
	username varchar(15) not null,
	role numeric(1) not null,
	password varchar(15) not null,
)

CREATE TABLE Courses(
	id integer primary key identity(1,1),
	name varchar(50) not null,
	description varchar(255) not null,
	user_id int,
)
CREATE TABLE Lessons(
	id integer primary key identity(1,1),
	name varchar(50) not null,
	description varchar (255) not null,
	url_video varchar(255),
	course_id int
)

CREATE TABLE Comments (
	id integer primary key identity(1,1),
	user_id int,
	lesson_id int,
)

-- Relationships
ALTER TABLE Courses
	ADD CONSTRAINT FK_user_id 
	FOREIGN KEY(user_id)
	REFERENCES Users(id)
	ON DELETE CASCADE
	ON UPDATE CASCADE

ALTER TABLE Comments
	ADD CONSTRAINT FK_user_comments_id
	FOREIGN KEY(user_id)
	REFERENCES Users(id)
	ON DELETE CASCADE
	ON UPDATE CASCADE

ALTER TABLE Comments
	ADD CONSTRAINT FK_lesson_id
	FOREIGN KEY(lesson_id)
	REFERENCES Lessons(id)
	ON DELETE CASCADE
	ON UPDATE CASCADE

ALTER TABLE Lessons
	ADD CONSTRAINT FK_course_id
	FOREIGN KEY(course_id)
	REFERENCES Courses(id)



--SELECT * FROM Lessons WHERE (course_id=1)
--select * from Lessons
--select * from Courses
-- select * from Lessons
-- select * from Users
 -- update Users set role= 1 where id=1
 --INSERT INTO Courses(name, description, cover, user_id) VALUES('hoLA','H', '', 1)
-- INSERT INTO Users(name, last_name, email, username, role, password) values('Andrés', 'Domínguez', 'andres@andres.com', 'andresprogra', 0, 'andres123')
-- INSERT INTO Courses(name, description, user_id) values('Curso de programación', 'Curso básico', 1)
-- SELECT * FROM Courses c INNER JOIN Users as u ON c.user_id= u.id