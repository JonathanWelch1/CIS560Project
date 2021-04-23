---------------------------------------------------
--Script to populate Food.Measurement
INSERT INTO Foods.Measurement (MeasurementID, UnitMeasurement)
SELECT *
FROM Foods.MeasurementD 
---------------------------------------------------
--Script to populate Food.Category
SET IDENTITY_INSERT Foods.Category ON
INSERT INTO Foods.Category(CategoryID, CategoryName)
SELECT *
FROM Foods.CategoryD 
---------------------------------------------------
--Script to populate Food.Food
INSERT INTO Foods.Food(FoodID, Discription)
SELECT *
FROM Foods.FoodD 
---------------------------------------------------
--Script to populate Food.FoodCategoryL
INSERT INTO Foods.FoodCategoryL(CategoryID, FoodID)
SELECT *
FROM Foods.FoodCategoryLD
---------------------------------------------------
--Script to populate Food.Nutrient
INSERT INTO Foods.Nutrient(NutrientID, NutrientName)
SELECT *
FROM Foods.NutrientD
---------------------------------------------------
--Script to populate Food.Amount
INSERT INTO Foods.Amount(FoodID,MeasurementID,NutrientID,Calories)
SELECT *
FROM Foods.AmountD
---------------------------------------------------
--Drop the dummy tables
DROP TABLE IF EXISTS Foods.CategoryD;
DROP TABLE IF EXISTS Foods.FoodCategoryLD;
DROP TABLE IF EXISTS Foods.FoodD;
DROP TABLE IF EXISTS Foods.AmountD;
DROP TABLE IF EXISTS Foods.MeasurementD;
DROP TABLE IF EXISTS Foods.NutrientD;