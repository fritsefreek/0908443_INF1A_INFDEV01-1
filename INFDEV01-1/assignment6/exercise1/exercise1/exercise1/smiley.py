import math

size = int(raw_input("Size: "))
if size < 10:
    size = 10
scale = size / 10
radius = size / 2
figure = ""

for i in range(0, size):
    x1y1 = (i - (radius)) * (i - (radius))
    
    for x in range(0, size):
        x2y2 = (x - (radius)) * (x - (radius))
        if math.sqrt(x1y1 + x2y2) < radius and math.sqrt(x1y1 + x2y2) > radius - 1 or math.sqrt(x1y1 + x2y2) - (radius - 1) == 0:
            figure += "*"
        # Eyebrows
        elif i == (3 * scale) and (x == (3 * scale) or x == (7 * scale)):
            figure += "-"
        # Eyes
        elif i == (4 * scale) and (x == (3 * scale) or x == (7 * scale)):
            figure += "o"
        # Nose
        elif i == (6 * scale) and x == (5 * scale):
            figure += "#"
        # Cheek left
        elif i == (6 * scale) and x == (3 * scale):
            figure += "\\"
        # Cheek right
        elif i == (6 * scale) and x == (7 * scale):
            figure += "/"
        # Mouth
        elif i == (7 * scale) and (x == (4 * scale) or x == (5 * scale) or x == (6 * scale)):
            figure += "-"
        else:
            figure += " "
    figure += "\n"

print(figure)