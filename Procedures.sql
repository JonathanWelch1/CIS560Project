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
___________________________________________________________________________________________________________-You need to implement number 4 cutie
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