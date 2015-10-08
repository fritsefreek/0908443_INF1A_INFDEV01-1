int = int(raw_input("Please fill in a number: "))
figure = ""

for i in range(0, int):
    for x in range(0, int + i):
        if x < int - (i + 1):
            figure += " "
        else:
            figure += "*"
    
    figure += "\n"
print(figure)
