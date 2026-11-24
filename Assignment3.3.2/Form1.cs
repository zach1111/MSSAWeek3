
using System.ComponentModel;

namespace Assignment3._3._2
{
/* 3.3.2
    *Create a class: Student with fields like studid, firstname, lastname, address,monthofadmission,grade to hold character.
Create a list of students and perform following operations in windows application:

add new records,
delete record and
display them in grid.
Monthofadmission should be enum.
*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Person> persons = new List<Person>();

            persons.Add(new Person { Name = "John", Surname = "Black" });
            persons.Add(new Person { Name = "Mary", Surname = "White" });
            persons.Add(new Person { Name = "Zach", Surname = "Orange" });

            var bindingList = new BindingList<Person>(persons);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
     }


    

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
