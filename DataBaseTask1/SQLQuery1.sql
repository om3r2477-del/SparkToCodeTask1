USE master;
GO

IF DB_ID('CompanyDB') IS NOT NULL
DROP DATABASE CompanyDB;
GO

CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO

CREATE TABLE Department
(
Dnumber INT PRIMARY KEY,
Dname VARCHAR(60) NOT NULL UNIQUE,
Mgr_ssn CHAR(9),
Mgr_start_date DATE,
NumberOfEmployees INT DEFAULT 0 CHECK (NumberOfEmployees >= 0)
);

	
CREATE TABLE Employee
(
    Ssn CHAR(9) PRIMARY KEY,
    Fname VARCHAR(30) NOT NULL,
    Minit CHAR(1),
    Lname VARCHAR(30) NOT NULL,
    Address VARCHAR(100),
    Sex CHAR(1) NOT NULL CHECK (Sex IN ('M','F')),
    Bdate DATE,
    Salary DECIMAL(10,2) NOT NULL CHECK (Salary > 0),
    Dno INT NOT NULL,
    Super_ssn CHAR(9)
);

CREATE TABLE Dept_Locations
(
Dnumber  INT NOT NULL,
Dlocation VARCHAR(40) NOT NULL,
PRIMARY KEY (Dnumber, Dlocation),

    FOREIGN KEY (Dnumber)
        REFERENCES Department(Dnumber)


);

CREATE TABLE Project
(
    Pnumber INT PRIMARY KEY,
    Pname VARCHAR(50) NOT NULL UNIQUE,
    Plocation VARCHAR(50),
    Dnum INT NOT NULL,

    FOREIGN KEY (Dnum)
        REFERENCES Department(Dnumber)
);

CREATE TABLE Works_On
(
    Essn CHAR(9),
    Pno INT,
    Hours DECIMAL(4,1) CHECK (Hours >= 0),

    PRIMARY KEY (Essn, Pno),

    FOREIGN KEY (Essn)
        REFERENCES Employee(Ssn),

    FOREIGN KEY (Pno)
        REFERENCES Project(Pnumber)
);

CREATE TABLE Dependent
(
    Essn CHAR(9),
    Dependent_name VARCHAR(30),
    Sex CHAR(1) CHECK (Sex IN ('M','F')),
    Bdate DATE,
    Relationship VARCHAR(20),

    PRIMARY KEY (Essn, Dependent_name),

    FOREIGN KEY (Essn)
        REFERENCES Employee(Ssn)
);

ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Department
FOREIGN KEY (Dno)
REFERENCES Department(Dnumber);

ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Supervisor
FOREIGN KEY (Super_ssn)
REFERENCES Employee(Ssn);

ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
FOREIGN KEY (Mgr_ssn)
REFERENCES Employee(Ssn);

-- Insert Sample Data

INSERT INTO Department
VALUES
(1, 'Finance', NULL, NULL, 0),
(2, 'Engineering', NULL, NULL, 0);

INSERT INTO Employee
VALUES
('123456789', 'Ali', 'M', 'Karem', 'Muscat', 'M', '1985-05-11', 6500, 2, NULL),
('234567890', 'Fatma', 'A', 'Salim', 'Nizwa', 'F', '1992-08-22', 4800, 2, '123456789'),
('345678901', 'Mutaz', 'S', 'Omar', 'Sohar', 'M', '2002-11-05', 5500, 1, '123456789');

UPDATE Department
SET Mgr_ssn = '123456789', Mgr_start_date = '2024-01-01'
WHERE Dnumber = 2;

UPDATE Department
SET Mgr_ssn = '345678901', Mgr_start_date = '2024-02-01'
WHERE Dnumber = 1;

INSERT INTO Dept_Locations
VALUES
(1, 'Muscat'),
(1, 'Nizwa'),
(2, 'Sohar');

INSERT INTO Project
VALUES
(10, 'Accounting System', 'Muscat', 1),
(20, 'Mobile App', 'Sohar', 2);

INSERT INTO Works_On
VALUES
('123456789', 20, 15),
('234567890', 20, 30),
('345678901', 10, 25);

INSERT INTO Dependent
VALUES
('123456789', 'Yousef', 'M', '2015-02-18', 'Son'),
('234567890', 'Layan', 'F', '2015-01-11', 'Daughter');

UPDATE Employee
SET Salary = Salary + 500
WHERE Ssn = '234567890';

UPDATE Employee
SET Dno = 1
WHERE Ssn = '234567890';

UPDATE Project
SET Plocation = 'Salalah'
WHERE Pnumber = 20;

UPDATE Works_On
SET Hours = 35
WHERE Essn = '234567890'
AND Pno = 20;

UPDATE Dependent
SET Relationship = 'Child'
WHERE Essn = '234567890'
AND Dependent_name = 'Layan';

DELETE FROM Dependent
WHERE Essn = '234567890'
AND Dependent_name = 'Layan';

DELETE FROM Works_On
WHERE Essn = '345678901'
AND Pno = 10;

UPDATE Department
SET Mgr_ssn = NULL,
    Mgr_start_date = NULL
WHERE Dnumber = 1;

DELETE FROM Employee
WHERE Ssn = '345678901';

SELECT * FROM Department;
SELECT * FROM Employee;
SELECT * FROM Dept_Locations;
SELECT * FROM Project;
SELECT * FROM Works_On;
SELECT * FROM Dependent;
