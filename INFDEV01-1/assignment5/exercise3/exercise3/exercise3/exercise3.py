import math

string = raw_input("Please fill in a string: ")
int = int(raw_input("Please fill in an int: "))
newString = ""


if abs(int) > 26:
    int = int % 26 + 1

for character in string:
    initalOrdValue = ord(character)
    
    if character.isalpha():
        # Lower
        if character.islower():
            if ord("a") + int < ord("a"):
                number = ord("z") + (int + 1)
            else:
                number = ord("a") + (int - 1) 
        # Capital
        else:
            if ord("A") + int < ord("A"):
                number = ord("Z") + (int + 1)
            else:
                number = ord("A") + (int - 1) 

    newString += chr(number)
print(newString)