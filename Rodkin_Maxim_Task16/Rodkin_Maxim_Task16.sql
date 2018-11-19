USE master
IF(db_id(N'UsersAndAwards')) IS NOT NULL
	DROP DATABASE UsersAndAwards

CREATE DATABASE UsersAndAwards
GO

USE UsersAndAwards
CREATE TABLE Users(
	[Id] int not null primary key identity(1,1),
	[FirstName] nvarchar(50),
	[LastName] nvarchar(50),
	[Birthdate] datetime2,
	[Age] int
	)


USE UsersAndAwards
CREATE TABLE Awards(
	[Id] int not null primary key identity(1,1),
	[Title] nvarchar(50),
	[Description] nvarchar(250)
	)


CREATE TABLE Relations(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[UserId] INT NOT NULL,
	[AwardId] INT NOT NULL,
	FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
	FOREIGN KEY (AwardId) REFERENCES Awards(Id) ON DELETE CASCADE,
	)


CREATE PROCEDURE AddAward(
--Alter PROCEDURE AddAward(
	@title nvarchar(50),
	@description nvarchar(250))
AS
BEGIN
	INSERT INTO Awards
	VALUES(@title, @description)
END


CREATE PROCEDURE UpdateAward(
--Alter PROCEDURE UpdateAward(
	@id int,
	@title nvarchar(50),
	@description nvarchar(250))
AS
BEGIN
	UPDATE Awards
	 SET title = @title,
	     [Description]=@description
	 WHERE Id = @id
END


CREATE PROCEDURE DeleteAward(
--Alter PROCEDURE DeleteAward(
	@id int)
AS
BEGIN
 DELETE FROM Awards
  WHERE id=@id
END

CREATE TYPE AwardsIds
AS TABLE(id int)



create procedure RemoveUser(
--Alter PROCEDURE RemoveUser(
    @userId int)
AS
BEGIN
	DELETE FROM Users
	 WHERE id=@userId
END

create PROCEDURE AddUser(
--Alter PROCEDURE AddUser(
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@birthdate datetime2,
	@age int,
	@awardIds AwardsIds readonly)
AS
BEGIN
	DECLARE @userId AS TABLE(id int)

	INSERT INTO Users(FirstName, LastName, Birthdate, Age)
		OUTPUT Inserted.Id INTO @userId
		VALUES(@firstName, @lastName, @birthdate, @age)

	INSERT INTO Relations
		SELECT [@userId].id, [@awardIds].id FROM @awardIds, @userId
END


create PROCEDURE UpdateUser(
--Alter PROCEDURE UpdateUser(
	@userId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@birthdate datetime2,
	@age int,
	@awardIds AwardsIds readonly)
AS
BEGIN

	UPDATE Users
	 SET[FirstName] = @firstName,
		[LastName]=@lastName,
		[Birthdate]=@birthdate,
		[Age]=@age
	  WHERE Id = @userId

	 DELETE FROM relations
	  WHERE userId=@userId

	INSERT INTO Relations
	SELECT @userId, [@awardIds].id FROM @awardIds
END



CREATE PROCEDURE GetUserAwards(
--Alter PROCEDURE GetUserAwards(
	@userId int)
AS
BEGIN
 SELECT awards.id, title, [description]
  from awards inner join relations on awards.id=relations.awardid
  where userid=@userId
END


INSERT INTO Users(FirstName, LastName, Birthdate)
VALUES(N'User 1', N'Test1', '2010-10-02')
INSERT INTO Users(FirstName, LastName, Birthdate)
VALUES(N'User 3', N'Test3', '2010-10-02')
INSERT INTO Users(FirstName, LastName, Birthdate)
VALUES(N'User 4', N'Test4', '2010-10-02')


INSERT INTO Awards
VALUES(N'nobel prize', N'epic award')
INSERT INTO Awards
VALUES(N'another prize', 'common award')

INSERT INTO Relations
VALUES(1, 1), (1,2),(2,2)

BEGIN
DECLARE @awards AwardsIds;
INSERT INTO @awards VALUES(1),(2)
EXEC UpdateUser 2, N'User 1', N'Test123', N'2000-01-01', 3, @awards
END


