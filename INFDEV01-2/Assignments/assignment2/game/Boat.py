import pygame
from Node import *
from Common import *

class Boat:
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
            if(randomNumber == 1 and self.Tile.Up != None):
               if(self.Tile.Up.River == True or self.Tile.Up.Harbor == True or self.Tile.Up.Bridge == True):
                newPosition = self.Tile.Up
            elif(randomNumber == 2 and self.Tile.Right != None):
                if(self.Tile.Right.River == True or self.Tile.Right.Harbor == True or self.Tile.Right.Bridge == True):
                    newPosition = self.Tile.Right
            elif(randomNumber == 3 and self.Tile.Down != None):
                if(self.Tile.Down.River == True or self.Tile.Down.Harbor == True or self.Tile.Down.Bridge == True):
                    newPosition = self.Tile.Down
            elif(randomNumber == 4 and self.Tile.Left != None):
                if(self.Tile.Left.River == True or self.Tile.Left.Harbor == True or self.Tile.Left.Bridge == True):
                    newPosition = self.Tile.Left
            else:
                newPosition = False

        return Boat(newPosition, self.Texture, self.Tile.Harbor)