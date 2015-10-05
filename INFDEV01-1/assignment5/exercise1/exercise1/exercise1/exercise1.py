string = raw_input("Please fill in a string: ")
characters = len(string)
reversedString = ""

while characters > 0:
    reversedString += string[characters -1]
    characters -= 1
print(reversedString)