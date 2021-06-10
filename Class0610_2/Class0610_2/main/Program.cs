using Class0610_2.model;
using Class0610_2.util;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610_2.main
{
    class Program
    {
        static void Main(string[] args)
        {
            RandData rand = new RandData();
            Student[] st = new Student[10];
            st[0] = new Student(
                rand.getName(),
                rand.getAge(),
                rand.getGender(),
                rand.getAddress());
            Console.WriteLine(st[0].ToString());


            for (int i = 0; i < 10; i++)
            {
                st[i] = new Student(
                    rand.getName(),
                    rand.getAge(),
                    rand.getGender(),
                    rand.getAddress());
                Console.WriteLine(st[i].ToString());

            }

            
        }
    }
}
