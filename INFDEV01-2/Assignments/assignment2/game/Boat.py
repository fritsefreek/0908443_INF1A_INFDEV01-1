import pygame
import random
from Node import *
from Common import *

class Boat:
    def __init__(self, tile, texture, canBeRemoved=False):
        self.Tile = tile
        self.Texture = texture
        self.CanBeRemoved = canBeRemoved

    def Draw(self, entity, screen, offset):
        _width = int(offset / 3)
        screen.blit(pygame.transform.scale(self.Texture, (_width, _width)),
            (_width + entity.Value.Tile.Position.X * offset,
            _width + entity.Value.Tile.Position.Y * offset))

    def CanBeRemoved(self):
        return False

    def Update(self):
        return self




def UpdateBoats(boats):
    updatedboats = Empty
    while boats.IsEmpty is False:
        newPosition = False
        if(boats.Value.Tile.Harbor == True):
            boats.Value.CanBeRemoved = True
            newPosition = boats.Value.Tile
        else:
            while(newPosition == False):
                randomNumber = random.randint(1, 4)
                if(randomNumber == 1 and boats.Value.Tile.Up != None):
                   if(boats.Value.Tile.Up.River == True or boats.Value.Tile.Up.Harbor == True or boats.Value.Tile.Up.Bridge == True):
                    newPosition = boats.Value.Tile.Up
                elif(randomNumber == 2 and boats.Value.Tile.Right != None):
                    if(boats.Value.Tile.Right.River == True or boats.Value.Tile.Right.Harbor == True or boats.Value.Tile.Right.Bridge == True):
                        newPosition = boats.Value.Tile.Right
                elif(randomNumber == 3 and boats.Value.Tile.Down != None):
                    if(boats.Value.Tile.Down.River == True or boats.Value.Tile.Down.Harbor == True or boats.Value.Tile.Down.Bridge == True):
                        newPosition = boats.Value.Tile.Down
                elif(randomNumber == 4 and boats.Value.Tile.Left != None):
                    if(boats.Value.Tile.Left.River == True or boats.Value.Tile.Left.Harbor == True or boats.Value.Tile.Left.Bridge == True):
                        newPosition = boats.Value.Tile.Left
                else:
                    newPosition = False

        updatedboats = Node(Boat(newPosition, boats.Value.CanBeRemoved), updatedboats)
        boats = boats.Tail

    return updatedboats

def RemoveParkedBoats(boats):
    newBoatList = Empty
    while boats.IsEmpty is False:
        if(boats.Value.CanBeRemoved == False):
            newBoatList = Node(Boat(boats.Value.Tile), newBoatList)
        boats = boats.Tail
    return newBoatList
