namespace StoryWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gizemli Ateşkes!");
            Console.Write("Taraf seçimi = Savaş (S) /Barış (B): ");
            string answer = Console.ReadLine();
            if (answer == "s" || answer == "S")
            {
                //Savaş alanı
                Console.Clear();
                Console.WriteLine("Artık yoluna Savaş ile devam edeceksin!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ateşkes için karşı taraf senden çok farklı bir istekte bulundu. Ateşkesi Barış'tan gizleyeceksin! (Barış senin kardeşin!)");
                Console.Write("İsteği Kabul Et (K) / İsteği Reddet (R): ");
                string O = Console.ReadLine();
                if (O == "K" || O == "k")
                {
                    //isteği kabul ettin
                    Console.Clear();
                    Console.WriteLine("Kabul ettiğini öğrendiklerinde çok şaşırdılar. Başta inanmadılar, senin ateşkes detaylarını öğrenmek için onlara yalan söylediğini düşündüler. Doğru mu düşünüyorlar?");
                    Console.WriteLine("Evet (E) / Hayır (H): ");
                    string answer1 = Console.ReadLine();
                    if (answer1 == "e" || answer1 == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("Kardeşine ihanet eden birinin ateşkes detaylarını da düşmanlara vereceğini düşünüyorlar. Bu durumda bir karar aldılar.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Seninle çalışmak ve gizliliği paylaşmak istemiyorlar.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Görevi tamamlayamadın! Başarısız oldun! ");
                        Console.WriteLine("Seninle devam edilmeyecek!!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Kardeşinden bir şey gizlemeceğini anladıklarında ilk olarak akıllarına senin sadık bir eleman olduğun geldi. Bu durumda seni gözetim altında tutup ateşkes detaylarının önemsiz kısımlarından sana anlatmaya başlayıp bu bilgilerle ne yapacağını görmek istiyorlar!!");
                        Console.WriteLine("Tebrikler Savaş! Görevi tamamlayacağını biliyordum!");
                    }
                }
                else
                {
                    //İsteği Reddettin
                    Console.Clear();
                    Console.WriteLine("Bir kaç kişi senin isteği kabul edeceğini düşünüyordu ve bu sebeple arkanda seni etkisiz hale getirmek isteyen bir adam bulunuyordu. Sen isteği reddettiğin için sana farkettirmeden o adamı arkandan almak istediler.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Sen durumu farkettin. Şimdi ne yapacaksın? Karşılık ver (K) / Ateşkes detaylarını öğrenene kadar bekle (B): ");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "k" || answer2 == "K")
                    {
                        Console.Clear();
                        Console.WriteLine("Onlar çok kalabalık. Karşılık vermek hiç mantıklı bir atak değildi. Seni etkisiz hale getirdiler.");
                        Console.WriteLine("Ateşkesi merak ediyorsan baştan başla!");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sakin kaldığın için seni kutluyorum. Ateşkes detaylarını sana vermeyi kabul ettiler. Sana güvenebileceğimi biliyordum.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Detayları al ve yanıma gel. Seninle başka işler de yapacağız! ");
                        Console.WriteLine("Diğer işlere devam edelim!!");


                    }

                }
            }
            else
            {
                //"Barış Alanı"
                Console.Clear();
                Console.WriteLine("Artık yoluna Barış ile devam edeceksin");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ateşkes detaylarını Savaş'a vermediğin için sana güveniyorlar ve bu sebeple sana daha fazla görev vermek istiyorlar. Savaş'ı etkisiz hale getirmen gerekiyor. İsteklerini yerine getirecekmisin? (Savaş senin kardeşin!) Evet (E) / Hayır (H):  ");
                string answer3 = Console.ReadLine();
                if (answer3 == "E" || answer3 == "e")
                {
                    //Evet
                    Console.Clear();
                    Console.WriteLine("Bu görevi kabul ettiğin için çok şaşırdılar. Bir yandan görev için neler yapabileceğini anladılar, diğer yandan kardeşini etkisiz hale getiren biri herkesi etkisiz hale getirir diye düşündüler. Kendi aralarında bir toplantı yapmaya karar verdiler.  ");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Toplantıyı dinle. Evet(E) / Hayır (H): ");
                    string answer4 = Console.ReadLine();
                    if (answer4 == "E" || answer4 == "e")
                    {
                        Console.Clear();
                        Console.WriteLine("Dinlediğini anladılar ve seni etkisiz hale getirdiler.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Başarısız oldun!");


                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Bir karar aldıklarını söylediler ve bu görev için kardeşini öldüren birinin sadık olduğuna karar verdiklerini ve seninle devam edeceklerini söylediler.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Artık sana başka gizli detayları da verip seni yönetici yapmaya karar verdiler.");
                        Console.WriteLine("Başardın. Görevi tamamladın!");

                    }

                }
                else
                {
                    //Hayır
                    Console.Clear();
                    Console.WriteLine("Bir çoğunun beklediği cevabı versen de bazıları bu cevabı senden beklemiyordu. Bu sebeple toplantı yapmak istediler ve seni bekletmeye karar verdiler.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Toplantı bitiminde sana teklif sundular . ");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Ya kardeşini öldüreceksin ya da burda devam etmeyeceksin! Sen hangisini seçeceksin? Öldür (Ö) / Devam et(D): ");
                    string answer5 = Console.ReadLine();
                    if (answer5 == "ö" || answer5 == "Ö")
                    {
                        Console.Clear();
                        Console.WriteLine("Kardeşini öldürmen karşılığında sana sırları vermeye devam ettiler.");
                        Console.WriteLine("Sırları almaya devam et.");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Görevi reddedip devam etmek istedin. Bunu duyan yönetici çok sinirlendi. Seni etkisiz hale getirmek istedi.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Bir çoğu bu karara sevinse de bazıları senin sadık bir eleman olduğunu ve kardeşini öldürmemeni takdir ettiklerini söylediler.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Oy çoğunluğuyla seni aralarına almaya karar verdiler.");
                        Console.WriteLine("Başardın.");

                    }
                }
            }



        }
    }
}
