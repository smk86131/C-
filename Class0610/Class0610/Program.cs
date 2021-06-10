using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.printCarInfo();

            Car car2 = new Car("현대", "은색", "G80", "6천만원");
            car2.setPrice("7천만원");
            car2.printCarInfo();
            Console.WriteLine("가격표 :" + car2.getPrice());

            Car2 car3 = new Car2("테슬라", "빨강", "1억2천", "모델S");
            car3.Price = "4천오백만원";
            Console.WriteLine("가격표: " + car3.Price);
            Console.WriteLine(car3.ToString());
        }

        
    }
}
