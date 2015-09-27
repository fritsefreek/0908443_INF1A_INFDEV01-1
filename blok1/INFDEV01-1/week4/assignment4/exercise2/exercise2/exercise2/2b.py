# Import classes
import Validater
import Converter
import math

question = " please chose from rock, paper, scissors, spock, lizzard \n"

# Get the name of the first player
player1 = raw_input("Player1, what is your name? \n")
# Get the player1 choice
player1Input = raw_input(player1 + question)
# Validate input
while(Validater.validate(player1Input) == 0) :
    player1Input = raw_input(player1 + question)

# Get the name of the second player
player2 = raw_input("Player2, what is your name? \n")
# Get the player2 choice
player2Input = raw_input(player2 + question)
# Validate input
while(Validater.validate(player2Input) == 0) :
    player2Input = raw_input(player2 + question)

# Convert name to number
player1InputNumber = Converter.nameToNumber(player1Input)
player2InputNumber = Converter.nameToNumber(player2Input)

# Check who won
difference = (player1InputNumber - player2InputNumber) % 5

if difference == 0:
    print("It is a tie")
elif difference == 1:
    print("%s has won") % player1
elif difference == 2:
    print("%s has won") % player1
elif difference == 3:
    print("%s has won") % player2
else:
    print("%s has won") % player2
