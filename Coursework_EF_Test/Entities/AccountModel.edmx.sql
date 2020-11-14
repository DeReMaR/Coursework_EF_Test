
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/14/2020 14:33:59
-- Generated from EDMX file: C:\Users\derem\source\repos\Coursework_EF\Coursework_EF_Test\Entities\AccountModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\USERS\DEREM\SOURCE\REPOS\COURSEWORK_EF\COURSEWORK_EF_TEST\ACCOUNT.MDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'WorkerSet'
CREATE TABLE [dbo].[WorkerSet] (
    [Id_Worker] int IDENTITY(1,1) NOT NULL,
    [WName] nvarchar(max)  NOT NULL,
    [WPosition] nvarchar(max)  NOT NULL,
    [WSex] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AccountSet'
CREATE TABLE [dbo].[AccountSet] (
    [Id_Account] int IDENTITY(1,1) NOT NULL,
    [APlace] int  NOT NULL,
    [AObjName] nvarchar(max)  NOT NULL,
    [AInvNum] int  NOT NULL,
    [ADate] datetime  NOT NULL,
    [AUsage] int  NOT NULL,
    [APrice] int  NOT NULL,
    [ACount] int  NOT NULL,
    [ASum] int  NOT NULL,
    [AStatus] nvarchar(max)  NOT NULL,
    [WorkerId_Worker] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Worker] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [PK_WorkerSet]
    PRIMARY KEY CLUSTERED ([Id_Worker] ASC);
GO

-- Creating primary key on [Id_Account] in table 'AccountSet'
ALTER TABLE [dbo].[AccountSet]
ADD CONSTRAINT [PK_AccountSet]
    PRIMARY KEY CLUSTERED ([Id_Account] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [WorkerId_Worker] in table 'AccountSet'
ALTER TABLE [dbo].[AccountSet]
ADD CONSTRAINT [FK_WorkerAccount]
    FOREIGN KEY ([WorkerId_Worker])
    REFERENCES [dbo].[WorkerSet]
        ([Id_Worker])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkerAccount'
CREATE INDEX [IX_FK_WorkerAccount]
ON [dbo].[AccountSet]
    ([WorkerId_Worker]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------