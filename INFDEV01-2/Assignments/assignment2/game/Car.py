import pygame
import random
from Node import *
from Common import *

class Car:
    def __init__(self, tile, canBeRemoved=False):
        self.Tile = tile
        self.CanBeRemoved = canBeRemoved




def DrawCars(car, screen, offset, car_texture):
    _width = int(offset / 3)

    screen.blit(pygame.transform.scale(car_texture, (_width, _width)),
        (_width + car.Value.Tile.Position.X * offset,
        _width + car.Value.Tile.Position.Y * offset))

def UpdateCars(cars, updatedCars):
    if(cars.Value.Tile.Park == True):
        cars.Value.CanBeRemoved = True
        newPosition = cars.Value.Tile
    else:
        newPosition = False
        while(newPosition == False):
            randomNumber = random.randint(1, 4)
            if(randomNumber == 1 and cars.Value.Tile.Up != None and cars.Value.Tile.Up.Traverseable == True and cars.Value.Tile.Up.Harbor == False):
                newPosition = cars.Value.Tile.Up
            elif(randomNumber == 2 and cars.Value.Tile.Right != None and cars.Value.Tile.Right.Traverseable == True and cars.Value.Tile.Right.Harbor == False):
                newPosition = cars.Value.Tile.Right
            elif(randomNumber == 3 and cars.Value.Tile.Down != None and cars.Value.Tile.Down.Traverseable == True and cars.Value.Tile.Down.Harbor == False):
                newPosition = cars.Value.Tile.Down
            elif(randomNumber == 4 and cars.Value.Tile.Left != None and cars.Value.Tile.Left.Traverseable == True and cars.Value.Tile.Left.Harbor == False):
                newPosition = cars.Value.Tile.Left
            else:
                newPosition = False

    updatedCars = Node(Car(newPosition, cars.Value.CanBeRemoved), updatedCars)
    return updatedCars

def RemoveParkedCars(cars):
    newCarList = Empty
    while cars.IsEmpty is False:
        if(cars.Value.CanBeRemoved == False):
            newCarList = Node(Car(cars.Value.Tile), newCarList)
        cars = cars.Tail
    return newCarList