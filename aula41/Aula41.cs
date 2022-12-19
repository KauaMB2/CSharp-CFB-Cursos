using System;

public class Flor{
	public string cor;
	public string corSetGet{
		get{// Acessor GET
			return this.cor;
		}
		set{// Acessor SET
			this.cor=value;
		}
	}
	public Flor(string c){
		this.cor=c;
	}
}
class Aula41{
	static void Main(){
		Flor f1=new Flor("Violeta");
		Console.WriteLine(f1.corSetGet);// Chama acessor GET
		f1.cor="Rosa";// Chama acessor SET
		Console.WriteLine(f1.corSetGet);// Chama acessor GET
	}
}