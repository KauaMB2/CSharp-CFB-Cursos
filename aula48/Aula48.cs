using System;

class Recursividade{
	public static int Fat(int n){
		int res=0;
		if(n<=1){
			res=1;
		}else{
			res=n*Fat(n-1);
			Console.WriteLine("{0} - {1}",n,res);
		}
		return res;
	}
}
class Aula48{
	public static void Main(){
		Console.WriteLine(Recursividade.Fat(6));
	}
}