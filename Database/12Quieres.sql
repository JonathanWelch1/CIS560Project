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
*/
SELECT C.CategoryName, F.Discription
FROM Food.Category C
    INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID
    INNER JOIN Food.Food F ON F.FoodID = L.FoodID
WHERE C.CategoryID = 13
GROUP BY CategoryName, Discription
/*------------------------------------------------
Query 4
Displays all the foods in Vegtables category
*/
SELECT C.CategoryName, F.Discription
FROM Food.Category C
    INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID
    INNER JOIN Food.Food F ON F.FoodID = L.FoodID
WHERE C.CategoryID = 3
GROUP BY CategoryName, Discription
/*------------------------------------------------
Query 6
Displays all the foods in Meats category
*/
SELECT C.CategoryName, F.Discription
FROM Foods.Category C
    INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID
    INNER JOIN Food.Food F ON F.FoodID = L.FoodID
WHERE C.CategoryID = 6
GROUP BY CategoryName, Discription
/*------------------------------------------------
Query 7
Displays all the foods in Fish category
*/
SELECT C.CategoryName, F.Discription
FROM Food.Category C
    INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID
    INNER JOIN Food.Food F ON F.FoodID = L.FoodID
WHERE C.CategoryID = 12
GROUP BY CategoryName, Discription