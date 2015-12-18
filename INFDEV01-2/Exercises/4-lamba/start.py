from classes.Node import *

numbers = Empty
numbers = Node(1, numbers)
numbers = Node(2, numbers)
numbers = Node(3, numbers)
numbers = Node(4, numbers)


def combine(op, x, y):
    return op(x, y)


def increment(list, function):
    if(list.IsEmpty):
        return Empty
    else:
        return Node(function(list.Head), increment(list.Tail, function))


def summed(list, function):
    if(list.IsEmpty):
        return 0
    else:
        return function(list.Head, summed(list.Tail, function))


def even(list, function):
    if(list.IsEmpty):
        return Empty
    else:
        if(function(list.Head)):
            return Node(list.Head, even(list.Tail, function))
        else:
            return even(list.Tail, function)

def fold(list, f, z):
    if list.IsEmpty:
        return z
    else:
        return f(list.Head,fold(list.Tail,f,z))

def foldBack(list, f):
    if list.IsEmpty:
        return Empty
    else:
        return fold(list.Tail,f,f(list.Head,Empty))

def reverse(list):
    return foldBack(list, (lambda head, tail: Node(head,tail)))


combined = combine((lambda x, y: x+y), 10, 20)
print("Combined: %i" % combined)

incremented = increment(numbers, lambda x: x+1)
print("Incremented: %i" % incremented.Head, incremented.Tail.Head, incremented.Tail.Tail.Head, incremented.Tail.Tail.Tail.Head)

summed = summed(numbers, lambda x, y: x + y)
print("Summed: %i" % summed)

even = even(numbers, lambda x : x % 2 == 0)
print("Even numbers: %i" % even.Head, even.Tail.Head)

rlist = reverse(numbers)

def printList(l):
    if l.IsEmpty:
        return
    else:
        print(l.Head)
        printList(l.Tail)


printList(rlist)