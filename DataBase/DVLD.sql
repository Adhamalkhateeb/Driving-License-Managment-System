

CREATE TABLE Countries (
    CountryID INT PRIMARY KEY,
    CountryName NVARCHAR(50)
);

CREATE TABLE People (
    PersonID INT PRIMARY KEY,
    NationalNo NVARCHAR(20),
    FirstName NVARCHAR(20),
    SecondName NVARCHAR(20),
    ThirdName NVARCHAR(20),
    LastName NVARCHAR(20),
    DateOfBirth DATETIME,
    Gender TINYINT,
    Address NVARCHAR(500),
    Phone NVARCHAR(20),
    Email NVARCHAR(50),
    NationalityCountryID INT,
    ImagePath NVARCHAR(250),
    FOREIGN KEY (NationalityCountryID) REFERENCES Countries(CountryID)
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    PersonID INT,
    UserName NVARCHAR(20),
    Password NVARCHAR(20),
    IsActive BIT,
    FOREIGN KEY (PersonID) REFERENCES People(PersonID)
);

CREATE TABLE ApplicationTypes (
    ApplicationTypeID INT PRIMARY KEY,
    ApplicationTypeTitle NVARCHAR(150),
    ApplicationFees SMALLMONEY
);

CREATE TABLE Applications (
    ApplicationID INT PRIMARY KEY,
    ApplicantPersonID INT,
    ApplicationDate DATETIME,
    ApplicationTypeID INT,
    ApplicationStatus TINYINT,
    LastStatusDate DATETIME,
    PaidFees SMALLMONEY,
    CreatedByUserID INT,
    FOREIGN KEY (ApplicantPersonID) REFERENCES People(PersonID),
    FOREIGN KEY (ApplicationTypeID) REFERENCES ApplicationTypes(ApplicationTypeID),
    FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID)
);

CREATE TABLE LicenseClasses (
    LicenseClassID INT PRIMARY KEY,
    ClassName NVARCHAR(50),
    ClassDescription NVARCHAR(500),
    MinimumAllowedAge TINYINT,
    DefaultValidityLength TINYINT,
    ClassFees SMALLMONEY
);

CREATE TABLE LocalDrivingLicenseApplications (
    LocalDrivingLicenseApplicationID INT PRIMARY KEY,
    ApplicationID INT,
    LicenseClassID INT,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (LicenseClassID) REFERENCES LicenseClasses(LicenseClassID)
);

CREATE TABLE TestTypes (
    TestTypeID INT PRIMARY KEY,
    TestTypeTitle NVARCHAR(100),
    TestTypeDescription NVARCHAR(500),
    TestTypeFees SMALLMONEY
);

CREATE TABLE TestAppointments (
    TestAppointmentID INT PRIMARY KEY,
    LocalDrivingLicenseApplicationID INT,
    TestTypeID INT,
    AppointmentDate SMALLDATETIME,
    PaidFees SMALLMONEY,
    CreatedByUserID INT,
    IsLocked BIT,
    RetakeTestApplicationID INT,
    FOREIGN KEY (LocalDrivingLicenseApplicationID) REFERENCES LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID),
    FOREIGN KEY (TestTypeID) REFERENCES TestTypes(TestTypeID),
    FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID),
    FOREIGN KEY (RetakeTestApplicationID) REFERENCES Applications(ApplicationID)
);

CREATE TABLE Tests (
    TestID INT PRIMARY KEY,
    TestAppointmentID INT,
    TestResult BIT,
    Notes NVARCHAR(500),
    CreatedByUserID INT,
    FOREIGN KEY (TestAppointmentID) REFERENCES TestAppointments(TestAppointmentID),
    FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID)
);

CREATE TABLE Drivers (
    DriverID INT PRIMARY KEY,
    PersonID INT,
    CreatedByUserID INT,
    CreatedDate SMALLDATETIME,
    FOREIGN KEY (PersonID) REFERENCES People(PersonID),
    FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID)
);

CREATE TABLE Licenses (
    LicenseID INT PRIMARY KEY,
    ApplicationID INT,
    DriverID INT,
    LicenseClassID INT,
    IssueDate DATETIME,
    ExpirationDate DATETIME,
    Notes NVARCHAR(500),
    PaidFees SMALLMONEY,
    IsActive BIT,
    IssueReason TINYINT,
    CreatedByUserID INT,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (DriverID) REFERENCES Drivers(DriverID),
    FOREIGN KEY (LicenseClassID) REFERENCES LicenseClasses(LicenseClassID),
    FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID)
);

CREATE TABLE DetainedLicenses (
    DetainID INT PRIMARY KEY,
    LicenseID INT,
    DetainDate SMALLDATETIME,
    FineFees SMALLMONEY,
    CreatedByUserID INT,
    IsReleased BIT,
    ReleaseDate SMALLDATETIME,
    ReleasedByUserID INT,
    ReleaseApplicationID INT,
    FOREIGN KEY (LicenseID) REFERENCES Licenses(LicenseID),
    FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID),
    FOREIGN KEY (ReleasedByUserID) REFERENCES Users(UserID),
    FOREIGN KEY (ReleaseApplicationID) REFERENCES Applications(ApplicationID)
);
