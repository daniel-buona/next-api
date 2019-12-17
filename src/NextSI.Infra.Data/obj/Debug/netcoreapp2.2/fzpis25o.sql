CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Customers` (
    `Id` char(36) NOT NULL,
    `Inserted_at` datetime NOT NULL,
    `Updated_at` datetime NULL,
    `Deleted_at` datetime NULL,
    `Name` varchar(100) NOT NULL,
    `Email` varchar(100) NOT NULL,
    `BirthDate` datetime(6) NOT NULL,
    CONSTRAINT `PK_Customers` PRIMARY KEY (`Id`)
);

CREATE TABLE `Users` (
    `Id` char(36) NOT NULL,
    `Inserted_at` datetime NOT NULL,
    `Updated_at` datetime NULL,
    `Deleted_at` datetime NULL,
    `FirstName` varchar(100) NOT NULL,
    `LastName` varchar(100) NOT NULL,
    `Email` varchar(100) NOT NULL,
    `Password` varchar(100) NOT NULL,
    CONSTRAINT `PK_Users` PRIMARY KEY (`Id`)
);

INSERT INTO `Customers` (`Id`, `BirthDate`, `Deleted_at`, `Email`, `Inserted_at`, `Name`, `Updated_at`)
VALUES ('7055a2c0-8330-42be-b107-7cb601ba0324', '2019-11-01 06:58:13.095646', NULL, 'danielbuona@hotmail.com', '0001-01-01 00:00:00.000000', 'Daniel Buona', NULL);

INSERT INTO `Users` (`Id`, `Deleted_at`, `Email`, `FirstName`, `Inserted_at`, `LastName`, `Password`, `Updated_at`)
VALUES ('48da082b-b318-49a6-81fc-bf83dd176703', NULL, 'admin@nextsi.com.br', 'Super', '2019-11-01 06:58:13.090851', 'Admin', '36n54v6CzXkFI0A7GjbH1MmI/FjeoRLDzKMpKT6ed60=', NULL);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20191101095813_InitialMigration', '2.2.6-servicing-10079');

