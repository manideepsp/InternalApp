using System;

namespace DataLayer
{
    public class DataFactory
    {
        public DALAuthentication CreateObject()
        {
            DALAuthentication obj = new DALAuthentication();
            return obj;
        }
    }
}
