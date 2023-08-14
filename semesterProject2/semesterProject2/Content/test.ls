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

Write("a > 4 is", a > 4)
Write("a < 4 is", a < 4)
Write("a != 4 is", a != 4)

name = 'Alex'
fullname = 'Oleksandr'
Write("My name is ", name)
surname = 'Multykh'
Write("My surname is ", surname)
Write("My full name is ", fullname + " " + surname)
WriteLn(name > surname)                                 // error