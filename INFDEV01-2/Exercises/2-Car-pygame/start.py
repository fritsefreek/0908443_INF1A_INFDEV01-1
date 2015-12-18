import pygame, os, random
from pygame.locals import *
from classes.Car import Car
from classes.Node import *

pygame.init()

# Create the game window
screenWidth = 600
screenHeight = 400
screen = pygame.display.set_mode((screenWidth, screenHeight))

# Start the random number event timer
createRandonNumber = USEREVENT + 1
pygame.time.set_timer(createRandonNumber, 1000)

# Start the random number event timer
spawnCar = USEREVENT + 2
pygame.time.set_timer(spawnCar, 5000)

# Default values
done = False
randomNumber = 1
activeCars = Empty
activeCarsList = Empty

carSprite = pygame.image.load(os.path.join("images/car.png"))
carSprite = pygame.transform.scale(carSprite, (30, 50))

# Refresh the game x times per second
while not done:

    # Loop trough all the events
    for event in pygame.event.get():
            # If user press escape the game
            if event.type == pygame.QUIT:
                    done = True
            if event.type == createRandonNumber:
                randomNumber = random.randrange(1, 5)
            if event.type == spawnCar:
                randomX = random.randrange(0, 500)
                randomY = random.randrange(0, 300)
                direction = random.randrange(1, 5)

                # Add the car to the lists
                activeCars = Node(Car(randomX, randomY, direction), activeCars)
                activeCarsList = Node(Car(randomX, randomY, direction), activeCarsList)

    # Reset the screen (remove old drawings)
    screen.fill((0, 0, 0))

    while activeCars.isEmpty is False:
        # Chose the direction and rotation of the car
        carDirection = (activeCars.value.direction + randomNumber) % 5
        if carDirection == 1:
            activeCars.value.y -= 1
            carSprite2 = pygame.transform.rotate(carSprite, 0)
        elif carDirection == 2:
            activeCars.value.y += 1
            carSprite2 = pygame.transform.rotate(carSprite, 180)
        elif carDirection == 3:
            activeCars.value.x -= 1
            carSprite2 = pygame.transform.rotate(carSprite, 90)
        else:
            activeCars.value.x += 1
            carSprite2 = pygame.transform.rotate(carSprite, 270)

        # Draw the car on the screen
        screen.blit(carSprite2, (activeCars.value.x, activeCars.value.y))

        activeCars = activeCars.tail

    # Remove cars that are outside the screen from the list
    listTemp = Empty
    activeCarsNew = activeCarsList
    while activeCarsNew.isEmpty is False:
        if activeCarsNew.value.x < (screenWidth - 50) and activeCarsNew.value.x > 0 and activeCarsNew.value.y < (screenHeight - 50) and activeCarsNew.value.y > 0:
            listTemp = Node(Car(activeCarsNew.value.x, activeCarsNew.value.y, activeCarsNew.value.direction), listTemp)
        activeCarsNew = activeCarsNew.tail

    activeCars = listTemp
    activeCarsList = listTemp

    # Update the screen
    pygame.display.flip()