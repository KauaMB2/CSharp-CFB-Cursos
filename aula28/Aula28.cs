using System;

class Aula28{
	static void Main(){
		Jogador j1=new Jogador();
		Console.WriteLine(j1.energia);
	}
}
public class Jogador{
	public int energia=100;
	public bool vivo=true;
	public Jogador(){
		this.energia=100;
		this.vivo=true;
	}
}