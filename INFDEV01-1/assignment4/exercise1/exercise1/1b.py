# Get the input as a float
celcius = float(input("Please fill in a number "))

# Check if the value if below the absolute zero -> if it is, user has to fill in a value again
while celcius < -273.15 :
    celcius = float(input("Please fill in a number that is higher then -273.15 "))


# Convert the value to Kelvin and round it with a precision of 2 decimals
kelvin = celcius + 273.15

# Print the kelvin value
print "%f Celcius is %f Kelvin" % (celcius, kelvin)