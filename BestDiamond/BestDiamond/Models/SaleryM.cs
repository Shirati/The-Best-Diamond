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
  public  class SaleryM
    {
        private int kodMonth;
        public DataRow Dr { get; set; }
        public String Id { get; set; }

        private int scumA;
        private int monthD;
        private int yearD;
        private double pricesuch;

        public int ScumA
        {
            get
            {
                return this.scumA;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.monthD = value;
                else
                    throw new Exception("טעות סכום");
            }
        }

        public int MonthD
        {
            get
            {
                return this.monthD;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.monthD = value;
                else
                    throw new Exception("טעות בחודש");
            }
        }


        public int YearD
        {
            get
            {
                return this.yearD;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.yearD = value;
                else
                    throw new Exception("טעות בחודש");
            }
        }

        public double Pricesuch
        {
            get
            {
                return this.pricesuch;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.pricesuch = value;
                else
                    throw new Exception("טעות במחיר");
            }
        }

        public int KodMonth
        {
            get
            {
                return this.kodMonth;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.kodMonth = value;
                else
                    throw new Exception("טעות בקוד");
            }
        }

        


        public SaleryM()
        {

        }
        public SaleryM(DataRow dr)
        {
            this.Dr = dr;
            this.Id = dr["id"].ToString();
            this.monthD = Convert.ToInt32(dr["monthD"].ToString());
            this.yearD = Convert.ToInt32(dr["yearD"].ToString());
            this.KodMonth = Convert.ToInt32(dr["Kods1"].ToString());
            //this.pricesuch =Convert.ToDouble(dr["Pricesum"].ToString());
            this.scumA = Convert.ToInt32(dr["scumA"].ToString());
        }
        public void PutInto()
        {
            Dr["id"] = this.Id;
            Dr["scumA"] = this.scumA;
            Dr["kods1"] = this.kodMonth;
            Dr["monthD"] = this.monthD;
            Dr["yearD"] = this.yearD;
            Dr["pricesuch"] = this.pricesuch;
        }
        public override string ToString()
        {
            return scumA + "  " + pricesuch;
        }

        public Worker ThisWorker()
        {
            WorkerDB tbl = new WorkerDB();
            return tbl.Find(this.Id);


        }

    }
}






    