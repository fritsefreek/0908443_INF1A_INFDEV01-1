int = int(raw_input("Please fill in a number: "))
figure = ""

for i in range(0, int):
    width = int - 1
    for x in range(0, int + width):
        if x - width + i < 0 or x - width - i > 0:
            figure += " "
        else :
            figure += "*"
    figure += "\n"
print(figure)