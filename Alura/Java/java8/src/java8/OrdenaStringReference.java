package java8;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import java.util.function.Consumer;

public class OrdenaStringReference {
	public static void main(String[] args) {
		List<String> palavras = new ArrayList<String>();
		palavras.add("alura online");
		palavras.add("editora casa do codigo");
		palavras.add("caelum");



		//palavras.sort((s1, s2) -> Integer.compare(s1.length(), s2.length()));
//		palavras.sort(Comparator.comparing(s  -> s.length()));
		palavras.sort(Comparator.comparing(String::length));

		System.out.println(palavras);


		palavras.forEach(s -> System.out.println(s));

//METODO REFERENCE		
		palavras.forEach(System.out::println);

	}

}

