using System;

class aula03{
	static void Main(){
		float num1=0,num2=0,res=0;
		string nome="";
		Console.WriteLine("Olá! qual o seu nome?");
		nome=Console.ReadLine();
		Console.WriteLine("Digite um número: ");
		num1=float.Parse(Console.ReadLine());
		Console.WriteLine("Digite um outro número: ");
		num2=float.Parse(Console.ReadLine());
		res=num1+num2;
		Console.WriteLine("Olá, "+nome+". A soma de "+num1+" com "+num2+" é "+res);
	}
}