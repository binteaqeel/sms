CREATE DATABASE sms;

USE sms;

CREATE TABLE students(
	id INT PRIMARY KEY IDENTITY(10,1),
	Fname VARCHAR(255) Not null,
	Lname VARCHAR(255) Not null,
	DOB DATE Not null,
	gender VARCHAR(6) Not null,
	email VARCHAR(255) Not null,
	phoneNumber VARCHAR(255) Not null,
	adres VARCHAR(255) Not null,
	pasword VARCHAR(255) Not null,
	confirmPassword VARCHAR(255)Not null
);

INSERT INTO students VALUES('Student1','Check','2000-12-12','MALE','STUDENT@gmail.com','+92 02033440334','PLACE','123','123');
INSERT INTO students VALUES('Student2','Check','2000-12-12','MALE','STUDENT@gmail.com','+92 02033440334','PLACE','123','123');
INSERT INTO students VALUES('Student3','Check','2000-12-12','MALE','STUDENT@gmail.com','+92 02033440334','PLACE','123','123');
INSERT INTO students VALUES('Student4','Check','2000-12-12','MALE','STUDENT@gmail.com','+92 02033440334','PLACE','123','123');
INSERT INTO students VALUES('Student5','Check','2000-12-12','MALE','STUDENT@gmail.com','+92 02033440334','PLACE','123','123');

SELECT * FROM students;



CREATE TABLE instructor(
	id INT PRIMARY KEY IDENTITY(100,1),
	Fname VARCHAR(255) Not null,
	Lname VARCHAR(255) Not null,
	DOB DATE Not null,
	gender VARCHAR(6)Not null,
	email VARCHAR(255) Not null,
	phoneNumber VARCHAR(255) Not null,
	adres VARCHAR(255) Not null,
	pasword VARCHAR(255) Not null,
	confirmPassword VARCHAR(255)Not null
);

INSERT INTO instructor VALUES('Instructor1','Check','2000-12-12','MALE','INSTRUCTOR@gmail.com','+92 02033440334','PLACE','456','456');
INSERT INTO instructor VALUES('Instructor2','Check','2000-12-12','MALE','INSTRUCTOR@gmail.com','+92 02033440334','PLACE','456','456');
INSERT INTO instructor VALUES('Instructor3','Check','2000-12-12','MALE','INSTRUCTOR@gmail.com','+92 02033440334','PLACE','456','456');
INSERT INTO instructor VALUES('Instructor4','Check','2000-12-12','MALE','INSTRUCTOR@gmail.com','+92 02033440334','PLACE','456','456');
INSERT INTO instructor VALUES('Instructor5','Check','2000-12-12','MALE','INSTRUCTOR@gmail.com','+92 02033440334','PLACE','456','456');

SELECT * FROM instructor;

CREATE TABLE administration(
	id INT PRIMARY KEY IDENTITY(50,1),
	Fname VARCHAR(255) Not null,
	Lname VARCHAR(255) Not null,
	DOB DATE Not null,
	gender VARCHAR(6) Not null,
	email VARCHAR(255) Not null,
	phoneNumber VARCHAR(255) Not null,
	adres VARCHAR(255) Not null,
	pasword VARCHAR(255) Not null,
	confirmPassword VARCHAR(255) Not null
);

INSERT INTO administration VALUES('admin1','Check','2000-12-12','MALE','admin@gmail.com','+92 02033440334','PLACE','789','789');
INSERT INTO administration VALUES('admin2','Check','2000-12-12','MALE','admin@gmail.com','+92 02033440334','PLACE','789','789');
INSERT INTO administration VALUES('admin3','Check','2000-12-12','MALE','admin@gmail.com','+92 02033440334','PLACE','789','789');
INSERT INTO administration VALUES('admin4','Check','2000-12-12','MALE','admin@gmail.com','+92 02033440334','PLACE','789','789');
INSERT INTO administration VALUES('admin5','Check','2000-12-12','MALE','admin@gmail.com','+92 02033440334','PLACE','789','789');

SELECT * FROM administration;

create table stdFeedbackForInst(
	id int primary key identity,
	instId int,
	foreign key(instId) references instructor(id),
	stdId int,
	foreign key (stdId) references students(id),
	fdbkDesc TEXT
);

