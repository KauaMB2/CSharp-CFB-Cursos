using System;


struct Carro{
	public string marca;
	public string modelo;
	public string cor;

	public Carro(string marca, string modelo, string cor){
		this.marca=marca;
		this.modelo=modelo;
		this.cor=cor;
	}
	public void info(){
		Console.WriteLine("Marca.: {0}",this.marca);
		Console.WriteLine("Modelo: {0}",this.modelo);
		Console.WriteLine("Cor...: {0}",this.cor);
		Console.WriteLine("------------------------------");
	}
}
class Aula44{
	static void Main(){
		Carro c1=new Carro("Toyota","Corola","Azul");
		c1.info();
		c1.marca="OutraMarca";
		c1.modelo="OutroModelo";
		c1.cor="Vermleho";
		c1.info();
	}
}

//Struct não é considerado uma classe. Struct é como se fosse uma classe, porém mais leve pasra o processamento.