while True:
    password = raw_input("Please fill in your password: ")
    points = 0
    numbers = 0
    specialCharacters = 0
    CapitalizedCharacters = 0
    normalCharacters = 0
    strenght = "weak"

    # Loop trough each character of the password string
    for character in password:
        # Get the Ascii value of the character and save it in a new varaible
        oct = ord(character)

        # Give the variable points acoring to its type
        # Special character
        if oct < 48 or oct > 57 and oct < 65 or oct > 90 and oct < 97 or oct > 122 and oct < 128:
            points += 2
            specialCharacters += 1
        # Number
        elif oct > 47 and oct < 58:
            points += 2
            numbers += 1
        # Capalized character
        elif oct > 64 and oct < 91:
            points += 2
            CapitalizedCharacters += 1
        # Normal character
        elif oct > 96 and oct < 123:
            points += 1
            normalCharacters += 1

    # Calculate points based on the whole password
    # Gain extra points for the string lenght, increases exponentially
    points += (len(password) / 10) * 2
    # Gain points if a password has a special character and a number and a capalized number and a normal character
    if specialCharacters > 0 and numbers > 0 and CapitalizedCharacters > 0 and normalCharacters > 0:
        points += 5

    # Calculate the strenght of the password
    if points > 10 and points <= 20:
        strenght = "medium"
    elif points > 20:
        strenght = "strong"

    print("Your password is %i characters long") % len(password) 
    print("You have used %i special characters, %i numbers, %i capitalized characters and %i normal characters") % (specialCharacters, numbers, CapitalizedCharacters, normalCharacters)
    print("You have gain %i points you passsword is %s") % (points, strenght) 