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
 public   class Diary
    {

        public DataRow Dr { get; set; }
        private string id;
        public DateTime detef { get; set; }
        public DateTime detes { get; set; }
        
        
        private int mark;
        private double pricew;
        public int Kodyo { get; set; }
        public int Kodya { get; set; }

       
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (ValidateUtil.LegalId(value))
                    this.id = value;
                else
                    throw new Exception("טעות בת.ז");
            }
        }

       

     


       


        


        public int Mark
        {
            get
            {
                return this.mark;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.mark = value;
                else
                    throw new Exception("טעות בציון");
            }
        }

        public double Pricew
        {
            get
            {
                return this.pricew;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.pricew = value;
                else
                    throw new Exception("טעות במחיר");
            }
        }














        public Diary()
        {

        }
        public Diary(DataRow dr)
        {
            this.Dr = dr;
            this.Kodyo = Convert.ToInt32(dr["kodD"].ToString());
            this.id = dr["id"].ToString();
            this.Kodya = Convert.ToInt32(dr["kody"].ToString());
            this.mark = Convert.ToInt32(dr["mark"].ToString());
            this.detes = Convert.ToDateTime(dr["dates"].ToString());
            this.detef = Convert.ToDateTime(dr["datef"].ToString());
            this.pricew = Convert.ToDouble(dr["pricew"].ToString());

        }
        public void PutInto()
        {
            Dr["id"] = this.id;
            Dr["dates"] = this.detes;
            Dr["datef"] = this.detef;
            Dr["kodD"] = this.Kodyo;
            Dr["kody"] = this.Kodya;
            Dr["mark"] = this.mark;
            Dr["pricew"] = this.pricew;
        }
        public override string ToString()
        {
            return Kodya + "  " + pricew;

       }
        public Worker ThisWorker()
        {
            WorkerDB tbl = new WorkerDB();
            return tbl.Find(this.Id);


        }

        public DiamondWork ThisDiamondWork()
        {
            DiamondWorkDB tbl = new DiamondWorkDB();
            return tbl.Find(this.Kodya.ToString());


        }




    }
}





   

