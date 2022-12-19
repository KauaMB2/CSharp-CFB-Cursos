using System;

sealed public class Operario{//Não posso herdar classes "sealed". "sealed" bloqueia a herança
	public int forca;
	public bool EPIs;
	public Operario(int forca, bool EPIs){
		this.forca=forca;
		this.EPIs=EPIs;
	}
	public void info(){
		Console.WriteLine(this.forca);
		Console.WriteLine(this.EPIs);
	}
}
class Aula40{
	static void Main(){
		Operario op=new Operario(100,true);
		op.info();
	}
}