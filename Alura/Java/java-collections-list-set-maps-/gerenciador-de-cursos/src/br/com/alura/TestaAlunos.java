package br.com.alura;

import java.util.Collection;
import java.util.Collections;
import java.util.HashSet;
import java.util.Set;

public class TestaAlunos {

	public static void main(String[] args) {

		Collection<String> alunos = new HashSet<>();
		alunos.add("Humberto luis");
		alunos.add("isabella");
		alunos.add("Guilherme");
		alunos.add("maria");
		
//		for (String aluno : alunos) {
//			System.out.println(aluno);
//		}
		
		boolean contemHumberto = alunos.contains("Humberto luis");
		System.out.println(contemHumberto);
		
		System.out.println(alunos.size());
		
		alunos.forEach(aluno ->{
			System.out.println(aluno);
		});

		System.out.println(alunos);
}
}