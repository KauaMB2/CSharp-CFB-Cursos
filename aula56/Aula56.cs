using System;
using System.Collections.Generic;

class Aula56{
	// LinkedList=onde cada elemento é um nó da lista e o elemento é ligado ao elemento anterior e posterior
	public static void Main(){
		LinkedList<string> transp = new LinkedList<string>();

		transp.AddFirst("Carro");//É adicionada no início da lista
		transp.AddFirst("Avião");//É adicionada no início da lista
		transp.AddFirst("Navio");//É adicionada no início da lista
		transp.AddFirst("Motocicleta");//É adicionada no início da lista
		transp.AddLast("Bicicleta");//É adicionada no fim da lista
		foreach(string t in transp){
			Console.WriteLine("Transporte: {0}",t);
		}
		Console.WriteLine("------------------");
		LinkedListNode<string> node;//Uma posição específica do LinkedList
		node=transp.FindLast("Navio");// Nó é igual ao elemento "Navio"
		transp.AddAfter(node,"Patinete");//Adiciona elemento logo após o nó
		node=transp.FindLast("Avião");// Nó é igual ao elemento "Navio"
		transp.AddAfter(node,"Patinete");//Adiciona o elemento atrás do nó
		foreach(string t in transp){
			Console.WriteLine("Transporte: {0}",t);
		}
		Console.WriteLine("------------------");

		transp.Remove("Navio");//Remove "Navio"
		transp.RemoveLast();//Remove ultimo elmento do LinkedList
		transp.RemoveFirst();//Remove primeiro elmento do LinkedList
		foreach(string t in transp){
			Console.WriteLine("Transporte: {0}",t);
		}
		Console.WriteLine("------------------");
		transp.Clear();//Deleta todos os elementos da lista
		foreach(string t in transp){
			Console.WriteLine("Transporte: {0}",t);
		}
		Console.WriteLine("------------------");
	}
}