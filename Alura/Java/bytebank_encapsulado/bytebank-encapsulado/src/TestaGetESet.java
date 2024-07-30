
public class TestaGetESet {
	public static void main(String[] args) {
		Conta conta = new Conta(1337, 24226);
		//conta.numero = 1233;
		conta.setNumero(1233);
		System.out.println(conta.getNumero());
		
		Cliente humberto = new Cliente();
		//Conta.titular = humberto;
		
		humberto.setNome("Humberto Luis");
		conta.setTitular(humberto);
		System.out.println(conta.getTitular().getNome());
		
		conta.getTitular().setProfissao("Programador");
		System.out.println(conta.getTitular().getProfissao());
		
		// estao no mesmo destino de referencia !
		System.out.println(humberto);
		System.out.println(conta.getTitular());
	}

}
