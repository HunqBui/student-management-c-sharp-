using System;
using System.Collections.Generic;

namespace asm
{
    public class StudentListManagement
    {

        public List<Student> list = new List<Student>();

        public void AddStudent()
        {
            Student st = new Student();
            while (true)
            {
                System.Console.WriteLine("=================================");
                System.Console.WriteLine("NEW STUDENT");
                System.Console.WriteLine("=================================");

                Console.WriteLine("Student ID: ");
                st.Studentid = Console.ReadLine();

                Console.WriteLine("First Name: ");
                st.Firstname = Console.ReadLine();

                Console.WriteLine("Middle Name: ");
                st.Middlename = Console.ReadLine();

                Console.WriteLine("Last Name: ");
                st.Lastname = Console.ReadLine();

                Console.WriteLine("Birthday: ");
                st.Birthday = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Address: ");
                st.Address = Console.ReadLine();

                Console.WriteLine("Phone: ");
                st.Phone = Console.ReadLine();

                Console.WriteLine("Email: ");
                st.Email = Console.ReadLine();

                Console.WriteLine("Class Name: ");
                st.Classname = Console.ReadLine();

                Console.WriteLine("Note: ");
                st.Note = Console.ReadLine();

                Console.WriteLine("Status: ");
                st.Status = Console.ReadLine();

                list.Add(st);
                System.Console.WriteLine("=================================");
                System.Console.WriteLine("Add Student Complete!");
                System.Console.Write("Do u wanna continue (y/n): ");
                string choice = Console.ReadLine();


                if (choice == "n")
                {
                    break;
                }


            }
        }

        public void Menu()
        {
            int choice;
            while (true)
            {
                System.Console.WriteLine("======================================");
                System.Console.WriteLine("--- VTC ACADEMY STUDENT MANAGEMENT ---");
                System.Console.WriteLine("STUDENT LIST MANAGEMENT");
                System.Console.WriteLine("======================================");
                System.Console.WriteLine("1. ADD STUDENT");
                System.Console.WriteLine("2. SEARCH STUDENTS");
                System.Console.WriteLine("3. SHOW ALL STUDENTS");
                System.Console.WriteLine("4. BACK TO MAIN MENU");
                System.Console.Write("YOUR OPTION: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        //SearchStudent();
                        break;
                    case 3:
                        ShowAllStudent();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Please select option [1-3]");
                        break;

                }
            }
        }
        public void ShowAllStudent()
        {
            while (true)
            {
                System.Console.WriteLine("===============================================================");
                System.Console.WriteLine("STUDENT LIST");
                System.Console.WriteLine("---------------------------------------------------------------");
                System.Console.WriteLine("| Student id  |  Full Name        | Class   | Phone   | Email |");
                System.Console.WriteLine("---------------------------------------------------------------");
                foreach (Student student in list)
                {
                    System.Console.WriteLine("|{0, -12}| {1, -19}| {2, -8}| {3, -8}| {4, -7}|", student.Studentid, student.Lastname + student.Middlename + student.Firstname, student.Classname, student.Phone, student.Email);
                }
                System.Console.WriteLine("---------------------------------------------------------------");
                System.Console.WriteLine("Input Student Id to view Details or Input 0 back to menu: ");
                string a = Console.ReadLine();
                if (a == "0")
                {
                    return;
                }
                else
                {
                    int count = 0;
                    foreach (Student item in list)
                    {
                        if (a == item.Studentid)
                        {
                            studentDetail(item);
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write("You entered incorrectly, pess enter to re-enter: ");
                        Console.ReadKey();
                    }
                }
            }
        }
        public void studentDetail(Student student)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("STUDENT INFORMATION");
            Console.WriteLine("======================================");

            Console.WriteLine("Student ID: " + student.Studentid);
            Console.WriteLine("First Name: " + student.Firstname);
            Console.WriteLine("Middle Name: " + student.Middlename);
            Console.WriteLine("Last Name: " + student.Lastname);
            Console.WriteLine("Birthday: " + student.Birthday);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Phone: " + student.Phone);
            Console.WriteLine("Email: " + student.Email);
            Console.WriteLine("Class Name: " + student.Classname);
            Console.WriteLine("Note: " + student.Note);
            Console.WriteLine("Status: " + student.Status);
            Console.WriteLine("======================================");
            Console.WriteLine("1. Update Student Information");
            Console.WriteLine("2. Change Student Status");
            Console.WriteLine("3. Change Class");
            Console.WriteLine("4. Back to -> STUDENT LIST MANAGEMENT");
            Console.Write("YOUR CHOICE: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    update(student);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    return;

            }
        }

        public void update(Student st)
        {
            foreach (var item in list)
            {
                if (item.Studentid.Equals(st.Studentid))
                {
                    Console.WriteLine("First Name: ");
                    item.Firstname = Console.ReadLine();

                    Console.WriteLine("Middle Name: ");
                    item.Middlename = Console.ReadLine();

                    Console.WriteLine("Last Name: ");
                    item.Lastname = Console.ReadLine();

                    Console.WriteLine("Birthday: ");
                    item.Birthday = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Address: ");
                    item.Address = Console.ReadLine();

                    Console.WriteLine("Phone: ");
                    item.Phone = Console.ReadLine();

                    Console.WriteLine("Email: ");
                    item.Email = Console.ReadLine();

                    Console.WriteLine("Class Name: ");
                    item.Classname = Console.ReadLine();

                    Console.WriteLine("Note: ");
                    item.Note = Console.ReadLine();

                    Console.WriteLine("Status: ");
                    item.Status = Console.ReadLine();
                }
            }
        }

        // public Student input()
        // {
        //     Student student = new Student();
        //     Console.WriteLine("ID: ");
        //     student.Studentid(Console.ReadLine());
        //     Console.WriteLine("First Name: ");
        //     student.Firstname(Console.ReadLine());
        //     Console.WriteLine("Middle Name: ");
        //     student.Middlename(Console.ReadLine());
        //     Console.WriteLine("Last Name: ");
        //     student.Lastname(Console.ReadLine());
        //     Console.WriteLine("Birthday: ");
        //     student.Birthday(Console.ReadLine());
        //     Console.WriteLine("Address: ");
        //     student.Address(Console.ReadLine());
        //     Console.WriteLine("Phone: ");
        //     student.Phone(Console.ReadLine());
        //     Console.WriteLine("Email: ");
        //     student.Email(Console.ReadLine());
        //     Console.WriteLine("Note: ");
        //     student.Note(Console.ReadLine());
        //     return student;
        // }
        public void SearchStudent(Student st)

        {
            string name;
            int count = 0;
            Console.WriteLine("Input Name Search: ");
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("| No | Fullname                              ");
            Console.WriteLine("+-------------------------------------------+");
        }
    }

}
/*-- Lấy ra những Sản phẩm/ hàng hoá đang được bán (active)
select *
from Items
where Is_Active=1;

-- Lấy ra những khách hàng có tài khoản tại ngân hàng BIDV
select *
from Customers
where Bank like '%BIDV%';

-- Lấy ra những người bán hàng có địa chỉ tại Hà Nội
select *
from Sellers
where Address like '%Hà Nội%';

-- Lấy ra những hoá đơn có thuế VAT là 10%
select *
from Invoices
where round(VAT_Rate, 2) = 0.1;*/