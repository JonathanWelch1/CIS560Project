---------------------------------------------------
--Script to populate Food.Measurement
INSERT INTO Food.Measurement (MeasurementID, UnitMeasurement)
SELECT *
FROM Food.MeasurementD 
---------------------------------------------------
--Script to populate Food.Category
SET IDENTITY_INSERT Food.Category ON
INSERT INTO Food.Category(CategoryID, CategoryName)
SELECT *
FROM Food.CategoryD 
---------------------------------------------------
--Script to populate Food.Food
INSERT INTO Food.Food(FoodID, Discription)
SELECT *
FROM Food.FoodD 
---------------------------------------------------
--Script to populate Food.FoodCategoryL
INSERT INTO Food.FoodCategoryL(CategoryID, FoodID)
SELECT *
FROM Food.FoodCategoryLD
---------------------------------------------------
--Script to populate Food.Nutrient
INSERT INTO Food.Nutrient(NutrientID, NutrientName)
SELECT *
FROM Food.NutrientD
---------------------------------------------------
--Script to populate Food.Amount
INSERT INTO Food.Amount(FoodID,MeasurementID,NutrientID,Calories)
SELECT *
FROM Food.AmountD
---------------------------------------------------
--Drop the dummy tables
DROP TABLE IF EXISTS Food.CategoryD;
DROP TABLE IF EXISTS Food.FoodCategoryLD;
DROP TABLE IF EXISTS Food.FoodD;
DROP TABLE IF EXISTS Food.AmountD;
DROP TABLE IF EXISTS Food.MeasurementD;
DROP TABLE IF EXISTS Food.NutrientD;