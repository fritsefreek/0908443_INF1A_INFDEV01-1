# Get the input as a float
fahrenheit = float(input("Please fill in a number "))

# Convert the value to Celcius and round it with a precision of 2 decimals
celcius = round((fahrenheit - 32) * 5/9, 2)

# Print the celcius value
print "%f Fahrenheit is %f Celcius" % (fahrenheit, celcius)