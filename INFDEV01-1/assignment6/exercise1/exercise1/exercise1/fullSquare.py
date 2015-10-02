int = int(raw_input("Please fill in a number: "))
figure = ""

for i in range(0, int):
    for i in range(1, int):
        figure += "*"
    figure += "* \n"
print(figure)