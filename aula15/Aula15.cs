using System;

class Aula15{
	static void Main(){
		Console.WriteLine("Entre com algum número de 1 a 5");
		byte valor=Convert.ToByte(Console.ReadLine());
		switch(valor){
			case 1:
				Console.WriteLine("Você escreveu 1");
				break;
			case 2:
				Console.WriteLine("Você escreveu 1");
				break;
			case 3:
				Console.WriteLine("Você escreveu 1");
				break;
			case 4:
				Console.WriteLine("Você escreveu 1");
				break;
			case 5:
				Console.WriteLine("Você escreveu 1");
				break;
			default:
				Console.WriteLine("Você escreveu outro valor");
				break;
		}
	}
}