CREATE TABLE [dbo].[MMContacts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [dDate] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Company] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Telephone] NVARCHAR(20) NOT NULL, 
    [Subject] NVARCHAR(50) NOT NULL, 
    [MessageBody] NVARCHAR(MAX) NOT NULL
)
