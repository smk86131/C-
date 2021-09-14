using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_lamda
{
    class Student : Person
    {

     
            public string hakbeon { get; set; }

            public void study()
            {
                System.Windows.Forms.MessageBox.Show("공부하는중...");
            }
        }
    
}
