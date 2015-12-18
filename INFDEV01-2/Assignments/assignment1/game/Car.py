import pygame
import random
from Node import *

class Car:
    def __init__(self, tile):
        self.Tile = tile

    def Draw(self, car, screen, offset, car_texture):
        _width = int(offset / 3)

        screen.blit(pygame.transform.scale(car_texture, (_width, _width)),
            (_width + car.Value.Tile.Position.X * offset,
            _width + car.Value.Tile.Position.Y * offset))

    def Update(self, cars, updatedCars):

        if(cars.Value.Tile.Park == False):
            newPosition = False
            while(newPosition == False):
                randomNumber = random.randint(1, 4)
                if(randomNumber == 1 and cars.Value.Tile.Up != None and cars.Value.Tile.Up.Traverseable == 1):
                    newPosition = cars.Value.Tile.Up
                elif(randomNumber == 2 and cars.Value.Tile.Right != None and cars.Value.Tile.Right.Traverseable == 1):
                    newPosition = cars.Value.Tile.Right
                elif(randomNumber == 3 and cars.Value.Tile.Down != None and cars.Value.Tile.Down.Traverseable == 1):
                    newPosition = cars.Value.Tile.Down
                elif(randomNumber == 4 and cars.Value.Tile.Left != None and cars.Value.Tile.Left.Traverseable == 1):
                    newPosition = cars.Value.Tile.Left
                else:
                    newPosition = False

            if(newPosition != None):
                updatedCars = Node(Car(newPosition), updatedCars)
        return updatedCars