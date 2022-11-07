using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment
{
    public class Detail
    {
        public static void Main(string[] args)
        {   string search;
            List<Student> detail= new List<Student>();
            detail.Add(new Student());
            detail[0].age=20;
            detail[0].name="amal";
            detail[0].department="science";

            detail.Add(new Student());
            detail[1].age=23;
            detail[1].name="Rohit";
            detail[1].department="commerce";

            detail.Add(new Student());
            detail[2].age=22;
            detail[2].name="Rahul";
            detail[2].department="Science";

            int flag=0;
            for(int i=0;i<detail.Count;i++)
            {
                System.Console.WriteLine(detail[i].getdata());
            }
            
            
        }
    }
}