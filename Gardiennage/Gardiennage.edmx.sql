
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/14/2019 14:28:39
-- Generated from EDMX file: E:\devspace\csharp\Gardiennage\Gardiennage\Gardiennage.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Gardiennage];
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

-- Creating table 'GardienSet'
CREATE TABLE [dbo].[GardienSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [FinDambauche] nvarchar(max)  NULL,
    [SituationMatrimoniale] nvarchar(max)  NOT NULL,
    [Domicile] nvarchar(max)  NOT NULL,
    [Matricule] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [UrlCv] nvarchar(max)  NULL,
    [DebutDambauche] datetime  NOT NULL
);
GO

-- Creating table 'ContratSet'
CREATE TABLE [dbo].[ContratSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Debut] datetime  NOT NULL,
    [Fin] datetime  NOT NULL,
    [Lieu] nvarchar(max)  NOT NULL,
    [Client] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [UrlFichier] nvarchar(max)  NULL
);
GO

-- Creating table 'GardienContrat'
CREATE TABLE [dbo].[GardienContrat] (
    [Gardiens_Id] int  NOT NULL,
    [Contrats_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'GardienSet'
ALTER TABLE [dbo].[GardienSet]
ADD CONSTRAINT [PK_GardienSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ContratSet'
ALTER TABLE [dbo].[ContratSet]
ADD CONSTRAINT [PK_ContratSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Gardiens_Id], [Contrats_Id] in table 'GardienContrat'
ALTER TABLE [dbo].[GardienContrat]
ADD CONSTRAINT [PK_GardienContrat]
    PRIMARY KEY CLUSTERED ([Gardiens_Id], [Contrats_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Gardiens_Id] in table 'GardienContrat'
ALTER TABLE [dbo].[GardienContrat]
ADD CONSTRAINT [FK_GardienContrat_Gardien]
    FOREIGN KEY ([Gardiens_Id])
    REFERENCES [dbo].[GardienSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Contrats_Id] in table 'GardienContrat'
ALTER TABLE [dbo].[GardienContrat]
ADD CONSTRAINT [FK_GardienContrat_Contrat]
    FOREIGN KEY ([Contrats_Id])
    REFERENCES [dbo].[ContratSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GardienContrat_Contrat'
CREATE INDEX [IX_FK_GardienContrat_Contrat]
ON [dbo].[GardienContrat]
    ([Contrats_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------