int = int(raw_input("Please fill in a number: "))
figure = ""

for i in range(0, int):
    for x in range(0, int + (int - 1)):
        if x - (int - 1) + i < 0 or x - (int - 1) - i > 0:
            figure += " "
        else :
            figure += "*"
    figure += "\n"
print(figure)