from threading import Thread
import os, pygame
import time
from Tile import *
from Node import *

pygame.init()
size = width, height = 600, 600
white = 255, 255, 255
green = 50, 255, 100
screen = pygame.display.set_mode(size)
offset = 30
board_size = 10
car_texture = pygame.image.load("Content/car.png").convert()
entry_tile = build_square_matrix(board_size, offset)
cars = Empty


def Update(cars):
    updatedCars = Empty
    while cars.IsEmpty is False:
        updatedCars = cars.Value.Update(cars, updatedCars)
        cars = cars.Tail
    return updatedCars


def Draw(cars, screen):
    while not cars.IsEmpty:
        cars.Value.Draw(cars, screen, offset, car_texture)
        cars = cars.Tail


def Main(cars):
    counter = 0

    while True:
        counter += 1
        if counter == 5:
            cars = Node(Car(entry_tile), cars)
            counter = 0
        screen.fill(green)
        entry_tile.Reset()
        entry_tile.Draw(screen)

        cars = Update(cars)
        Draw(cars, screen)

        pygame.display.flip()
        time.sleep(0.1)
    
Main(cars)