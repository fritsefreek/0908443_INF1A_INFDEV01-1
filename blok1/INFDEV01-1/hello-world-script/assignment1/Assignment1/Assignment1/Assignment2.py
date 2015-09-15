print "Enter your name",

username = raw_input()
usernameLenght = len(username)
lastNumber = usernameLenght

print "Your name is " + str(usernameLenght) + " characters long"

for x in range(0,usernameLenght):
    
    for y in range(0,usernameLenght):
        if lastNumber == y:
            print " ",
        else:
            print "*",
    lastNumber = lastNumber - 1
    print ""
    
