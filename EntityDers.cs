using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
  public  class EntityDers
    {
        private string dersad;
        public string DERSAD
        {
            get { return dersad; }
            set { dersad = value; }
        }

        private int dersid;
        public int DERSID
        {
            get { return dersid; }
            set { dersid = value; }
        }

        private int min;
        public int MIN
        {
            get { return min; }
            set { min = value; }
        }

        private int max;
        public int MAX
        {
            get { return max; }
            set { max = value; }
        }
    }
}
