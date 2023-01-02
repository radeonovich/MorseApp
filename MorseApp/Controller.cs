using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseApp
{
    public class Controller
    {
        private Model model;
        private Form1 view;
        
        public Controller(Model model, Form1 view)
        {
            this.model = model;
            this.view = view;
        }
        
        public void Encode()
        {
            model.Encode();
        }

        public void Decode()
        {
            model.Decode();
        }

        public void OpenFile(string path)
        {
            model.OpenFile(path);
        }

        public void SaveFile(string path)
        {
            model.SaveFile(path);
        }
    }
}
