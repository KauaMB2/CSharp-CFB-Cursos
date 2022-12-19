using System;

class Aula29{
	static void Main(){
		Jogador j1=new Jogador("Kauã");
		Jogador j2=new Jogador("Théo");
		Console.WriteLine(j1.nome);
		Console.WriteLine(j2.nome);
	}
}
public class Jogador{
	public int energia;
	public string nome;
	public Jogador(string n){//Método construtor
		energia=100;
		nome=n;
	}
	~Jogador(){//Método destrutora(É chamada quando os objetos estão sendo destruídos. Ex: Quando o programa fecha)
		Console.WriteLine("Jogador {0} foi destruido.",nome);
	}
}