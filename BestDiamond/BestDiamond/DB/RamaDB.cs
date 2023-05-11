using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
    class RamaDB : GeneralDB
    {
        protected List<Rama> list = new List<Rama>();
        public RamaDB()
            : base("Rama")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Rama(dr));
            }
        }

        public List<Rama> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Rama Find(string code)
        {
            return this.GetList().Find(x => x.KodR == Convert.ToInt32(code));
        }
        public void DeleteRow(string code)
        {
            Rama rama = this.Find((code));
            if (rama != null)
            {

                rama.Dr.Delete();
                this.Update();
            }
        }

        public void UpdateRow(Rama r)
        {
            r.PutInto();
            this.Update();
        }
        public void AddNew(Rama r)
        {
            r.Dr = table.NewRow();
            r.PutInto();
            this.Add(r.Dr);
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;



            return this.GetList().Max(x => x.KodR) + 1;
        }


    }
}
