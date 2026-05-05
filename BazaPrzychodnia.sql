IF DB_ID(N'Przychodnia') IS NULL
BEGIN
    CREATE DATABASE [Przychodnia];
END

CREATE TABLE [Przychodnia].dbo.lekarze(
    id_lekarz INT IDENTITY(1,1) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Specialization VARCHAR(100) NOT NULL,
    Phone VARCHAR(20) NULL,
    Password VARCHAR(256) NOT NULL,
    LicenseNumber VARCHAR(50) NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT PK_lekarze PRIMARY KEY CLUSTERED (id_lekarz)
) ON [PRIMARY];

CREATE UNIQUE INDEX UQ_lekarze_Email ON [Przychodnia].dbo.lekarze(Email);

CREATE TABLE [Przychodnia].dbo.urzytkownicy(
    id_uzytkownik INT IDENTITY(1,1) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NULL,
    Phone VARCHAR(20) NULL,
    Email VARCHAR(255) NOT NULL,
    Password VARCHAR(256) NOT NULL,
    CzyAdmin bit NOT NULL CONSTRAINT DEFAULT (0);
    CreatedAt DATETIME2(7) NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT PK_urzytkownicy PRIMARY KEY CLUSTERED (id_uzytkownik)
) ON [PRIMARY];

CREATE UNIQUE INDEX UQ_urzytkownicy_Email ON [Przychodnia].dbo.urzytkownicy(Email);

CREATE TABLE [Przychodnia].dbo.recepty(
    id_recepty INT IDENTITY(1,1) NOT NULL,
    data DATE NOT NULL,
    id_lekarz INT NOT NULL,
    id_uzytkownik INT NOT NULL,
    opis VARCHAR(500) NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT PK_recepty PRIMARY KEY CLUSTERED (id_recepty)
) ON [PRIMARY];

CREATE TABLE [Przychodnia].dbo.wizyty(
    id_wizyta INT IDENTITY(1,1) NOT NULL,
    Data_Wizyty DATETIME2(7) NOT NULL,
    id_lekarz INT NOT NULL,
    id_uzytkownik INT NOT NULL,
    opis VARCHAR(500) NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT PK_wizyty PRIMARY KEY CLUSTERED (id_wizyta)
) ON [PRIMARY];

ALTER TABLE [Przychodnia].dbo.recepty
    ADD CONSTRAINT FK_recepty_lekarze FOREIGN KEY (id_lekarz)
    REFERENCES [Przychodnia].dbo.lekarze(id_lekarz);

ALTER TABLE [Przychodnia].dbo.recepty
    ADD CONSTRAINT FK_recepty_urzytkownicy FOREIGN KEY (id_uzytkownik)
    REFERENCES [Przychodnia].dbo.urzytkownicy(id_uzytkownik);

ALTER TABLE [Przychodnia].dbo.wizyty
    ADD CONSTRAINT FK_wizyty_lekarze FOREIGN KEY (id_lekarz)
    REFERENCES [Przychodnia].dbo.lekarze(id_lekarz);

ALTER TABLE [Przychodnia].dbo.wizyty
    ADD CONSTRAINT FK_wizyty_urzytkownicy FOREIGN KEY (id_uzytkownik)
    REFERENCES [Przychodnia].dbo.urzytkownicy(id_uzytkownik);
