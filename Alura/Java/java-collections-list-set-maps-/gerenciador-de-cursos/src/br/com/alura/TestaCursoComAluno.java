package br.com.alura;

import java.util.Iterator;
import java.util.Set;

public class TestaCursoComAluno {
	public static void main(String[] args) {
		
		Curso javaColecoes = new Curso("Dominando as coleÇões do java",
				"Humberto");
		
		javaColecoes.adiciona(new Aula("Trabalhando com ArrayList",21));
		javaColecoes.adiciona(new Aula("Criando uma aula",20));
		javaColecoes.adiciona(new Aula("Modelando com coleções",22));

		Aluno a1= new Aluno("HUMBERTO", 32443);
		Aluno a2 = new Aluno("Guilherme", 2343);
		Aluno a3 =  new Aluno("maria",23324);
		
		javaColecoes.matricula(a1);
		javaColecoes.matricula(a2);
		javaColecoes.matricula(a3);
		
		System.out.println("todos os aluno matriculados:");
//		javaColecoes.getAlunos().forEach(a -> {
//			System.out.println(a);
//		} );

		
		Set<Aluno> aluno= javaColecoes.getAlunos();
		Iterator<Aluno> iterador = aluno.iterator();
//		iterador.hasNext()
		while(iterador.hasNext()){
			Aluno proximo= iterador.next();
			System.out.println(proximo);
		}
		
		
		
		
		
		System.out.println("O aluno " + a1 + " esta matriculado? ");
		System.out.println(javaColecoes.estaMatriculado(a1));
		
		
		Aluno humberto = new Aluno("HUMBERTO", 777);
		System.out.println("o aluno humberto oliveira esta cadastrado?");
		System.out.println(javaColecoes.estaMatriculado(humberto));
		
		System.out.println("o a1 é igual ao humberto? ");
		System.out.println(a1.equals(humberto));
		
	}
}
