
public class TestaBanco {
	public static void main(String[] args) {
		Cliente humberto = new Cliente();
		humberto.nome = "Humberto Luis";
		humberto.cpf = "222.222.222-22";
		humberto.profissao="programador";
		
		Conta contaDoHumberto = new Conta();
		contaDoHumberto.deposita(100);
		
		// associa o cliente humberto a contaDoHumberto
		contaDoHumberto.titular = humberto;
		System.out.println(contaDoHumberto.titular.nome);
	}
}
