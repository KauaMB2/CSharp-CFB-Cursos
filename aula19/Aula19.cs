using System;

class Aula19{
	static void Main(){
		byte[] num=new byte[10];
		for(byte i=0;i<num.Length;i++){
			num[i]=(byte)(5*i);//(byte) converte pasa byte
		}
		for(byte i=0;i<num.Length;i++){
			Console.WriteLine("Valor de num na pos{0}: {1}",i,num[i]);
		}
	}
}