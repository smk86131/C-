using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_and_lamda
{
    public partial class Form1 : Form
    {
        public delegate void TempFunc();
        public Form1()
        {
            InitializeComponent();
            button1.Click -= button1_Click;
            button1.Click += button1_Click;

            button1.Click += (object s, EventArgs e) =>
              {
                  MessageBox.Show("메시지박스너무지겹다");
              };
           
        }

        public void myFunc()
        {
            MessageBox.Show("Test");
        }
        public void iteratorFunction(TempFunc t, int count)
        {
            for (int i = 0; i < count; i++)
                t();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = "온창민";
            MessageBox.Show(p.Name);
            p.Sleep();

            Student s = new Student();
            s.Name = "이동준";
            s.Sleep();
            s.study();

            TempFunc ttt = myFunc;
            iteratorFunction(ttt, 3);

            TempFunc ttt2 = () => { MessageBox.Show("aaa"); };
            iteratorFunction(ttt2, 3);

            iteratorFunction(() => { MessageBox.Show("lamda"); }, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < 50; i++)
                    Console.Write("A");

            });
            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 50; i++)
                    Console.Write("B");
            });

            t1.Start();
            t2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Form2().Show(); //뒤에꺼 선택가능:모달리스(Modaless)

            //Modal(모달)
            new Form2().ShowDialog(); //Message Box처럼 뒤에거선택x
        }
    }
}
