using BestDiamond.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDiamond.Models
{
  public  class Rama
    {
        private int kodR;
        private string teur;

        public int KodR
        {
            get
            {
                return this.kodR;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.kodR = value;
                else
                    throw new Exception("טעות בקוד");
            }
        }



        public string Teur
        {
            get
            {
                return this.teur;
            }

            set
            {
                if (ValidateUtil.IsHebrew(value.ToString()))
                    this.teur = value;
                else
                    throw new Exception("טעות בתאור");
            }
        }

        public DataRow Dr { get; set; }

        public Rama()
        {

        }
        public Rama(DataRow dr)
        {
            this.Dr = dr;
            this.kodR = Convert.ToInt32(dr["kodR"].ToString());
            this.teur = (dr["teur"].ToString());
          
        }
        public void PutInto()
        {

            Dr["teur"] = this.teur;
            Dr["kodR"] = this.kodR;
            

        }
        public override string ToString()
        {
            return  teur  ;
        }
    }
}


   



   