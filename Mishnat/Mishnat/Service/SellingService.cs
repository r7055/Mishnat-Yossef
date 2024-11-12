using Mishnat.DTO;
using Mishnat.entities;

namespace Mishnat.Service
{
    public class SellingService
    {
       
        private static int id = 1;
        public List<Selling> GetSellings() { return DataContext.Sellings; }

        public Selling GetSellingById(int sellingId)
        {
            if (DataContext.Sellings == null) { return null; }
            return DataContext.Sellings.Where(s => s.SellingId==sellingId).FirstOrDefault<Selling>();
        }
        public bool UpdateSellingById(int sellingId, Selling selling )
        {
            if (DataContext.Sellings == null) { return false; }
            Selling s = DataContext.Sellings.Find(s => s.SellingId==sellingId);
            if (s == null) { return false; }
            s.Parasha = selling.Parasha;
            s.Products = selling.Products;
            s.Date=s.Date;
            return true;
        }
        public bool AddSelling(Selling selling)
        {
            if(DataContext.Sellings == null) { return false; }
            selling.SellingId = id++;
            DataContext.Sellings.Add(selling);
            return true;
        }
        public bool DeleteSelling(int sellingId)
        {
            if (DataContext.Sellings == null) { return false; }
            Selling s = DataContext.Sellings.Find(s => s.SellingId==sellingId);
            if (s == null) { return false; }
            DataContext.Sellings.Remove(s);
            return true;
        }
    }
}
