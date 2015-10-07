int = int(raw_input("Please fill in a number: "))
figure = ""
halfWidth = int - 1

for i in range(0, int):
    for x in range(0, int + halfWidth):
        distanceFromCenter = x - halfWidth 
        if distanceFromCenter + i < 0 or distanceFromCenter - i > 0:
            figure += " "
        else :
            figure += "*"
    figure += "\n"
print(figure)