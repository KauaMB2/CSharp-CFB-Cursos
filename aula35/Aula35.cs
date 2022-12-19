using System;

class Aula34{
	static void Main(){
		Carro j1=new Carro("HB20","Vermelho");
		j1.Info();
		CarroCombate cc1=new CarroCombate();
		cc1.InfoCC();
	}
}
class Veiculo{
	private int rodas;
	private int velMax;
	private bool ligado;
	public Veiculo(int r,bool l,int v){//Função contrutora
		this.rodas=r;
		this.ligado=l;
		this.velMax=v;
	}
	public void setLigado(bool l){//Configura var ligado
		ligado=l;
	}
	public string getLigado(){//Pega var ligado
		return (ligado?"Sim":"Não");
	}
	public void setRodas(int r){//Configura var rodas
		this.rodas=r;
	}
	public int getRodas(){//Pega var rodas
		return this.rodas;
	}
	public int getVelMax(){//Pega var velMax
		return velMax;
	}
	public void setVelMax(int v){//Configura var velMax
		this.velMax=v;
	}
}
class Carro:Veiculo{//Classe carro herda a classe Veiculo
	private string cor;
	private string nome;
	public Carro(string nome, string cor):base(4,false,120){
		this.nome=nome;
		this.cor=cor;
	}
	public string getCor(){//Pega var cor
		return this.cor;
	}
	public string getNome(){//Pega var nome
		return this.nome;
	} 
	public void Info(){
		Console.WriteLine("Cor.........: {0}",this.cor);
		Console.WriteLine("Nome........: {0}",this.nome);
		Console.WriteLine("Rodas.......: {0}",this.getRodas());
		Console.WriteLine("Vel.Maxima..: {0}",this.getVelMax());
		Console.WriteLine("Ligado......: {0}",this.getLigado());
		Console.WriteLine("------------------------");
	}
}
class CarroCombate:Carro{
	private int municao;
	public CarroCombate():base("Carro combate","Verde"){
		this.municao=100;
		this.setRodas(8);
		this.setVelMax(80);
		this.setLigado(true);
	}
	public int getMonicao(){
		return municao;
	}
	public void InfoCC(){
		Console.WriteLine("Cor.........: {0}",this.getCor());
		Console.WriteLine("Nome........: {0}",this.getNome());
		Console.WriteLine("Rodas.......: {0}",this.getRodas());
		Console.WriteLine("Vel.Maxima..: {0}",this.getVelMax());
		Console.WriteLine("Ligado......: {0}",this.getLigado());
		Console.WriteLine("Monição.....: {0}",this.getMonicao());
		Console.WriteLine("------------------------");
	}
}
