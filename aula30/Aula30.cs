using System;

class Aula31{
	static void Main(){
		Jogador j1=new Jogador();
		Jogador j2=new Jogador();
		Jogador j3=new Jogador();
		Jogador j4=new Jogador();
		Jogador j5=new Jogador("Joana");
		Jogador j6=new Jogador("Goku",100);
		Jogador j7=new Jogador("Théo",30,false);
		Jogador j8=new Jogador("Kauã",100,true);
		j1.info();
		j2.info();
		j3.info();
		j4.info();
		j5.info();
		j6.info();
		j7.info();
		j8.info();
	}
}
public class Jogador{
	public static int i=0;//Variável global da classe Jogador
	public int energia;
	public bool vivo=true;
	public string nome;

	public Jogador(){
		energia=100;
		vivo=true;
		nome="Jogador"+i.ToString();
		++i;
	}
	public Jogador(string n){
		energia=100;
		vivo=true;
		nome=n;
	}
	public Jogador(string n,int e){
		energia=e;
		vivo=true;
		nome=n;
	}
	public Jogador(string n,int e,bool v){
		energia=e;
		vivo=v;
		nome=n;
	}

	public void info(){
		Console.WriteLine("Nome do jogador: {0}",nome);
		Console.WriteLine("Energia do jogador: {0}",energia);
		Console.WriteLine("Estado do jogador: {0}",vivo);
		Console.WriteLine("-----------------------------\n");
	}
}