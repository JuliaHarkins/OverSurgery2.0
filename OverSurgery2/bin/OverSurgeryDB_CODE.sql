CREATE DATABASE `OverSurgery`;

USE OverSurgery;

CREATE TABLE `Address` (
    `AddressID` INT(8) NOT NULL auto_increment,
    `HouseName` VARCHAR(35) default '',
    `HouseNumber` INT(4) default 0,
    `AddressLine1` VARCHAR(100) NOT NULL default '',
    `PostCode` VARCHAR(10) NOT NULL default '',
    PRIMARY KEY(`AddressID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Staff` (
    `StaffID` INT(8) NOT NULL auto_increment,
    `Forename` VARCHAR(35) NOT NULL default '',
    `Surname` VARCHAR(35) NOT NULL default '',
    `Email` VARCHAR(50) NOT NULL default '',
    `AddressID` INT(8) NOT NULL default 0,
    `Username` VARCHAR(35) NOT NULL default '',
    `Password` VARCHAR(255) NOT NULL default '',
    `Type` INT(1) NOT NULL default 0,
    PRIMARY KEY(`StaffID`),
    FOREIGN KEY(`AddressID`) REFERENCES Address(`AddressID`) ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `MedicalStaff` (
    `MedicalStaffID` INT(8) NOT NULL auto_increment,
    `MedicalPracticeNumber` VARCHAR(35) NOT NULL default '',
    `PermissionLevel` TINYINT(1) NOT NULL default 0,
    `StaffID` INT(8) NOT NULL,
    `Gender` TINYINT NOT NULL default 0,
    PRIMARY KEY(`MedicalStaffID`),
    FOREIGN KEY(`StaffID`) REFERENCES Staff(`StaffID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Patient` (
    `PatientID` INT(8) NOT NULL auto_increment,
    `Forename` VARCHAR(35) NOT NULL default '',
    `Surname` VARCHAR(35) NOT NULL default '',
    `Gender` TINYINT(1) NOT NULL default 0,
    `DateOfBirth` DATE NOT NULL default 19001231,
    `PhoneNumber` VARCHAR(35) NOT NULL default '',
    `RegesteredDoctorID` INT(8) NOT NULL default 0,
    `AddressID` INT(8) NOT NULL default 0,
    PRIMARY KEY(`PatientID`),
    FOREIGN KEY(`RegesteredDoctorID`) REFERENCES MedicalStaff(`MedicalStaffID`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`AddressID`) REFERENCES Address(`AddressID`) ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Appointment` (
    `AppointmentID` INT(8) NOT NULL auto_increment,
    `AppointmentDate` DATE NOT NULL default 19991231,
    `AppointmentTime` TIME NOT NULL default 090000,
    `AppointmentNote` VARCHAR(250) NULL default '',
    `AppointmentAttended` BOOLEAN NULL default 0,
    `MedicalStaffID` INT(8) NOT NULL default 0,
    `PatientID` INT(8) NOT NULL default 0,
    PRIMARY KEY(`AppointmentID`),
    FOREIGN KEY(`MedicalStaffID`) REFERENCES MedicalStaff(`MedicalStaffID`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`PatientID`) REFERENCES Patient(`PatientID`) ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `MedicalHistory` (
    `MedicalHistoryID` INT(8) NOT NULL auto_increment,
    `MedicalHistory` TEXT NOT NULL default '',
    `DateOf` DATE NOT NULL default 19991231,
    `PatientID` INT(8) NOT NULL default 0,
    PRIMARY KEY(`MedicalHistoryID`),
    FOREIGN KEY(`PatientID`) REFERENCES Patient(`PatientID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Medication` (
    `MedicationID` INT(8) NOT NULL auto_increment,
    `PermissionLevel` INT(2) NOT NULL default 99,
    `MedicationName` VARCHAR(35) NOT NULL default '',
    `Dosage` VARCHAR(35) NOT NULL default '0mg',
    PRIMARY KEY(`MedicationID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `OnCall` (
    `OnCallID` INT(8) NOT NULL auto_increment,
    `StartDate` DATE NOT NULL default 19991231,
    `EndDate` DATE NOT NULL default 19991231,
    `MedicalStaffID` INT(8) NOT NULL default 0,
    PRIMARY KEY(`OnCallID`),
    FOREIGN KEY(`MedicalStaffID`) REFERENCES MedicalStaff(`MedicalStaffID`) ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Prescription` (
    `PrescriptionID` INT(8) NOT NULL auto_increment,
    `DateIssued` DATE NOT NULL default 19991231,
    `DateOfNextIssue` DATE NULL default 19991231,
    `Ammount` INT(2) NOT NULL default 0,
    `Extendable` BOOLEAN NOT NULL default 0,
    `MedicationID` INT(8) NOT NULL default 0,
    `PatientID` INT(8) NOT NULL default 0,
    `MedicalStaffID` INT(8) NOT NULL default 0,
    PRIMARY KEY(`PrescriptionID`),
    FOREIGN KEY(`MedicationID`) REFERENCES Medication(`MedicationID`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`PatientID`) REFERENCES Patient(`PatientID`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`MedicalStaffID`) REFERENCES MedicalStaff(`MedicalStaffID`) ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Extension` (
    `ExtensionID` INT(8) NOT NULL auto_increment,
    `Extended` TINYINT(1) NOT NULL default 0,
    `PrescriptionID` INT(8) NOT NULL default 0,
    `DateOfExtension` DATE NULL default 19991231,
    `MedicalStaffID` INT(8) NOT NULL default 0,
    `Reason` VARCHAR(256) NULL default '',
    PRIMARY KEY(`ExtensionID`),
    FOREIGN KEY(`PrescriptionID`) REFERENCES Prescription(`PrescriptionID`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`MedicalStaffID`) REFERENCES MedicalStaff(`MedicalStaffID`) ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `ResetRequests` (
	`RequestID` INT(6) NOT NULL auto_increment,
	`UserName` varchar(255) NOT NULL default '',
	`VerificationCode` varchar(8) NOT NULL default '',
	PRIMARY KEY(`RequestID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `DayOfWeek` (
    `DayID` INT(6) NOT NULL auto_increment,
    `DayName` VARCHAR(35) NOT NULL default '',
    PRIMARY KEY(`DayID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Rota` (
    `RotaID` INT(6) NOT NULL auto_increment,
    `DayID` INT(6) NOT NULL default 0,
    `StaffID` INT(6) NOT NULL default 0,
    PRIMARY KEY(`RotaID`),
    FOREIGN KEY(`DayID`) REFERENCES DayOfWeek(`DayID`) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(`StaffID`) REFERENCES Staff(`StaffID`) ON DELETE CASCADE ON UPDATE CASCADE,
)

-- TESTING ACCOUNT --
CREATE USER 'DBAccess'@localhost IDENTIFIED BY 'Nricb';
GRANT ALL ON OverSurgery.* TO 'DBAccess'@localhost;

-- Access accounts to limit maximum data access --
#CREATE USER 'PatientAccess'@ localhost IDENTIFIED BY 'Nricb';
#CREATE USER 'DoctorAccess'@localhost IDENTIFIED BY 'Nricb';
#CREATE USER 'StaffAccess'@localhost IDENTIFIED BY 'Nricb';
#CREATE USER 'OtherAccess'@localhost IDENTIFIED BY 'Nricb';



INSERT INTO Address VALUES (1, null, 2, "THIS IS A TEST", "01 TEST 10");
INSERT INTO Address VALUES (2, null, 12, "X THIS IS A TEST", "01 TEST 10");
INSERT INTO Address VALUES (3, null, 16, "Q THIS IS A TEST", "01 TEST 10");
INSERT INTO Address VALUES (4, null, 19, "Z THIS IS A TEST", "01 TEST 10");
INSERT INTO Address VALUES (5, "Trial", null, "B THIS IS A TEST", "01 TEST 10");

#All passwords = password123 as test data defaults
INSERT INTO Staff VALUES (1, 'Linus', 'Torvild', 'Test.OverSurgery@gmail.com',1 , 'Linus', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 3);
INSERT INTO Staff VALUES (2, 'Bill', 'Gates', 'Someone.OverSurgery@gmail.com',1 , 'Bill', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 1);
INSERT INTO Staff VALUES (3, 'Steve', 'Jobs', 'Test.OverSurgery@gmail.com',2 , 'Steve', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 4);
INSERT INTO Staff VALUES (4, 'Test', 'Trial', 'Someone.OverSurgery@gmail.com',2 , 'Test', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 1);
INSERT INTO Staff VALUES (5, 'Manager', 'Test', 'Test.OverSurgery@gmail.com',1 , 'Manager', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 5);
INSERT INTO Staff VALUES (6, 'Receptionist', 'Test', 'Someone.OverSurgery@gmail.com',1 , 'Receptionist', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 4);
INSERT INTO Staff VALUES (7, 'Doctor', 'Test', 'Test.OverSurgery@gmail.com',2 , 'Doctor', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 3);
INSERT INTO Staff VALUES (8, 'Nurse', 'Test', 'Someone.OverSurgery@gmail.com',2 , 'Nurse', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 1);
INSERT INTO Staff VALUES (9, 'Locum', 'Test', 'Test.OverSurgery@gmail.com',3 , 'Locum', '$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a', 2);

INSERT INTO MedicalStaff VALUES (1, '123456789AB', 3, 1, 0);
INSERT INTO MedicalStaff VALUES (2, '987654321BA', 3, 9, 1);
INSERT INTO MedicalStaff VALUES (3, '159753824QW', 1, 8, 0);
INSERT INTO MedicalStaff VALUES (4, '953718462BV', 3, 7, 1);
INSERT INTO MedicalStaff VALUES (5, '464868461WH', 1, 4, 1);
INSERT INTO MedicalStaff VALUES (6, '764281546PX', 2, 2, 0);

INSERT INTO Patient VALUES (1, 'Steven', 'Smith', 1, 19800615, '+447634395183', 1, 3);
INSERT INTO Patient VALUES (2, 'Jane', 'Hollo', 0, 19451112, '01563572805', 4, 4);
INSERT INTO Patient VALUES (3, 'Amy','Adams', 1, 19980317, '07829405285', 4, 5);
INSERT INTO Patient VALUES (4, 'Thomas', 'William', 0, 20050501, '01553490294', 3, 2);
INSERT INTO Patient VALUES (5, 'Andy', 'Potato', 0, 19900720, '+447911363901', 3, 1);

INSERT INTO Appointment VALUES (1, 20171109, 093000, 'blood test', 0, 1, 1);
INSERT INTO Appointment VALUES (2, 20171109, 161500, '', 0, 4, 2);
INSERT INTO Appointment VALUES (3, 20171110, 161500, '', 0, 4, 5);
INSERT INTO Appointment VALUES (4, 20171109, 161500, '', 0, 3, 3);

-- INSERT INTO MedicalHistory VALUES (1, '');
-- INSERT INTO MedicalHistory VALUES (2, '');
-- INSERT INTO MedicalHistory VALUES (3, '');
-- INSERT INTO MedicalHistory VALUES (4, '');
-- INSERT INTO MedicalHistory VALUES (5, '');
-- INSERT INTO MedicalHistory VALUES (6, '');
-- INSERT INTO MedicalHistory VALUES (7, '');

INSERT INTO Medication VALUES (1, 1, 'Parasetomol', '500mg');
INSERT INTO Medication VALUES (2, 1, 'Asprin', '50mg');
INSERT INTO Medication VALUES (3, 2, 'Levothyroxine', '50mcg');
INSERT INTO Medication VALUES (4, 2, 'Tramadol', '10mg');
INSERT INTO Medication VALUES (5, 3, 'Morphine', '25mg');
INSERT INTO Medication VALUES (6, 3, 'Morphine', '50mg');
INSERT INTO Medication VALUES (7, 1, 'Ibruprofen', '200mg');
INSERT INTO Medication VALUES (8, 2, 'Codine Phosphate', '30mg');
INSERT INTO Medication VALUES (9, 3, 'Tramadol', '25mg');

INSERT INTO OnCall VALUES (1, 20171120, 20171210, 4);

INSERT INTO Prescription VALUES (1, 20170901, 20170930, 32, 1, 8, 1, 4);
INSERT INTO Prescription VALUES (2, 20171001, 20171101, 32, 1, 6, 2, 1);
INSERT INTO Prescription VALUES (3, 20171001, 20171101, 28, 1, 2, 4, 2);
INSERT INTO Prescription VALUES (4, 20170912, 20171001, 28, 1, 1, 4, 6);
INSERT INTO Prescription VALUES (5, 20170912, null, 14, 0, 2, 3, 6);
INSERT INTO Prescription VALUES (6, 20171001, 20171101, 32, 1, 3, 4, 5);

INSERT INTO Extension VALUES (1, 0, 1, null, 4, null);
INSERT INTO Extension VALUES (2, 0, 3, 20171001, 1, 'Doctor Unavailable');
INSERT INTO Extension VALUES (3, 0, 2, null, 1, null);