# Get the name of the first player
player1 = raw_input("Player1, what is your name? \n")
# Get the player1 choice
player1Input = raw_input(player1 + " please chose from rock, paper, scissors, spock or lizzard \n")
# Validate the user input
while player1Input != "rock" and player1Input != "paper" and player1Input != "scissors" and player1Input != "spock" and player1Input != "lizzard" :
    player1Input = raw_input(player1 + " please chose from rock, paper, scissors, spock or lizzard \n")

# Get the name of the second player
player2 = raw_input("Player2, what is your name? \n")
# Get the player21 choice
player2Input = raw_input(player2 + " please chose from rock, paper, scissors, spock or lizzard \n")
# Validate the user input
while player2Input != "rock" and player2Input != "paper" and player2Input != "scissors" and player1Input != "spock" and player1Input != "lizzard" :
    player2Input = raw_input(player2 + " please chose from rock, paper, scissors, spock or lizzard \n")

# Display the input for both users
print "%s selected %s" % (player1, player1Input)
print "%s selected %s" % (player2, player2Input)

# Check wich player has won
output = "Couldn't find a winner"

# Rock
if player1Input == "rock" and player2Input == "paper" :
    output = "%s won" %player2
elif player1Input == "rock" and player2Input == "scissors" :
    output = "%s won" %player1
elif player1Input == "rock" and player2Input == "lizzard" :
    output = "%s won" %player1
elif player1Input == "rock" and player2Input == "spock" :
    output = "%s won" %player2
# Paper
elif player1Input == "paper" and player2Input == "rock" :
    output = "%s won" %player1
elif player1Input == "paper" and player2Input == "scissors" :
    output = "%s won" %player2
elif player1Input == "paper" and player2Input == "lizzard" :
    output = "%s won" %player2
elif player1Input == "paper" and player2Input == "spock" :
    output = "%s won" %player1
# Scissors
elif player1Input == "scissors" and player2Input == "rock" :
    output = "%s won" %player2
elif player1Input == "scissors" and player2Input == "paper" :
    output = "%s won" %player1
elif player1Input == "scissors" and player2Input == "lizzard" :
    output = "%s won" %player1
elif player1Input == "scissors" and player2Input == "spock" :
    output = "%s won" %player2
# Lizzard
elif player1Input == "lizzard" and player2Input == "rock" :
    output = "%s won" %player2
elif player1Input == "lizzard" and player2Input == "paper" :
    output = "%s won" %player1
elif player1Input == "lizzard" and player2Input == "scissors" :
    output = "%s won" %player2
elif player1Input == "lizzard" and player2Input == "spock" :
    output = "%s won" %player1
# Spock
elif player1Input == "spock" and player2Input == "rock" :
    output = "%s won" %player1
elif player1Input == "spock" and player2Input == "paper" :
    output = "%s won" %player2
elif player1Input == "spock" and player2Input == "lizzard" :
    output = "%s won" %player2
elif player1Input == "spock" and player2Input == "scissors" :
    output = "%s won" %player1
# Same
elif player1Input == player2Input :
    output = "Draw"
else :
    output = "Error: couldn't find a winner"

# Display the result
print output