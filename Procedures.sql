/*------------------------------------------------
Query 1
Displays all the Food CategoryNames
*/
SELECT *
FROM Food.Category C
/*------------------------------------------------
Query 2
Displays all the food Discriptions
**The name of the food is within the discription**
*/
SELECT F.Discription
FROM Food.Food F
/*------------------------------------------------
Query 3
Displays all the foods in Fruits category
Variable is for Categories, 13 : Fruits , 3 : Vegtable, 6 Meats, 7 : Vegetables
*/
DECLARE @categoryID INT = 13
SELECT C.CategoryName, F.Discription
FROM Food.Category C
    INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID
    INNER JOIN Food.Food F ON F.FoodID = L.FoodID
WHERE C.CategoryID = categoryID
GROUP BY CategoryName, Discription
/*------------------------------------------------
Query 4
Displays Top result of nutrient, for a corrisponding category
*/
DECLARE @nutrientID INT = 2, @categoryID INT = 6;
WITH FoodofCategory(FoodID, Discription, CategoryName) AS
    (
        SELECT FD.FoodID, FD.Discription, C.CategoryName
        FROM Food.Category C
            INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID
            INNER JOIN Food.Food FD ON FD.FoodID = L.FoodID
        WHERE C.CategoryID = @categoryID
        GROUP BY FD.FoodID, FD.Discription, C.CategoryName
    )
SELECT TOP(100) F.Discription, N.NutrientName, A.Amount, M.UnitMeasurement
FROM FoodofCategory F 
    INNER JOIN Food.Amount A ON A.FoodID = F.FoodID
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID
WHERE N.NutrientID = @nutrientID
ORDER BY A.Amount DESC
/*------------------------------------------------
Query 5
Displays the quiery of all one nutrient
*/
DECLARE @foodID INT = 0
SELECT N.NutrientName, A.Amount, M.UnitMeasurement
FROM Food.Amount A 
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID
WHERE A.FoodID = @foodId AND A.Amount IS NOT NULL;
/*------------------------------------------------
Query 6
This queiry displays the foods with the most combine nutrients and ranks the by 
the sum of the total
*/
SELECT TOP(100) F.FoodID, F.Discription, RANK() OVER(ORDER BY Amount.Total DESC) AS [RankOfFood]
FROM 
(
    SELECT TOP(100) A.FoodID, SUM(A.Amount) AS Total
    FROM Food.Amount A
        INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID
        INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID
    GROUP BY A.FoodID
    ORDER BY Total DESC
) AS Amount 
INNER JOIN Food.Food F ON F.FoodID = Amount.FoodID
ORDER BY Amount.Total DESC

/*
Query 7
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

 /*
 Query 8 
Allows the user to input categoryID and nutrientID and returns the top food according to those user inputs
 */
 DECLARE @CategoryID INT = 0
 DECLARE @NutrientID INT = 0
 WITH FoodofCategory(FoodID, Discription, CategoryName) AS 
 (
     SELECT FD.FoodID, FD.Discription, C.CategoryName 
     FROM Food.Category C 
        INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID 
        INNER JOIN Food.Food FD ON FD.FoodID = L.FoodID 
    WHERE C.CategoryID =" + CategoryID+ "
    GROUP BY FD.FoodID, FD.Discription, C.CategoryName 
 ) 
SELECT TOP 50 F.CategoryName, F.Discription, A.Amount, M.UnitMeasurement 
FROM FoodofCategory F 
    INNER JOIN Food.Amount A ON A.FoodID = F.FoodID 
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID 
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID 
 WHERE N.NutrientID = " + NutrientID + " 
 ORDER BY A.Amount DESC

 /*------------------------------------------------
Query 9
Returns the best rank food according to the amount
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
Returns everything
*/
SELECT * 
FROM Food.Category C 
    INNER JOIN Food.FoodCategoryL FCL ON FCL.CategoryID = C.CategoryID 
    INNER JOIN Food.Food F ON F.FoodID = FCL.FoodID 
    INNER JOIN Food.Amount A ON A.FoodID = F.FoodID 
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID 
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID
/*------------------------------------------------
Query 11
Updates the food table
*/
DECLARE @name NVARCHAR(50) = "name", @foodID INT = 0
UPDATE Food.Food 
SET 
    [Name] = @name
    WHERE FoodID = @foodId 
SELECT *
FROM Food.Food
/*------------------------------------------------
Query 12
returns food with the largest amount of protein
*/
DECLARE @low INT = 0, @high INT = 0, @rank INT = 50
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