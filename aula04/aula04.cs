using System;

class aula04{
	static int num=3;
	static void Main(){
		Console.WriteLine(num);
		printar();
	}
	static void printar(){
		Console.WriteLine(num);
	}
	//O comando static afirma que a função pertence à classe e por isso, não é necessário chamar a método utilizando objeto.
	//Sendo assim, chama-se o método pintar da seguinte forma: pintar()
	//Seria incorreto se o método fosse chamado da seguinte maneira: obj.pintar()
}