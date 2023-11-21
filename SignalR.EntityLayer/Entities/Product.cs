namespace SignalRApi1.DAL.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }

        public String Description { get; set; }
        public decimal Price
        {
            get; set;
        }
        public string ImageUrl
        {
            get; set;
        }
        public bool ProductStatus
        {
            get; set;
        }
    }

}

