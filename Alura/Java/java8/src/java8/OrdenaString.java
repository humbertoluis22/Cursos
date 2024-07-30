package java8;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import java.util.function.Consumer;

public class OrdenaString {
	public static void main(String[] args) {
		List<String> palavras = new ArrayList<String>();
		palavras.add("alura online");
		palavras.add("editora casa do codigo");
		palavras.add("caelum");

//		Comparator comparador = new ComparadorPorTamanho();
		// Collections.sort(palavras,comparador);

		// classe anonima
//		palavras.sort(new Comparator<String>() {
//			@Override
//			public int compare(String s1, String s2) {
//				if(s1.length()< s2.length())
//					return -1;
//				if(s1.length() > s2.length())
//					return 1;
//				return 0;
//			}
//			
//		});

		// lambda
//		palavras.sort(( s1,  s2) -> {
//				if(s1.length()< s2.length())
//					return -1;
//				if(s1.length() > s2.length())
//					return 1;
//				return 0;
//			}	
//		);

		palavras.sort((s1, s2) -> Integer.compare(s1.length(), s2.length()));

		
		System.out.println(palavras);

//		for (String p : palavras) {
//			System.out.println(p);
//		}

		// classe anonima
//		
//		Consumer<String>  consumidor = new Consumer<String>() {
//			@Override
//			public void accept(String s) {
//				System.out.println(s);
//			}
//		};

//		palavras.forEach(new Consumer<String>() {
//			@Override
//			public void accept(String s) {
//				System.out.println(s);
//			}
//		});

		// lambda
		palavras.forEach(s -> System.out.println(s));

	}
}

//class ImprimeNaLinha implements Consumer<String>{
//
//	@Override
//	public void accept(String arg0) {
//		System.out.println(arg0);
//	}
//	
//	
//}

//
//class ComparadorPorTamanho implements Comparator<String>{
//
//	@Override
//	public int compare(String s1, String s2 ) {
//		if(s1.length()< s2.length())
//			return -1;
//		if(s1.length() > s2.length())
//			return 1;
//		return 0;
//	}
//	
//	
//}