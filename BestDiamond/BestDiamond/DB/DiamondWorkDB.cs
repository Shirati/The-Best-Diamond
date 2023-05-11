using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
    class DiamondWorkDB : GeneralDB
    {
        protected List<DiamondWork> list = new List<DiamondWork>();
        public DiamondWorkDB()
            : base("DiamondWork")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new DiamondWork(dr));
            }
        }

        public List<DiamondWork> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public DiamondWork Find(string code)
        {
            return this.GetList().Find(x => x.Kodya == Convert.ToInt32(code));
        }
        public void DeleteRow(string code)
        {
            DiamondWork diamondWork = this.Find((code));
            if (diamondWork != null)
            {

                diamondWork.Dr.Delete();
                this.Update();
            }
        }

        public void UpdateRow(DiamondWork d)
        {
            d.PutInto();
            this.Update();
        }
        public void AddNew(DiamondWork d)
        {
            d.Dr = table.NewRow();
            d.PutInto();
            this.Add(d.Dr);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;



            return this.GetList().Max(x => x.Kodya) + 1;
        }



    }
}
