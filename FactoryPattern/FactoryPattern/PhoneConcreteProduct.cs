using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class PhoneConcreteProduct : PhoneProduct
    {
        public string getBrand()
        {
            return brand;
        }

        public string getCPU()
        {
            return cpu;
        }

        public string getGPU()
        {
            return gpu;
        }

        public string getOS()
        {
            return os;
        }
        public void createNote8()
        { //Creates the product Note8
            brand = "Samsung";
            cpu = "Snapdragon 835";
            gpu = "Adreno 540";
            os = "Android 7.1.1 Nougat";
        }
        public void createIPhone7()
        { //Creates the product IPhone 7
            brand = "Apple";
            cpu = "A10 Fusion";
            gpu = "A10 Fusion";
            os = "iOS 10";
        }
        public void createPriv()
        { //Creates the product BlackBerry Priv
            brand = "BlackBerry";
            cpu = "Snapdragon 808";
            gpu = "Adreno 418";
            os = "Android 5.1.1 Lollipop";
        }
    }
}
