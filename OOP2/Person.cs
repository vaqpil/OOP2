
//Person tom = new Person();

class Person
{
    public string name = "НЕ известно";
    public int age;
    public Person()

    {
        Console.WriteLine("Создание объекта Person");
        name = "Tom";
        age = 34;
    }
    public void Print()
    {
        Console.WriteLine($"ИМЯ: {name} ВОЗРАСТ: {age}");
    }
}
