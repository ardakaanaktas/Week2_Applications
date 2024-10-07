namespace _01ForWxamples
{
	internal class Program
	{
		/*
		 Pratik - For Örnekleri
			Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları for kullanarak yapınız.

			1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

			2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

			3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

			4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

			5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
		*/

		static void Main(string[] args)
		{
			#region Soru1
			Console.WriteLine("--------------1.Soru------------------");
			for (int i = 0; i < 10; i++)//0 dan 10 a kadar döngü içeriği döndürüyoruz.
			{
				Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
			}
			#endregion



			#region Soru2
			Console.WriteLine("--------------2.Soru------------------");
			for (int i = 1; i <= 20; i++)
			{
				Console.Write($"{i} ");//1 den 20 ye kadar olan sayıları yazdırıyoruz.
			}
			Console.WriteLine();
			#endregion



			#region Soru3
			Console.WriteLine("--------------3.Soru------------------");
			for (int i = 1; i <= 20; i++)//1 den 20 ye kadar olan sayıları döngü içerisinde kontrol ediyoruz.
			{
				if (i % 2 == 0)//Çift sayıları buluyoruz.
				{
					Console.Write($"{i} ");//Çift sayıları yazdırıyoruz.
				}
			}
			Console.WriteLine();
			#endregion

			#region Soru4
			Console.WriteLine("--------------4.Soru------------------");
			int total = 0;
			for (int i = 50; i <= 150; i++)//50 den 150 ye kadar olan sayıları döngü içerisinde kontrol ediyoruz.
			{
				total = total + i;//50 ile 150 arasındaki sayıları topluyoruz.
			}
			Console.WriteLine("50 - 150 arasında ki sayıların toplamı => " + total);
			#endregion

			#region Soru5
			Console.WriteLine("--------------5.Soru------------------");
			int oddTotal = 0;
			int evenTotal = 0;
			for (int i = 1; i <= 120; i++)
			{
				if (i % 2 == 0)//Çift sayıları buluyoruz.
				{
					evenTotal = evenTotal + i;
				}
				else//Tek sayıları buluyoruz.
				{
					oddTotal = oddTotal + i;
				}
			}
			Console.WriteLine($"Tek sayıların Toplamı => {oddTotal}");
			Console.WriteLine($"Çift sayıların Toplamı => {evenTotal}");
			#endregion

		}
	}
}
