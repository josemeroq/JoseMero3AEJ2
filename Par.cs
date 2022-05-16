using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ2
{
    public class Par
    {
        private int num { set; get; }

        public Par(int num)
        {
            this.num = num;
        }

        public void proceso()
        {
            if(num % 2 == 0)
            {
                Console.WriteLine("El número " + num + " es par ");
            }
            else
            {
                Console.WriteLine("El número " + num + " no es par ");
            }
            Console.ReadKey();
        }
    }
    

}
