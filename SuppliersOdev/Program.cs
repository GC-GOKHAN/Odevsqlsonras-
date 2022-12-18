namespace SuppliersOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SuppliersOperation SuppliersOperation = new SuppliersOperation();

            List<Suppliers> SuppList = SuppliersOperation.SuppList();


            Suppliers shp = new Suppliers();

            Console.WriteLine("Şirket Adı Giriniz");
            shp.CompanyName = Console.ReadLine();


            Console.WriteLine("İletişim Kişisi Giriniz");
            shp.ContactName = Console.ReadLine();

            Console.WriteLine("İletişim Kişisi Unvan Giriniz");
            shp.ContactTitle = Console.ReadLine();

            Console.WriteLine("Adres Giriniz");
            shp.Address = Console.ReadLine();


            int result = SuppliersOperation.Add(shp);
            if (result > 0)
                Console.WriteLine("İşlem Başarılı");
            else
                Console.WriteLine("İşlem başarısız");

            foreach (var item in SuppList)
            {

            }











        }
    }
}