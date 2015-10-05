string = raw_input("Please fill in a string: ")
int = int(raw_input("Please fill in an int: "))
newString = ""

for character in string:
    initalOrdValue = ord(character)
    
    if initalOrdValue > 96 and initalOrdValue < 123 or initalOrdValue > 64 and initalOrdValue < 91:
        # Lower
        if initalOrdValue > 96 and initalOrdValue < 123:
            if ord(character) + int > 122:
                character = chr(int + 96) 
            else:
                character = chr(121 - int) 
    
        # Capital
        if initalOrdValue > 64 and initalOrdValue < 91:
            if ord(character) + int > 90:
                character = chr(int + 64) 
            else:
                character = chr(89 - int) 

    newString += character
print(newString)
