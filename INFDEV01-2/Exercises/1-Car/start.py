from classes.Car import Car

car1 = Car('red', 'BMW')
print "Car1 brand: %s" % car1.brand
print "Car1 engine brand: %s" % car1.engine.brand
print "Car1 wheel material: %s" % car1.wheels.material
print "Car1 tyres agespan: %s" % car1.wheels.tyres.ageSpan
print "Car1 seat amount: %i" % car1.seats.amount
print "Car1 lights type: %s" % car1.lights.type
print "Car1 driver name: %s" % car1.driver.name
print "Car1 passenger name: %s" % car1.passenger.name
