
public class TestaCondicional {
	public static void main(String[] args) {
		System.out.println("testando condicionais");
		int idade = 12;
		int quantidadePessoas = 3;
		if (idade >= 18) {
			System.out.println("vc tem mais de 18 anos");
			System.out.println("seja bem vindo");
		}

		else {
			if (quantidadePessoas >= 2 ) {
				System.out.println("voce não tem 18, mas pode entrar, "
						+ "POIS ESTAO ACOMPANHADO");
				
			}
			else {
			System.out.println("infelizmente voce não pode entrar");
		}
	}
	}
}
