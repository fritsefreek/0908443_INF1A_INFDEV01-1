int = int(raw_input("Please fill in a number: "))
figure = ""

for y in range(0, int):
    for x in range(0, int):
        if y >= x:
            figure += "*"
    figure += "\n"
print(figure)