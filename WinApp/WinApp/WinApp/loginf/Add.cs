using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.loginf
{
    internal class Add
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public int invnumber { get; set; }
        public string objname { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public bool isAvailable { get; set; }    
        public static List <Add> add = new List<Add> ();
        public static Add findOne(string name)
        {
            return add.Find(i => i.objname == name);
        }

        

        public string save()

        {
            add.Add(this);
            return objname;
        }
        public static List<Add> get()
        {
            return add;
        }
    }
}
