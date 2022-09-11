using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class MainClass
    {

        
        Deneme2 _myInterfacee = new Deneme2();


        MyInterface _myInterface;
        public MainClass(MyInterface value)
        {
            _myInterface = value;
        }


       



        void testMethod()
        {
            _myInterface.testFunct();
            _ = _myInterfacee.testıd;
        }
    }
}
