namespace Bootcamp_Homework.Models.Repositories
{
    public class BookRepository
    {
        private static List<Book> books = new();
        
        static BookRepository()
        {
            books.Add(new Book {
                Id = 1,
                Title = "Savaş ve Barış",
                Author = "Lev Tolstoy",
                PublicationYear = 1869,
                ISBN = "9780199232765",
                Genre = "Roman",
                Publisher = "Penguin Classics",
                PageCount = 1225,
                Language = "Rusça",
                Summary = "Rus aristokrasisinin Napolyon Savaşları sırasında yaşadığı olaylar üzerine büyük bir epik roman.",
                AvailableCopies = 4
            });
            books.Add(new Book
            {
                Id = 2,
                Title = "Suç ve Ceza",
                Author = "Fyodor Dostoyevski",
                PublicationYear = 1866,
                ISBN = "9780140449136",
                Genre = "Roman",
                Publisher = "Penguin Classics",
                PageCount = 576,
                Language = "Rusça",
                Summary = "Bir adamın cinayet işledikten sonra yaşadığı vicdan azabı ve psikolojik çöküş üzerine bir roman.",
                AvailableCopies = 3
            });
            books.Add(new Book
            {
                Id = 3,
                Title = "Anna Karenina",
                Author = "Lev Tolstoy",
                PublicationYear = 1877,
                ISBN = "9780143035008",
                Genre = "Roman",
                Publisher = "Penguin Classics",
                PageCount = 964,
                Language = "Rusça",
                Summary = "Rus aristokrasisi içinde trajik bir aşk hikayesi ve toplumsal normlara başkaldırı.",
                AvailableCopies = 5
            });
            books.Add(new Book
            {
                Id = 4,
                Title = "Madame Bovary",
                Author = "Gustave Flaubert",
                PublicationYear = 1857,
                ISBN = "9780140449129",
                Genre = "Roman",
                Publisher = "Penguin Classics",
                PageCount = 384,
                Language = "Fransızca",
                Summary = "Hayatından memnun olmayan bir kadının romantik hayalleri ve sonunda trajik bir sona sürüklenmesi.",
                AvailableCopies = 2
            });
            books.Add(new Book
            {
                Id = 5,
                Title = "Don Kişot",
                Author = "Miguel de Cervantes",
                PublicationYear = 1605,
                ISBN = "9780060934347",
                Genre = "Roman",
                Publisher = "Harper Perennial",
                PageCount = 992,
                Language = "İspanyolca",
                Summary = "Hayalperest bir şövalye olan Don Kişot’un maceraları ve sadık hizmetkarı Sancho Panza'nın hikayesi.",
                AvailableCopies = 6
            });
        }


        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

    }
}
