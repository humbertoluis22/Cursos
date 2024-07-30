package java8;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

 class Cursos {
	private String nome;
    private int alunos;

    public Cursos(String nome, int alunos) {
        this.nome = nome;
        this.alunos = alunos;
    }

    public String getNome() {
        return nome;
    }

    public int getAlunos() {
        return alunos;
    }
    
    
}


public class ExemploCurso {
	public static void main(String[] args) {
		List<Cursos> cursos = new ArrayList<Cursos>();
		cursos.add(new Cursos("Python" , 45));
		cursos.add(new Cursos("Javascript",150));
		cursos.add(new Cursos("java 8", 113));
		cursos.add(new Cursos("c",55));
		
	//lambda	
//	cursos.sort(Comparator.comparing(c -> c.getAlunos()));
		//reference
		cursos.sort(Comparator.comparing(Cursos:: getAlunos));
		
//		cursos.forEach(System.out::println);
	
		cursos.forEach(c -> System.out.println(c.getNome()));
		
//		cursos.stream().filter(c -> c.getAlunos() >=100).forEach(
//				c-> System.out.println(c.getNome()));

//		cursos.stream().filter(c -> c.getAlunos() >=100).map(c -> c.getAlunos())
//		.forEach(total -> System.out.println(total));;
		
		int sum = cursos.stream().filter(c -> c.getAlunos() >=100).mapToInt(c -> c.getAlunos()).sum();
		System.out.println(sum);
		
		Optional<Cursos> optionalCurso =cursos.stream()
			.filter(c -> c.getAlunos() >= 100)
			.findAny();

		//classe optional
//		Cursos curso = optionalCurso.get();
//		System.out.println(curso.getNome());
		
		optionalCurso.ifPresent(c -> System.out.println(c.getNome()));
		
		cursos =cursos.stream()
			.filter(c -> c.getAlunos() >= 100)
			.collect(Collectors.toList());
		
		cursos.stream()
			.forEach(c -> System.out.println(c.getNome()));
		
		
		
		cursos.stream()
			.filter(c -> c.getAlunos() >=100)
			.collect(Collectors.toMap(
					c -> c.getNome(),
					c -> c.getAlunos()))
			.forEach((nome,alunos) -> System.out.println(nome + " tem "  
					+ alunos + " alunos "));
	}
	
	
}