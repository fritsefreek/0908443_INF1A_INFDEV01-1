import pygame
import random
from Node import *
from Common import *

class Car:
    def __init__(self, tile):
        self.Tile = tile

def DrawCars(car, screen, offset, car_texture):
    _width = int(offset / 3)

    screen.blit(pygame.transform.scale(car_texture, (_width, _width)),
        (_width + car.Value.Tile.Position.X * offset,
        _width + car.Value.Tile.Position.Y * offset))

def UpdateCars(cars, updatedCars):
    print(cars.Value.Tile.Down.Traverseable)
    newPosition = False
    if(cars.Value.Tile.Down.Traverseable == True):
        newPosition = cars.Value.Tile.Down

        if(newPosition != None):
            updatedCars = Node(Car(newPosition), updatedCars)
    return updatedCars