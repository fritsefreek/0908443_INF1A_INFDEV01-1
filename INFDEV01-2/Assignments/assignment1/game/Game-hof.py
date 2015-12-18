from threading import Thread
import os, pygame
import time
from Tile import *
from Node import *
from Car import  *
import random
from HOF import *

pygame.init()
size = width, height = 600, 600
white = 255, 255, 255
green = 50, 255, 100
screen = pygame.display.set_mode(size)
offset = 30
board_size = 10
car_texture = pygame.image.load("Content/car.png").convert()
entry_tile = build_square_matrix(board_size, offset)
car_list = Node(Car(entry_tile), Empty)


def Update(cars):
    cars = filter(cars, lambda car: not Car.isParked(car))
    cars = map(cars, lambda car: Car.Update(car))

    carIntGen = random.randint(0,1337)
    if(carIntGen % 12 == 0):
      cars = Node(Car(entry_tile), cars)

    return cars

def Draw(cars, screen):
    while not cars.IsEmpty:
        cars.Value.Draw(cars, screen, offset, car_texture)
        cars = cars.Tail


def Main(cars):
  while True:
    screen.fill(green)
    entry_tile.Reset()
    entry_tile.Draw(screen)

    cars = Update(cars)
    Draw(cars, screen)

    pygame.display.flip()
    time.sleep(0.1)

# Run the Main function.
Main(car_list)