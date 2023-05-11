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
  public  class DiamondFoler
    {
        public DataRow Dr { get; set; }

        private int kodm;
        public int Kodya { get; set; }
        public DateTime DateGo { get; set; }
        public DateTime DateBack { get; set; }
        public string Id { get; set; }
        private int level;


        public int Kodm
        {
            get
            {
                return this.kodm;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.kodm = value;
                else
                    throw new Exception("טעות בקוד");
            }
        }



        public int Level
        {
            get
            {
                return this.level;
            }

            set
            {
                
                    this.level = value;
                
            }
        }

        
        public DiamondFoler()
        {

        }
        public DiamondFoler(DataRow dr)
        {
            this.Dr = dr;
            this.kodm = Convert.ToInt32(dr["kodm"].ToString());
            this.Kodya= Convert.ToInt32(dr["kody"].ToString());
            this.Id = (dr["id"].ToString());
            this.level = Convert.ToInt32(dr["levelYa"].ToString());
            this.DateGo = Convert.ToDateTime(dr["DateGo"].ToString());
            this.DateBack = Convert.ToDateTime(dr["Datecome"].ToString());
        }
        public void PutInto()
        {

            Dr["kody"] = this.Kodya;
            Dr["kodm"] = this.kodm;
            Dr["levelYa"] = this.level;
            Dr["DateGo"] = this.DateGo;
            Dr["Datecome"] = this.DateBack;
            Dr["Id"] = this.Id;
        }
        public override string ToString()
        {
            return kodm.ToString() ;
        }

        public DiamondWork ThisDiamondWork()
        {
            DiamondWorkDB tbl = new DiamondWorkDB();
            return tbl.Find((this.Kodya.ToString()));


        }
        public KindE ThisLevel()
        {
            KindEDB tbl = new KindEDB();
            return tbl.Find((this.level.ToString()));


        }
        public Worker ThisWorker()
        {
            WorkerDB tbl = new WorkerDB();
            return tbl.Find((this.Id));


        }
    }
}


   







    