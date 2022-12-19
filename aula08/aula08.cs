using System;

class aula08{
	static void Main(){
		int v1,v2,soma;
		string nome;

		Console.WriteLine("Qual é o seu nome?");
		nome=Console.ReadLine();
		Console.WriteLine("Digita um número: ");
		v1=Convert.ToInt32(Console.ReadLine());//Converte de string para int 
		Console.WriteLine("Digite um segundo número: ");
		v2=int.Parse(Console.ReadLine());//Converte de string para int 
		soma=v1+v2;
		Console.WriteLine("Olá, {3}! A some de {0} mais {1} é igual a {2}",v1,v2,soma,nome);

		
	}
}