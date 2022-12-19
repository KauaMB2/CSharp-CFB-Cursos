using System;

class Aula31{
	static void Main(){
		Jogador.iniciar();
		Jogador.Info();
		Jogador.iniciar("Kauã");
		Jogador.Info();
		Jogador.iniciar();
		Jogador.Info();
		Jogador.iniciar("Bruno");
		Jogador.Info();

		Inimigo i1=new Inimigo("Joana");
		Inimigo i2=new Inimigo("Maria");
		Inimigo i3=new Inimigo("Paulinho");
		i1.Info();
		i2.Info();
		i3.Info();
		Inimigo.ativarAlerta();
		i1.Info();
		i2.Info();
		i3.Info();
	}
}
class Inimigo{
	static private bool alerta=false;//Variável global da classe Inimigo
	private string nome;
	public Inimigo(string n){
		nome=n;
	}
	static public void ativarAlerta(){
		alerta=true;
	}
	public void Info(){
		Console.WriteLine(alerta);
		Console.WriteLine(nome);
		Console.WriteLine("----------------------");
	}
}
static public class Jogador{
	static public int i=0;
	static public int energia;
	static public bool vivo=true;
	static public string nome;
	static public void iniciar(){
		energia=100;
		vivo=true;
		nome="Jogador"+i.ToString();
		++i;
	}
	static public void iniciar(string n){
		energia=100;
		vivo=true;
		nome=n;
		++i;
	}
	static public void Info(){
		Console.WriteLine("Nome do jogador: {0}",nome);
		Console.WriteLine("Energia do jogador: {0}",energia);
		Console.WriteLine("Estado do jogador: {0}",vivo);
		Console.WriteLine("-----------------------------\n");
	}
}

//Uma classe stetic só tem 1 endereço na memória, portanto, não é possível instanciar objetos. Além disso, uma classe static pode ser chamada a qualquer momento 