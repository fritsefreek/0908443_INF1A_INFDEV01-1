string = raw_input("Please fill in a string: ")
int = int(raw_input("Please fill in an int: "))
newString = ""

for character in string:
    initalOrdValue = ord(character)
    
    if initalOrdValue > 96 and initalOrdValue < 123 or initalOrdValue > 64 and initalOrdValue < 91:
        # Lower
        if initalOrdValue > 96 and initalOrdValue < 123:
            if ord(character) + int > 122:
                character = chr(96 + int) 
            else:
                character = chr(122 + int) 
    
        # Capital
        if initalOrdValue > 64 and initalOrdValue < 91:
            if ord(character) + int > 90:
                character = chr(64 + int) 
            else:
                character = chr(90 + int) 

    newString += character
print(newString)
