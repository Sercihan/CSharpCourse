namespace _18_FileOperations_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DosyaYaz();
            //DosyaOku();
        }

        static void DosyaYaz()
        {
            string dosyaYolu = @"C:\TEST\deneme.txt";
            bool isDirectoryExists = Directory.Exists("C:\\TEST");

            if (!isDirectoryExists)
            {
                Directory.CreateDirectory("C:\\TEST");
            }

            FileStream fileStream = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write);

            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine("3.Satır Merhaba Dünya");
            streamWriter.WriteLine("4.Satır Hoşçakal Dünya");

            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        static void DosyaOku()
        {
            string dosyaYolu = @"C:\TEST\deneme.txt";

            FileStream fileStream = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fileStream);

            //string yazi = streamReader.ReadLine();
            //while (yazi != null)
            //{
            //    Console.WriteLine(yazi);
            //    yazi = streamReader.ReadLine();
            //}

            string yazi = streamReader.ReadToEnd();
            Console.WriteLine(yazi);
            streamReader.Close();
            fileStream.Close();
        }
    }
}
