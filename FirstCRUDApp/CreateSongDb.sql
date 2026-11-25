IF DB_ID(N'SongDb') IS NULL
BEGIN
	CREATE DATABASE SongDb;
END
GO

USE SongDb;
GO

CREATE TABLE dbo.Songs
(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Genre NVARCHAR(100) NULL,
	Artists NVARCHAR(500) NOT NULL,
	SongTitle NVARCHAR(374) NOT NULL, -- Worlds longest song title is 374 characters long
	Album NVARCHAR(200) NOT NULL,
	NumberOfStreams DECIMAL(20, 0) NOT NULL CONSTRAINT CK_Songs_NumberOfStreams_NonNegative CHECK (NumberOfStreams >= 0),
	-- Check song ends with .mp3
	SongFileLocation NVARCHAR(260) NOT NULL CONSTRAINT CK_Songs_SongFileLocation_Mp3 CHECK (SongFileLocation LIKE N'%.mp3')
);