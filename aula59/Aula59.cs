using System;
using System.Collections.Generic;

class Aula59{
	public static void Main(){
		//FILA= O primeiro a entrar é o primeiro a sair
		Queue<string> veiculos=new Queue<string>();
		veiculos.Enqueue("Carro");//Adiciona elemento na fila
		veiculos.Enqueue("Moto");//Adiciona elemento na fila
		veiculos.Enqueue("Navio");//Adiciona elemento na fila
		veiculos.Enqueue("Aviao");//Adiciona elemento na fila

		string v="Patinete";
		if(veiculos.Contains(v)){//Verifica se o elemento "Patinete" está na fila
			Console.WriteLine("Veiculo "+v+" encontrado");
		}else{
			Console.WriteLine("Veiculo "+v+" não está na fila");
		}
		Console.WriteLine("Tamanho fila: "+veiculos.Count);//Informa a quantidade de elementos na fila
		veiculos.Clear();//Deleta todos os elementos da fila
		Console.WriteLine("Tamanho fila: "+veiculos.Count);//Informa a quantidade de elementos na fila

		veiculos.Enqueue("Carro");//Adiciona elemento na fila
		veiculos.Enqueue("Moto");//Adiciona elemento na fila
		veiculos.Enqueue("Navio");//Adiciona elemento na fila
		veiculos.Enqueue("Aviao");//Adiciona elemento na fila

		Console.WriteLine("Veículo(Peek): {0}",veiculos.Peek());//APENAS retorna o primeiro elemento
		Console.WriteLine("Veículo(Peek): {0}",veiculos.Peek());//APENAS retorna o primeiro elemento
		while(veiculos.Count>0){
			Console.WriteLine("Veículo(Dequeue): {0}",veiculos.Dequeue());//Retorna o primeiro elemento e tira ele da fila
		}
		Console.WriteLine("Tamanho fila: "+veiculos.Count);//Informa a quantidade de elementos na fila
	}
}