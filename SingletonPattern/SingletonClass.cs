using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonClass
    {
        private static SingletonClass _singletonobject;
        private SingletonClass()
        {

        }

        public static SingletonClass CreateObject()
        {
            if(_singletonobject == null)
            {
                _singletonobject = new SingletonClass();
            }

            return _singletonobject;
        }
    }
}
