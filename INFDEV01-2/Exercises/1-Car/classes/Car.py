from classes.Engine import Engine
from classes.Wheels import Wheels
from classes.Seats import Seats
from classes.Lights import Lights
from classes.Person import Person

class Car:
    def __init__(self, color, brand):
        self.engine = Engine('180', 'Euro95', 100, 25, 10, 'VW')
        self.wheels = Wheels('steel')
        self.seats = Seats('black', 5, 0)
        self.lights = Lights('halogen', 1)
        self.driver = Person(1, 1, 5, "Remco")
        self.passenger = Person(0, 0, 0, "Henk")

        self.color = color
        self.brand = brand
