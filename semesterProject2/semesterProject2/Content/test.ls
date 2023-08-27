a = 9
Write("a is ", a)

Write("a + 5 = ", a + 5)
Write("a + 5.3 = ", a + 5.3)
Write("a - 5 = ", a - 5)
Write("a * 5 = ", a * 5)
Write("a / 3 = ", a / 3)
Write("a % 5 = ", a % 5)

While a > 6 do 
{
    a = a - 2
    Write("a is ", a)
}

If a == 5 do 
{
    WriteLn("a is equals 5")
}

If a == 5 and 7 + 1 == 8 do
{
    WriteLn("Both conditions are true")
}

If a == 4 or 7 + 1 == 9 do
{
    WriteLn("Only one condition is true")
}
Else do
{
    WriteLn("Either both or none of conditions are true")
}

WriteLn("a > 4 is", a > 4)
WriteLn("a < 4 is", a < 4)
WriteLn("a != 4 is", a != 4)

name = 'Alex'
fullname = 'Oleksandr'
WriteLn("My name is ", name)
surname = 'Multykh'
WriteLn("My surname is ", surname)
WriteLn("My full name is ", fullname + " " + surname)

WriteLn("-------------------1. Print sum of two numbers -------------------")

a = 5
b = 7
WriteLn("a = " + a)
WriteLn("b = " + b)
result = a + b
WriteLn("result = a + b = " + result)

WriteLn("-------------------2. Multiply all numbers from 1 to 10 -------------------")

result = 1
i = 10
While i > 1 do 
{
    result = result * i
    WriteLn(result / i + " * " + i + " = " + result)
    i = i - 1
}
WriteLn("result = " + result)

WriteLn("-------------------3. Add up all odd numbers from 1 to 20 -------------------")

result = 0
i = 20
While i > 0 do 
{
    If i % 2 == 1 do 
    {
        result = result + i
        WriteLn(result - i + " + " + i + " = " + result)
        i = i - 1
    }
    Else do
    {
        i = i - 1
    }
}

WriteLn("result = " + result)

WriteLn("-------------------4. Find an average number from the sum of even numbers from 7 to 20 -------------------")

a = 20
cnt = 0
sum = 0

While a >= 7 do 
{
    If a % 2 == 0 do 
    {
        sum = sum + a
        cnt = cnt + 1
        a = a - 1
    }
    Else do 
    {
        a = a - 1
    }
}

WriteLn("sum = " + sum)
WriteLn("count = " + cnt)
result = sum / cnt
WriteLn("result = sum / cnt = " + result)

WriteLn("-------------------5. Make a pyramid of a high 5 -------------------")

a = 1
space = 5

While a < 10 do 
{
    WriteLn(" " * space + "*" * a + space * " ")
    a = a + 2
    space = space - 1
}
