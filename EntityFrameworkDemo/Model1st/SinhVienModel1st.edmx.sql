
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/03/2019 08:47:39
-- Generated from EDMX file: C:\Users\hpl27\Desktop\Hoc.NET\EntityFramework\EntityFrameworkDemo\Model1st\SinhVienModel1st.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SinhVienModel1st];
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

-- Creating table 'SinhViens'
CREATE TABLE [dbo].[SinhViens] (
    [ID_SV] int IDENTITY(1,1) NOT NULL,
    [ID_Khoa] int  NOT NULL,
    [TenSV] nvarchar(max)  NOT NULL,
    [Diem] float  NOT NULL,
    [GioiTinh] bit  NOT NULL,
    [NgaySinh] datetime  NOT NULL
);
GO

-- Creating table 'Khoas'
CREATE TABLE [dbo].[Khoas] (
    [ID_Khoa] int IDENTITY(1,1) NOT NULL,
    [TenKhoa] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_SV] in table 'SinhViens'
ALTER TABLE [dbo].[SinhViens]
ADD CONSTRAINT [PK_SinhViens]
    PRIMARY KEY CLUSTERED ([ID_SV] ASC);
GO

-- Creating primary key on [ID_Khoa] in table 'Khoas'
ALTER TABLE [dbo].[Khoas]
ADD CONSTRAINT [PK_Khoas]
    PRIMARY KEY CLUSTERED ([ID_Khoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ID_Khoa] in table 'SinhViens'
ALTER TABLE [dbo].[SinhViens]
ADD CONSTRAINT [FK_KhoaSinhVien]
    FOREIGN KEY ([ID_Khoa])
    REFERENCES [dbo].[Khoas]
        ([ID_Khoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KhoaSinhVien'
CREATE INDEX [IX_FK_KhoaSinhVien]
ON [dbo].[SinhViens]
    ([ID_Khoa]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------