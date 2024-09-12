


Student studentOne = new()
{
    name = "Sefa",
    surName = "Kahraman",
    phone = "+9078945961",
};

Student student2 = new("Ahmet", "Memlük", "+978954623");

Console.WriteLine(studentOne.ToString());
Console.WriteLine("-------------------------");
Console.WriteLine(student2.ToString());

StudentManager student = new();
student.Add(studentOne);
student.Add(student2);


class Student
{
    public string name;
    public string surName;
    public string phone;

    public Student()
    {
    }

    public Student(string Name, string SurName, string Phone)
    {
        name = Name;
        surName = SurName;
        phone = Phone;
    }

    public override string ToString()
    {
        return $"***Student Created***\n\nName: {name}\nSurname: {surName.ToUpper()}\nPhone: {phone}";
    }


}

class StudentManager
{
    public void Add(Student student)
    {
        Console.WriteLine($"\n{student.name} is Added...");
    }
    public void Update(Student student)
    {
        Console.WriteLine($"{student.name} is Updated...");
    }
    public void Remove(Student student)
    {
        Console.WriteLine($"{student.name} is Removed...");
    }


}

