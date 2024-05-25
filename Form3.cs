using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace COMPROG
{
    public partial class Form4 : Form
    {
        private List<Person> people;
        public Form2 DisplayForm { get; set; }

        public Form4(Form2 displayForm)
        {
            InitializeComponent();
            DisplayForm = displayForm; 
            DisplayForm = displayForm;
            people = new List<Person>(); // Initialize the list
        }

        private class Person
        {
            public string name;
            public int age;
            public string interests;
            public string location;
            public Image Image;

            public Person(string name, int age, string interests, string location, string bio, Image Image)
            {
                this.name = name;
                this.age = age;
                this.interests = interests;
                this.location = location;
                this.Image = Image;
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var random = new Random();

            var person1 = new Person(
                "Lucas Castro",
                random.Next(18, 65),
                "Volleyball, Jazz, Tennis, Pasta",
                "Cerrado, Brazil",
                "",
                Image.FromFile(@"D:\Eerah\CODING SHITSS\C#\COMPROG\assets\1.png")
            );
            people.Add(person1);

            var person2 = new Person(
                "Isabella Garcia",
                random.Next(18, 65),
                "Rhythm Games, Electronic, Romance, Pasta",
                "Buenos Aires, Argentina",
                "",
                Image.FromFile(@"D:\Eerah\CODING SHITSS\C#\COMPROG\assets\2.png")
            );
            people.Add(person2);

            var person3 = new Person(
                "Aisha Mohammed",
                random.Next(18, 65),
                "Platform Games, Badminton, Meat",
                "Kingston, Jamaica",
                "",
                Image.FromFile(@"D:\Eerah\CODING SHITSS\C#\COMPROG\assets\3.png")
            );
            people.Add(person3);

            var person4 = new Person(
                "Soo-jin Kim",
                random.Next(18, 65),
                "Classical, Volleyball, Sci-Fi, Pastries",
                "Seoul, South Korea",
                "",
                Image.FromFile(@"D:\Eerah\CODING SHITSS\C#\COMPROG\assets\4.png")
            );
            people.Add(person4);

            var person5 = new Person(
                "Miguel Santos",
                random.Next(18, 65),
                "Survival Games, Hip-hop, Basketball, Action, Fruits & Vegetables",
                "Manila, Philippines",
                "",
                Image.FromFile(@"D:\Eerah\CODING SHITSS\C#\COMPROG\assets\5.png")
            );
            people.Add(person5);

            var person6 = new Person(
                "Kyle Anderson",
                random.Next(18, 65),
                "Classical, Basketball, Horror, Pastries",
                "Seattle, Washington, USA",
                "",
                Image.FromFile(@"D:\Eerah\CODING SHITSS\C#\COMPROG\assets\6.png")
            );
            people.Add(person6);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#FC7A8E");
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int index = rand.Next(people.Count);
            Person randomPerson = people[index];

            pictureBox1.Image = randomPerson.Image;
            label1.Text = randomPerson.name;
            label3.Text = randomPerson.age.ToString();
            label4.Text = randomPerson.location;
            label6.Text = randomPerson.interests.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#FF385C");
        }
    }
}