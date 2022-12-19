using System;


class Veiculo{
	private int velMax;
	protected int velAtual;
	public Veiculo(int vm,int va){
		this.velMax=vm;
		this.velAtual=va;
	}
	public int getVelMax(){
		return this.velMax;
	}
}
class Carro:Veiculo{
	private bool ligado;
	private int rodas;
	private int portas; 
	public Carro(bool l,int r,int p):base(100,20){
		this.ligado=l;
		this.rodas=r;
		this.portas=p;
	}
	public int getVelAtual(){
		return this.velAtual;
	}
	public void modificaVel(int v){
		this.velAtual+=v;
		int velMax=getVelMax();
		if(this.velAtual>velMax){
			this.velAtual=velMax;
		}
		if(this.velAtual<0){
			this.velAtual=0;
		}
	}
}
class Aula36{
	static void Main(){
		Carro c1=new Carro(true,8,4);
		info:
			Console.WriteLine(c1.getVelAtual());
			Console.WriteLine(c1.getVelMax());

		pergunta:
			Console.Write("Digite \"A\" para aumentar a velocidade, \"D\" para diminuir e \"S\" para sair: ");
			string resposta=Console.ReadLine();
			char res;
			if(resposta.Length>1){
				Console.WriteLine("Você digitou um caracter inválido");
				goto pergunta;//GOTO
			}
			else{
				res=resposta[0];
			}
			switch(res){
				case 'A': case 'a':
					c1.modificaVel(+5);
					goto info;
					break;
				case 'D': case 'd':
					c1.modificaVel(-5);
					goto info;
					break;
				case 'S': case 's':
					Console.Write("Fim do programa!");
					break;
				default:
					Console.WriteLine("Você digitou um caracter inválido");
					goto pergunta;//GOTO
					break;
			}
	}
}