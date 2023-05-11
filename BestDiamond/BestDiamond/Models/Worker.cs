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
   public class Worker
    {
        public DataRow Dr { get; set; }
        private string id;
        private string lname;
        private string fname;
        private string pel;
        private int kodB;
        private int semel;
        private int numch;
        public int KodE { get; set; }

        public bool Status { get; set; }
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

        public string Fname
        {
            get
            {
                return this.fname;
            }

            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.fname = value;
                else
                    throw new Exception("טעות בשם פרטי");
            }
        }

        public string Lname
        {
            get
            {
                return this.lname;
            }

            set
            {
                if (ValidateUtil.IsHebrew(value))
                    this.lname = value;
                else
                    throw new Exception("טעות בשם משפחה");
            }
        }

        
        public string Pel
        {
            get
            {
                return this.pel;
            }

            set
            {
                if (ValidateUtil.IsCellPhone(value))
                    this.pel = value;
                else
                    throw new Exception("טעות בפלאפון");
            }
        }


        public int KodB
        {
            get
            {
                return this.kodB;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.kodB = value;
                else
                    throw new Exception("טעות בקוד");
            }
        }


        public int Semel
        {
            get
            {
                return this.semel;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.semel = value;
                else
                    throw new Exception("טעות בסמל");
            }
        }

        public int Numch
        {
            get
            {
                return this.numch;
            }

            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    this.numch = value;
                else
                    throw new Exception("טעות קוד");
            }
        }


        public Worker()
        {

        }
        public Worker(DataRow dr)
        {
            this.Dr = dr;
            this.id = dr["id"].ToString();
            this.lname = dr["lname"].ToString();
            this.fname = dr["fname"].ToString();
            this.pel = dr["pel"].ToString();
            this.kodB =Convert.ToInt32( dr["kodB"].ToString());
            this.semel = Convert.ToInt32(dr["semel"].ToString());
            this.KodE = Convert.ToInt32(dr["kodE"].ToString());
            this.numch = Convert.ToInt32(dr["numch"].ToString());
            if (dr["status"].Equals(true))
                this.Status = true;
            else
                this.Status = false;
        }
        public void PutInto()
        {
            Dr["id"] = this.id;
            Dr["lname"] = this.lname;
            Dr["fname"] = this.fname;
            Dr["pel"] = this.pel;
            Dr["status"] = this.Status;
            Dr["kodE"] = this.KodE;
            Dr["kodB"] = this.KodB;
            Dr["semel"] = this.semel;
            Dr["numch"] = this.numch;
        }
        public KindE ThisK()
        {
            KindEDB tbl = new KindEDB();
            return tbl.Find(this.KodE.ToString());


        }
        public override string ToString()
        {
            return id;
        }

        

    }
}
