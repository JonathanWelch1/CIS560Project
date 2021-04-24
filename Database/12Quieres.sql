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
DECLARE @nutrientID INT = 0, @categoryID INT = 6;
WITH FoodofCategory(FoodID, Discription, CategoryName) AS
    (
        SELECT FD.FoodID, FD.Discription, C.CategoryName
        FROM Food.Category C
            INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID
            INNER JOIN Food.Food FD ON FD.FoodID = L.FoodID
        WHERE C.CategoryID = @categoryID 
        GROUP BY FD.FoodID, FD.Discription, C.CategoryName
    )
SELECT TOP 50 F.CategoryName, F.Discription, A.Amount, M.UnitMeasurement
FROM FoodofCategory F 
    INNER JOIN Food.Amount A ON A.FoodID = F.FoodID
    INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID
    INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID
WHERE N.NutrientID = @nutrientID
ORDER BY A.Amount DESC