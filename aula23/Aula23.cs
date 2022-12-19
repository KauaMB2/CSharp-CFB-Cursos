using System;

class Aula23{
	static void Main(){
		int[] vetor1=new int [5];
        int[] vetor2=new int [5];
        int[] vetor3=new int [5];
        int[,] matriz=new int [2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random = new Random();
        for(int i=0; i<vetor1.Length;i++){
            vetor1[i]=random.Next(50,100);//(max,Min)
        }

        Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        Console.WriteLine("BinarySearch");
        int procurado=33;
        int pos=Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado,pos);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);//Copia todos os valores do vetor1 para o vetor2
        foreach(int n in vetor2){
        	Console.WriteLine(n);
    	}
        Console.WriteLine("-------------------------------------------");

    	Console.WriteLine("CopyTo");
    	vetor1.CopyTo(vetor3,0);//Todos os valores do vetor1 serão copiados para o vetor3 a partir da posição 0
    	foreach(int n in vetor3){
    		Console.WriteLine(n);
    	}
        Console.WriteLine("-------------------------------------------");

    	Console.WriteLine("GetLongLength");
    	long qtdeElementosVetor=vetor1.GetLongLength(0);//Pega a quantidade de elementos na matriz
    	Console.WriteLine("Quantidade de elementos: {0}",qtdeElementosVetor);
        Console.WriteLine("-------------------------------------------");
        
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor=vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Menor índice da matriz é {0} e do vetor é {1}",MenorIndiceMatriz_D1,MenorIndiceVetor);
        Console.WriteLine("-------------------------------------------");
        
         Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice da matriz é {0} e do vetor é {1}",MaiorIndiceMatriz_D1,MaiorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));//Retorna o valor so índice 3
        int valor1=Convert.ToInt32(matriz.GetValue(1,3));//Retorna o valor da linha 1 e coluna 3
		Console.WriteLine("Valores: {0}, {1}",valor0,valor1);
		Console.WriteLine("-------------------------------------------");

        Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1,3);//Retorna o índice do primeiro número 3 que ele encontrar no array
        Console.WriteLine("Índice do primeiro valor 3:{0}",indice1);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1,3);//Retorna o índice do último número 3 que ele encontrar no array
        Console.WriteLine("Índice do útlimo valor 3:{0}",indice2);
        Console.WriteLine("-------------------------------------------");
        
        Console.WriteLine("Reverse");
        Array.Reverse(vetor1);//Inverte as posições dos elementos no array
        foreach(int n in vetor1){
        	Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");
        
        Console.WriteLine("SetValue");
        for(int i=0;i<vetor2.Length;i++){
        	vetor2.SetValue(0,i);//Coloca o valor 0 no indice i no array
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
        	Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");
        
        Console.WriteLine("Sort");
        Array.Sort(vetor1);//Ordena o array na ordem crescente dos números
        Array.Sort(vetor2);//Ordena o array na ordem crescente dos números
        Array.Sort(vetor3);//Ordena o array na ordem crescente dos números
        Console.WriteLine("Vetor 1");
        foreach(int n in vetor1){
        	Console.WriteLine(n);
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
        	Console.WriteLine(n);
        }
        Console.WriteLine("Vetor 3");
        foreach(int n in vetor3){
        	Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");
    }
}