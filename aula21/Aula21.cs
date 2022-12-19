using System;

class Aula21{
	static void Main(){
		string senha="12345";
		string senhauser;
		do{
			Console.Clear();
			Console.WriteLine("Digite sua senha: ");
			senhauser=Console.ReadLine();
		}while(senha != senhauser);

		Console.WriteLine("Senha Correta");
	}
}