using Mishnat.DTO;

namespace Mishnat.Service
{
    public class SellingService
    {
        public List<Selling> Sellings { get; set; }
        private static int id = 1;
        public List<Selling> GetSellings() { return Sellings; }

        public Selling GetSellingById(int sellingId)
        {
            if (Sellings == null) { return null; }
            return Sellings.Where(s => s.SellingId==sellingId).FirstOrDefault<Selling>();
        }
        public bool UpdateSellingById(int sellingId, Selling selling )
        {
            if (Sellings == null) { return false; }
            Selling s = Sellings.Find(s => s.SellingId==sellingId);
            if (s == null) { return false; }
            s = selling;
            return true;
        }
        public bool AddSelling(Selling selling)
        {
            if(Sellings == null) { return false; }
            selling.SellingId = id++;
            Sellings.Add(selling);
            return true;
        }
        public bool DeleteSelling(int sellingId)
        {
            if (Sellings == null) { return false; }
            Selling s = Sellings.Find(s => s.SellingId==sellingId);
            if (s == null) { return false; }
            Sellings.Remove(s);
            return true;
        }
    }
}
