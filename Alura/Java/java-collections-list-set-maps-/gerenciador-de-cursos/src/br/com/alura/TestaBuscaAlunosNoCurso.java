package br.com.alura;

public class TestaBuscaAlunosNoCurso {
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
		
		System.out.println("quem é o aluno com matricula 2343?");
		Aluno aluno2 =javaColecoes.buscaMatriculado(234);
		System.out.println("aluno: " + aluno2);
}
	

}
