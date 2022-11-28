using KutuphaneEF.Models;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryContext libraryContext = new LibraryContext();
            libraryContext.Database.Migrate();
            City city= new City();
            District district = new District();
            Library library = new Library();
            Book book = new Book(); 
            Employee employee = new Employee(); 
            BookLocation bookLocation=new BookLocation();   
            byte operation;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bir işlem seç");
                Console.WriteLine("1- Şehir ekle");
                Console.WriteLine("2- İlçe ekle");
                Console.WriteLine("3- Kütüphane ekle");
                Console.WriteLine("4- Kitap ekle");
                Console.WriteLine("5-Çalışan ekle");
                Console.WriteLine("6- Kütüphaneye kitap ekle");
                operation=byte.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 0:
                        return;
                    case 1:
                       
                        Console.Write("Plaka kodu: ");
                        city.PlateCode = byte.Parse(Console.ReadLine());
                        Console.Write("Şehir adı giriniz: ");
                        city.Name = Console.ReadLine();
                        libraryContext.Add(city);
                        break;
                    case 2:
                        Console.Write("İlçe giriniz: ");
                        district.Name = Console.ReadLine();
                        Console.Write("Nüfus sayısı giriniz: ");
                        district.Population = int.Parse(Console.ReadLine());
                        Console.Write("Bağlı olduğu ilin plaka kodunu giriniz: ");
                        district.CityId = byte.Parse(Console.ReadLine());
                        libraryContext.Add(district);  
                        break;
                    case 3:   
                        Console.Write("Kütüphane adı giriniz: ");
                        library.Name = Console.ReadLine();
                        Console.Write("Kitap sayısı giriniz: ");
                        library.BookCount = int.Parse(Console.ReadLine());
                        Console.Write("Kapasite giriniz: ");
                        library.Capacity = short.Parse(Console.ReadLine());
                        Console.Write("Kuruluş tarihi giriniz: ");
                        library.EstablishmentDate= DateTime.Parse(Console.ReadLine());
                        Console.Write("Bulunduğu ilçe id'sini giriniz: ");
                        library.DistrictId = short.Parse(Console.ReadLine());
                        libraryContext.Add(library);       
                        break;
                    case 4:
                        Console.Write("ISBN giriniz: ");
                        book.ISBN = Console.ReadLine();
                        Console.Write("Kitap adı giriniz: ");
                        book.Title = Console.ReadLine();
                        Console.Write("Yazar adı giriniz: ");
                        book.Writer = Console.ReadLine();
                        libraryContext.Add(book);
                        break;
                    case 5:
                        Console.Write("Personelin TC numarasını giriniz: ");
                        employee.Id= long.Parse(Console.ReadLine());
                        Console.Write("Personel adı giriniz: ");
                        employee.Name = Console.ReadLine();
                        Console.Write("Personel doğum tarihini giriniz: ");
                        employee.BirthDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Çalıştığı kütüphaneyi giriniz: ");
                        employee.LibraryId = short.Parse(Console.ReadLine());
                        libraryContext.Add(employee);
                        break;
                    case 6:
                        Console.Write("Kütüphaneye eklenecek kitap id' si: ");
                        bookLocation.ISBN = Console.ReadLine();
                        Console.Write("Kütüphane id'si giriniz: ");
                        bookLocation.LibraryId= short.Parse(Console.ReadLine());
                        Console.Write("Dolap no giriniz: ");
                        bookLocation.Cabinet = Console.ReadLine();
                        Console.Write("Raf no giriniz: ");
                        bookLocation.Shelf = Console.ReadLine();
                        Console.WriteLine("Kitap adeti giriniz: ");
                        bookLocation.Amount=byte.Parse(Console.ReadLine());
                        libraryContext.Add(bookLocation);
                        break;
                    default:
                        break;
                }
                libraryContext.SaveChanges();
            }
            

        }
    }
}