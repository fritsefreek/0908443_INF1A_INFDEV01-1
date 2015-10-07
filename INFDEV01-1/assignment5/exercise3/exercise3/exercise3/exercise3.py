import math

string = raw_input("Please fill in a string: ")
int = int(raw_input("Please fill in an int: "))
newString = ""

if abs(int) > 26:
    int = int % 26

for character in string:
    if character.isalpha():

        number = ord(character) + int

        # Lower
        if character.islower():
            if number < ord("a"):
                number += 26
                
            elif number > ord("z"):
                number -= 26        
        # Capital
        else:
            if number < ord("A"):
                number += 26
                
            elif number > ord("Z"):
                number -= 26  

        newString += chr(number)
    else:
        newString += character

print(newString)