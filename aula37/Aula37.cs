using System;

class Aula37{
	static void Main(){
		Derivada2 teste=new Derivada2();
		Console.WriteLine("\n\nCom isso concluímos que quando instanciamos um objeto, a ordem de execução vai da classe Base(Classe pai) até a classe derivada(Classe filho que foi chamada na instanciação do objeto)");
	}
}

class Base{
	public Base(){
		Console.WriteLine("Construtor da classe Base");
	}
}
class Derivada1:Base{
	public Derivada1():base(){
		Console.WriteLine("Construtor da classe Derivada1");
	}
}
class Derivada2:Derivada1{
	public Derivada2():base(){
		Console.WriteLine("Construtor da classe Derivada2");
	}
}