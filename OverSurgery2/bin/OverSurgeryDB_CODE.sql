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
    `StaffID` INT(8) NOT NULL,
    PRIMARY KEY(`MedicalStaffID`),
    FOREIGN KEY(`StaffID`) REFERENCES Staff(`StaffID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Patient` (
    `PatientID` INT(8) NOT NULL auto_increment,
    `Forename` VARCHAR(35) NOT NULL default '',
    `Surname` VARCHAR(35) NOT NULL default '',
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
    `MedicalHistoryFileLocation` VARCHAR(50) NOT NULL default '',
    `DateOfFile` DATE NOT NULL default 19991231,
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
	`UserName` varchar(255) NOT NULL,
	`VerificationCode` varchar(8) NOT NULL
	); ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- TESTING ACCOUNT --
CREATE USER 'DBAccess'@localhost IDENTIFIED BY 'Nricb';
GRANT ALL ON OverSurgery.* TO 'DBAccess'@localhost;

-- Access accounts to limit maximum data access --
#CREATE USER 'PatientAccess'@ localhost IDENTIFIED BY 'Nricb';
#CREATE USER 'DoctorAccess'@localhost IDENTIFIED BY 'Nricb';
#CREATE USER 'StaffAccess'@localhost IDENTIFIED BY 'Nricb';
#CREATE USER 'OtherAccess'@localhost IDENTIFIED BY 'Nricb';