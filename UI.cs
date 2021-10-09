using System;

namespace asm
{
    public class UI
    {
        int choice;
        StudentListManagement slm;
        ClassManagement cm;
        //asm hoàn chỉnh

        public void Displaymenu()
        {
            System.Console.WriteLine("======================================");

            System.Console.WriteLine("--- VTC STUDENT ACADEMY MANAGEMENT ---");

            System.Console.WriteLine("======================================");

            System.Console.WriteLine("1. STUDENT LIST MANAGEMENT");
            System.Console.WriteLine("2. CLASSES MANAGEMENT");
            System.Console.WriteLine("3. EXIT APPLICATION");
            System.Console.WriteLine("======================================");
            System.Console.Write("#YOUR CHOICE: ");
            this.slm = new StudentListManagement();
            this.cm = new ClassManagement();


            this.choice = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (choice)
                {
                    case 1:
                        this.slm.Menu();
                        break;
                    case 2:
                        this.cm.DisplayClasses();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    case 4:
                        break;
                }
            }
        }

    }
}