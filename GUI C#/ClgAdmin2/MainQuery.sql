-- New Main Qury for ClgAdmin2
-- CREATING STUDENT TABLE
-- Date : 24 October
USE SAMPLE;
CREATE TABLE STUDENT
(
    ID INT PRIMARY KEY IDENTITY(1, 1), -- Auto-incremented ID starting from 1
    NAME VARCHAR(30) NOT NULL,
    PHONE VARCHAR(12) NOT NULL UNIQUE ,
    EMAIL VARCHAR(30) NOT NULL UNIQUE,
    ADDRESS VARCHAR(50) NOT NULL,
    GENDER VARCHAR(10) NOT NULL,
    DOB DATE NOT NULL, -- Changed to DATE for better date handling
    COURSE VARCHAR(20) NOT NULL,
    
);

SELECT * FROM STUDENT;

CREATE TABLE Teacher
(
    TeacherID INT PRIMARY KEY IDENTITY(1, 1), -- Auto-incremented ID starting from 1
    NAME VARCHAR(30) NOT NULL,
    PHONE VARCHAR(12) NOT NULL UNIQUE ,
    EMAIL VARCHAR(30) NOT NULL UNIQUE,
    ADDRESS VARCHAR(50) NOT NULL,
    GENDER VARCHAR(10) NOT NULL,
    DOB DATE NOT NULL, -- Changed to DATE for better date handling
    
);
SELECT * FROM Teacher;

CREATE TABLE COURSES(
	CourseCode INT IDENTITY(1,1) PRIMARY KEY,
	CourseName VARCHAR(30) NOT NULL,
)
--INSERT INTO COURSES (CourseName) VALUES ('BCA'),('BBA');
SELECT * FROM COURSES;


CREATE TABLE TeacherCourses (
    TeacherID INT,                   -- 'ID' from Teachers table (id attr of teacher)
    CourseCode INT,                    -- CourseID from Courses table
    PRIMARY KEY (TeacherID, CourseCode),  -- Composite primary key (both TeacherID and CourseID) for this table
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID) -- foreign key refer to 'ID' of teacher
        ON DELETE CASCADE,           -- Ensures deleting a teacher also removes related records
    FOREIGN KEY (CourseCode) REFERENCES Courses(CourseCode)
        ON DELETE CASCADE            -- Ensures deleting a course also removes related records
);
