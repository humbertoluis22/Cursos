package br.com.alura;

import java.util.List;

public class TestaCurso {
	public static void main(String[] args) {
		
		Curso javaColecoes = new Curso("Dominando as coleÇões do java",
				"Humberto");
//		List<Aula> aulas = javaColecoes.getAula();
//		System.out.println(aulas);
		
//		aulas.add(new Aula("Trabalhando com ArrayList",21));
		
		
//	javaColecoes.getAula().add(new Aula("Trabalhando com ArrayList",21));
		javaColecoes.adiciona(new Aula("Trabalhando com ArrayList",21));
		javaColecoes.adiciona(new Aula("Criando uma aula",20));
		javaColecoes.adiciona(new Aula("Modelando com coleções",22));

		
//		System.out.println(aulas);
		
		System.out.println(javaColecoes.getAula());
	}

}