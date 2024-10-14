namespace VacationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Holiday:
            Console.Write("Gitmek istediğiniz yer ? (Bodrum/Marmaris/Çeşme) : ");
            string? place = Console.ReadLine();
            place = place?.ToLower();

            Console.WriteLine("Kaç kişi olacaksınız ? ");
            int? personCount = Convert.ToInt32(Console.ReadLine());
        way:
            Console.WriteLine("Gidiş için hangi yolu tercih edersiniz ? (Hava yolu için -> \"1\" / Kara yolu için -> \"2\")");
            int? way = Convert.ToInt32(Console.ReadLine());

            if (way == 1 || way == 2)
            {
                switch (place)
                {
                    case "bodrum":
                        Console.WriteLine("Bodrum hakkında genel bilgi");
                        if (way == 1)
                        {
                            int price = 4000 * (int)personCount;
                            Console.WriteLine("Tati Harcamanızın totali : " + price + "\n"
                                + "Toplam kişi sayınız: " + personCount);

                            Console.WriteLine("Tekrar hesaplama yapmak istiyor musunuz ? (e/h)");
                            string? answer = Console.ReadLine();
                            if (answer == "e")
                            {
                                goto Holiday;
                            }
                            else if (answer == "h")
                            {
                                Console.WriteLine("İyi tatiller dileriz.");
                            }
                        }
                        else if (way == 2)
                        {
                            int price = 1500 * (int)personCount;
                            Console.WriteLine("Tati Harcamanızın totali : " + price + "\n" +
                                "Toplam kişi sayınız: " + personCount);
                            Console.WriteLine("Tekrar hesaplama yapmak istiyor musunuz ? (e/h)");
                            string? answer = Console.ReadLine();
                            if (answer == "e")
                            {
                                goto Holiday;
                            }
                            else if (answer == "h")
                            {
                                Console.WriteLine("İyi tatiller dileriz.");
                            }
                        }
                        break;
                    case "marmaris":
                        Console.WriteLine("Marmaris genel bilgi");
                        if (way == 1)
                        {
                            int price = 4000 * (int)personCount;
                            Console.WriteLine("Tati Harcamanızın totali : " + price + "\n"
                                + "Toplam kişi sayınız: " + personCount);
                            Console.WriteLine("Tekrar hesaplama yapmak istiyor musunuz ? (e/h)");
                            string? answer = Console.ReadLine();
                            if (answer == "e")
                            {
                                goto Holiday;
                            }
                            else if (answer == "h")
                            {
                                Console.WriteLine("İyi tatiller dileriz.");
                            }
                        }
                        else if (way == 2)
                        {
                            int price = 1500 * (int)personCount;
                            Console.WriteLine("Tati Harcamanızın totali : " + price + "\n" +
                                "Toplam kişi sayınız: " + personCount);
                            Console.WriteLine("Tekrar hesaplama yapmak istiyor musunuz ? (e/h)");
                            string? answer = Console.ReadLine().ToLower();
                            if (answer == "e")
                            {
                                goto Holiday;
                            }
                            else if (answer == "h")
                            {
                                Console.WriteLine("İyi tatiller dileriz.");
                            }
                        }
                        break;
                    case "çeşme":
                        Console.WriteLine("Çeşme genel bilgi");
                        if (way == 1)
                        {
                            int price = 4000 * (int)personCount;
                            Console.WriteLine("Tati Harcamanızın totali : " + price + "\n"
                                + "Toplam kişi sayınız: " + personCount);
                            Console.WriteLine("Tekrar hesaplama yapmak istiyor musunuz ? (e/h)");
                            string? answer = Console.ReadLine().ToLower();
                            if (answer == "e")
                            {
                                goto Holiday;
                            }
                            else if (answer == "h")
                            {
                                Console.WriteLine("İyi tatiller dileriz.");
                            }
                        }
                        else if (way == 2)
                        {
                            int price = 1500 * (int)personCount;
                            Console.WriteLine("Tati Harcamanızın totali : " + price + "\n" +
                                "Toplam kişi sayınız: " + personCount);
                            Console.WriteLine("Tekrar hesaplama yapmak istiyor musunuz ? (e/h)");
                            string? answer = Console.ReadLine().ToLower();
                            if (answer == "e")
                            {
                                goto Holiday;
                            }
                            else if (answer == "h")
                            {
                                Console.WriteLine("İyi tatiller dileriz.");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Maalesef girdiğiniz şehir için planlama yapılamamaktadır.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
                goto way;
            }

        }


    }
}
