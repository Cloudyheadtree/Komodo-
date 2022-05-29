namespace KomodoFinal.Repository
{
    public class SushiItem
    {
        public int SushiNumber {get; set;}
        public string SushiName {get; set;}
        public string Description { get; set;}
        public string Ingredients { get; set;}
        public double Price { get; set;}

        public SushiItem()
        {}
        public SushiItem(int sushiNum, string sushiName, string description, string ingredients, double price)
        {
            SushiNumber = sushiNum;
            SushiName = sushiName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}