using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace telefonkonyv_winforms
{
    public partial class Form1 : Form
    {
        List<string> AddLbls = new List<string>() { "Enter name:", "Enter the address:",
            "Enter father name:", "Enter mother name:", "Enter phone no.:", "Enter sex:",
            "Enter e-mail:", "Enter citizen no:" };
        int setNumber;
        Person p;

        public Form1()
        {
            InitializeComponent();
            Menu(true);
            ResetVis();
        }

        public void ResetVis()
        {
            lblAddTexts.Visible = false;
            txtAdd.Visible = false;
            txtDel.Visible = false;
            txtSearch.Visible = false;
            txtModify.Visible = false;
        }

        public void Menu(bool b)
        {
            lblWelcome.Visible = b;
            lblMenu.Visible = b;
            lblAddNew.Visible = b;
            lblDisplay.Visible = b;
            lblExit.Visible = b;
            lblModify.Visible = b;
            lblSearch.Visible = b;
            lblDelete.Visible = b;
        }

        public void AddRecord()
        {
            Menu(false);
            lblAddTexts.Visible = true;
            txtAdd.Visible = true;
            txtAdd.Text = "";
            txtAdd.Focus();
            setNumber = 0;
            p = new Person();

            SetValueLbls();
        }

        public void SetValueLbls()
        {
            lblAddTexts.Text = AddLbls[setNumber];
            txtAdd.Text = "";
        }
        public void SetValues()
        {
            if (txtAdd.Text != "")
            {
                if (setNumber == 0)
                {
                    p.Name = txtAdd.Text;
                    setNumber++;
                    SetValueLbls();
                }
                else if (setNumber == 1)
                {
                    p.Address = txtAdd.Text;
                    setNumber++;
                    SetValueLbls();
                }
                else if (setNumber == 2)
                {
                    p.FatherName = txtAdd.Text;
                    setNumber++;
                    SetValueLbls();
                }
                else if (setNumber == 3)
                {
                    p.MotherName = txtAdd.Text;
                    setNumber++;
                    SetValueLbls();
                }
                else if (setNumber == 4)
                {
                    if (long.TryParse(txtAdd.Text, out long l))
                    {
                        p.MobileNo = l;
                        setNumber++;
                        SetValueLbls();
                    }
                    else
                    {
                        SetValueLbls();
                    }
                }
                else if (setNumber == 5)
                {
                    p.Sex = txtAdd.Text;
                    setNumber++;
                    SetValueLbls();
                }
                else if (setNumber == 6)
                {
                    p.Email = txtAdd.Text;
                    setNumber++;
                    SetValueLbls();
                }
                else if (setNumber == 7)
                {
                    p.CitizenNo = txtAdd.Text;
                    Add();
                }
            }
        }

        public void Add()
        {
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
            ResetVis();
            Menu(true);
        }

        private void lblAddNew_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void txtAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetValues();
            }
        }

        public void ListRecord()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("project.dat", FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    p = new Person
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
                }
            }
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            ListRecord();
            Menu(false);
        }

        public void DeleteRecord()
        {
            Menu(false);
            lblAddTexts.Visible = true;
            lblAddTexts.Text = "Enter CONTACT'S NAME:";
            txtDel.Visible = true;
            txtDel.Text = "";
            txtDel.Focus();
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        public void Delete()
        {
            string name = txtDel.Text;
            List<Person> persons = new List<Person>();

            using (BinaryReader reader = new BinaryReader(File.Open("project.dat", FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    p = new Person
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
            ResetVis();
            Menu(true);
        }

        private void txtDel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDel.Text != "") 
            {
                Delete();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            SearchRecord();
        }

        public void Search()
        {
            string name = txtSearch.Text;

            using (BinaryReader reader = new BinaryReader(File.Open("project.dat", FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    p = new Person
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
        }

        public void SearchRecord()
        {
            Menu(false);
            lblAddTexts.Visible = true;
            lblAddTexts.Text = "Enter name of person to search";
            txtSearch.Visible = true;
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSearch.Text != "")
            {
                Search();
            }
        }

        public void ModifyRecord()
        {
            Menu(false);
            lblAddTexts.Visible = true;
            lblAddTexts.Text = "Enter CONTACT'S NAME TO MODIFY:";
            txtModify.Visible = true;
            txtModify.Text = "";
            txtModify.Focus();
        }

        public void Modify()
        {
            string name = txtModify.Text;

            List<Person> persons = new List<Person>();

            using (BinaryReader reader = new BinaryReader(File.Open("project.dat", FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    p = new Person
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
        }

        private void lblModify_Click(object sender, EventArgs e)
        {
            ModifyRecord();
        }

        private void txtModify_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtModify.Text != "")
            {
                Modify();
            }
        }
    }
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
}
