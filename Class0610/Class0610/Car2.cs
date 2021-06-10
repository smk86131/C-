using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610
{
    class Car2
    {
        //클래스 변수
        public const string JIJUM = "동대구 영업소";

        //인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;

        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }

        //매개변수
        public Car2(string company, string color, string price, string model)
        {
            this.company = company;
            this.color = color;
            this.price = price;
            this.model = model;
        }
    }
}
