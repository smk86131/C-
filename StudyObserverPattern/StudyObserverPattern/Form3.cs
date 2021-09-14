using System;
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
    public partial class Form3 : Form, IObserver
    {
        public Form3(ISubject sub, Form2 frm2, Frorm)
        {
            sub.register
            InitializeComponent();
        }

        public void update(string value)
        {
            // throw new NotImplementedException();
        }
    }
}
