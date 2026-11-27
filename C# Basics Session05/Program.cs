namespace C__Basics_Session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            Book book = new Book();
            //Console.WriteLine( book.password);// The Field InAccessible due to it's Protection Level

            #endregion

            #region Q02

            //Console.WriteLine(book.copiesInStock);//it's compile because you can access internal field in the same assembly

            #endregion

            #region Q03

            book.Title = "Clean Code ";
            //Console.WriteLine(book.Title);
            #endregion

            #region Q04

            book.gen=Genre.Science;
            //Console.WriteLine(book.gen);

            #endregion

            #region Q05

            //Console.WriteLine($"Fiction: {(int)Genre.Fiction}, NonFiction: {(int)Genre.NonFiction }, Science: {(int)Genre.Science}");

            #endregion

            #region Q06

            int genreNumber = 1;
            Genre result = (Genre)genreNumber;
            //Console.WriteLine((Genre)result);
            #endregion

            #region Q07

            Genre genre = Genre.Fiction;
            string res=genre.ToString();
            //Console.WriteLine(res);
            #endregion

            #region Q08

            string genreText = "Science";
            Genre g=(Genre)Enum.Parse(typeof(Genre),genreText);
            //Console.WriteLine(g);

            #endregion

            #region Q09

            //string genreText2 = "Mystery";
            //bool r=Enum.TryParse(genreText2, out genre);
            //if(r)
            //    Console.WriteLine(genre);
            //else
            //    Console.WriteLine("Unknown genre");
            #endregion

            #region Session Task

            Membership St1 = new Membership();
            St1.EnterInfo();
            St1.Print();

            #endregion

        }
    }
}
