## Do while vs While - Pratik
	
### While
	  
	#region while
            int sayac = 0;
            if (int.TryParse(Console.ReadLine(), out int limit))
            {
				while (sayac <= limit)
				{
					Console.WriteLine("Ben Patika'lıyım");
					sayac++;
				}
			}
			#endregion

### Do While
	
	#region DoWhile
			sayac = 0;//sayacı sıfırlıyoruz.
			if (int.TryParse(Console.ReadLine(), out limit))
			{
				do
				{
					Console.WriteLine("Ben Patika'lıyım");
					sayac++;
				} while (sayac <= limit);
			}
			#endregion

### Summary
	
	#region Summary
			/*
			 kontrol değişkenimiz döngü başında veya sonunda kontrol edilir. Do while döngüsünde kontrol değişkeni döngü sonunda kontrol edilir.Ancak while döngüsünde kontrol değişkeni döngü başında kontrol edilir.
			Bu sebeple while döngüsü, döngü şartı sağlanmadığı sürece hiçbir işlem yapmaz. Do while döngüsü ise döngü şartı sağlanmasa bile en az bir kere çalışır.
			 */
			#endregion
