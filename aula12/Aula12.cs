using System;
class Aula12{
	static void Main(){
		byte n1,n2,n3,n4,media;
		string nomeAluno;
		Console.Write("Digite o nome do aluno: ");
		nomeAluno=Console.ReadLine();
		Console.Write("\nDigite a 1ª nota: ");
		n1=Convert.ToByte(Console.ReadLine());
		Console.Write("\nDigite a 2ª nota: ");
		n2=Convert.ToByte(Console.ReadLine());
		Console.Write("\nDigite a 3ª nota: ");
		n3=Convert.ToByte(Console.ReadLine());
		Console.Write("\nDigite a 4ª nota: ");
		n4=Convert.ToByte(Console.ReadLine());
		media=Convert.ToByte((n1+n2+n3+n4)/4);
		if(media>=60){
			Console.WriteLine("PARABÉNS,{0}, VOCÊ PASSOU DE ANO!! :)",nomeAluno);
		}
		else{
			Console.WriteLine("Que pena, {0}. Você ficou de recuperação",nomeAluno);
		}
	}
}