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