using System;

class Aula51{
	public static void Main(string[] args){
		if(args.Length>0){
			Console.WriteLine("Número de argumentos: {0}",args.Length);
			int r=0;
			for(int i=0;i<args.Length;i++){
				r+=int.Parse(args[i]);
			}
			Console. WriteLine(r);
		}else{
			Console.WriteLine("Não foram passados os argumentos");
		}
	}
}