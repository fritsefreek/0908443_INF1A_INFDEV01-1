import pygame
from Node import *
from Common import *

class Car:
    def __init__(self, tile, texture, canBeRemoved=False):
        self.Tile = tile
        self.Texture = texture
        self.CanBeRemoved = canBeRemoved


    def Draw(self, screen, offset):
        _width = int(offset / 3)
        screen.blit(pygame.transform.scale(self.Texture, (_width, _width)),
            (_width + self.Tile.Position.X * offset,
            _width + self.Tile.Position.Y * offset))


    def Update(self):
        newPosition = False
        while(newPosition == False):
            randomNumber = random.randint(1, 4)
            if(randomNumber == 1 and self.Tile.Up != None and self.Tile.Up.Traverseable == True and self.Tile.Up.Harbor == False):
                newPosition = self.Tile.Up
            elif(randomNumber == 2 and self.Tile.Right != None and self.Tile.Right.Traverseable == True and self.Tile.Right.Harbor == False):
                newPosition = self.Tile.Right
            elif(randomNumber == 3 and self.Tile.Down != None and self.Tile.Down.Traverseable == True and self.Tile.Down.Harbor == False):
                newPosition = self.Tile.Down
            elif(randomNumber == 4 and self.Tile.Left != None and self.Tile.Left.Traverseable == True and self.Tile.Left.Harbor == False):
                newPosition = self.Tile.Left
            else:
                newPosition = False

        return Car(newPosition, self.Texture, self.Tile.Park)