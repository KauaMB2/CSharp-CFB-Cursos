using System;

class Aula52{
	public static void Main(){
		int n1=0;
		int n2=10;
		int res=0;
		try{
			res=n2/n1;
			Console.WriteLine("{0}/{1}={2}",n2,n1,res);
		}catch(DivideByZeroException e){
			Console.WriteLine("ERRO: {0}",e.Message);
			Console.WriteLine("Ex: {0}",e.GetType());
		}
	}
}