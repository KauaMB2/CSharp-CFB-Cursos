using System;

class Aula11{
	static void Main(){
		int x=10;
		short y=(short)x;//Converte cariável "x"(32Bits) para "y"(16Bits) 
		Console.WriteLine("{0}=>{1} - {2}=>{3}",x,x.GetType(),y,y.GetType());
	}
}