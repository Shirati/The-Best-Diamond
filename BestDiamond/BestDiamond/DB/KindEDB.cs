using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
    class KindEDB : GeneralDB
    {
        protected List<KindE> list = new List<KindE>();
        public KindEDB()
            : base("KindE")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new KindE(dr));
            }
        }

        public List<KindE> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public KindE Find(string code)
        {
            return this.GetList().Find(x => x.KodE == Convert.ToInt32(code));
        }
        public void DeleteRow(string code)
        {
            KindE kindE = this.Find((code));
            if (kindE != null)
            {

                kindE.Dr.Delete();
                this.Update();
            }
        }

        public void UpdateRow(KindE k)
        {
            k.PutInto();
            this.Update();
        }
        public void AddNew(KindE k)
        {
            k.Dr = table.NewRow();
           k.PutInto();
            this.Add(k.Dr);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;



            return this.GetList().Max(x => x.KodE) + 1;
        }



    }
}
