from classes.Node import *

def increment(node, amount):
    if node.isEmpty is True:
        return Empty
    else:
        return Node(node.value + amount, increment(node.tail, amount))


def filterEven(node):
    if node.isEmpty is True:
        return Empty
    else:
        if node.value % 2 == 0:
            return Node(node.value, filterEven(node.tail))
    return filterEven(node.tail)


def count(node, total=0):
    if node.isEmpty is True:
        return total
    else:
        return count(node.tail, total + 1)

def sum(node, total = 0):
    if node.isEmpty is True:
        return total
    else:
        total += node.value
        return sum(node.tail, total)


def reverse(oldList, reversedList=Empty):
    if oldList.isEmpty is True:
        return reversedList
    else:
        return reverse(oldList.tail, Node(oldList.value, reversedList))


node = Empty
node = Node(1, node)
node = Node(2, node)
node = Node(3, node)
node = Node(4, node)

incrementList = increment(node, 10)
print "\nIncrement list: %i" % incrementList.value, incrementList.tail.value, incrementList.tail.tail.value, incrementList.tail.tail.tail.value

countList = count(node)
print "\nCount list: %i" % countList

evenList = filterEven(node)
print "\nEven list: %i" % evenList.value, evenList.tail.value

sumTest = sum(node)
print "\nSum: %i" % sumTest

reversedNote = reverse(node)
print "\nReversed list: %i" % reversedNote.value, reversedNote.tail.value, reversedNote.tail.tail.value, reversedNote.tail.tail.tail.value