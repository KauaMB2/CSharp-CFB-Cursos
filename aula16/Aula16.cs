using System;

class Aula15{
	static void Main(){
		//GOTO É MUITOOOOOOOOO UTIL!!!!!!!!!!!


		inicio:
			Console.Clear();

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

			perguntaFinal:
				Console.WriteLine("Deseja entrar com um novo valor?[S/N]");
				char resposta=char.Parse(Console.ReadLine());
				if(resposta=='s' || resposta=='S'){
					goto inicio;//GOTO
				}else if(resposta=='n' || resposta=='N'){
					Console.Write("Fim do programa!");
				}else{
					Console.WriteLine("Você digitou um caracter inválido");
					goto perguntaFinal;//GOTO
				}
	}
}