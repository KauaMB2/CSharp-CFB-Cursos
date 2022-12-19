using System;

namespace aula02{
	class Program{
	    static void Main(string[] args){
	    	if(args.GetLength(0)>0){
	    		Console.WriteLine(args.GetValue(0));
	    	}
	        Console.WriteLine("Hello, World!");
	    }
	}
}
//dotnet new console --use-program-main