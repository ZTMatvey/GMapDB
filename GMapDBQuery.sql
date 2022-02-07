CREATE DATABASE GMapDB
GO
USE GMapDB;
 
CREATE TABLE Markers
(
	Id INT PRIMARY KEY IDENTITY,
	Latitude DECIMAL(24, 10) NOT NULL,
	Longitude DECIMAL(24, 10) NOT NULL,
	Name NVARCHAR(150) COLLATE Cyrillic_General_CI_AS
);
GO
INSERT INTO Markers (Latitude, Longitude, Name) VALUES
(25.122318, 55.132433, 'Palm Jumeirah in Dubai'),
(36.176333, -112.460353, 'Grand Canyon'),
(-16.356378, 145.804226, 'Great Barrier Reef'),
(43.979102, 15.381623, 'The Lover’s island');