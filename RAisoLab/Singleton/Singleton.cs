using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Singleton
{
    public class Singleton
    {
        private Singleton() { }
        private static RAisoDatabaseEntities1 db = null;

        public static RAisoDatabaseEntities1 getInstance()
        {
            if (db == null)
            {
                db = new RAisoDatabaseEntities1();
            }
            return db;
        }
    }
}