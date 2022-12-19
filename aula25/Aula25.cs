using System;

class Aula25{
	static int x=10;
	static void Main(){
		somar1(x);//Passagem por valor(Enredeços diferentes na memória)
		Console.WriteLine(x);
		somar2(ref x);//Passagem por referência(Mesmo endereço na memória)
		Console.WriteLine(x);
	}
	static void somar1(int valor){
		valor*=2;//Multiplica valor por dois
	}
	static void somar2(ref int valor){
		valor*=2;//Multiplica valor por dois
	}
}
//https://pt.stackoverflow.com/questions/82630/o-que-s%C3%A3o-os-par%C3%A2metros-out-e-ref

// REF:
// -a variável deve ser inicializada antes de ser passada
// -dentro do método a variável não precisa ser modificada
// -os dados podem ser passados em ambas direções 

// OUT:
// -a variável não precisa ser inicializada
// -dentro do método a variável DEVE ser modificada (ou dá erro)
// -os dados só podem ser passados em apenas uma direção