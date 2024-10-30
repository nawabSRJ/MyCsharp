use SAMPLE;

-- CREATING STUDENT TABLE
CREATE TABLE STUDENT(
	ID INT PRIMARY KEY,
	NAME VARCHAR(30) NOT NULL,
	COURSE VARCHAR(20) NOT NULL,
)
-- ADDING SOME ENTRIES IN STUDENT TABLE
INSERT INTO STUDENT VALUES (1,'Pratham Gupta','BCA'),(2,'Ansh Mishra','BBA');
SELECT * FROM STUDENT;

-- CREATING TEACHERS TABLE 
CREATE TABLE Teachers (
    ID INT PRIMARY KEY,     
    Name VARCHAR(30) NOT NULL,  
);
SELECT * FROM TEACHERS;

-- CREATING COURSES TABLE 
CREATE TABLE Courses (
    CourseID INT IDENTITY(1,1) PRIMARY KEY, -- making this auto-incremented 
    CourseName VARCHAR(30) NOT NULL,
);
SELECT * FROM COURSES;
-- Identity(1,1) means : the CourseID will start at 1 and increment by 1 for each new row

-- CREATING TABLE FOR RECORD OF COURSES TAUGHT BY TEACHERS
CREATE TABLE TeacherCourses (
    TeacherID INT,                   -- 'ID' from Teachers table (id attr of teacher)
    CourseID INT,                    -- CourseID from Courses table
    PRIMARY KEY (TeacherID, CourseID),  -- Composite primary key (both TeacherID and CourseID) for this table
    FOREIGN KEY (TeacherID) REFERENCES Teachers(ID) -- foreign key refer to 'ID' of teacher
        ON DELETE CASCADE,           -- Ensures deleting a teacher also removes related records
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
        ON DELETE CASCADE            -- Ensures deleting a course also removes related records
);

SELECT * FROM TeacherCourses;

-- query for getting courses of a teacher
SELECT c.CourseName FROM TeacherCourses tc JOIN Courses c ON tc.CourseID = c.CourseID WHERE tc.TeacherID = 2;