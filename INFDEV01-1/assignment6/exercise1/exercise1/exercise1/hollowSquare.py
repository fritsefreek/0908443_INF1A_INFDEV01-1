int = int(raw_input("Please fill in a number: "))
figure = ""

for y in range(0, int):
    for x in range(0, int):
        if x == 0 or x == int - 1 or y == 0 or y == int - 1:
            figure += "*"
        else:
            figure += " "
    figure += "\n"
print(figure)