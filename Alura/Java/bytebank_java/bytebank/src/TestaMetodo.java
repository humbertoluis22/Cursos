
public class TestaMetodo {
	public static void main(String[] args) {
		Conta contaDoHumberto = new Conta();
		contaDoHumberto.saldo= 100;
		contaDoHumberto.deposita(50);
		
		System.out.println(contaDoHumberto.saldo);
		
		boolean conseguiuRetirar =contaDoHumberto.saca(150);
		System.out.println(contaDoHumberto.saldo);
		System.out.println(conseguiuRetirar);
		
		Conta contaDaMaria = new Conta();
		contaDaMaria.saldo = 1000;
		
		//pode usar o if pq o metodo devolve um valor boolean
		if(contaDaMaria.transfere(300, contaDoHumberto)) {
			System.out.println("transferencia realizada com sucesso");
		}
		else {
			System.out.println("nã foi possivel realizar a transferencia");
		}
		System.out.println(contaDaMaria.saldo);
		System.out.println(contaDoHumberto.saldo);
			
		
		contaDoHumberto.titular = "Humberto Luis";
		System.out.println(contaDoHumberto.titular);
		
	}

}
