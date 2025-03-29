using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaZH
{
    abstract class Document
    {
        private string title;
        public string Title { get { return title; } }

        public abstract void Print();
        protected Document(string title)
        {
            this.title = title;
        }

    }
}
