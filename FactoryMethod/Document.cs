using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public List<Page> Pages
        {
            get
            {
                return _pages;
            }
        }

        public Document()
        {
            CreatePages();
        }

        public abstract void CreatePages();
        
    }
}
