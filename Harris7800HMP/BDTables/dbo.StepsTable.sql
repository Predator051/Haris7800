﻿CREATE TABLE [dbo].[Steps]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] TEXT NOT NULL, 
    [Passed] TINYINT NOT NULL DEFAULT 0
)
