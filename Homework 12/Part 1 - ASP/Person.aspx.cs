using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_1___ASP
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<People> mylist = new List<People>();
            People p1 = new People("Nate", 12, 6.4);
            People p2 = new People("John", 10, 5.2);
            People p3 = new People("Hank", 13, 5.0);
            People p4 = new People("Jennie", 16, 6.0);
            People p5 = new People("Frank", 10, 5.6);
            People p6 = new People("Fran", 12, 5.9);
            People p7 = new People("Jilly", 10, 6.2);
            People p8 = new People("Taylor", 13, 5.4);
            People p9 = new People("Cole", 16, 4.0);
            People p10 = new People("Rob", 9, 5.7);

            mylist.Add(p1);
            mylist.Add(p2);
            mylist.Add(p3);
            mylist.Add(p4);
            mylist.Add(p5);
            mylist.Add(p6);
            mylist.Add(p7);
            mylist.Add(p8);
            mylist.Add(p9);
            mylist.Add(p10);

            //PersonGridView.DataSource = from a in mylist select a;
            //PersonGridView.DataSource = from a in mylist where a.Age <= 12 select a;
            //PersonGridView.DataBind();

            int personCount = (from a in mylist
                              orderby a.Name, a.Height, a.Age
                              select a).Count();
            double average = 0;
            double sum = 0;

            foreach(var pp in mylist)
            {
                sum += pp.Height;
            }

            average = sum / personCount;

            PersonGridView.DataSource = from a in mylist where a.Height >= average && a.Age <= 12 select a;
            PersonGridView.DataBind();

        }

        public class People
        {
            string name;
            int age;
            double height;

            public People(string name, int age, double height)
            {
                this.Name = name;
                this.Age = age;
                this.Height = height;
            }

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public double Height { get => height; set => height = value; }
        }
    }
}