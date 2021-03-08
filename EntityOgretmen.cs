using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private string ogrtadsoyad;

        public string OGRTADSOYAD
        {
            get { return ogrtadsoyad; }
            set { ogrtadsoyad = value; }
        }

        private int ogrtid;

        public int OGRTID
        {
            get { return ogrtid; }
            set { ogrtid = value; } 
        }

        private int ogrtbrans;

        public int OGRTBRANS
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }

    }
}
