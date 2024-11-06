using Mishnat.DTO;
using Mishnat.entities;

namespace Mishnat.Service
{
    public class SellingService
    {
       
        private static int id = 1;
        public List<Selling> GetSellings() { return DataContextManager.Manager.Sellings; }

        public Selling GetSellingById(int sellingId)
        {
            if (DataContextManager.Manager.Sellings == null) { return null; }
            return DataContextManager.Manager.Sellings.Where(s => s.SellingId==sellingId).FirstOrDefault<Selling>();
        }
        public bool UpdateSellingById(int sellingId, Selling selling )
        {
            if (DataContextManager.Manager.Sellings == null) { return false; }
            Selling s = DataContextManager.Manager.Sellings.Find(s => s.SellingId==sellingId);
            if (s == null) { return false; }
            s.Parasha = selling.Parasha;
            s.Products = selling.Products;
            s.Date=s.Date;
            return true;
        }
        public bool AddSelling(Selling selling)
        {
            if(DataContextManager.Manager.Sellings == null) { return false; }
            selling.SellingId = id++;
            DataContextManager.Manager.Sellings.Add(selling);
            return true;
        }
        public bool DeleteSelling(int sellingId)
        {
            if (DataContextManager.Manager.Sellings == null) { return false; }
            Selling s = DataContextManager.Manager.Sellings.Find(s => s.SellingId==sellingId);
            if (s == null) { return false; }
            DataContextManager.Manager.Sellings.Remove(s);
            return true;
        }
    }
}
