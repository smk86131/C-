using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_lamda
{
    class Person
    {

        private string name_;

        public string getName() { return name_; }

        public void setName(string name) { name_ = name; }

        private string name;

        public string Name { get => name; set => name = value; }

        public string name2 { get; set; }

        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("드르르렁");
        }
    }

    
    
}
