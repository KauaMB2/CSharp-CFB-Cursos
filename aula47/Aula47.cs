using System;

class Calc{
	//SOBRECARGA DE MÉTODOS
	public static int soma(params int[] n){
		int s=0;
		for(int i=0;i<n.Length;i++){
			s+=n[i];
		}
		return s;
	}
	public static double soma(params double[] n){
		double s=0;
		for(int i=0;i<n.Length;i++){
			s+=n[i];
		}
		return s;
	}
}
class Aula47{
	static void Main(){
		Console.WriteLine(Calc.soma(10.5,19.2));
		Console.WriteLine(Calc.soma(10,19));
	}
}