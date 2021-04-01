
namespace DevExpressAPI.DataSource
{
    public class Costume
    {
        private static int id = 0;

        public int CostumeID { get; }

        public string CostumeName { get; set; }

        public bool IsWoom { get; set; }

        public int Price { get; set; }

        public string MakerName { get; set; }

        public Costume()
        {
            CostumeID = ++id;
            CostumeName = "Empty name";
            IsWoom = true;
            Price = 10;
            MakerName = "CocoChanel";
        }

        public Costume(string costumeName, bool isWoom, int size, string makerName)
        {
            CostumeID = ++id;
            CostumeName = costumeName;
            IsWoom = isWoom;
            Price = size;
            MakerName = makerName;
        }

        public override string ToString()
        {
            return string.Join(" ", CostumeName, IsWoom ? "Woom" : "Not woom", Price, MakerName);
        }
    }
}
