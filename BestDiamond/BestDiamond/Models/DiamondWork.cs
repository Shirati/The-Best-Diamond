using BestDiamond.DB;
using BestDiamond.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDiamond.Models
{
   public class DiamondWork
    {
        public DataRow Dr { get; set; }

        private int kodya;
        public int Kodbuy { get; set; }
        public DateTime Datef { get; set; }
        public DateTime Dates { get; set; }
        public int KodGelem { get; set; }
        private int camut;


        public int Kodya
        {
            get
            {
                return this.kodya;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.kodya = value;
                else
                    throw new Exception("טעות בקוד");
            }
        }



        public int Camut
        {
            get
            {
                return this.camut;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.camut = value;
                else
                    throw new Exception("טעות כמות");
            }
        }

      

        public DiamondWork()
        {

        }
        public DiamondWork(DataRow dr)
        {
            this.Dr = dr;
            this.Kodbuy = Convert.ToInt32(dr["Kodbuy"].ToString());
            this.kodya = Convert.ToInt32(dr["kody"].ToString());
            this.camut = Convert.ToInt32(dr["camut"].ToString());
            this.KodGelem = Convert.ToInt32(dr["KodGelem"].ToString());
            this.Datef = Convert.ToDateTime(dr["Datef"].ToString());
            this.Dates = Convert.ToDateTime(dr["Dates"].ToString());
        }
        public void PutInto()
        {

            Dr["kody"] = this.kodya;
            Dr["KodGelem"] = this.KodGelem;
            Dr["Kodbuy"] = this.Kodbuy;
            Dr["Datef"] = this.Datef;
            Dr["Dates"] = this.Dates;
            Dr["camut"] = this.camut;
        }
        public override string ToString()
        {
            return kodya + "  " + camut + "  " ;
        }
        public Gelem ThisGelem()
        {
            GelemDB tbl = new GelemDB();
            return tbl.Find((this.Kodbuy.ToString()),this.KodGelem.ToString());


        }





    }
}


   



    