using System;

class Aula39{
	static void Main(){
		Carro c1=new Carro();
		for(int i=0;i<5;i++){
			c1.aceleracao(5);
		}
	}
}
abstract class Veiculo{// "abstract" define que a classe Veiculo não pode ser instanciada, somente herdada, portanto, é uma classe de referência para outras classes
	protected int velAtual;
	protected bool ligado;
	public void setLigado(bool ligado){
		this.ligado=ligado;
	}
	abstract public void aceleracao(int v);
}
class Carro:Veiculo{
	public Carro(){
		this.ligado=false;
		this.velAtual=20;
	}
	override public void aceleracao(int v){
		this.velAtual+=v;
		Console.WriteLine(this.velAtual);
	}
}