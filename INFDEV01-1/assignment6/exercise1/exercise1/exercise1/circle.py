import math

int = int(raw_input("Please fill in a number: "))
radius = int / 2
figure = ""

for y in range(0, int):
    x1y1 = (y - (radius)) * (y - (radius))
    
    for x in range(0, int):
        x2y2 = (x - (radius)) * (x - (radius))
        if math.sqrt(x1y1 + x2y2) < radius:
            figure += "*"
        else:
            figure += " "
    figure += "\n"

print(figure)