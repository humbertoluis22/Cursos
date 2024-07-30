
public class TesteReferencia {
	public static void main(String[] args) {
		Conta primeiraConta = new Conta();
		primeiraConta.saldo = 300;
		System.out.println("o saldo da primeira conta é de " + primeiraConta.saldo);
		
		
		//outra flecha para o mesmo objeto
		// o =   diz q o obejto dae esquerda vai receber o valor do da direita
		//porem nesse caso o valor da direita é uma referencia, sendo assim não possui 
		// um valor especifico e sim uma referencia 
		Conta segundaConta = primeiraConta;
		// o endereço da flecha
		System.out.println(segundaConta);
		// o valor q esta no endereço
		System.out.println("saldo da segunda conta: "+ segundaConta.saldo);
		
		segundaConta.saldo += 100;
		System.out.println("saldo da segunda conta: "+ segundaConta.saldo);
		
		System.out.println(primeiraConta.saldo);
		
		if(primeiraConta ==  segundaConta) {
			System.out.println("sim, vc só tem uma conta,"
					+ " os nomes sao referencias");
		}
	}
}
