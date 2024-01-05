CREATE DATABASE OpenSpace_StudyClub;

CREATE TABLE TabelUser_1
(
	Id INT IDENTITY(1,1),
	Name VARCHAR(150) UNIQUE,
	Password VARCHAR(130),
	Phone VARCHAR(20),
	CNIC VARCHAR(19) UNIQUE,
	DOB VARCHAR(10),
	Gender VARCHAR(6),
	Email VARCHAR(30),
	Role VARCHAR(5),
	User_Add VARCHAR(150),
	CONSTRAINT TabelUser_1_PK PRIMARY KEY (Id)
);



INSERT INTO TabelUser_1 VALUES
('user', '123456', '+11 111 111111', '1111-111111-1', '09/18/2021' , 'Male' , 'user@gmail.com', 'User' , 'Indonesian'),
('admin', '12345678', '+11 111 111111', '2222-222222-1', '09/18/2021' , 'Male' , 'user@gmail.com', 'Admin' , 'Malaysia');

CREATE TABLE Class_Table (
	Class_ID INT IDENTITY(1, 1),
	Class_Name varchar(100) UNIQUE,
	Class_Total INT,
	Class_Male INT,
	Class_Female INT,
	CONSTRAINT Class_Table_PK PRIMARY KEY (Class_ID)

);

CREATE TABLE Student_Table
(
	Student_ID INT IDENTITY (1, 1),
	Student_Name VARCHAR(150),
	Student_Total VARCHAR(50) UNIQUE,
	Student_Gender VARCHAR(10),
	Class_ID INT,
	CONSTRAINT Student_Table_PK PRIMARY KEY (Student_ID),
	CONSTRAINT Student_Table_FK FOREIGN KEY (Class_ID) REFERENCES Class_Table ( Class_ID) ON DELETE CASCADE

);
