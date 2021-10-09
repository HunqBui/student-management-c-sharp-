using System;

namespace asm
{
    public class ClassManagement
    {
        ClassManagement cm;
        
        public void DisplayClasses()
        {

            while (true)
            {
                Console.WriteLine("CLASSES MANAGEMENT");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. ADD CLASS");
                Console.WriteLine("2. STUDYING CLASSES");
                Console.WriteLine("3. COMPLETED CLASSES");
                Console.WriteLine("4. CLOSED CLASSES");
                Console.WriteLine("5. ALL CLASSES");
                Console.WriteLine("6. BACK TO MAIN MENU");
                Console.WriteLine("==========================================");
                Console.Write("#YOUR CHOICE: ");
                this.cm = new ClassManagement();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        this.cm.StudyingClasses();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }
        }
        public void AddClass()
        {
            
        }

        public void StudyingClasses()
        {
            while (true)
            {
                Console.WriteLine("======================================================");
                Console.WriteLine("STUDYING CLASSES");
                Console.WriteLine("======================================================");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("|Class      |Study day   |Study time     |Classroom   |Status      |");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("|PF17       |2 , 4 , 6   |08:30 - 11:30  |Lab 1       |Studying    |");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("|PF18       |3 , 5 , 7   |14:00 - 17:00  |Lab 2       |Studying    |");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("|AF20       |2 , 4 , 6   |18:00 - 21:00  |Art         |Studying    |");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.Write("Input Class to view Details or Input 0 back to menu: ");
                string a = Console.ReadLine();
                if (a == "0")
                {
                    return;
                }
                else
                {

                }
            }
        }
    }
}