
public class TesteGerente {

	public static void main(String[] args) {
		
		Autenticavel refencia  = new Gerente(); 
		
		
		
		Gerente g1 = new Gerente();
		g1.setNome("humberto luis");
		g1.setCpf("23432354365");
		g1.setSalario(5000.00);
		
		System.out.println(g1.getNome());
		System.out.println(g1.getCpf());
		System.out.println(g1.getSalario());
		
		
		g1.setSenha(222);
		boolean autenticou = g1.autentica(222);
		System.out.println(autenticou);
		
		System.out.println(g1.getBonificacao());
	}

}