select * from stdFeedbackForInst;

create table stdFeedbackForAdmin(
	id int primary key identity,
	adId int,
	foreign key(adId) references administration(id),
	stdId int,
	foreign key (stdId) references students(id),
	fdbkDesc TEXT Not null
);

select * from stdFeedbackForAdmin;

create table instFeedbackForStudent(
	id int primary key identity,
	stdId int,
	foreign key (stdId) references students(id),
	instId int,
	foreign key(instId) references instructor(id),
	fdbkDesc TEXT Not null
);

select * from instFeedbackForStudent;
--Changes From Here-----
create table instFeedbackForAdmin(
	id int primary key identity,
	adId int,
	foreign key (adId) references administration(id),
	instId int,
	foreign key(instId) references instructor(id),
	fdbkDesc TEXT Not null
);

select * from instFeedbackForAdmin;

create table AdminFeedbackForInstructor(
	id int primary key identity,
	InstId int,
	foreign key (InstId) references instructor(id),
	adId int,
	foreign key(adId) references administration(id),
	fdbkDesc TEXT Not null
);

select * from AdminFeedbackForInstructor;


create table AdminFeedbackForStudent(
	id int primary key identity,
	stdId int Not null,
	foreign key (stdId) references students(id),
	adId int,
	foreign key(adId) references administration(id),
	fdbkDesc TEXT Not null
);

select * from AdminFeedbackForStudent;

--iskoo set krleee bhnnnnnn khudara

create table semester(
	id int primary key identity,
	SemName varchar(255) Not null,
	FeePerCrdHr int Not null,
	noOfCrs int Not null,
	PassingMarks int Not null
);

select * from semester;
--isko join krana hoga classes ke sath kiu ke student class me enroll hoga 
create table courses(
	id int primary key identity,
	crsName varchar(500) Not null unique,
	crsAbr varchar(50) Not null unique,
	crsDesc varchar(50) Not null
);

select * from courses;


create table InstExpertise(
	id int primary key identity,
	instId int,
	foreign key (instId) references instructor(id),
	crsId int,
	foreign key (crsId) references courses(id)
);

select * from InstExpertise;

create table classes(
	id int primary key identity (114900,1),
	crsId int,
	foreign key (crsId) references courses(id),
	instId int,
	foreign key (instId) references instructor(id),
	CrdHrs int,
	semId int,
	foreign key (semId) references semester(id)
);

select * from classes;


create table UpdrageStudents (
	id int primary key identity,
	stdId int,
	foreign key (stdId) references students(id),
	semId int,
	foreign key (semId) references semester(id)
);

select * from UpdrageStudents;


create table stdClassRequest(
	id int primary key identity,
	classId int,
	foreign key (classId) references classes(id),
	stdId int,
	foreign key (stdId) references students(id)
);

select * from stdClassRequest;


create table paidEnrollment(
	id int primary key identity,
	stdId int,
	foreign key (stdId) references students(id),
	semId int,
	foreign key (semId) references semester(id)
);

select * from paidEnrollment;


create table AssessmentType(
	id int primary key identity,
	AssessmentName varchar(255) Not null,
	AssessDesc TEXT Not null,
	totalMarks int Not null,
	HOdate date Not null,
	SubDate date Not null,
	classId int,
	foreign key (classId) references classes(id)
);


select * from AssessmentType;

create table Assessment(
	id int primary key identity,
	stdId int,
	foreign key (stdId) references students(id),
	ObtainMarks int Not null,
	AssessId int,
	foreign key (AssessId) references AssessmentType(id)
);


select * from Assessment;
------------------------------------------------------------------------------------------Maslaaaaaaaaaa

CREATE TABLE resultStatus(
    id int primary key identity,
    stdId int,
    foreign key (stdId) references students(id),
    classId int,
    foreign key (classId) references classes(id),
    Perrcentage decimal,
	statuss varchar(50)
);

select * from resultStatus;

----------------------------------------------------------------------------------------------------------------Hogaya hal

--show all ClassIds and courseName from classes and course of the  semester of semId  to which the student of  stdId = 10 has the highest semId from semester table in upgradeStudent table 

