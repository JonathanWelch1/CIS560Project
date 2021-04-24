#-------------------------------------
#Updates the foodData.csv file 
#Filters out the NULL, American Indian, and restuarant
a_file = open("foodData.csv", "r")
lines = a_file.readlines()
a_file.close()

count = 0
new_file = open("foodData.csv", "w")
for line in lines:
    array = line.split(',')
    discription = array[2].split(' ')
    if array[2] != 'American Indian' and array[2] != 'Restaurant Foods' and array[2] !=  'NULL' and array[2] != 'Fast Foods' and array[2] != 'Prepared Meals' and len(discription) < 7:
        array[0] = str(count)
        new_line = ""
        for element in array:
            new_line += element + ','
        new_line = new_line[:-1]
        new_file.write(new_line)
        count += 1
new_file.close()
#-------------------------------------
#Updates the foodData.csv file 
#Filters out all colums that have all NULL values
#
file = open("foodData.csv", 'r')
lines = file.readlines()
numLines = len(lines)
col = len(lines[0].split(','))

array2D =[]
delCols = []
for line in lines:
    array2D.append(line.split(','))

for i in range(10, col - 1):
    count = 0
    for j in range(numLines - 1):
        if(array2D[j][i] != "NULL"):
            break
        else:
            count += 1
            if(count == (numLines - 1)):
                delCols.append(i)

for row in range(numLines):
    for index in range(len(delCols)):
        array2D[row].pop(delCols[index]-index)

new_file = open('foodData.csv', 'w')
for line in array2D:
    new_line = ""
    for element in line:
        new_line += element + ','
    new_line = new_line[:-1]
    new_file.write(new_line)

new_file.close()
file.close()
#Columns Deleted: [21, 28, 29, 37, 45, 46, 52]
#-------------------------------------
#Creates the Category.csv file
foodCategory = []
with open('foodData.csv', 'r') as dataFile:
   for line in dataFile:
        array = line.split(',')
        if(array[2] not in foodCategory):
            foodCategory.append(array[2])
dataFile.close()

with open('Category.csv', 'w') as file:
    count = 0
    for category in foodCategory:
       file.write('{},{}\n'.format(count, category))
       count += 1
#-------------------------------------
#Creates the foodCategoryL.csv & food.csv file
file = open("Category.csv", "r")
categorys = []
for line in file:
    array = line.split(',')
    categorys.append(array[1])
file.close()

food = open("Food.csv", "w")
FoodCategoryL = open("FoodCategoryL.csv", "w")
file = open("foodData.csv", "r")
for line in file:
    array = line.split(',')
    categoryId = categorys.index(array[2]+'\n')
    FoodCategoryL.write("{},{}\n".format(categoryId, array[0]))
    food.write('{},{}\n'.format(array[0], array[1]))

food.close()
FoodCategoryL.close()
#-------------------------------------
#Creates the Nutrient.csv file
file = open("nutrients.csv", "r")
line = file.readline()
nutrients = line.split(',')
file.close()

delCols = [21, 28, 29, 37, 45, 46, 52]
for i in range(len(delCols)):
    nutrients.pop(delCols[i]-i)

new_file = open("Nutrient.csv",'w')
count = 0
for n in nutrients:
    new_file.write('{},{}\n'.format(count - 3, n))#-4 to offset first 3 columns not wanted
    count += 1

new_file.close()
#-------------------------------------
#Creates the Measurement.csv file  
file = open("Nutrient.csv", "r")
lines = file.readlines()
file.close()

units = []
for line in lines:
    Id, nutrient = line.split(',')
    array = nutrient.split(' ')
    unit = array[len(array) - 1]
    unit = unit.replace('(', '')
    unit = unit.replace(')', '')
    if unit not in units:
        units.append(unit)
    
new_file = open("Measurement.csv", 'w')
count = 0
for u in units:
    new_file.write('{},{}'.format(count - 3, u))
    count += 1
new_file.close
#-------------------------------------
#Creates the Amount.csv file  
file = open("Nutrient.csv", "r")
file2 = open("foodData.csv", "r")
file3 = open("Measurement.csv", "r")
linesN = file.readlines()
linesF = file2.readlines()
linesM = file3.readlines()
file.close()
file2.close()
file3.close()

MeasureIds = []
for m in linesM:
    array = m.split(',')
    MeasureIds.append(array[1])

new_file = open("Amount.csv", 'w')

for linef in linesF:
    temp = linef.split(',')
    for i in range(1,len(linesN)):
        new_line = ""
        new_line += temp[0]
        NutrientId, nutrient = linesN[i].split(',')
        array = nutrient.split(' ')
        unit = array[len(array) - 1]
        unit = unit.replace('(', '')
        unit = unit.replace(')', '')
        measureId = MeasureIds.index(unit)
        if(temp[i] == "NULL" or temp[i] == "0" or temp[i] == "NULL\n"):
            new_line += (',' + str(measureId) + ',' + NutrientId + ',' + "")
        else:
            new_line += (',' + str(measureId) + ',' + NutrientId + ',' + temp[i])
        new_line += '\n'
        new_file.write(new_line)
    
new_file.close
#-------------------------------------
#Remove the measurements from Nutrient
file = open("Nutrient.csv", "r")
lines = file.readlines()
file.close()

new_file = open("R.csv", 'w')

for line in lines:
    array = line.split(',')
    arrayN = array[1].split(" ")
    new_line = ""
    for i in range(len(arrayN) - 1):
        new_line += arrayN[i]
    
    new_file.write("{},{}\n".format(array[0],new_line)) 
new_file.close()