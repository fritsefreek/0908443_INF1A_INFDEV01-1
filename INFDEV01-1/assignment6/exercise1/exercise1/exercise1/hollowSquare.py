int = int(raw_input("Please fill in a number: "))
figure = ""

for i in range(0, int):
    for x in range(1, int):
        if x == 1 or i == 0 or i == int -1:
            figure += "*"
        else:
            figure += " "
    figure += "* \n"
print(figure)