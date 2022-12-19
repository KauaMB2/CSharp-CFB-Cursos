using System;

class Aula10{
	enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
	static void Main(){
		DiasSemana x1=DiasSemana.Sexta;
		int x2=(int)DiasSemana.Sexta;
		DiasSemana x3=(DiasSemana)3;

		Console.Write("{0}\n{1}\n{2}",x1,x2,x3);
	}
}