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
  public  class Gelem
    {
       
        public DataRow Dr { get; set; }
       
        private int kodbuy;
        public int KodGelem { get; set; }
        private int mishkal;
        private int kodRama;
        private int camut;
        private double pricesuch;
        private string color;
        public bool Pack { get; set; }
        



        public int Kodbuy
        {
            get
            {
                return this.kodbuy;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.kodbuy = value;
                else
                    throw new Exception("טעות בקוד");
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

        public int KodRama
        {
            get
            {
                return this.kodRama;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.kodRama = value;
                else
                    throw new Exception("טעות בקוד");
            }
        }

        public int Mishkal
        {
            get
            {
                return this.mishkal;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.mishkal = value;
                else
                    throw new Exception("טעות במשקל");
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
                    throw new Exception("טעות בכמות");
            }
        }

       


        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.color = value;
                else
                    throw new Exception("טעות בצבע");
            }
        }

        


        public Gelem()
        {

        }
        public Gelem(DataRow dr)
        {
            this.Dr = dr;
            this.color = dr["color"].ToString();
            this.Pack = dr["pack"].Equals(true);
            this.KodGelem = Convert.ToInt32(dr["kodGelem"].ToString());
            this.kodbuy = Convert.ToInt32(dr["kodbuy"].ToString());
            this.kodRama = Convert.ToInt32(dr["kodRama"].ToString());
            this.pricesuch = Convert.ToDouble(dr["pricesuch"].ToString());
            this.camut = Convert.ToInt32(dr["camut"].ToString());
            this.mishkal = Convert.ToInt32(dr["mishkal"].ToString());
           
        }
        public void PutInto()
        {
            Dr["camut"] = this.camut;
            Dr["color"] = this.color;
            Dr["kodbuy"] = this.kodbuy;
            Dr["kodGelem"] = this.KodGelem;
            Dr["kodRama"] = this.kodRama;
            Dr["pricesuch"] = this.pricesuch;
            Dr["mishkal"] = this.mishkal;
            Dr["pack"] = this.Pack;
           
        }
        public override string ToString()
        {
            return camut + "  " + pricesuch;
        }
        public Rama ThisRama()
        {
            RamaDB tbl = new RamaDB();
            return tbl.Find((this.kodRama.ToString()));


        }
        public Buy ThisBuy()
        {
            BuyDB tbl = new BuyDB();
            return tbl.Find((this.Kodbuy.ToString()));


        }
    }
}



   