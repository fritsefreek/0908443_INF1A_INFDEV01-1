from __future__ import print_function
import time
from threading import Thread
import os, pygame
import time
from Tile import *
from Node import *
from Boat import *
from HOFs import *


pygame.init()
size = width, height = 600, 600
white = 255, 255, 255
green = 50, 255, 100
screen = pygame.display.set_mode(size)
offset = 50
size = 10
entry_road, entry_rivers, bridges = build_scene(size, offset)
boat_texture = pygame.image.load("Content/tanker.png").convert_alpha()
car_texture = pygame.image.load("Content/car.png").convert_alpha()
entities = Empty


def UpdateEntities(entities):
    return map(entities, lambda e: e.Update())


def DrawEntities(entities, screen, offset):
    iterrate(entities, lambda e: e.Draw(screen, offset))
    #return map(entities, lambda e: e.Draw(screen, offset))


def Main(entities):
  counter = 0
  while True:    
    counter += 1
    if counter == 5:
        entities = Node(Car(entry_road.Value, car_texture), entities)
        entities = Node(Boat(entry_rivers.Value, boat_texture),  entities)
        counter = 0
    screen.fill(green)

    #here we draw the board, do not move
    _board = entry_road
    while not _board.IsEmpty:
      _board.Value.Draw(screen, False)
      _board = _board.Tail

    #here we draw the bridges, do not move
    _board = bridges
    while not _board.IsEmpty:
      _board.Value.Draw(screen, True)
      _board = _board.Tail


    entities = UpdateEntities(entities)
    entities = filter(entities, lambda e : not e.CanBeRemoved)
    DrawEntities(entities, screen, offset)

    pygame.display.flip()
    time.sleep(0.2)
    
Main(entities)