using System;

namespace E_Commerce//Bookstore
//List of books and calculating current price
//Now I dont have time to continue this one so for now i will let it be like this
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();
            LiteratureBooks literatureBooks1 = new LiteratureBooks();
            TextBooks textBooks = new TextBooks();
            BookManager bookManager = new BookManager();


            literatureBooks1.Author = "Orhan Pamuk";
            literatureBooks1.BookName = "Kırmızı Saçlı Kadın";
            literatureBooks1.OrginalPrice = 22;
            literatureBooks1.DiscountRate = 30;
            bookManager.CurrentPrice(literatureBooks1);
            literatureBooks1.StockStatus = true;
            literatureBooks1.StockVolume = 30;
            literatureBooks1.NumberOfPages = "204";
            literatureBooks1.FirstEditionYear = "2016";
            Console.WriteLine("Anlik fiyat "+literatureBooks1.CurrentPrice);

            LiteratureBooks literatureBooks2 = new LiteratureBooks();
            literatureBooks2.Author = "George Orwell";
            literatureBooks2.BookName = "Hayvan Çifliği";
            literatureBooks2.OrginalPrice = 11;
            literatureBooks2.DiscountRate = 30;
            bookManager.CurrentPrice(literatureBooks2);
            literatureBooks2.StockStatus = true;
            literatureBooks2.StockVolume = 40;
            literatureBooks2.NumberOfPages = "152";
            literatureBooks2.FirstEditionYear = "1945";
            Console.WriteLine("Anlik fiyat " + literatureBooks2.CurrentPrice);

            ComicBooks comicBooks1 = new ComicBooks();
            comicBooks1.Author = "Eiichiro Oda";
            comicBooks1.BookName = "One Piece 39.Cilt-Çekişme";
            comicBooks1.OrginalPrice = 20;
            comicBooks1.DiscountRate = 22;
            bookManager.CurrentPrice(comicBooks1);
            comicBooks1.StockStatus = true;
            comicBooks1.StockVolume = 15;
            comicBooks1.NumberOfPages = "192";
            comicBooks1.FirstEditionYear = "2018";
            Console.WriteLine("Anlik fiyat " + comicBooks1.CurrentPrice);

            ComicBooks comicBooks2 = new ComicBooks();
            comicBooks2.Author = "Sui İshida";
            comicBooks2.BookName = "Tokyo Gul 1. Cilt";
            comicBooks2.OrginalPrice = 24;
            comicBooks2.DiscountRate = 22;
            bookManager.CurrentPrice(comicBooks2);
            comicBooks2.StockStatus = true;
            comicBooks2.StockVolume = 15;
            comicBooks2.NumberOfPages = "192";
            comicBooks2.FirstEditionYear = "2015";
            Console.WriteLine("Anlik fiyat " + comicBooks2.CurrentPrice);

            ForeignLanguagesBooks foreignLanguagesBooks1 = new ForeignLanguagesBooks();
            foreignLanguagesBooks1.Author = "Antoine de Saint-Exupery";
            foreignLanguagesBooks1.BookName = "The Little Prince - Stage 2 - İngilizce Hikaye";
            foreignLanguagesBooks1.OrginalPrice = 10;
            foreignLanguagesBooks1.DiscountRate = 35;
            bookManager.CurrentPrice(foreignLanguagesBooks1);
            foreignLanguagesBooks1.StockStatus = true;
            foreignLanguagesBooks1.StockVolume = 15;
            foreignLanguagesBooks1.NumberOfPages = "60";
            foreignLanguagesBooks1.FirstEditionYear = "2017";
            Console.WriteLine("Anlik fiyat " + foreignLanguagesBooks1.CurrentPrice);

            MyBooksList<String> authors = new MyBooksList<string>();
            authors.Add(foreignLanguagesBooks1.Author);
            authors.Add(literatureBooks1.Author);
            authors.Add(literatureBooks2.Author);
            authors.Add(comicBooks1.Author);
            authors.Add(comicBooks2.Author);

            foreach (var book in authors.Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
