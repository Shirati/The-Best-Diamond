using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
    class SaleryMDB : GeneralDB
    {
        protected List<SaleryM> list = new List<SaleryM>();
        public SaleryMDB()
            : base("SaleryM")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new SaleryM(dr));
            }
        }

        public List<SaleryM> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public SaleryM Find(string code)
        {
            return this.GetList().Find(x => x.KodMonth == Convert.ToInt32(code));
        }
        public void DeleteRow(string code)
        {
            SaleryM saleryM = this.Find((code));
            if (saleryM != null)
            {

                saleryM.Dr.Delete();
                this.Update();
            }
        }

        public void UpdateRow(SaleryM s)
        {
            s.PutInto();
            this.Update();
        }
        public void AddNew(SaleryM s)
        {
            s.Dr = table.NewRow();
            s.PutInto();
            this.Add(s.Dr);
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.KodMonth) + 1;
        }


    }
}
