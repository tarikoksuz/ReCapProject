CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CarName] NVARCHAR(50) NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] DECIMAL NULL, 
    [Description] NVARCHAR(50) NULL
)
