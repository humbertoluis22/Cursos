package br.com.alura.tdd;

import org.junit.jupiter.api.Test;

import junit.framework.Assert;

public class CalculadoraTest {
	
	
	//cada cenario vira um metodo para teste e nao se usa o main. @Test para informar que teste atraves do junit
	
	@Test
	public void deveriaSomarDoisNumerosPositivos() {
		Calculadora calc = new Calculadora();
		int soma = calc.somar(3, 7);
		
		Assert.assertEquals(12, soma);
	}
}