SELECT 
    c.id AS ClassId,
    crs.crsName AS CourseName
FROM 
    classes c
INNER JOIN 
    courses crs ON c.crsId = crs.id
INNER JOIN 
    UpdrageStudents us ON c.semId = us.semId
WHERE 
    us.stdId = 10
    AND c.semId = (SELECT MAX(semId) FROM UpdrageStudents WHERE stdId = 10);

---------------------------------------------------------------------------------------------
--to show all the classes
SELECT
    c.id AS ClassId,
    crs.crsName AS CourseName
FROM
    classes c
INNER JOIN
    courses crs ON c.crsId = crs.id;

--------------------------------------------------------------------------------------------------
SELECT
    c.id AS ClassId,
    crs.crsName AS CourseName
FROM
    classes c
INNER JOIN
    courses crs ON c.crsId = crs.id
INNER JOIN
    resultStatus rs ON c.id = rs.classId
WHERE
    rs.stdId = 10
    AND rs.statuss = 'PASS';

------------------------------------------------------------------------------------------------------------
SELECT
    A.ClassId,
    A.CourseName
FROM
    (
    SELECT
        c.id AS ClassId,
        crs.crsName AS CourseName
    FROM
        classes c
    INNER JOIN
        courses crs ON c.crsId = crs.id
    ) AS A
LEFT JOIN
    (
    SELECT
        c.id AS ClassId,
        crs.crsName AS CourseName
    FROM
        classes c
    INNER JOIN
        courses crs ON c.crsId = crs.id
    INNER JOIN
        resultStatus rs ON c.id = rs.classId
    WHERE
        rs.stdId = 10
        AND rs.statuss = 'PASS'
    ) AS B ON A.CourseName = B.CourseName
WHERE
    B.ClassId IS NULL;

--------------------------------------------------------------------------------------------
--final query
SELECT 
    C.ClassId,
    C.CourseName
FROM 
    (
    SELECT 
        c.id AS ClassId,
        crs.crsName AS CourseName
    FROM 
        classes c
    INNER JOIN 
        courses crs ON c.crsId = crs.id
    INNER JOIN 
        UpdrageStudents us ON c.semId = us.semId
    WHERE 
        us.stdId = 10
        AND c.semId = (SELECT MAX(semId) FROM UpdrageStudents WHERE stdId = 10)
    ) AS C
INNER JOIN
    (
    SELECT
        A.ClassId,
        A.CourseName
    FROM
        (
        SELECT
            c.id AS ClassId,
            crs.crsName AS CourseName
        FROM
            classes c
        INNER JOIN
            courses crs ON c.crsId = crs.id
        ) AS A
    LEFT JOIN
        (
        SELECT
            c.id AS ClassId,
            crs.crsName AS CourseName
        FROM
            classes c
        INNER JOIN
            courses crs ON c.crsId = crs.id
        INNER JOIN
            resultStatus rs ON c.id = rs.classId
        WHERE
            rs.stdId = 10
            AND rs.statuss = 'PASS'
        ) AS B ON A.CourseName = B.CourseName
    WHERE
        B.ClassId IS NULL
    ) AS D ON C.ClassId = D.ClassId AND C.CourseName = D.CourseName;


create table expiredClasses(
	id int primary key identity,
	classId int,
	foreign key (classId) references classes(id)
);

select * from expiredClasses;

create table timeTableEnviroment (
	id int primary key identity,
	semId int,
	foreign key (semId) references semester(id),
	noOfWeeks int,
	hrPerClass int,
	startTimeTableFrom date
);

select * from timeTableEnviroment;

drop table timeTableEnviroment;


create table timeTable(
	id int primary key identity,
	ttEnvId int,
	foreign key (ttEnvId) references timeTableEnviroment(id),
	dayOfTheWeek varchar(50),
	periodNumb int,
	classId int,
	foreign key (classId) references classes(id),
	classroomId int,
	foreign key (classroomId) references classroom(id)
);

select * from timeTable;

drop table timetable;

create table classroom(
	id int primary key identity,
	className varchar(255) unique
);

drop table classroom;
