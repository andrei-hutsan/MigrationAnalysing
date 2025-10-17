IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table1] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table1] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table10] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table10] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table2] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table2] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table3] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table3] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table4] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table4] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table5] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table5] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table6] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table6] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table7] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table7] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table8] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table8] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    CREATE TABLE [Table9] (
        [Id] int NOT NULL IDENTITY,
        [column9] nvarchar(max) NOT NULL,
        [column8] nvarchar(max) NOT NULL,
        [column7] nvarchar(max) NOT NULL,
        [column6] nvarchar(max) NOT NULL,
        [column5] nvarchar(max) NOT NULL,
        [column4] nvarchar(max) NOT NULL,
        [column3] nvarchar(max) NOT NULL,
        [column2] nvarchar(max) NOT NULL,
        [column1] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Table9] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251017074737_InitialBaseline'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20251017074737_InitialBaseline', N'9.0.10');
END;

COMMIT;
GO

