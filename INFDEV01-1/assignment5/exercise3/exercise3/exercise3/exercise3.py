string = raw_input("Please fill in a string: ")
int = int(raw_input("Please fill in an int: "))
newString = ""

for character in string:
    initalOrdValue = ord(character)
    
    if character.isalpha():
        # Lower
        if character.islower():
            if ord(character) + int > 122:
                character = chr(96 + int) 
            else:
                character = chr(123 + int)
        # Capital
        else:
            if ord(character) + int > 90:
                character = chr(64 + int) 
            else:
                character = chr(91 + int) 

    newString += character
print(newString)