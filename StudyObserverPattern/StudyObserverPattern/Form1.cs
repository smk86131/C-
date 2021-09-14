using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyObserverPattern
{
    public partial class Form1 : Form, ISubject
    {
        //Ilist 인터페이스가 적용되어있는객체리스트
        IList observers = new ArrayList();

        List<IObserver> obs = new List<IObserver>();

        Form2 frm2 = null;
        Form3 frm3 = null;
        Form4 frm4 = null;

        public Form1()
        {
            InitializeComponent();

            ArrayList example = new ArrayList();
            example.Add(1);
            example.Add("aaaa");

            frm2 = new Form2(this);
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;

            frm2 = new Form2(this);
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;

            frm2 = new Form2(this);
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
        }

        public void notify()
        {
            // throw new NotImplementedException();
        }

        public void register(IObserver o)
        {
            // throw new NotImplementedException();
            _observers.Add(o);
        }

        public void remove(IObserver o)
        {
            // throw new NotImplementedException();
        }
    }
}
