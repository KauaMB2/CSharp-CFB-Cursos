using System;

class Aula33{
	static void Main(){
		Jogador j1=new Jogador("Bruno");
		j1.Info();
		j1.setEnergia(+50);
		j1.Info();
		j1.setEnergia(-150);
		j1.Info();
	}
}
class  Jogador{
	private string nome;
	private int energia;
	public Jogador(string nome){
		 this.nome=nome;
		 this.energia=100;
	}
	public int getEnergia(){
		return energia;
	}
	public string getNome(){
		return nome;
	}
	public void setEnergia(int e){
		this.energia+=e;
		if(this.energia>100){
			this.energia=100;
		}
		if(this.energia<0){
			this.energia=0;
		}
	}
	public void Info(){
		Console.WriteLine("Nome....: {0}",this.nome);
		Console.WriteLine("energia.: {0}",this.energia);
	}
}