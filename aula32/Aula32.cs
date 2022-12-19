using System;

class Aula32{
	static void Main(){
		Calcular c=new Calcular(4,6);
		Console.WriteLine(c.Soma());
	}
}
class Calcular{
	int v1;//this.v1
	int v2;//this.v2
	public Calcular(int v1,int v2){
		this.v1=v1;
		this.v2=v2;
	}
	public int Soma(){
		return v1+v2;
	}
}
//this refere-se ao objeto em questão.