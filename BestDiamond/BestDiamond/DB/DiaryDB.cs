using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
   class DiaryDB : GeneralDB
    {
        protected List<Diary> list = new List<Diary>();
        public DiaryDB()
            : base("Diary")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Diary(dr));
            }
        }

        public List<Diary> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Diary Find(string code)
        {
            return this.GetList().Find(x => x.Kodya ==Convert.ToInt32 (code));
        }
        public void DeleteRow(string code)
        {
            Diary diary = this.Find((code));
            if (diary != null)
            {

                diary.Dr.Delete();
                this.Update();
            }
        }
      
        public void UpdateRow(Diary d)
        {
            d.PutInto();
            this.Update();
        }
        public void AddNew(Diary d)
        {
            d.Dr = table.NewRow();
           d.PutInto();
            this.Add(d.Dr);
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;



            return this.GetList().Max(x => x.Kodyo) + 1;
        }





    }
}
