using System;

class aula09{
	static void Main(){

		//OPERADORES BITWISE
		int x=10;//00001010
		Console.WriteLine(x);
		x=x<<1;//00010100
		Console.WriteLine(x);
		x=x<<1;//00101000
		Console.WriteLine(x);
		x=x<<1;//01010000
		Console.WriteLine(x);
		x=x<<1;//10100000
		Console.WriteLine(x);
		//------------
		Console.WriteLine(x);
		x=x>>1;//01010000
		Console.WriteLine(x);
		x=x>>1;//00101000
		Console.WriteLine(x);
		x=x>>1;//00010100
		Console.WriteLine(x);
		x=x>>1;//00001010
		Console.WriteLine(x);
	}
}