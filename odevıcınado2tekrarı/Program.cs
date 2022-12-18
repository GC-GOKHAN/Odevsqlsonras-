using System.ComponentModel.DataAnnotations.Schema;

namespace odevıcınado2tekrarı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            ShippersOperation ShippersOperation = new ShippersOperation();

            List<Shippers> shipList = ShippersOperation.ShipList();

           
            Shippers shp = new Shippers();

            Console.WriteLine("Şirket Adı Giriniz");
            shp.CompanyName = Console.ReadLine();


            Console.WriteLine("Telefon ???");
            shp.Phone = Console.ReadLine();

            int result= ShippersOperation.Add(shp);
            if (result > 0)
                Console.WriteLine("İşlem Başarılı");
            else 
                Console.WriteLine("İşlem başarısız");

            foreach (var item in shipList)
            {

            }




        }
    }
}