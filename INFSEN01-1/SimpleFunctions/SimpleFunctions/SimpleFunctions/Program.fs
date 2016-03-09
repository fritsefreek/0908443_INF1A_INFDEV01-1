//1. Define a function that takes two integers n, m and another integer x and do the following: if the product of n and x is m return the string
//"Tro", if the product of m and x is n return "lolo", and if the product of n and m is x return "Trololo". In all other cases just return an emtpy string.
let exercise1 n m x =
    if n*x = m then "Tro"
    elif m*x = n then "lolo"
    elif n*m = x then "Trololo"
    else "empty"

System.Console.WriteLine(exercise1 10 5 2)


//2. Define a new version of exercise 1 where the user can specify the messages to output.
let exercise2 n m x output1 output2 output3 output4 =
    if n*x = m then output1
    elif m*x = n then output2
    elif n*m = x then output3
    else output4

System.Console.WriteLine(exercise2 10 5 2 "output1" "output2" "output3" "output4")


//3. The crazy operation takes two one-digit integer numbers n and m and does the following: if n divides m then just return an integer number containing the digits nm.
//For example crazy 4 8 returns 48. If n is positive and m negative return their product. In all the other cases return the sum of the two numbers. Implement this
//extremely useful operation.
let exersise3 n m =
