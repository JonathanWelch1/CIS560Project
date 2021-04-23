--CREATE SCHEMA Foods; /* Uncomment me! */
USE joselopez44528

DROP TABLE IF EXISTS Foods.FoodCategoryL;
DROP TABLE IF EXISTS Foods.Amount;
DROP TABLE IF EXISTS Foods.Food;
DROP TABLE IF EXISTS Foods.Category;
DROP TABLE IF EXISTS Foods.Nutrient;
DROP TABLE IF EXISTS Foods.Measurement;
--DROP SCHEMA IF EXISTS Foods;
GO 

--CREATE SCHEMA Foods;

GO

CREATE TABLE Foods.Category
(
    CategoryID INT NOT NULL IDENTITY PRIMARY KEY,
    CategoryName NVARCHAR(50) NOT NULL
);

CREATE TABLE Foods.Food
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
CREATE TABLE Foods.FoodCategoryL
(
    CategoryID INT NOT NULL,
    FoodID INT NOT NULL, 

    CONSTRAINT [PK_Foods_FoodCategoryL] PRIMARY KEY
    (
        CategoryID,
        FoodID
    ),

    CONSTRAINT [FK_Foods_FoodCategoryL_CategoryID] FOREIGN KEY (CategoryID) REFERENCES Foods.Category(CategoryID),
    CONSTRAINT [FK_Foods_FoodCategoryL_FoodID] FOREIGN KEY (FoodID) REFERENCES Foods.Food(FoodID),
);

CREATE TABLE Foods.Nutrient
(
    NutrientID INT NOT NULL,
    NutrientName NVARCHAR(50),

    CONSTRAINT[PK_Foods_Nutrient] PRIMARY KEY
    (
        NutrientID 
    ),
);


CREATE TABLE Foods.Measurement
(
    MeasurementID INT NOT NULL,
    UnitMeasurement NVARCHAR(20),

    CONSTRAINT[PK_Foods_Measurement] PRIMARY KEY
    (
        MeasurementID
    ),
);


CREATE TABLE Foods.Amount
(
    FoodID INT NOT NULL,
    MeasurementID INT NOT NULL,
    NutrientID INT NOT NULL,
    Calories float,


    CONSTRAINT[PK_Foods_Amount] PRIMARY KEY
    (
        MeasurementID,
        NutrientID,
        FoodID
    ),

    CONSTRAINT [FK_Foods_Amount_MeasurementID] FOREIGN KEY (MeasurementID) REFERENCES Foods.Measurement(MeasurementID),
    CONSTRAINT [FK_Foods_Amount_FoodID] FOREIGN KEY (FoodID) REFERENCES Foods.Food(FoodID),
    CONSTRAINT [FK_Foods_Amount_NutrientID] FOREIGN KEY (NutrientID) REFERENCES Foods.Nutrient(NutrientID)

);





