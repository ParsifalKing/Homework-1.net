
using Homework_1;

var bookServ = new BookService();

var stop = true;
while (stop)
{
    System.Console.WriteLine("Enter command for reading : read");
    System.Console.WriteLine("Enter command for creating : add");
    System.Console.WriteLine("Enter command for updating : update");
    System.Console.WriteLine("Enter command for deleting : delete");
    System.Console.WriteLine("Enter command for searching : search");
    System.Console.WriteLine("Enter command for accessing : access");
    System.Console.WriteLine("Enter command to exit : exit");

    System.Console.Write("          Enter your command : ");
    var command = System.Console.ReadLine();
    Thread.Sleep(millisecondsTimeout: 1000);
    System.Console.Write(". ");
    Thread.Sleep(millisecondsTimeout: 1000);
    System.Console.Write(". ");
    Thread.Sleep(millisecondsTimeout: 1000);
    System.Console.WriteLine(".");
    System.Console.WriteLine();

    if (command.ToLower() == "read")
    {
        System.Console.WriteLine("------------ All books ------------ ");
        foreach (var item in bookServ.GetBooks())
        {
            System.Console.Write("Book Id : ");
            System.Console.WriteLine(item.Id);
            System.Console.Write("Book title : ");
            System.Console.WriteLine(item.Title);
            System.Console.Write("Book author : ");
            System.Console.WriteLine(item.Author);
            System.Console.Write("Book category : ");
            System.Console.WriteLine(item.Category);
            System.Console.Write("Book access : ");
            System.Console.WriteLine(item.Access);
            System.Console.WriteLine("--------------------------");
        }
        System.Console.WriteLine();
    }

    else if (command.ToLower() == "add")
    {
        var book = new Book();
        System.Console.Write("Book title : ");
        book.Title = System.Console.ReadLine();
        System.Console.Write("Book author : ");
        book.Author = System.Console.ReadLine();
        System.Console.Write("Book category : ");
        book.Category = System.Console.ReadLine();
        System.Console.Write("Book access : ");
        book.Access = Convert.ToBoolean(System.Console.ReadLine());
        System.Console.WriteLine();
        bookServ.AddBook(book);
    }

    else if (command.ToLower() == "update")
    {
        var book = new Book();
        System.Console.Write("Book Id : ");
        book.Id = int.Parse(Console.ReadLine());
        System.Console.Write("Book title : ");
        book.Title = System.Console.ReadLine();
        System.Console.Write("Book author : ");
        book.Author = System.Console.ReadLine();
        System.Console.Write("Book category : ");
        book.Category = System.Console.ReadLine();
        System.Console.Write("Book access : ");
        book.Access = Convert.ToBoolean(System.Console.ReadLine());
        System.Console.WriteLine();
        bookServ.UpdateBook(book);
    }


    else if (command.ToLower() == "delete")
    {
        System.Console.Write("Please enter bookId for deleting : ");
        int bookId = int.Parse(Console.ReadLine());
        bookServ.DeleteBook(bookId);
        System.Console.WriteLine();
    }

    else if (command.ToLower() == "search")
    {
        System.Console.Write($"How you want to search books? \nBy 'title' or 'author' or 'category'. Please enter command : ");
        var searchCommand = System.Console.ReadLine();

        if (searchCommand.ToLower() == "title")
        {
            System.Console.Write("Please enter title of book : ");
            var bookTitle = Console.ReadLine();
            System.Console.WriteLine();
            foreach (var item in bookServ.SearchBookByTitle(bookTitle))
            {
                System.Console.Write("Book Id : ");
                System.Console.WriteLine(item.Id);
                System.Console.Write("Book title : ");
                System.Console.WriteLine(item.Title);
                System.Console.Write("Book author : ");
                System.Console.WriteLine(item.Author);
                System.Console.Write("Book category : ");
                System.Console.WriteLine(item.Category);
                System.Console.Write("Book access : ");
                System.Console.WriteLine(item.Access);
                System.Console.WriteLine("--------------------------");
            }
            System.Console.WriteLine();
        }
        else if (searchCommand.ToLower() == "author")
        {
            System.Console.Write("Please enter Author of book : ");
            var bookAuthor = Console.ReadLine();
            System.Console.WriteLine();
            foreach (var item in bookServ.SearchBookByAuthor(bookAuthor))
            {
                System.Console.Write("Book Id : ");
                System.Console.WriteLine(item.Id);
                System.Console.Write("Book title : ");
                System.Console.WriteLine(item.Title);
                System.Console.Write("Book author : ");
                System.Console.WriteLine(item.Author);
                System.Console.Write("Book category : ");
                System.Console.WriteLine(item.Category);
                System.Console.Write("Book access : ");
                System.Console.WriteLine(item.Access);
                System.Console.WriteLine("--------------------------");
            }
            System.Console.WriteLine();
        }
        else if (searchCommand.ToLower() == "category")
        {
            System.Console.Write("Please enter category of book : ");
            var bookCategory = Console.ReadLine();
            System.Console.WriteLine();
            foreach (var item in bookServ.SearchBookByCategory(bookCategory))
            {
                System.Console.Write("Book Id : ");
                System.Console.WriteLine(item.Id);
                System.Console.Write("Book title : ");
                System.Console.WriteLine(item.Title);
                System.Console.Write("Book author : ");
                System.Console.WriteLine(item.Author);
                System.Console.Write("Book category : ");
                System.Console.WriteLine(item.Category);
                System.Console.Write("Book access : ");
                System.Console.WriteLine(item.Access);
                System.Console.WriteLine("--------------------------");
            }
            System.Console.WriteLine();
        }
    }

    else if (command.ToLower() == "access")
    {
        var book = new Book();
        System.Console.Write("Please enter Id of book to change access : ");
        book.Id = int.Parse(Console.ReadLine());
        System.Console.Write("Please change access of book : ");
        book.Access = bool.Parse(Console.ReadLine());
        bookServ.AccessOfBook(book);
        System.Console.WriteLine();
    }


    else if (command.ToLower() == "exit")
    {
        stop = false;
    }

}

