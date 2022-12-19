using System;

delegate float Op(params float[] nums);//Delegate
class Mat{
	public static float pi=3.1415F;
	public static float somar(params float[] n){
		float r=0;
		for(int i=0;i<n.Length;i++){
			r+=n[i];
		}
		return r;
	}
	public static float mult(params float[] n){
		float r=1;
		for(int i=0;i<n.Length;i++){
			r*=n[i];
		}
		return r;
	}
}
class Aula49{
	public static float vpi=Mat.pi;
	public static void Main(){
		Op d1=new Op(Mat.mult);//d1=Mat.mult()
		Op d2=new Op(Mat.somar);//d2=Mat.somar()
		Console.WriteLine(d1(vpi,vpi,vpi,vpi,vpi));
		Console.WriteLine(d2(vpi,vpi,vpi,vpi,vpi));
	}
}