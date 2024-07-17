using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace telefonkonyv
{
    using System;
    using System.IO;
    using System.Text;

    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public long MobileNo { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string CitizenNo { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Start();
        }

        static void Back()
        {
            Start();
        }

        static void Start()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\t**********WELCOME TO PHONEBOOK***********");
            Console.WriteLine("\n\n\t\t\t MENU\t\t\n\n");
            Console.WriteLine("\t1.Add New \t2.List \t\t3.Exit \n\t4.Modify \t5.Search\t6.Delete");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': AddRecord(); break;
                case '2': ListRecord(); break;
                case '3': Environment.Exit(0); break;
                case '4': ModifyRecord(); break;
                case '5': SearchRecord(); break;
                case '6': DeleteRecord(); break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nEnter 1 to 6 only");
                    Console.WriteLine("\n Press any key");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }

        static void AddRecord()
        {
            Console.Clear();
            Person p = new Person();

            Console.Write("\n Enter name: ");
            p.Name = Console.ReadLine();

            Console.Write("\nEnter the address: ");
            p.Address = Console.ReadLine();

            Console.Write("\nEnter father name: ");
            p.FatherName = Console.ReadLine();

            Console.Write("\nEnter mother name: ");
            p.MotherName = Console.ReadLine();

            Console.Write("\nEnter phone no.:");
            p.MobileNo = long.Parse(Console.ReadLine());

            Console.Write("Enter sex:");
            p.Sex = Console.ReadLine();

            Console.Write("\nEnter e-mail:");
            p.Email = Console.ReadLine();

            Console.Write("\nEnter citizen no:");
            p.CitizenNo = Console.ReadLine();

            using (BinaryWriter writer = new BinaryWriter(File.Open("project.dat", FileMode.Append)))
            {
                writer.Write(p.Name);
                writer.Write(p.Address);
                writer.Write(p.FatherName);
                writer.Write(p.MotherName);
                writer.Write(p.MobileNo);
                writer.Write(p.Sex);
                writer.Write(p.Email);
                writer.Write(p.CitizenNo);
            }

            Console.WriteLine("\nRecord saved");
            Console.WriteLine("\n\nPress any key");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ListRecord()
        {
            Console.Clear();
            using (BinaryReader reader = new BinaryReader(File.Open("project.dat", FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    Person p = new Person
                    {
                        Name = reader.ReadString(),
                        Address = reader.ReadString(),
                        FatherName = reader.ReadString(),
                        MotherName = reader.ReadString(),
                        MobileNo = reader.ReadInt64(),
                        Sex = reader.ReadString(),
                        Email = reader.ReadString(),
                        CitizenNo = reader.ReadString()
                    };

                    Console.WriteLine("\n\n\n YOUR RECORD IS\n\n ");
                    Console.WriteLine($"\nName={p.Name}\nAddress={p.Address}\nFather name={p.FatherName}\nMother name={p.MotherName}\nMobile no={p.MobileNo}\nSex={p.Sex}\nE-mail={p.Email}\nCitizen no={p.CitizenNo}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("\n Press any key");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void SearchRecord()
        {
            Console.Clear();
            Console.Write("\nEnter name of person to search\n");
            string name = Console.ReadLine();

            using (BinaryReader reader = new BinaryReader(File.Open("project.dat", FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    Person p = new Person
                    {
                        Name = reader.ReadString(),
                        Address = reader.ReadString(),
                        FatherName = reader.ReadString(),
                        MotherName = reader.ReadString(),
                        MobileNo = reader.ReadInt64(),
                        Sex = reader.ReadString(),
                        Email = reader.ReadString(),
                        CitizenNo = reader.ReadString()
                    };

                    if (p.Name == name)
                    {
                        Console.WriteLine($"\n\tDetail Information About {name}");
                        Console.WriteLine($"\nName:{p.Name}\nAddress:{p.Address}\nFather name:{p.FatherName}\nMother name:{p.MotherName}\nMobile no:{p.MobileNo}\nSex:{p.Sex}\nEmail:{p.Email}\nCitizen no:{p.CitizenNo}");
                        break;
                    }
                }
            }

            Console.WriteLine("\n Press any key");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void DeleteRecord()
        {
            Console.Clear();
            Console.Write("Enter CONTACT'S NAME:");
            string name = Console.ReadLine();

            List<Person> persons = new List<Person>();

            using (BinaryReader reader = new BinaryReader(File.Open("project.dat", FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    Person p = new Person
                    {
                        Name = reader.ReadString(),
                        Address = reader.ReadString(),
                        FatherName = reader.ReadString(),
                        MotherName = reader.ReadString(),
                        MobileNo = reader.ReadInt64(),
                        Sex = reader.ReadString(),
                        Email = reader.ReadString(),
                        CitizenNo = reader.ReadString()
                    };

                    if (p.Name != name)
                    {
                        persons.Add(p);
                    }
                }
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open("project.dat", FileMode.Create)))
            {
                foreach (var p in persons)
                {
                    writer.Write(p.Name);
                    writer.Write(p.Address);
                    writer.Write(p.FatherName);
                    writer.Write(p.MotherName);
                    writer.Write(p.MobileNo);
                    writer.Write(p.Sex);
                    writer.Write(p.Email);
                    writer.Write(p.CitizenNo);
                }
            }

            Console.WriteLine("RECORD DELETED SUCCESSFULLY.");
            Console.WriteLine("\n Press any key");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ModifyRecord()
        {
            Console.Clear();
            Console.Write("\nEnter CONTACT'S NAME TO MODIFY:\n");
            string name = Console.ReadLine();

            List<Person> persons = new List<Person>();

            using (BinaryReader reader = new BinaryReader(File.Open("project.dat", FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    Person p = new Person
                    {
                        Name = reader.ReadString(),
                        Address = reader.ReadString(),
                        FatherName = reader.ReadString(),
                        MotherName = reader.ReadString(),
                        MobileNo = reader.ReadInt64(),
                        Sex = reader.ReadString(),
                        Email = reader.ReadString(),
                        CitizenNo = reader.ReadString()
                    };

                    if (p.Name == name)
                    {
                        Console.Write("\n Enter name:");
                        p.Name = Console.ReadLine();
                        Console.Write("\nEnter the address:");
                        p.Address = Console.ReadLine();
                        Console.Write("\nEnter father name:");
                        p.FatherName = Console.ReadLine();
                        Console.Write("\nEnter mother name:");
                        p.MotherName = Console.ReadLine();
                        Console.Write("\nEnter phone no:");
                        p.MobileNo = long.Parse(Console.ReadLine());
                        Console.Write("\nEnter sex:");
                        p.Sex = Console.ReadLine();
                        Console.Write("\nEnter e-mail:");
                        p.Email = Console.ReadLine();
                        Console.Write("\nEnter citizen no\n");
                        p.CitizenNo = Console.ReadLine();

                        Console.WriteLine("\n Your data is modified");
                    }
                    persons.Add(p);
                }
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open("project.dat", FileMode.Create)))
            {
                foreach (var p in persons)
                {
                    writer.Write(p.Name);
                    writer.Write(p.Address);
                    writer.Write(p.FatherName);
                    writer.Write(p.MotherName);
                    writer.Write(p.MobileNo);
                    writer.Write(p.Sex);
                    writer.Write(p.Email);
                    writer.Write(p.CitizenNo);
                }
            }

            Console.WriteLine("\n Press any key");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}
