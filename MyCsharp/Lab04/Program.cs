using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab04
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Employee() { }
        public Employee(int id , string name , string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        public string viewEmployee()
        {
            return Id + " " + Name + " " + Address;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {   //khoi tao cach 1 : khong co gia tri , tu them gia tri
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Huy";
            employee.Address = "Ha Noi";
            // khoi tao cach 2 : co gia tri 
            Employee employee1 = new Employee(2, "Ha", "Lai Chau");
            Console.WriteLine(employee.viewEmployee());
            Console.WriteLine(employee1.viewEmployee());

        }
    }
    public class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList1 = new ArrayList();
            //Dung ham Add de them cac phan tu vao array
            //Them cac phan tu vao arrayList
            arrayList.Add("i Mac");
            arrayList.Add("i Phone");

            //Them cac phan tu vao arrayList1
            arrayList1.Add("B Mac");
            arrayList1.Add("B Phone");

            //Dua danh sach arrayList1 vao arrayList
            arrayList.AddRange(arrayList1);

            arrayList.Insert(3, "C Phone"); //ham .Insert chen phan tu "C Phone" vao vi tri thu 3 tinh tu arrayList[0] 
            
            //Duyet cac phan tu trong array bang for
            for(int i = 0; i < arrayList.Count; i++) //Ham .Count la ham dem
            {
                Console.WriteLine(arrayList[i]);
            }

            //-------------------------------------

            //Boxing and unboxing 
            int valueToBox = 123;
            object boxed = valueToBox; // chuyen du lieu tu kieu int -> object goi la Boxing

            int valueOutOfBox = (int)boxed; // chuyen tu object -> int goi la unboxing

            //----------------------------------------

            //iCollection.CopyTo

            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add("Huy");
            arrayList2.Add("Ha");

            //Remove - xoa 

            arrayList2.Remove("Huy"); // dung ham .Remove de xoa 1 phan tu trong arraylist2 theo "Ten"
            arrayList2.RemoveAt(0); // dung ham .RemoveAt de xoa 1 phan tu trong arraylist2 theo vi tri 0

            //Tim kiem , kiem tra 
            arrayList2.Contains("Ha");//tim trong arraylist2 co "Ha" hay khong , neu co tra ve true

            //Ung dung ham de tim kiem 
            bool check = arrayList2.Contains("Huy");
            if(check == true) { Console.WriteLine("Tim thay!"); }
            else { Console.WriteLine("Khong tim thay!"); }
            //---------------------------------------

            //IDictionary

            Hashtable employee = new Hashtable();
            //Add key and values vao employee
            employee.Add("A", "Anh");
            employee.Add("B", "Bao");
            employee.Add("C", "Chill");
            employee.Add("D", "Dung");
            employee.Add("H", "Huy");

            //tao keys va values chua cac key va values cua employee bang ICollection
            ICollection keys = employee.Keys;
            ICollection values = employee.Values;

            //Duyet key and value

            foreach (object key in keys)
            {
                Console.WriteLine(key);
            }

            foreach (object value in values)
            {
                Console.WriteLine(value);
            }
            //-------------------------------------------


            //SortedList

            
            SortedList<string,string> User = new SortedList<string,string>();// khoi tao SortedList kieu binh thuong
            User.Add("a", "anh");
            User.Add("b", "bac");
            User.Add("h", "huy");
            User.Add("c", "chiu");

            foreach(KeyValuePair<string,string> Users in User)
            {
                Console.WriteLine(Users);
            }

            SortedList sortedListkhongphanbietchuviet = new SortedList(new CaseInsensitiveComparer());// khoi tao sortedList khong phan biet viet hoa, viet thuong

            //dung sortedList ho tro hashtable sap xep

            Hashtable hashtable = new Hashtable();
            SortedList hotrohashTablesapxep = new SortedList(hashtable, new CaseInsensitiveComparer());








            //---------------------------------------
            string[] student = new string[2];
            arrayList2.CopyTo(student, 0); // dung ham .CopyTo de gan cac phan tu cua arrayList vao mang student,bat dau tu 0


            //dung foreach de duyet cac phan tu trong mang 
            foreach (string name in student)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(arrayList2.Count);//Dung ham .Count de dem cac phan tu trong arraylist
            //---------------------------------------------------

            
            
        }
    }
}
