using System;

class Aula38{
	static void Main(){
		Derivada1 d1=new Derivada1();
		Derivada2 d2=new Derivada2();
		d1.info();
		d2.info();
	}
}

class Base{
	public Base(){
		Console.WriteLine("Construtor da classe Base");
	}
	virtual public void info(){}//O 'virtual" afirma que esse método poderá ser sobrescrito nas classes derivadas
}
class Derivada1:Base{
	public Derivada1():base(){
		Console.WriteLine("Construtor da classe Derivada1");
	}
	override public void info(){// "override" indica que o método será sobrescrito
		Console.WriteLine("Derivada1");
	}
}
class Derivada2:Derivada1{
	public Derivada2():base(){
		Console.WriteLine("Construtor da classe Derivada2");
	}
	override public void info(){// "override" indica que o método será sobrescrito
		Console.WriteLine("Derivada2");
	}
}