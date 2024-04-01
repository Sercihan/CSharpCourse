namespace _18_FileOperations_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Directory ve File Sınıfları
            //string directory = "C:\\TEST";
            //string file = "C:\\TEST\\File.txt";

            //Directory.CreateDirectory(directory); //Klasör oluşturur
            //bool isDirectoryExists = Directory.Exists(directory); //Klasör var mı diye bakar
            //string[] directories = Directory.GetDirectories(directory); //Klasördeki klasörleri getirir
            //string[] files = Directory.GetFiles(directory); //Klasördeki dosyaları getirir
            //Directory.Move("C:\\TEST", "C:\\TEST2"); //Klasörü ve içindekileri taşır, ismini değiştirir
            //Directory.Delete(directory); //Boş klasörü siler

            //File.Create(file); //Dosya oluşturur
            //bool isFileExists = File.Exists(file); //Dosya var mı diye bakar
            //File.Move("C:\\TEST\\File.txt", "C:\\MEHMET\\File.txt"); //Dosyayı taşır, ismini değiştirir
            //File.Delete(file); //Dosyayı siler
            #endregion

            #region DirectoryInfo ve FileInfo Sınıfları

            string directory = "C:\\TEST";
            string file = "C:\\TEST\\File.txt";

            DirectoryInfo dInfo = new DirectoryInfo(directory);
            DateTime dCreateDate = dInfo.CreationTime; //Oluşturulma zamanı
                                                       //    dInfo.Delete(); //Klasörü siler
            string dFullName = dInfo.FullName; //Klasörün yolu
                                               //    string dName = dInfo.Name; //Klasörün adı
                                               //    DirectoryInfo parent = dInfo.Parent; //Üst klasör bilgisi

            //    FileInfo fInfo = new FileInfo(file);
            //    DateTime fCreateDate = fInfo.CreationTime; //Oluşturulma zamanı
            //    DirectoryInfo fDirectory = fInfo.Directory; //Bulunduğu klasörün bilgisi
            //    string fDirectoryName = fInfo.DirectoryName; //Bulunduğu klasörün adı
            //    string fExtension = fInfo.Extension; //Uzantısı
            //    string fFullName = fInfo.FullName; //Dosyanın yolu
            //    long fSize = fInfo.Length; //Dosyanın byte cinsinden boyutu
            //    string fName = fInfo.Name; //Dosyanın adı

            #endregion
        }
    }
}
