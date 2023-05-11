using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
    class BuyDB : GeneralDB
    {
        protected List<Buy> list = new List<Buy>();
        public BuyDB()
            : base("Buy")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Buy(dr));
            }
        }

        public List<Buy> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Buy Find(string code)
        {
            return this.GetList().Find(x => x.Kodbuy == Convert.ToInt32(code));
        }
        public void DeleteRow(string code)
        {
            Buy buy = this.Find((code));
            if (buy != null)
            {

                buy.Dr.Delete();
                this.Update();
            }
        }

        public void UpdateRow(Buy b)
        {
            b.PutInto();
            this.Update();
        }
        public void AddNew(Buy b)
        {
            b.Dr = table.NewRow();
b.PutInto();
            this.Add(b.Dr);
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;



            return this.GetList().Max(x => x.Kodbuy) + 1;
        }

    }
}
