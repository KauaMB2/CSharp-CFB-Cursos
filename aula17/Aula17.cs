using System;

class Aula17{
	static void Main(){
		byte[] x=new byte[5];

		x[0]=11;
		x[1]=22;
		x[2]=33;
		x[3]=44;
		x[4]=55;

		byte[] y=new byte[3]{55,66,77};
		byte[] z={55,77,99};
		Console.WriteLine(x[0]);
		Console.WriteLine(y[0]);
		Console.WriteLine(z[0]);
	}
}