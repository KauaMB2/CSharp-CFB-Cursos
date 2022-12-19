using System;

class Aula26{
	

	static void Main(){
		int quociente=0;
		int resto=0;

		Console.WriteLine("Entre com o valor do dividendo");
		int dividendo=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Entre com o valor do divisor");
		int divisor=Convert.ToInt32(Console.ReadLine());

		quociente=dividir(dividendo,divisor,out resto);
		Console.WriteLine("{0}/{1} = {2}, resto {3}", dividendo, divisor, quociente, resto);
	}
	static int dividir(int dividendo, int divisor, out int resto) {
        int quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
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