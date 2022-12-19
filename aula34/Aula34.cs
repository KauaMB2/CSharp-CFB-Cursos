using System;

class Aula34{
	static void Main(){
		Carro j1=new Carro("HB20","Vermelho");
		j1.Info();
	}
}
class Veiculo{
	public int rodas;
	public int velMax;
	private bool ligado;
	public void ligar(){
		this.ligado=true;
	}
	public void desligar(){
		this.ligado=false;
	}
	public string getLigado(){
		if(ligado){
			return "Sim";
		}else{
			return "Não";
		}
	}

}
class Carro:Veiculo{//Classe carro herda a classe Veiculo
	private string cor;
	private string nome;
	public Carro(string nome, string cor){
		this.desligar();
		this.nome=nome;
		this.cor=cor;
		this.rodas=4;
		this.velMax=120;
	}
	public void Info(){
		Console.WriteLine("Cor.........: {0}",this.cor);
		Console.WriteLine("Nome........: {0}",this.nome);
		Console.WriteLine("Rodas.......: {0}",this.rodas);
		Console.WriteLine("Vel.Maxima..: {0}",this.velMax);
		Console.WriteLine("Ligado......: {0}",this.getLigado());
	}
}
