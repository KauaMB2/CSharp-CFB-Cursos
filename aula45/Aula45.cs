using System;


struct Carro{
	public string cor;

	public Carro(string marca, string modelo, string cor){
		this.cor=cor;
	}
}
class Aula44{
	static void Main(){
		Carro[] c=new Carro[5];
		c[0].cor="Azul";
		c[1].cor="Violeta";
		c[2].cor="Amarelo";
		c[3].cor="Vermelho";
		for(int i=0;i<c.Length;i++){
			Console.WriteLine(c[i].cor);
		}
	}
}

//Struct não é considerado uma classe. Struct é como se fosse uma classe, porém mais leve pasra o processamento.