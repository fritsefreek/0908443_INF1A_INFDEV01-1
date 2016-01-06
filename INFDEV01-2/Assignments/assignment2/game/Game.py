import time
from threading import Thread
import os, pygame
import time
from Tile import *
from Node import *
from Boat import *
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
cars = Empty
boats = Empty


def DrawEntities(entities, screen, offset):
    while not entities.IsEmpty:
        entities.Value.Draw(screen, offset)
        entities = boats.Tail

        
def Main(cars, boats):
  counter = 0
  while True:    
    counter += 1
    if counter == 5:
        cars = Node(Car(entry_road.Value), cars)
        boats = Node(Boat(entry_rivers.Value), boats)
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

    cars = RemoveParkedCars(UpdateCars(cars))
    DrawCars(cars, screen, offset, car_texture)

    boats = RemoveParkedBoats(UpdateBoats(boats))
    DrawBoats(boats, screen, offset, boat_texture)

    pygame.display.flip()
    time.sleep(0.2)
    
Main(cars, boats)