CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL , 
    [ContactID] INT NOT NULL , 
    [Name] NVARCHAR(100) NULL, 
    [Company] NVARCHAR(100) NULL, 
    [Telephone] NVARCHAR(100) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [Client] BIT NULL, 
    [Last Call] DATETIME NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([ContactID]) 
)

GO
