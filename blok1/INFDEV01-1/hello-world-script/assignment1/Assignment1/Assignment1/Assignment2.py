print "Enter your name",

username = raw_input()
usernameLenght = len(username)
lastNumber = usernameLenght

print "Your name is " + str(usernameLenght) + " characters long \n"
print "Version 1:"

for x in range(0,usernameLenght):
    
    for y in range(0,usernameLenght):
        if lastNumber <= y:
            if x == usernameLenght -1:
                print "*",
            else:
                print " ",
        else:
            print "*",

        if y == usernameLenght -1:
            print "*",
    lastNumber = lastNumber - 1
    
    print ""


lastNumber = usernameLenght
print "\n Version 2:"

for x in range(0,usernameLenght):
    
    for y in range(0,usernameLenght):
        if lastNumber == y:
            print " ",
        else:
            print "*",
      
    lastNumber = lastNumber - 1
    print ""
    
