
public class TesteSacaNegativo {

	public static void main(String[] args) {
		Conta  c = new Conta();
		c.deposita(100);
		c.saca(300);
		System.out.println((c.saca(200)));
		System.out.println(c.getSaldo());
		
		
		//proibido 
		// só utilizar o metodo e não atributo
		// private não poed ser modificado e nem lido por outras classes 
		
		/*c.saldo = c.saldo - 200;
		System.out.println(c.saldo);*/
	}
}
