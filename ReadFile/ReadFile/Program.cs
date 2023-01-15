using System.Text;

namespace ReadFile
{
    class OpenRead
    {
        static void Main(string[] args)
        {

            string fileName = @"/Users/anicka/Desktop/csharp/ReadFile/ReadFile/basen.txt";

            string fileRead= File.ReadAllText(fileName);

            Console.WriteLine(fileRead);

            //byte[] buf = new byte[1024];
            //int c;

            //while ((c = fs.Read(buf, 0, buf.Length)) > 0)
            //{
            //    Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
            //}

            Console.ReadLine();

        }


    }
}
