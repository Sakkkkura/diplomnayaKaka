
USE SSSDiplom
GO

CREATE TABLE Teacher (
Id INT IDENTITY PRIMARY KEY NOT NULL,
LastName NVARCHAR(max) NOT NULL,
FirstName NVARCHAR(max) NOT NULL,
MiddleName NVARCHAR(max) NOT NULL,
);

CREATE TABLE Lesson (
Id INT IDENTITY PRIMARY KEY NOT NULL,
Title NVARCHAR(max) NOT NULL,
TeacherId INT NOT NULL,
FOREIGN KEY (TeacherId) REFERENCES Teacher (Id),
);

CREATE TABLE [Group] (
Id INT IDENTITY PRIMARY KEY NOT NULL,
Title NVARCHAR(max) NOT NULL,
);

CREATE TABLE CallSchedule (
Id INT IDENTITY PRIMARY KEY NOT NULL,
[Time] INT NOT NULL,
);

CREATE TABLE Cabinet (
Id INT IDENTITY PRIMARY KEY NOT NULL,
Number INT NOT NULL,
);

CREATE TABLE ClassType (
Id INT IDENTITY PRIMARY KEY NOT NULL,
Title NVARCHAR(max) NOT NULL,
);

CREATE TABLE Schedule (
Id INT IDENTITY PRIMARY KEY NOT NULL,
LessonId INT NOT NULL,
GroupId INT NOT NULL,
CabinetId INT NOT NULL,
CallScheduleId INT NOT NULL,
ClassTypeId INT NOT NULL,
[Date] DATE NOT NULL,
FOREIGN KEY (LessonId) REFERENCES Lesson (Id),
FOREIGN KEY (GroupId) REFERENCES [Group] (Id),
FOREIGN KEY (CabinetId) REFERENCES Cabinet (Id),
FOREIGN KEY (CallScheduleId) REFERENCES CallSchedule (Id),
FOREIGN KEY (ClassTypeId) REFERENCES ClassType (Id),
);

CREATE TABLE [Role] (
Id INT IDENTITY PRIMARY KEY NOT NULL,
Title NVARCHAR(max) NOT NULL,
);

CREATE TABLE [User] (
Id INT IDENTITY PRIMARY KEY NOT NULL,
[Login] NVARCHAR(max) NOT NULL,
[Password] NVARCHAR(max) NOT NULL,
RoleId INT REFERENCES [Role](Id) NOT NULL,
);


INSERT INTO [Role]([Title])
     VALUES
	 ('?????????'),
	 ('?????????????'),
	 ('???????')	   
GO

INSERT INTO [User]([Login], [Password], RoleId)
VALUES 
('login1','password1', 1),
('login2','password2', 2),
('login3','password3', 3)
GO
