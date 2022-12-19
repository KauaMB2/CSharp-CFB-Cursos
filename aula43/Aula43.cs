using System;

public interface Veiculo{
	void ligar();// Asssinatura ligar()
	void desligar();// Asssinatura desligar()
	void info();// Asssinatura info()
}
public interface Combate{
	void disparar();// Assinatura disparar()
	void setQtdMunicao();// Assinatura setQtdMunicao()
	void setQtdMunicao(int q);// Assinatura setQtdMunicao(int)
	int getMunicao();
}
class Carro:Veiculo,Combate{
	private int municao;
	private bool ligado;
	public Carro(){
		this.municao=50;
		this.ligado=true;
	}
	public void ligar(){
		this.ligado=true;
	}
	public void desligar(){
		this.ligado=false;
	}
	public void info(){}
	public void disparar(){
		this.municao-=5;
	}
	public void setQtdMunicao(){
		this.municao=50;
	}
	public void setQtdMunicao(int q){
		this.municao=50;
	}
	public int getMunicao(){
		return this.municao;
	}
}

class Aula43{
	static void Main(){
		Carro c1=new Carro();
		Console.WriteLine(c1.getMunicao());
		c1.disparar();
		Console.WriteLine(c1.getMunicao());
	}
}