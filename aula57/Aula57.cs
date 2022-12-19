using System;
using System.Collections.Generic;

class Aula57{
	public static void Main(){
		List<string> carros1=new List<string>();
		List<string> carros2=new List<string>();
		carros1.Add("Golf");
		carros1.Add("HRV");
		carros1.Add("Focus");
		carros1.Add("Argo");

		carros2.AddRange(carros1);//carros2 recebe todos os elentos de carros1
		foreach(string c in carros2){
			Console.WriteLine("Carro: {0}",c);
		}
		Console.WriteLine("----------------");

		if(carros1.Contains("Golf")){//Retorna se carros1 contém "Golf"
			Console.WriteLine("Está na lista");
		}else{
			Console.WriteLine("Não encontrado");
		}
		Console.WriteLine("----------------");

		string[] carros3=new string[10];
		carros1.CopyTo(carros3,2);//Copia os elementos do carros1 em carros3 apartir do índice 2 do carros3
		foreach(string c in carros3){
			Console.WriteLine("Carro: {0}",c);
		}
		Console.WriteLine("----------------");
		string carro="HRV";
		int pos=carros2.IndexOf(carro);//Retorna o índice do elemento "HRV"
		Console.WriteLine("Carro {0} está na posição{1}",carro,pos);
		Console.WriteLine("----------------");

		carros1.Clear();//Deleta todos os elementos de carros1
		foreach(string c in carros1){
			Console.WriteLine("Carro: {0}",c);
		}
		Console.WriteLine("----------------");
	}
}