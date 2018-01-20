using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructors
{
    public class Text
    {
        public string Message;

        public Text(string text)
        {
             this.Message = text;    
        }

        public void SendBackMessage()
        {
            Form1 form = new Form1(Message);

        }
    }
}


