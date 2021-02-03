using System;
//using System.Linq;

namespace ObjectArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");

            Console.WriteLine("Welcome to the student database!");
            Console.WriteLine("How many students list you need to enter: ");
            int num_of_stud = Convert.ToInt32(Console.ReadLine());
            string name;
            int age, rollno;
            Student[] stdlist = new Student[num_of_stud];
            Console.WriteLine(num_of_stud + " tables are created!\n");
            for(int i=0; i<num_of_stud; i++){
                stdlist[i] = new Student();
                Console.WriteLine("Enter Student " + (i+1) + " Details: ");
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Roll Number: ");
                rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                stdlist[i].SetInfo(name, rollno, age);
            }

            Console.WriteLine("\n Students information \n");

            for (int j = 0; j < num_of_stud; j++){
                 stdlist[j].printInfo();
            }

            



            /*
            foreach(int i in Enumerable.Range(0, num_of_stud))
            {
                stdlist[i] = new Student();

                Console.WriteLine("Enter Student " + i + " Details: ");
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Roll Number: ");
                rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Age: ");
                age = Convert.ToInt32(Console.ReadLine());

            }*/


            //stdlist[1] = new Student();


            /*
            stdlist[0].SetInfo("Yas", 101, 19);
            stdlist[1].SetInfo("seen", 102, 20);

            stdlist[0].printInfo();
            stdlist[1].printInfo();
            */


        }
    }

    class Student
    {
        private int rollno;
        private string name;
        private int age;

        public void SetInfo(string name, int rollno, int age)
        {
            this.name = name;
            this.rollno = rollno;
            this.age = age;
        }

        public void printInfo()
        {
            
            Console.WriteLine("Name: " + name);
            Console.WriteLine("rollno: " + rollno);
            Console.WriteLine("age: " + age);

        }
    }


}
