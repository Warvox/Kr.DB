CREATE TABLE [dbo].[Department] (
    [ID Department]             INT           IDENTITY (1, 1) NOT NULL,
    [Department]           NVARCHAR (50) NOT NULL,
    [Chief]                NVARCHAR (50) NOT NULL,
    [Phone]                NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID Department] ASC)
);