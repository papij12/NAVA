CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    [UserEmail] NVARCHAR(50) NOT NULL, 
    [UserName] NVARCHAR(50) NOT NULL
)
