figure = ""

for i in range(0, 10):
    for x in range(0, 10):
        # Border
        if (i == 0 or i == 8) and (x == 3 or x == 4 or x == 5):
            figure += "*"
        elif (i == 1 or i == 7 ) and (x == 2 or x == 6):
            figure += "*"
        elif (i == 2 or i == 6) and (x == 1 or x == 7):
            figure += "*"
        elif (i == 3 or i == 4 or i == 5) and (x == 0 or x == 8):
            figure += "*"
        # Eyebrows
        elif i == 2 and (x == 2 or x == 6):
            figure += "-"
        # Eyes
        elif i == 3 and (x == 2 or x == 6):
            figure += "o"
        # Nose
        elif i == 5 and x == 4:
            figure += "#"
        # Cheek left
        elif i == 5 and x == 2:
            figure += "\\"
        # Cheek right
        elif i == 5 and x == 6:
            figure += "/"
        # Mouth
        elif i == 6 and (x == 3 or x == 4 or x == 5):
            figure += "-"
        else:
            figure += " "

    figure += "\n"

print(figure)