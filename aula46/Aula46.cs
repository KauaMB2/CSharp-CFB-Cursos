using System;

class Galinha{
	private string nome;
	private int numOvo;
	public Galinha(string nome){
		this.nome=nome;
		numOvo=0;
	}
	public Ovo botar(){
		Ovo ovo=new Ovo(this.nome);//Cria objeto Ovo
		this.numOvo+=1;
		Console.WriteLine("Ovo criado: {0} | {1} | Total: {2}",this.numOvo,this.nome,ovo.getQtdTTOvo());
		return ovo;//Retorna objeto Ovo
	}
}
class Ovo{
	private string nomeGalinha;
	private static int numTotalOvo=0;
	public Ovo(string nomeGalinha){
		this.nomeGalinha=nomeGalinha;
		numTotalOvo++;
		Console.WriteLine("Novo ovo criado");
	}
	public int getQtdTTOvo(){
		return numTotalOvo;
	}
}
class Aula46{
	static void Main(){
		Galinha g1=new Galinha("Joana");
		Galinha g2=new Galinha("Kauã");
		for(int i=0;i<5;i++){
			g1.botar();
		}
		for(int i=0;i<5;i++){
			g2.botar();
		}
	}
}

