using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Factory
    {
        public string createProduct(String product)
        {
            PhoneConcreteProduct phone = new PhoneConcreteProduct();
            if (product == "Note8")
            { //Creates the product Note8
                phone.createNote8();
            }
            if (product == "iPhone 7")
            { //Creates the product IPhone 7
                phone.createIPhone7();
            }
            if (product == "Priv")
            { //Creates the product BlackBerry Priv
                phone.createPriv();
            }
            //Returns the string to be displayed to the user
            return "Brand: " + phone.getBrand() + "\nCPU: " + phone.getCPU() + "\nGPU: " + phone.getGPU() + "\nOS: " + phone.getOS() + "\n";
        }
    }
}
