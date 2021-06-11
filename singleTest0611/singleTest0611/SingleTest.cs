using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTest0611
{
    class SingleTest
    {
        private static SingleTest inst;
        private int data;
        //static Random r = new Random(); //메인에서 랜덤쓸때

        public SingleTest(Random r) //생성자의 매개변수
        {
            data = r.Next(1, 100);
        }

        public int getData() //int=인스턴스매서드
        {
            return data;
        }

        public static SingleTest getInst(Random r) //static=클래스매서드
        {
            if (inst == null)
            {
                inst = new SingleTest(r);
            }
            return inst;
        }
    }
}
