def fold(list, func, base):
    if(list.IsEmpty):
        return base
    else:
        return func(list.Head, fold(list.Tail, func, base))

def filter(list, p):
    if(list.IsEmpty):
        return Empty
    else:
        if p(list.Value):
            return Node(list.Value, list.Tail)
        else:
            return filter(list.Tail, p)

def map(list, func):
    if(list.IsEmpty):
        return Empty
    else:
        return Node(func(list.Value), map(list.Tail, func))

class Empty:
    def Length(self):
            return 0
    def StrInner(self):
        return ""
    def __rlshift__(self, x):
        return Node(x, self)
    def __str__(self):
        return "[]"

class Node:
    def __init__(self, x, xs):
        self.Head = x
        self.Tail = xs
    def Length(self):
        return 1 + self.Tail.Length()
    def StrInner(self):
        return str(self.Head) + "; " + self.Tail.StrInner()
    def __rlshift__(self, x):
        return Node(x, self)
    def __str__(self):
        return "[" + str(self.Head) + "; " + self.Tail.StrInner() + "]"

l = 1 << (2 << (3 << Empty()))
print(l)
print(l.Length())