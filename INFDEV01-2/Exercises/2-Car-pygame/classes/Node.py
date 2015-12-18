class Node:
    def __init__(self, value, tail):
        self.value = value
        self.tail = tail
        self.isEmpty = False

class Empty: 
    def __init__(self):
        self.isEmpty = True

Empty = Empty()