#-------------------------------------
#Remove NULL strings from Ammount
file = open("Amount.csv", "r")
lines = file.readlines()
file.close()

new_file = open("Amount.csv", 'w')

for line in lines:
    array = line.split(',')
    if array[3] == "-1\n":
        array[3] = ""
        new_line = ""
        for element in array:
            new_line += element + ','
        new_line = new_line[:-1]
        new_line += '\n'
        new_file.write(new_line)
    else:
       new_file.write(line) 
new_file.close()