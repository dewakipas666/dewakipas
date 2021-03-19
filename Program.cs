using System;


namespace tugas1
{



    public class Program
    {
        public int id;
        public string name;
        public string pic;
        public string gender;
        public int status;
        public string supplier;


        public void Index(int id, string name, string pic, string gender, int status, string supplier)
        //public void index()
        {
            this.id = id;
            this.name = name;
            this.pic = pic;
            this.gender = gender;
            this.status = status;
            this.supplier = supplier;


        }
        public void Info()
        {
            Console.Write("Masukan ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Nama : ");
            name = Console.ReadLine();
            Console.Write("Masukan Pic : ");
            pic = Console.ReadLine();
            Console.Write("Masukan Jenis Kelamin : ");
            gender = Console.ReadLine();
            Console.Write("Masukan Status : ");
            //bool status = Convert.ToBoolean(Console.ReadLine());
            status = Convert.ToInt32(Console.ReadLine());

           supplier = id + "\n" + name + "\n" + pic + "\n" + gender + "\n";
            Console.Write(supplier);
            //Console.WriteLine(supplier);
        }
        public void Plafon()
        {
            if (status > 0)
            {

            }
            else { }

        }
        public void Main(string[] args)
        {
            Info();
            Console.WriteLine("\n");
            Plafon();

        }

    }
}
