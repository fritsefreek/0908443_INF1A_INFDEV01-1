int = int(raw_input("Please fill in a number: "))
spaces = int
stars = 1
figure = ""

for i in range(0, int):

    spaces -= 1

    for space in range(0, spaces):
      figure += " "
    
    for star in range(0, stars):
        figure += "*"

    stars += 2
    figure += "\n"
print(figure)

figure = ""