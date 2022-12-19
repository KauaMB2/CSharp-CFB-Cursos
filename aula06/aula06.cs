using System;

class aula06{
	static void Main(){
		int n1,n2,n3;
		n1=10;n2=20;n3=30;
		Console.Write("\nn1={0}\nn2={1}\nn3={2}\n",n1,n2,n3);

		float valorCompra=5.5F;
		float valorVenda=0F;
		float lucro=0.1F;
		string produto="Pastel";

		valorVenda=valorCompra+(valorCompra*lucro);
		Console.WriteLine("Produto.....:{0,15}",produto);//0=> index, 15=> Espaçamento
		Console.WriteLine("Val.Compra..:{0,15:c}",valorCompra);//0=> index, 15=> Espaçamento, :c => "R$"
		Console.WriteLine("Lucro.......:{0,15:p}",lucro);//0=> index, 15=> Espaçamento, :c => "%"
		Console.WriteLine("Val.Venda...:{0,15:c}",valorVenda);//0=> index, 15=> Espaçamento, :c => "R$"
	}
}