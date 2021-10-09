using System;

namespace asm
{
    public class Student
    {
        private string studentid;
        private string firstname;
        private string middlename;
        private string lastname;
        private int birthday;
        private string address;
        private string phone;
        private string email;
        private string classname;
        private string note;
        private string status;

        public Student(string studentid, string firstname, string middlename, string lastname, int birthday, string address, string phone, string email, string classname, string note, string status)
        {
            this.studentid = studentid;
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.birthday = birthday;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.classname = classname;
            this.note = note;
            this.status = status;
        }

        public Student()
        {
            
        }
        public string Studentid
        {
            get
            {
                return this.studentid;
            }
            set
            {
                this.studentid = value;
            }
        }
        public string Firstname
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }
        }
        public string Middlename
        {
            get
            {
                return this.middlename;
            }
            set
            {
                this.middlename = value;
            }
        }
        public string Lastname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }
        public int Birthday
        {
            get
            {
                return this.birthday;
            }
            set
            {
                this.birthday = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Classname
        {
            get
            {
                return this.classname;
            }
            set
            {
                this.classname = value;
            }
        }
        public string Note
        {
            get
            {
                return this.note;
            }
            set
            {
                this.note = value;
            }
        }
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
        //override ToString() method 
        public override string ToString()
        {
            string info = this.studentid + "-" + this.firstname + "-" + this.middlename + "-" + this.lastname + "-" + this.birthday + "-" + this.address + "-" + this.phone + "-" + this.email + "-" + this.note + "-" + this.status;
            return info;
        }
    }
}