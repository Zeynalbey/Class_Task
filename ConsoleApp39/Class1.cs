using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    public class System
    {
        public string Name; public string Surname; public string FatherName; public int Age; public string Fin; public string PhoneNumber; public string Position; public int Salary;
        public System(string name, string surname, string father, int age, string fin, string phone, string position, int salary)
        {
            name = Console.ReadLine();
            surname = Console.ReadLine();
            father = Console.ReadLine();
            age =Convert.ToInt32( Console.ReadLine());
            fin = Console.ReadLine();
            phone = Console.ReadLine();
            position = Console.ReadLine();
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("___________________________________________________________________");

            Name = name;
            Surname = surname;
            FatherName = father;
            Age = age;
            Fin = fin;
            PhoneNumber = phone;
            Position = position;
            Salary = salary;

            Name1(); Name2(); Name3();
            Surname1(); Surname2(); Surname3();
            FatherName1(); FatherName2(); FatherName3();
            Age1();
            FinNumber1(); FinNumber2();
            PhoneNumber1(); PhoneNumber2(); PhoneNumber3();
            Position1();
            Salary1();
            
            Console.ReadLine();
        }
        public void Name1()
        {
            if (Name.Length < 2 || Name.Length > 20)
            {
                Console.WriteLine("Adda herflerin sayi 2 ve 20 arasinda olmalidir.");
            }
        }
        public void Name2()
        {
            char[] numbers = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < Name.Length; j++)
                {
                    if (Name[j] == numbers[i])
                    {
                        Console.WriteLine("Ad yazarken ancaq herflerden istifade edin.");
                        return;
                    }
                }
            }
        }
        public void Name3()
        {
            char[] smallLeters = new[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            for (int i = 0; i < smallLeters.Length; i++)
            {
                if (Name[0] == smallLeters[i])
                {
                    Console.WriteLine("Adin bas herfini boyuk yazin");
                    return;
                }
            }
        }
        public void Surname1()
        {
            if (Surname.Length < 2 || Surname.Length > 35)
            {
                Console.WriteLine("Soyadda herflerin sayi 2 ve 35 arasinda olmalidir.");
            }

        }
        public void Surname2()
        {
            char[] numbers = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < Surname.Length; j++)
                {
                    if (Surname[j] == numbers[i])
                    {
                        Console.WriteLine("Soyad yazarken ancaq herflerden istifade edin.");
                        return;
                    }
                }
            }
        }
        public void Surname3()
        {
            char[] smallLeters = new[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            for (int i = 0; i < smallLeters.Length; i++)
            {
                if (smallLeters[i] == Surname[0])
                {
                    Console.WriteLine("Soyadin bas herfini boyuk yazin");
                    return;
                }
            }
        }
        public void FatherName1()
        {
            if (FatherName.Length < 2 || FatherName.Length > 20)
            {
                Console.WriteLine("Ata adinda herflerin sayi 2 ve 20 arasinda olmalidir.");
            }
        }
        public void FatherName2()
        {
            char[] numbers = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < FatherName.Length; j++)
                {
                    if (FatherName[j] == numbers[i])
                    {
                        Console.WriteLine("Ata adi yazarken ancaq herflerlerden istifade edin.");
                        return;
                    }
                }
            }
        }
        public void FatherName3()
        {
            char[] smallLeters = new[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            for (int i = 0; i < smallLeters.Length; i++)
            {
                if (FatherName[0] == smallLeters[i])
                {
                    Console.WriteLine("Ata adinin bas herfini boyuk yazin.");
                }
            }
        }
        public void Age1()
        {
            if (Age < 18 || Age > 65)
            {
                Console.WriteLine("Yas 18 ve 65 arasinda olmalidir");
            }
        }
        public void FinNumber1()
        {
            if (Fin.Length != 7)
            {
                Console.WriteLine("Fin 7-ye beraber olmalidir");
            }
        }
        public void FinNumber2()
        {
            char[] smallLeters = new[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < smallLeters.Length; i++)
            {
                for (int j = 0; j < Fin.Length; j++)
                {
                    if (Fin[j] == smallLeters[i])
                    {
                        Console.WriteLine("Finkod yazarken kicik herflerden istifade etmek olmaz.");
                        return;
                    }
                }
            }
        }
        public void PhoneNumber1()
        {
            if (PhoneNumber[0] != '+' || PhoneNumber[1] != '9' || PhoneNumber[2] != '9' || PhoneNumber[3] != '4')
            {
                Console.WriteLine("Telefon nomresi +994-le baslamalidir");
            }
        }
        public void PhoneNumber2()
        {
            if (PhoneNumber.Length != 13)
            {
                Console.WriteLine("Telefon nomresi 13 reqem olmalidir.");
            }
        }
        public void PhoneNumber3()
        {
            char[] numbers = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '+' };        //bunu ozum add eledim ki, nomre yerine herf yazmaq olmasin, error vermesin.
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < PhoneNumber.Length; j++)
                {
                    if (PhoneNumber[j] != numbers[i])
                    {
                        Console.WriteLine("Telefon nomresi yazarken ancaq reqemlerden istifade edin.");
                        return;
                    }
                }
            }
        }
        public void Position1()
        {
            if (Position != "HR" && Position != "Engineer" && Position != "Audit")
            {
                Console.WriteLine("Pozisiya ancaq HR, Audit ve ya Engineer ola biler");
            }
        }
        public void Salary1()
        {
            if (Salary < 1500 || Salary > 5000)
            {
                Console.WriteLine("Bu maas serte uygun deyil.");
            }
        }
        

    }

}
