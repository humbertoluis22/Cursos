
public class TesteFuncionario {

	public static void main(String[] args) {
		
		
		
		
		Gerente humberto = new Gerente();
		humberto.setNome("Humberto Luis ");	
		humberto.setCpf("23465489789");
		humberto.setSalario(2600.00);
		
		System.out.println(humberto.getNome());
		System.out.println(humberto.getSalario());
		System.out.println(humberto.getBonificacao());
	}

}
