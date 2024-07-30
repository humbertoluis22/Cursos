
public class TestaContaSemCliente {
	public static void main(String[] args) {
		Conta contaDaMaria = new Conta();
		contaDaMaria.deposita(500);
		System.out.println(contaDaMaria.getSaldo());
		
		contaDaMaria.titular = new Cliente();
		contaDaMaria.titular.nome = "maria";
		System.out.println(contaDaMaria.titular.nome);
		
	}
}
