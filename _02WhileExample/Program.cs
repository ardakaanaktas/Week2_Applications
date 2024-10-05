using System;

namespace _02WhileExample
{
	internal class Program
	{
		/*
		 Pratik - For Örnekleri
			Bu pratik uygulama 5 aşamadan oluşuyor.Aşağıdaki alıştırmaları while kullanarak yapınız.

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
			int n = 0;
            while (n < 10)
            {
				Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
				n++;//döngünün sonsuz olmaması için kontrol değişkenimizi arttırıyoruz.
			}
            #endregion



            #region Soru2
            Console.WriteLine("--------------2.Soru------------------");
			n = 1;//1 den başlıyoruz.
			while (n <= 20)//20 ye kadar olan sayıları kontrol ediyoruz.
			{
				Console.Write($"{n} ");//1 den 20 ye kadar olan sayıları yazdırıyoruz.
				n++;//döngünün sonsuz olmaması için kontrol değişkenimizi arttırıyoruz.
			}
			Console.WriteLine();
			#endregion



			#region Soru3
			Console.WriteLine("--------------3.Soru------------------");
			n = 1;
			while (n <= 20)
			{
				if (n % 2 == 0)//Çift sayıları buluyoruz.
				{
					Console.Write($"{n} ");//Çift sayıları yazdırıyoruz.
				}
				n++;//döngünün sonsuz olmaması için kontrol değişkenimizi arttırıyoruz.
			}
			Console.WriteLine();
			#endregion

			#region Soru4
			Console.WriteLine("--------------4.Soru------------------");
			int total = 0;
			n = 50;//50 den başlıyoruz.
			while (n <= 150)//50 den 150 ye kadar olan sayıları kontrol ediyoruz.
			{
				total = total + n;//50 ile 150 arasındaki sayıları topluyoruz.
				n++;//döngünün sonsuz olmaması için kontrol değişkenimizi arttırıyoruz.
			}
			Console.WriteLine("50 - 150 arasında ki sayıların toplamı => " + total);
			#endregion

			#region Soru5
			Console.WriteLine("--------------5.Soru------------------");
			int oddTotal = 0;
			int evenTotal = 0;
			n = 1;//1 den başlıyoruz.
			while (n <= 120)//120 ye kadar olan sayıları kontrol ediyoruz.
			{
				if (n % 2 == 0)//Çift sayıları buluyoruz.
				{
					evenTotal = evenTotal + n;//Çift sayıları topluyoruz.
				}
				else//Tek sayıları buluyoruz.
				{
					oddTotal = oddTotal + n;//Tek sayıları topluyoruz.
				}
				n++;//döngünün sonsuz olmaması için kontrol değişkenimizi arttırıyoruz.
			}
			Console.WriteLine($"Tek sayıların Toplamı => {oddTotal}");
			Console.WriteLine($"Çift sayıların Toplamı => {evenTotal}");
			#endregion
		}
	}
}
