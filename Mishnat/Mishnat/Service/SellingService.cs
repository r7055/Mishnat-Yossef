using Mishnat.DTO;

namespace Mishnat.Service
{
    public class SellingService
    {
        public List<Selling> Sellings { get; set; }
        public List<Selling> GetSellings() { return Sellings; }
        public Selling GetSellingById(string sellingId)
        {
            if (Sellings == null) { return null; }
            return Sellings.Where(s => s.SellingId.Equals(sellingId)).FirstOrDefault<Selling>();
        }
        public bool UpdateSellingById(string sellingId, Selling selling )
        {
            if (Sellings == null) { return false; }
            Selling s = Sellings.Find(s => s.SellingId.Equals(sellingId));
            if (s == null) { return false; }
            s = selling;
            return true;
        }
        public bool AddSelling(Selling selling)
        {
            Sellings.Add(selling);
            return true;
        }
        public bool DeleteSelling(string sellingId)
        {
            if (Sellings == null) { return false; }
            Selling s = Sellings.Find(s => s.SellingId.Equals(sellingId));
            if (s == null) { return false; }
            Sellings.Remove(s);
            return true;
        }
    }
}
