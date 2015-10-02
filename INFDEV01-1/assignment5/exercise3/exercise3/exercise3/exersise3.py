string = raw_input("Please fill in a string: ")
int = int(raw_input("Please fill in an int: "))
newString = ""

for character in string:
    if character.isalpha() :
        character = chr(ord(character) + int)
    newString += character

print(newString)
