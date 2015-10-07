int = int(raw_input("Please fill in a number: "))
figure = ""

for i in range(0, int):
    for x in range(0, int):
        if i >= x:
            figure += "*"
    figure += "\n"
print(figure)