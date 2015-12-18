class Node:
    def __init__(self, Head, Tail):
        self.Head = Head
        self.Tail = Tail
        self.IsEmpty = False

class Empty: 
    def __init__(self):
        self.IsEmpty = True
Empty = Empty()