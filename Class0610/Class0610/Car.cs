using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610
{
    class Car
    {
        //클래스 변수
        public const string JIJUM = "동대구 영업소";

        //인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;

        //기본생성자
        public Car() 
        {
            company = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";
        }

        public Car(string company, string color, string model, string price) //매개변수
        {
            this.company = company; //인스턴스변수 충돌방지 this 객체가 생성되는시점에 주소값
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public void printCarInfo()
        {
            Console.WriteLine("제조사: " + company);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);

        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setPrice(string price)
        {
            this.price = price;
        }

        public string getModel()
        {
            return model;
        }

        public string getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            string str = "제조사: " + company + "\n";
            str += "색상" + color + "\n";
            str += "모델" + model + "\n";
            str += "가격" + price + "\n";

            return str;
        }

    }
}
