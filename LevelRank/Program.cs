using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Student mystudent = new Student("Nile", 0);
           
            mystudent.doSomething();
            mystudent.printStudent();
            mystudent.doSomething(); 
            mystudent.doSomething();
            mystudent.printStudent();
        }

    }
    class Student
    {
        public string name;
        public int level;
        string rank;

        public Student()
        {
            level = 0;
            rank = "";
            name = "";
        }
        public Student(string id, int pts)
        {
            name = id;
            level = pts;
        }
        public void printStudent()
        {
            findRank(this.level);
            Console.WriteLine("The student {0} is level {1} and rank {2}", name, level, rank);
            Console.WriteLine();
        }
        public void doSomething()
        {
            int action;
            
               
                Console.WriteLine("Select a number.\n Did the student (1) Code a program or (2) Assist another student? \n");
                Console.WriteLine();
                action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    level++;
                }
                else if (action == 2)
                {
                    level = level + 2;
                }
                else
                    Console.WriteLine("Invalid number.\n");
                

        }
        private void findRank(int pts)
        {
            int switchcase  = pts/5;
            switch (switchcase)
            {
                case 0:
                    {
                        rank = "Beginner";
                        Console.WriteLine("You are but a mere beginner still.");
                        break;
                    }
                case 1:
                    {
                        rank = "Grasshopper";
                        Console.WriteLine("You are a fledgling grasshopper.");
                        break;
                    }
                case 2:
                    {
                        rank = "Journeyman";
                        Console.WriteLine("You're a capable journeyman now!");
                        break;
                    }
                case 3:
                    {
                        rank = "Rock Star";
                        Console.WriteLine("Looks like we have a programming rock star on our hands!");
                        break;
                    }
                case 4:
                    {
                        rank = "Ninja";
                        Console.WriteLine("What a programming ninja you are!");
                        break;
                    }
                case 5:
                    {
                        rank = "Jedi";
                        Console.WriteLine("With you, the force is. Youre a programming Jedi!");
                        break;
                    }


            }
            
            
        }
    }
}
