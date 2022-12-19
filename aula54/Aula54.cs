using System;

namespace Calc1{
	class Area{
		public static void Quad(float altura, float largura){
			if((altura==0)||(largura==0)){
				throw new Exception("Altura e largura não podem ser iguais a zero");
			}
			Console.WriteLine(altura*largura);
		}
	}
}
namespace Calc2{
	class Area{
		public static void Quad(float altura, float largura){
			if((altura==0)||(largura==0)){
				throw new Exception("Altura e largura não podem ser iguais a zero");
			}
			Console.WriteLine(altura*largura);
		}
	}
}
class Aula53{
	public static void Main(){
		try{
			Calc1.Area.Quad(2,2);
		}catch(DivideByZeroException e){
			Console.WriteLine("ERRO: {0}",e.Message);
			Console.WriteLine("Ex: {0}",e.GetType());
		}
		try{
			Calc2.Area.Quad(3,4);
		}catch(DivideByZeroException e){
			Console.WriteLine("ERRO: {0}",e.Message);
			Console.WriteLine("Ex: {0}",e.GetType());
		}
	}
}