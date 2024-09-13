
using System.Security.Cryptography.X509Certificates;

Student student1 = new Student("Sefa", "Kahraman", 28, "Zümrütevler", "FullStack", "Beşiktaş", "JAVA,C#", "+905337825981", true);
student1.Print();

StudentManager studentOne = new(student1);
studentOne.Add();
studentOne.Update();
studentOne.Remove();


Student student2 = new("Ahmet", "Güllü", 45, "Pendik", "UI/UX", "sakaryaspor", "html", "45612345", false);
student2.Print();


Student student3 = new("Ali", "Mumcu", 40, "Kadıköy", "Frontend","Trabzonspor", "JS", "+9054321654", true);
Console.WriteLine(student3.ToString());



class Student
{
    public Student()
    {
        CreatedStudent();
    }
    public Student(string Isim, string Soyisim, int Yas, string Semt, string Alan, string TuttuguTakim,
        string BildigiPrgDilleri, string Numara, bool YabanciDilBiliyomu)
    {
        isim = Isim;
        soyisim = Soyisim;
        yas = Yas;
        semt = Semt;
        alan = Alan;
        tuttuguTakim = TuttuguTakim;
        bildigiProgramlamaDilleri = BildigiPrgDilleri;
        numara = Numara;
        yabanciDilBiliyomu = YabanciDilBiliyomu;
        CreatedStudent();
    }

    void CreatedStudent()
    {
        Console.WriteLine("\n--ÖĞRENCİ OLUŞTURULDU--\n");
    }

    public string isim;
    public string soyisim;
    public int yas;
    public string semt;
    public string alan;
    public string tuttuguTakim;
    public string bildigiProgramlamaDilleri;
    public string numara;
    public bool yabanciDilBiliyomu;


    public void Print()
    {
        Console.WriteLine($"İsim: {isim}");
        Console.WriteLine($"Soyisim: {soyisim}");
        Console.WriteLine($"Yaş: {yas}");
        Console.WriteLine($"Semt: {semt}");
        Console.WriteLine($"Alan: {alan}");
        Console.WriteLine($"Takımı: {tuttuguTakim}");
        Console.WriteLine($"Bildiği programlama dilleri: {bildigiProgramlamaDilleri}");
        Console.WriteLine($"Telefonu: {numara}");
        Console.WriteLine($"Yabancı Dil Biliyor Mu: {yabanciDilBiliyomu}");
        Console.WriteLine("\n----------------******-----------------\n");
    }

    public override string ToString()
    {
        return $"İsim: {isim}, Soyisim: {soyisim}, Yaş: {yas}, Semt: {semt}, " +
            $"\nAlan: {alan}, Takımı: {tuttuguTakim}, Bildiği programlama dilleri: {bildigiProgramlamaDilleri}, " +
            $"\nTelefonu: {numara}, Yabancı Dil Biliyor Mu: {yabanciDilBiliyomu}";
    }

}

class StudentManager
{
    Student student1;


    public StudentManager(Student student)
    {
        student1 = student;
    }

    public void Add()
    {
        if (student1.isim.Length >= 1 && student1.soyisim.Length >= 1 && (string.IsNullOrEmpty(student1.bildigiProgramlamaDilleri) == false) && student1.yas >= 18 &&
            student1.yas < 35 && (string.IsNullOrEmpty(student1.numara) == false) && (string.IsNullOrEmpty(student1.semt) == false) && student1.numara.Contains("+905") == true)
        {
            Console.WriteLine("++Öğrenci eklendi");

        }
        else
        {
            Console.WriteLine("--Öğrenci Eklenemedi");
        }

    }
    public void Update()
    {
        if (student1.isim.Length >= 1 && student1.soyisim.Length >= 1 && (string.IsNullOrEmpty(student1.bildigiProgramlamaDilleri) == false) && student1.yas >= 18 &&
    student1.yas < 35 && (string.IsNullOrEmpty(student1.numara) == false) && (string.IsNullOrEmpty(student1.semt) == false) && student1.numara.Contains("+905") == true)
        {
            Console.WriteLine("++Öğrenci Güncellendi");

        }
        else
        {
            Console.WriteLine("--Öğrenci Güncellenemedi");
        }

    }
    public void Remove()
    {
        Console.WriteLine("--Öğrenci Silindi");

    }

}