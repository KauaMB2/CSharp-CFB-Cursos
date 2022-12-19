using System;

class Aula18{
	static void Main(){
		byte[,] n=new byte[2,2];
		n[0,0]=3; n[0,1]=10;
		n[1,0]=30; n[1,1]=13;
		Console.WriteLine(n[0,1]);
	}
}