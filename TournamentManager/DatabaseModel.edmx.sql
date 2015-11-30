
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/30/2015 21:34:37
-- Generated from EDMX file: C:\Users\Vincas\Documents\Visual Studio 2015\Projects\TournamentManager\TournamentManager\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TournamentTimeControl_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TournamentTimeControl] DROP CONSTRAINT [FK_TournamentTimeControl_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_TournamentTimeControl_TimeControl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TournamentTimeControl] DROP CONSTRAINT [FK_TournamentTimeControl_TimeControl];
GO
IF OBJECT_ID(N'[dbo].[FK_TournamentAgeGroup_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TournamentAgeGroup] DROP CONSTRAINT [FK_TournamentAgeGroup_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_TournamentAgeGroup_AgeGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TournamentAgeGroup] DROP CONSTRAINT [FK_TournamentAgeGroup_AgeGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_TournamentPlayer_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TournamentPlayer] DROP CONSTRAINT [FK_TournamentPlayer_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_TournamentPlayer_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TournamentPlayer] DROP CONSTRAINT [FK_TournamentPlayer_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_GamePlayerWhite]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_GamePlayerWhite];
GO
IF OBJECT_ID(N'[dbo].[FK_GamePlayerBlack]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_GamePlayerBlack];
GO
IF OBJECT_ID(N'[dbo].[FK_GameTimeControl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_GameTimeControl];
GO
IF OBJECT_ID(N'[dbo].[FK_MoveGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Moves] DROP CONSTRAINT [FK_MoveGame];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Tournaments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tournaments];
GO
IF OBJECT_ID(N'[dbo].[Players]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Players];
GO
IF OBJECT_ID(N'[dbo].[Games]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Games];
GO
IF OBJECT_ID(N'[dbo].[TimeControls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TimeControls];
GO
IF OBJECT_ID(N'[dbo].[AgeGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AgeGroups];
GO
IF OBJECT_ID(N'[dbo].[Moves]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moves];
GO
IF OBJECT_ID(N'[dbo].[TournamentTimeControl]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TournamentTimeControl];
GO
IF OBJECT_ID(N'[dbo].[TournamentAgeGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TournamentAgeGroup];
GO
IF OBJECT_ID(N'[dbo].[TournamentPlayer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TournamentPlayer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tournaments'
CREATE TABLE [dbo].[Tournaments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Players'
CREATE TABLE [dbo].[Players] (
    [Id] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [Rating] float  NULL
);
GO

-- Creating table 'Games'
CREATE TABLE [dbo].[Games] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Result] nvarchar(7)  NOT NULL,
    [Date] datetime  NOT NULL,
    [PlayerWhite_Id] int  NOT NULL,
    [PlayerBlack_Id] int  NOT NULL,
    [TimeControl_Id] int  NOT NULL
);
GO

-- Creating table 'TimeControls'
CREATE TABLE [dbo].[TimeControls] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Control] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'AgeGroups'
CREATE TABLE [dbo].[AgeGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Moves'
CREATE TABLE [dbo].[Moves] (
    [Number] int  NOT NULL,
    [Color] nchar(1)  NOT NULL,
    [Field] nchar(2)  NOT NULL,
    [Piece] nchar(1)  NOT NULL,
    [GameId] int  NOT NULL
);
GO

-- Creating table 'TournamentTimeControl'
CREATE TABLE [dbo].[TournamentTimeControl] (
    [Tournaments_Id] int  NOT NULL,
    [TimeControls_Id] int  NOT NULL
);
GO

-- Creating table 'TournamentAgeGroup'
CREATE TABLE [dbo].[TournamentAgeGroup] (
    [Tournaments_Id] int  NOT NULL,
    [AgeGroups_Id] int  NOT NULL
);
GO

-- Creating table 'TournamentPlayer'
CREATE TABLE [dbo].[TournamentPlayer] (
    [Tournaments_Id] int  NOT NULL,
    [Players_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Tournaments'
ALTER TABLE [dbo].[Tournaments]
ADD CONSTRAINT [PK_Tournaments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [PK_Players]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [PK_Games]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TimeControls'
ALTER TABLE [dbo].[TimeControls]
ADD CONSTRAINT [PK_TimeControls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AgeGroups'
ALTER TABLE [dbo].[AgeGroups]
ADD CONSTRAINT [PK_AgeGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Number], [Color], [GameId] in table 'Moves'
ALTER TABLE [dbo].[Moves]
ADD CONSTRAINT [PK_Moves]
    PRIMARY KEY CLUSTERED ([Number], [Color], [GameId] ASC);
GO

-- Creating primary key on [Tournaments_Id], [TimeControls_Id] in table 'TournamentTimeControl'
ALTER TABLE [dbo].[TournamentTimeControl]
ADD CONSTRAINT [PK_TournamentTimeControl]
    PRIMARY KEY CLUSTERED ([Tournaments_Id], [TimeControls_Id] ASC);
GO

-- Creating primary key on [Tournaments_Id], [AgeGroups_Id] in table 'TournamentAgeGroup'
ALTER TABLE [dbo].[TournamentAgeGroup]
ADD CONSTRAINT [PK_TournamentAgeGroup]
    PRIMARY KEY CLUSTERED ([Tournaments_Id], [AgeGroups_Id] ASC);
GO

-- Creating primary key on [Tournaments_Id], [Players_Id] in table 'TournamentPlayer'
ALTER TABLE [dbo].[TournamentPlayer]
ADD CONSTRAINT [PK_TournamentPlayer]
    PRIMARY KEY CLUSTERED ([Tournaments_Id], [Players_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Tournaments_Id] in table 'TournamentTimeControl'
ALTER TABLE [dbo].[TournamentTimeControl]
ADD CONSTRAINT [FK_TournamentTimeControl_Tournament]
    FOREIGN KEY ([Tournaments_Id])
    REFERENCES [dbo].[Tournaments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TimeControls_Id] in table 'TournamentTimeControl'
ALTER TABLE [dbo].[TournamentTimeControl]
ADD CONSTRAINT [FK_TournamentTimeControl_TimeControl]
    FOREIGN KEY ([TimeControls_Id])
    REFERENCES [dbo].[TimeControls]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TournamentTimeControl_TimeControl'
CREATE INDEX [IX_FK_TournamentTimeControl_TimeControl]
ON [dbo].[TournamentTimeControl]
    ([TimeControls_Id]);
GO

-- Creating foreign key on [Tournaments_Id] in table 'TournamentAgeGroup'
ALTER TABLE [dbo].[TournamentAgeGroup]
ADD CONSTRAINT [FK_TournamentAgeGroup_Tournament]
    FOREIGN KEY ([Tournaments_Id])
    REFERENCES [dbo].[Tournaments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AgeGroups_Id] in table 'TournamentAgeGroup'
ALTER TABLE [dbo].[TournamentAgeGroup]
ADD CONSTRAINT [FK_TournamentAgeGroup_AgeGroup]
    FOREIGN KEY ([AgeGroups_Id])
    REFERENCES [dbo].[AgeGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TournamentAgeGroup_AgeGroup'
CREATE INDEX [IX_FK_TournamentAgeGroup_AgeGroup]
ON [dbo].[TournamentAgeGroup]
    ([AgeGroups_Id]);
GO

-- Creating foreign key on [Tournaments_Id] in table 'TournamentPlayer'
ALTER TABLE [dbo].[TournamentPlayer]
ADD CONSTRAINT [FK_TournamentPlayer_Tournament]
    FOREIGN KEY ([Tournaments_Id])
    REFERENCES [dbo].[Tournaments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Players_Id] in table 'TournamentPlayer'
ALTER TABLE [dbo].[TournamentPlayer]
ADD CONSTRAINT [FK_TournamentPlayer_Player]
    FOREIGN KEY ([Players_Id])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TournamentPlayer_Player'
CREATE INDEX [IX_FK_TournamentPlayer_Player]
ON [dbo].[TournamentPlayer]
    ([Players_Id]);
GO

-- Creating foreign key on [PlayerWhite_Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_GamePlayerWhite]
    FOREIGN KEY ([PlayerWhite_Id])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GamePlayerWhite'
CREATE INDEX [IX_FK_GamePlayerWhite]
ON [dbo].[Games]
    ([PlayerWhite_Id]);
GO

-- Creating foreign key on [PlayerBlack_Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_GamePlayerBlack]
    FOREIGN KEY ([PlayerBlack_Id])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GamePlayerBlack'
CREATE INDEX [IX_FK_GamePlayerBlack]
ON [dbo].[Games]
    ([PlayerBlack_Id]);
GO

-- Creating foreign key on [TimeControl_Id] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_GameTimeControl]
    FOREIGN KEY ([TimeControl_Id])
    REFERENCES [dbo].[TimeControls]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameTimeControl'
CREATE INDEX [IX_FK_GameTimeControl]
ON [dbo].[Games]
    ([TimeControl_Id]);
GO

-- Creating foreign key on [GameId] in table 'Moves'
ALTER TABLE [dbo].[Moves]
ADD CONSTRAINT [FK_MoveGame]
    FOREIGN KEY ([GameId])
    REFERENCES [dbo].[Games]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoveGame'
CREATE INDEX [IX_FK_MoveGame]
ON [dbo].[Moves]
    ([GameId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------