using System;

namespace mdsumon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Variable Demo!");

            Console.WriteLine("From number of student : "+AiubStudent.numOfStudents); //0
            AiubStudent jibon = new AiubStudent("Jibon", 111, 'm');
            AiubStudent badsha = new AiubStudent("Badshe", 112, 'm');
            AiubStudent bithi = new AiubStudent("Bithi", 113, 'f');
            AiubStudent sadiq = new AiubStudent("Sadiq", 114, 'm');
            AiubStudent tamal = new AiubStudent("Tamal", 115, 'm');
            // AiubStudent abc = new AiubStudent("abc", 115, 'd');
            Console.WriteLine("To number of student : " + AiubStudent.numOfStudents); //6

            AiubStudent.uniName = "American international university -Bangladesh";
            jibon.displayDetails();
            badsha.displayDetails();
            bithi.displayDetails();
            sadiq.displayDetails();
            tamal.displayDetails();
            //abc.displayDetails();

            Console.ReadKey();
        }
    }

    class AiubStudent
    {
        public string name;
        public int id;
        public char gender;
        public static string uniName = "AIUB";
        public static int numOfStudents = 0;

        public AiubStudent(string name, int id, char gender)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            numOfStudents++;

        }

        public void displayDetails()
        {
            string malePrefix = "Mr.", femalePrefix = "Mrs "; // local variable

            if (this.gender == 'm' || this.gender == 'M')
            {
                Console.WriteLine("name = " + malePrefix + this.name + " id =" + this.id
                + " gender = " + this.gender + " uni = " + AiubStudent.uniName);
            }
            else if (this.gender == 'f' || this.gender == 'F')
            {
                Console.WriteLine("name = " + femalePrefix + this.name + " id =" + this.id
                + " gender = " + this.gender + " uni = " + AiubStudent.uniName);
            }
            else
            {
                Console.WriteLine("name = ( invalid prefix)" + this.name + " id =" + this.id
                + " gender = " + this.gender + " uni = " + AiubStudent.uniName);
            }
        }
    }
}
