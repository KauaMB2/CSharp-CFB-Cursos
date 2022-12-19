using System;
using System.Collections.Generic;

class Aula53{
	static void Main(){
		Dictionary <int, string > veiculos = new Dictionary <int , string>();

		veiculos.Add(10,"Carro");
		veiculos.Add(0,"Avião");
		veiculos.Add(5,"Navio");
		veiculos.Add(3,"Moto");
		veiculos.Add(30,"Patinete");

		Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count);//Retorna o número de elementos no Dictionary
		veiculos.Clear();//Limpa o Dictionary

		veiculos.Add(10,"Carro");
		veiculos.Add(0,"Avião");
		veiculos.Add(5,"Navio");
		veiculos.Add(3,"Moto");
		veiculos.Add(30,"Patinete");

		int chave=30;
		if(veiculos.ContainsKey(chave)){//Verifica se há ou não a chave 30 no Dictionary
			Console.WriteLine("A chave {0} está na coleação",chave);
		}else{
			Console.WriteLine("A chave {0} NÃO está na coleação",chave);
		}
		veiculos.Remove(30);//Remove um elemento no Dictionary
		if(veiculos.ContainsKey(chave)){//Verifica se há ou não a chave 30 no Dictionary
			Console.WriteLine("A chave {0} está na coleação",chave);
		}else{
			Console.WriteLine("A chave {0} NÃO está na coleação",chave);
		}

		string valor="Navio";
		if(veiculos.ContainsValue(valor)){//Verifica se há ou não o valor "Navio" no Dictionary
			Console.WriteLine("A valor {0} está na coleação",valor);
		}else{
			Console.WriteLine("A valor {0} NÃO está na coleação",valor);
		}
		veiculos[5]="Cavalo";//Modifica um elemento no Dictionary
		if(veiculos.ContainsValue(valor)){//Verifica se há ou não o valor "Navio" no Dictionary
			Console.WriteLine("A valor {0} está na coleação",valor);
		}else{
			Console.WriteLine("A valor {0} NÃO está na coleação",valor);
		}

		foreach(KeyValuePair<int,string> v in veiculos){//Percorre a chave e os valores do dictionary
			Console.WriteLine(v.Key+" - "+v.Value);
		}
		Console.WriteLine("--------------");
		Dictionary<int,string>.ValueCollection valores=veiculos.Values;//Pega todos oa valores do Dictionary
		foreach(string v in valores){
			Console.WriteLine(v);
		}
	}
}