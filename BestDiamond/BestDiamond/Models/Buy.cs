using BestDiamond.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDiamond.Models
{
 public   class Buy
    {
        public int Kodbuy { get; set; }
        public DataRow Dr { get; set; }
        public DateTime Dateb { get; set; }
       
        private double sumpf;



       



       

        public double Sumpf
        {
            get
            {
                return this.sumpf;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.sumpf = value;
                else
                    throw new Exception("טעות בסכום");
            }
        }
       
        


        public Buy()
        {

        }
        public Buy(DataRow dr)
        {
            this.Dr = dr;
            this.Kodbuy = Convert.ToInt32(dr["kodbuy"].ToString());
           
            this.sumpf = Convert.ToDouble(dr["sumpf"].ToString());
            this.Dateb = Convert.ToDateTime(dr["Dateb"].ToString());
        }
        public void PutInto()
        {

            Dr["Kodbuy"] = this.Kodbuy;
           
            Dr["Sumpf"] = this.Sumpf;
            Dr["Dateb"] = this.Dateb;

        }
        public override string ToString()
        {
            return Sumpf + "  " + Dateb + "  " +Kodbuy;
        }
    }
}


   