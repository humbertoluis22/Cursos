
public class TestaEscopo {
	public static void main(String[] args) {

		System.out.println("testando condicionais");
		int idade = 19;
		int quantidadePessoas = 3;
		
		
		// variaveis se cria fora dos laços, pq dentro dos laços ela é declarada somente para aquele pedaço do codigo desde do primeiro { ate o  proximo }
		boolean acompanhado = quantidadePessoas >=2;
		
		
		
		System.out.println("o valor de acompanhado é " + acompanhado);
		if (idade >= 18 && acompanhado ) {
			System.out.println("seja bem vindo");
		}

		else {
			System.out.println("infelizmente voce não pode entrar");
		}
	}
}
