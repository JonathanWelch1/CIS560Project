#-------------------------------------
file = open("Nutrient.csv", "r")
lines = file.readlines()
file.close()

new_file = open("Nutrient.csv", 'w')

for line in lines:
    array = line.split(',')
    arrayN = array[1].split(" ")
    new_line = ""
    for i in range(len(arrayN) - 1):
        new_line += arrayN[i]
    
    new_file.write("{},{}\n".format(array[0],new_line)) 
new_file.close()