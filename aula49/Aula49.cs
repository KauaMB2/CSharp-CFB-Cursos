using System;

class Mat{
	public static float pi=3.1415F;
	public static float dobrar(float n){
		return n*2;
	}
}
class Aula49{
	public static float vpi=Mat.pi;
	public static void Main(){
		Console.WriteLine(Mat.dobrar(vpi));
	}
}