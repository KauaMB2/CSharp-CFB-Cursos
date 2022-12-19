using System;

public class Flor{
	public string[] cor=new string[5]{"Azul","Verde","Amarelo","Violeta","Rosa"};
	public string this[int i]{
		get{// Acessor GET
			return this.cor[i];
		}
		set{// Acessor SET
			this.cor[i]=value;
		}
	}
	public Flor(string c){
		this.cor[0]=c;
	}
}
class Aula41{
	static void Main(){
		Flor f1=new Flor("Vermelho");
		Console.WriteLine(f1[4]);// Chama acessor GET
		f1[4]="Preto";// Chama acessor SET
		Console.WriteLine(f1[4]);// Chama acessor GET
	}
}