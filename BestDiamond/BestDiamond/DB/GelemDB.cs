using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
    class GelemDB : GeneralDB
    {
        protected List<Gelem> list = new List<Gelem>();
        public GelemDB()
            : base("Gelem")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Gelem(dr));
            }
        }

        public List<Gelem> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Gelem Find(string code,string code1)
        {
            return this.GetList().Find(x => x.Kodbuy == Convert.ToInt32(code)&& x.KodGelem == Convert.ToInt32(code));
        }
        public void DeleteRow(string code,string code1)
        {
            Gelem gelem = this.Find(code, code1);
            if (gelem != null)
            {

                gelem.Dr.Delete();
                this.Update();
            }
        }

        public void UpdateRow(Gelem g)
        {
            g.PutInto();
            this.Update();
        }
        public void AddNew(Gelem g)
        {
            g.Dr = table.NewRow();
            g.PutInto();
            this.Add(g.Dr);
        }
        



    }
}
