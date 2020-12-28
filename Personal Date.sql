CREATE TABLE [dbo].[Personal Date](
	[Id] INT         IDENTITY (1, 1) NOT NULL, 
	[Gender]         NVARCHAR (50) NOT NULL,
    [Birthday]       DATE          NOT NULL,
    [Place of birth] NVARCHAR (50) NOT NULL,
    [Education]      NVARCHAR (50) NULL,
    [Phone]          NVARCHAR (50) NULL,
    [Email]          NVARCHAR (50) NULL,
	PRIMARY KEY ([Id] ASC)
)