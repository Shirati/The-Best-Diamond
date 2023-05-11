using BestDiamond.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDiamond.Models
{
 public   class KindE
    {
        private int kodE;
        public DataRow Dr { get; set; }
        private string teur;
        private double firsprice;
        private string part;



        public int KodE
        {
            get
            {
                return this.kodE;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.kodE = value;
                else
                    throw new Exception("טעות בקוד");
            }
        }


       
        public double FirstPrice
        {
            get
            {
                return this.firsprice;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.firsprice = value;
                else
                    throw new Exception("טעות במחיר");
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
        public string Part
        {
            get
            {
                return this.part;
            }

            set
            {
                if (ValidateUtil.IsHebrew(value.ToString()))
                    this.part = value;
                else
                    throw new Exception("טעות בחלק");
            }
        }










        public KindE()
        {

        }
        public KindE(DataRow dr)
        {
            this.Dr = dr;
            this.kodE = Convert.ToInt32(dr["kodE"].ToString());
            this.teur =(dr["teur"].ToString());
            this.firsprice = Convert.ToDouble(dr["firstprice"].ToString());
            this.part = (dr["part"].ToString());
        }
        public void PutInto()
        {
           
            Dr["kodE"] = this.kodE;
            Dr["teur"] = this.teur;
            Dr["firstprice"] = this.firsprice;
            Dr["part"] = this.part;
           
        }
        public override string ToString()
        {
            return teur+" "+kodE  ;
        }
    }
}






   