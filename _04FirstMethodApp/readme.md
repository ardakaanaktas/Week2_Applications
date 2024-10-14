### Pratik - İlk Method Uygulamamız

Aynı uygulama içerisinde 4 adet metot tanımlamanız ve çağırmanız isteniyor :

> Geriye Değer Döndürmeyen Bir void metot.

- Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 

> Geriye Tamsayı Döndüren Bir metot

- Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

> Parametre Alan ve Geriye Değer Döndüren Bir Metot

- Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

> Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

- Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.


### Kod parçaları

> Method - 1

        private static void truth()
        {
            Console.WriteLine("Bu gece Ay çok Güzel Değil mi ?");
        }

> Method - 2

        private static int dvidedTwo()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            return a / 2;
        }

> Method - 3

        private static int multiplyTwo(int a)
        {
            return a * 2;
        }


> Method - 4

        private static void greeting(string name,string surname)
        {
            Console.WriteLine($"Hoş Geldiniz, {name} {surname}");
        }