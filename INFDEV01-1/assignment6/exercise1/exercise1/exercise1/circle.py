import math

int = int(raw_input("Please fill in a number: "))
radius = int / 2
figure = ""

for i in range(1, int):
    x1y1 = (i - (radius)) * (i - (radius))
    
    for x in range(1, int):
        x2y2 = (x - (radius)) * (x - (radius))
        if math.sqrt(x1y1 + x2y2) < radius:
            figure += "*"
        else:
            figure += " "
    figure += "\n"

print(figure)