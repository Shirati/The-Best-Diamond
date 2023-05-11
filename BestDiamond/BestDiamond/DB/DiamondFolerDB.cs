using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
    class DiamondFolerDB : GeneralDB
    {
        protected List<DiamondFoler> list = new List<DiamondFoler>();
        public DiamondFolerDB()
            : base("DiamondFoler")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new DiamondFoler(dr));
            }
        }

        public List<DiamondFoler> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public DiamondFoler Find(string code)
        {
            return this.GetList().Find(x => x.Kodm == Convert.ToInt32(code));
        }
        public void DeleteRow(string code)
        {
            DiamondFoler diamondFoler = this.Find((code));
            if (diamondFoler != null)
            {

                diamondFoler.Dr.Delete();
                this.Update();
            }
        }

        public void UpdateRow(DiamondFoler d)
        {
            d.PutInto();
            this.Update();
        }
        public void AddNew(DiamondFoler d)
        {
            d.Dr = table.NewRow();
            d.PutInto();
            this.Add(d.Dr);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;



            return this.GetList().Max(x => x.Kodm) + 1;
        }



    }
}
