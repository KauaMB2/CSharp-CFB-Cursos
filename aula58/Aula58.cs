using System;
using System.Collections.Generic;

class Aula58{
	public static void Main(){
		List<string> carros1=new List<string>();
		List<string> carros2=new List<string>();
		carros1.Add("Golf");//Adiciona elemento
		carros1.Add("HRV");//Adiciona elemento
		carros1.Add("Focus");//Adiciona elemento
		carros1.Add("Argo");//Adiciona elemento

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
		
		carros1.Add("Golf");//Adiciona elemento
		carros1.Add("HRV");//Adiciona elemento
		carros1.Add("Focus");//Adiciona elemento
		carros1.Add("Argo");//Adiciona elemento
		carros1.Insert(1,"HRV");//Adiciona elemento "HRV" na posição 1
		foreach(string c in carros1){
			Console.WriteLine("Carro: {0}",c);
		}
		Console.WriteLine("----------------");
		int posHRV=carros1.LastIndexOf("HRV");//Retorno o último HRV 
		Console.WriteLine(posHRV);
		Console.WriteLine("----------------");

		carros1.Remove("Argo");//Remove elemento "Argo"
		carros1.RemoveAt(2);//Remove elemento na posição 2
		foreach(string c in carros1){
			Console.WriteLine("Carro: {0}",c);
		}
		Console.WriteLine("----------------");

		carros1.Reverse();//Inverte a ordem dos elementos
		foreach(string c in carros1){
			Console.WriteLine("Carro: {0}",c);
		}
		Console.WriteLine("----------------");

		carros1.Sort();//Ordena em ordem alfabética
		foreach(string c in carros1){
			Console.WriteLine("Carro: {0}",c);
		}
		Console.WriteLine("----------------");

		int tamanho=carros1.Count;//Informa o número de elementos no carros1
		int cap=carros1.Capacity;//Informa a capacidade de elementos no carros1
		Console.WriteLine("Tamanho: {0}",tamanho);
		Console.WriteLine("Capacidade: {0}",cap);
	}
}