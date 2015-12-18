class Node:
  def __init__(self, value, tail):
    self.Tail = tail
    self.Value = value
    self.IsEmpty = False

class Empty:
  def __init__(self):
    self.IsEmpty = True

Empty = Empty()


def output(l):
    if(isinstance(l, int)):
       print(l)
    elif(l.IsEmpty is False):
        print(l.Value)
        output(l.Tail)
    return '\n------\n'

def fold(l, f, z):
    if(l.IsEmpty is True):
        return z
    if(z is Empty):
        if(f(l.Value) is True):
            return Node(l.Value, fold(l.Tail, f, z))
        if(f(l.Value) is False):
            return fold(l.Tail, f, z)
        return Node(f(l.Value), fold(l.Tail, f, z))
    return f(l.Value, fold(l.Tail, f, z))


list = Node(1, Node(2, Node(3, Node(4, Empty))))

print(output(fold(list, lambda x, y: x + y, 0))) # prints 10
# de lambda functie geeft hier aan (x + y) (oftewel: tel de parameters die je binnenkrijgt bij elkaar op)
# en zoals je hier ziet: f(l.Value, fold(l.Tail, f, z)), krijgt hij een waarde binnen en herhaald dit zich tot if(l.IsEmpty is True): true is en
# hij 0 returned en zo dus de waarde terug geeft aan de functie die ervoor geroepen werd.
# Je krijgt dus eigenlijk dit: f(1, f(2, f(3, f(4, 0))))
# f telt in dit geval dus de waardes op en return dit, waarna de volgende f weer die waardes optelt, etc.
# Dit gebeurt in alle lambda die hieronder staan, het enige dat verandert is of die het optelt, vermenigvuldigd, aftrekt, etc.

# Je kunt het dus ook met "vaste" waardes doen, door deze te defineren als vaste waardes in de lambda functie, zoals hieronder:
print(output(fold(list, lambda x: x + 1, Empty))) # prints 2, 3, 4, 5
print(output(fold(list, lambda x: x * 10, Empty))) # prints 10, 20, 30, 40
print(output(fold(list, lambda x: x - 1, Empty))) # prints 0, 1, 2, 3

print(output(fold(list, lambda x: x % 2 == 0, Empty))) # prints 2, 4
# deze lambda kun je zien als
#   def modulo(value, with)
#       if(value % with == 0)
#           return True
#       else:
#           return False
# en als deze lambda true returned dan zorgt de functie fold ervoor dat er een nieuwe list gemaakt wordt met de l.values die
# door de lambda controle zijn gekomen.
# ook dit kan weer in 1 regel door enkel "x % 2 == 0" in te voeren.
# het scheelt dus veel functies, regels en onduidelijkheid voor iets simpels
# je kunt deze controles en mutaties uiteraard ook met strings enzo doen. Het is dus een hele krachtige manier van programmeren.

# Ik denk niet dat lambda bedoelt is om iets te reversen, daarvoor kun je beter een normale functie voor gebruiken, iets als dit:
def reverse(l, rl = Empty):
    if(l.IsEmpty is True):
        return rl
    return reverse(l.Tail, Node(l.Value, rl))
# of met een while loop zoals we bij een van de vorige lessen hebben gedaan.
print(output(reverse(list))) # prints 4, 3, 2, 1