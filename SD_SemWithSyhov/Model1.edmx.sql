
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/29/2018 08:33:50
-- Generated from EDMX file: E:\GitHub\SD_SemWithSyhov\SD_SemWithSyhov\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CW];
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

-- Creating table 'StudentSet'
CREATE TABLE [dbo].[StudentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CurrentCourse] tinyint  NOT NULL
);
GO

-- Creating table 'TeacherSet'
CREATE TABLE [dbo].[TeacherSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Post] tinyint  NOT NULL
);
GO

-- Creating table 'CourseWorkSet'
CREATE TABLE [dbo].[CourseWorkSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Course] tinyint  NOT NULL,
    [Mark] nvarchar(max)  NOT NULL,
    [Student_Id] int  NOT NULL,
    [Teacher_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [PK_StudentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeacherSet'
ALTER TABLE [dbo].[TeacherSet]
ADD CONSTRAINT [PK_TeacherSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseWorkSet'
ALTER TABLE [dbo].[CourseWorkSet]
ADD CONSTRAINT [PK_CourseWorkSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Student_Id] in table 'CourseWorkSet'
ALTER TABLE [dbo].[CourseWorkSet]
ADD CONSTRAINT [FK_StudentCourseWork]
    FOREIGN KEY ([Student_Id])
    REFERENCES [dbo].[StudentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentCourseWork'
CREATE INDEX [IX_FK_StudentCourseWork]
ON [dbo].[CourseWorkSet]
    ([Student_Id]);
GO

-- Creating foreign key on [Teacher_Id] in table 'CourseWorkSet'
ALTER TABLE [dbo].[CourseWorkSet]
ADD CONSTRAINT [FK_TeacherCourseWork]
    FOREIGN KEY ([Teacher_Id])
    REFERENCES [dbo].[TeacherSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeacherCourseWork'
CREATE INDEX [IX_FK_TeacherCourseWork]
ON [dbo].[CourseWorkSet]
    ([Teacher_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------