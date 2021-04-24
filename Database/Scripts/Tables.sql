--CREATE SCHEMA Foods; /* Uncomment me! */
USE joselopez44528

DROP TABLE IF EXISTS Food.FoodCategoryL;
DROP TABLE IF EXISTS Food.Amount;
DROP TABLE IF EXISTS Food.Food;
DROP TABLE IF EXISTS Food.Category;
DROP TABLE IF EXISTS Food.Nutrient;
DROP TABLE IF EXISTS Food.Measurement;
--DROP SCHEMA IF EXISTS Food;
GO 

--CREATE SCHEMA Food;

GO

CREATE TABLE Food.Category
(
    CategoryID INT NOT NULL IDENTITY PRIMARY KEY,
    CategoryName NVARCHAR(50) NOT NULL
);

CREATE TABLE Food.Food
(
    FoodID INT NOT NULL,
    Discription NVARCHAR(Max) NOT NULL,
    [Name] NVarChar(50),

    CONSTRAINT [PK_Foods_Food_FoodID] PRIMARY KEY
    (
        FoodID
    ),
);

GO
CREATE TABLE Food.FoodCategoryL
(
    CategoryID INT NOT NULL,
    FoodID INT NOT NULL, 

    CONSTRAINT [PK_Foods_FoodCategoryL] PRIMARY KEY
    (
        CategoryID,
        FoodID
    ),

    CONSTRAINT [FK_Foods_FoodCategoryL_CategoryID] FOREIGN KEY (CategoryID) REFERENCES Food.Category(CategoryID),
    CONSTRAINT [FK_Foods_FoodCategoryL_FoodID] FOREIGN KEY (FoodID) REFERENCES Food.Food(FoodID),
);

CREATE TABLE Food.Nutrient
(
    NutrientID INT NOT NULL,
    NutrientName NVARCHAR(50),

    CONSTRAINT[PK_Foods_Nutrient] PRIMARY KEY
    (
        NutrientID 
    ),
);


CREATE TABLE Food.Measurement
(
    MeasurementID INT NOT NULL,
    UnitMeasurement NVARCHAR(20),

    CONSTRAINT[PK_Foods_Measurement] PRIMARY KEY
    (
        MeasurementID
    ),
);


CREATE TABLE Food.Amount
(
    FoodID INT NOT NULL,
    MeasurementID INT NOT NULL,
    NutrientID INT NOT NULL,
    Amount float,


    CONSTRAINT[PK_Foods_Amount] PRIMARY KEY
    (
        MeasurementID,
        NutrientID,
        FoodID
    ),

    CONSTRAINT [FK_Foods_Amount_MeasurementID] FOREIGN KEY (MeasurementID) REFERENCES Food.Measurement(MeasurementID),
    CONSTRAINT [FK_Foods_Amount_FoodID] FOREIGN KEY (FoodID) REFERENCES Food.Food(FoodID),
    CONSTRAINT [FK_Foods_Amount_NutrientID] FOREIGN KEY (NutrientID) REFERENCES Food.Nutrient(NutrientID)

);





