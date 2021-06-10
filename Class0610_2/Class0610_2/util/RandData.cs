using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610_2.util
{
    class RandData
    {
        static string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" }; //static 클래스변수 빼면 인스턴스변수
        static int[] age = { 20, 25, 30, 40, 50 };
        static char[] gender = { '남', '여' };
        static string[] address = { "대구시 동구 신천3동", "서울시 동구 신청3동", "부산시 동구 신청3동", "대전시 동구 신천3동", "광주시 동구 신천3동" };
        Random r = new Random();

        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public int getAge()
        {
            return age[r.Next(0, 5)];
        }

        public char getGender()
        {
            return gender[r.Next(0, 2)];
        }

        public string getAddress()
        {
            return address[r.Next(0, 5)];
        }

        public void showStudentInfo()
        {
            Console.WriteLine("이름" + name, "나이", "성별" + age, "주소" + address);
        }


    }
}
