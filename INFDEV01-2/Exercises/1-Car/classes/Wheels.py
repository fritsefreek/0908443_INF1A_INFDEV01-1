from classes.Tyres import Tyres

class Wheels:
    def __init__(self, material):
        self.tyres = Tyres(20000)

        self.material = material