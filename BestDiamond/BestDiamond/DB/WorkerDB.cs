using BestDiamond.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestDiamond.DB
{
    class WorkerDB : GeneralDB
    {
        protected List<Worker> list = new List<Worker>();
        public WorkerDB()
            : base("Worker")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Worker(dr));
            }
        }

        public List<Worker> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Worker Find(string code)
        {
            return this.GetList().Find(x => x.Id == code);
        }
        public void DeleteRow(string code)
        {
            Worker worker = this.Find(code);
            if (worker != null)
            {

                worker.Dr.Delete();
                this.Update();
            }
        }
        public void DeleteStatus(string code)
        {
            Worker worker = this.Find(code);
            if (worker != null)
            {
                worker.Status = false;
                this.UpdateRow(worker);
            }
        }
        public void UpdateRow(Worker w)
        {
            w.PutInto();
            this.Update();
        }
        public void AddNew(Worker w)
        {
            w.Dr = table.NewRow();
            w.PutInto();
            this.Add(w.Dr);
        }

        
    
}
}
