using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelativityConnectTest
{
    public class CompareNameValueObjectByName : IComparer<NameValueObject>
    {
        public CompareNameValueObjectByName()
        {
        }
        //Implementing the Compare method
        public int Compare(NameValueObject object1, NameValueObject object2)
        {
            return string.Compare(object1.Name, object2.Name);
        }
    }
}
