/*------------------------------------------------
Query 1
Displays everything in the Category table
*/
SELECT *
FROM Food.Category C
/*------------------------------------------------
Query 2
Displays all the food Discriptions
Variable: term to search by
*/
DECLARE @term NVARCHAR(50) = 'Waffles%'
SELECT *
FROM Food.Food F
WHERE F.Discription LIKE @term
/*------------------------------------------------
Query 3
Displays Top result of a nutrient, of all foods
AND returns the top foods for that nutrient in that category
*/
DECLARE @nutrientID INT = 2
SELECT TOP(100) F.Discription, N.NutrientName, A.Amount, M.UnitMeasurement
FROM FoodofCategory F 
    INNER JOIN Food.Amount A ON A.FoodID = F.FoodID
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID
WHERE N.NutrientID = @nutrientID
ORDER BY A.Amount DESC
/*------------------------------------------------
Query 4
Displays all the foods in a category 
Variable is for Categories is inputed by user
*/
DECLARE @categoryID INT = 13
SELECT C.CategoryName, F.Discription
FROM Food.Category C
    INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID
    INNER JOIN Food.Food F ON F.FoodID = L.FoodID
WHERE C.CategoryID = categoryID
GROUP BY CategoryName, Discription
/*------------------------------------------------
Query 5 - REPORT*
Displays how many foods are in each category, Average calories per category, and ranks them form lowest to highest
*/
SELECT C.CategoryName, DerivedTable.TotalFoods, DerivedTable.AverageCalories, RANK() OVER(ORDER BY DerivedTable.AverageCalories) [Rank]
FROM 
    (
        SELECT FCL.CategoryID,COUNT(FCL.FoodID), ROUND(SUM(A.Amount)/COUNT(FCL.FoodID),2)
        FROM Food.Amount A
            INNER JOIN Food.FoodCategoryL FCL ON FCL.FoodID = A.FoodID
        WHERE A.NutrientID = 0
        GROUP BY FCL.CategoryID
    ) AS DerivedTable(CategoryID, TotalFoods, AverageCalories) 
    INNER JOIN Food.Category C ON C.CategoryID = DerivedTable.CategoryID
/*------------------------------------------------
Query 6 - REPORT*
Displays Top result of nutrient, for a corrisponding category
AND returns the top foods for that nutrient in that category
*/
 DECLARE @categoryID INT = 0, @nutrientID INT = 0, @rank INT = 50
 WITH FoodofCategory(FoodID, Discription, CategoryName) AS 
 (
     SELECT FD.FoodID, FD.Discription, C.CategoryName 
     FROM Food.Category C 
        INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID 
        INNER JOIN Food.Food FD ON FD.FoodID = L.FoodID 
    WHERE C.CategoryID = @categoryID
    GROUP BY FD.FoodID, FD.Discription, C.CategoryName 
 ) 
SELECT TOP (@rank) F.CategoryName, F.Discription, A.Amount, M.UnitMeasurement 
FROM FoodofCategory F 
    INNER JOIN Food.Amount A ON A.FoodID = F.FoodID 
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID 
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID 
 WHERE N.NutrientID = @nutrientID
 ORDER BY A.Amount DESC
/*
Query 7 - REPORT*
This query allows users to pick the top food names along with choosing the amounts in a range
*/
DECLARE @RANK INT = 0
DECLARE @LOW INT = 100
DECLARE @HIGH INT = 150
SELECT TOP(@RANK) F.Discription AS 'FoodName', M.UnitMeasurement, N.NutrientName, A.Amount 
FROM FOOD.Nutrient N INNER JOIN FOOD.Amount A ON A.NutrientID = N.NutrientID 
INNER JOIN FOOD.Food F ON F.FoodID = A.FoodID 
INNER JOIN FOOD.Measurement M ON M.MeasurementID = A.MeasurementID 
WHERE M.MeasurementID = 0 AND A.Amount BETWEEN @LOW AND @HIGH
 Order BY A.Amount DESC
 /*------------------------------------------------
Query 8 
Displays all the nutrients in the data base
along with the unit that is use to measure it
*/
SELECT N.NutrientID, N.NutrientName, M.UnitMeasurement
FROM Food.Amount A
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID
GROUP BY N.NutrientID, NutrientName, M.UnitMeasurement
/*------------------------------------------------
Query 9- REPORT
Displays the food with the mose Combine Nutrients and Ranks it by the Amount total
*/
DECLARE @rank INT = 50
SELECT TOP(@rank) F.FoodID, F.Discription, RANK() OVER(ORDER BY Amount.Total DESC) AS [RankOfFood] 
FROM 
( 
    SELECT TOP(@rank) A.FoodID, SUM(A.Amount) AS Total 
    FROM Food.Amount A 
        INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID 
        INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID 
    GROUP BY A.FoodID ORDER BY Total DESC
) AS Amount 
    INNER JOIN Food.Food F ON F.FoodID = Amount.FoodID 
ORDER BY Amount.Total DESC
 /*------------------------------------------------
Query 10 
Returns all the columns from all the tables
*/
SELECT C.CategoryName, F.Discription, F.Name,
      N.NutrientName, M.UnitMeasurement
FROM Food.Category C 
    INNER JOIN Food.FoodCategoryL FCL ON FCL.CategoryID = C.CategoryID 
    INNER JOIN Food.Food F ON F.FoodID = FCL.FoodID 
    INNER JOIN Food.Amount A ON A.FoodID = F.FoodID 
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID 
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID
/*------------------------------------------------
Query 11
Updates the Name On the Food Table
*/
DECLARE @name NVARCHAR(50) = "name", @foodID INT = 0
UPDATE Food.Food 
SET 
    [Name] = @name
    WHERE FoodID = @foodId 
SELECT *
FROM Food.Food F
WHERE F.FoodID = @foodID
/*------------------------------------------------
Query 12 - REPORT
Input Nutrient and range of calories, rank is displayed amount
Displays the foods of nutrient choosen, in calorie range
*/
DECLARE @low INT = 0, @high INT = 0, @rank INT = 50, @NutrientID INT = 0;
WITH Calories(Discription, Amount) AS 
(
    SELECT F.Discription, A.Amount 
    FROM FOOD.Amount A 
    INNER JOIN FOOD.Measurement M ON M.MeasurementID = A.MeasurementID 
    INNER JOIN FOOD.Food F ON F.FoodID = A.FoodID 
    WHERE M.MeasurementID = 0 AND A.Amount BETWEEN @low AND @high
) 
SELECT TOP(@rank) CAL.Discription AS 'FoodName', CAL.Amount AS 'Calories',
     N.NutrientName, A.Amount 
FROM FOOD.Nutrient N 
    INNER JOIN FOOD.Amount A ON A.NutrientID = N.NutrientID 
    INNER JOIN FOOD.Food F ON F.FoodID = A.FoodID 
    INNER JOIN FOOD.FoodCategoryL FCL ON FCL.FoodID = F.FoodID 
    INNER JOIN FOOD.Category C ON C.CategoryID = FCL.CategoryID 
    INNER JOIN FOOD.Measurement M ON M.MeasurementID = A.MeasurementID 
    INNER JOIN Calories CAL ON CAL.Discription = F.Discription 
WHERE N.NutrientID ="+ NutrientID + " AND A.Amount IS NOT NULL 
ORDER BY A.Amount DESC