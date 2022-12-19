using System;

class Aula27{
	static void Main(){
		int[] valores={1,2,3,5,7,11,13,17,19,23};
		soma(valores);	
	}
	static void soma(params int[] num){// O argumento "params" permite você enviar um array de qualquer tamanho para dentro do método  
		Console.WriteLine("Número de elementos passados: "+num.Length);
		if(num.Length<1){
			Console.WriteLine("Não existem valores a serem somados");
		}else if(num.Length<2){
			Console.WriteLine("Somente um valor foi passado: {0}",num[0]);
		}else{
			int res=0;
			for(int i=0;i<num.Length;i++){
				res+=num[i];
				Console.WriteLine("{0} - {1} - {2}",res,num[i],i);
			}
			Console.WriteLine("O resultado da soma é: {0}",res);
		}
	}
}