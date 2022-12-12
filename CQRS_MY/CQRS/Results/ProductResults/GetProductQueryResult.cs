namespace CQRS_MY.CQRS.Results.ProductResults
{
    public class GetProductQueryResult
    {

        //Depocu
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int? Stock { get; set; }

        public string Storage { get; set; }
        public string Shelf { get; set; }
       
    }
}
