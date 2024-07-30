package br.com.alura.java.io.teste;

import java.io.BufferedWriter;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintStream;
import java.io.Writer;

public class TesteEscritaPrintStreamPrintWriter {

	public static void main(String[] args) throws IOException {
		
//		FileWriter fw= new FileWriter("lorem2.txt");
		
		PrintStream ps= new PrintStream("lorem2.txt");

		ps.println("codigo mais avançado e elegante");
		ps.println();
		ps.println("usando outra classe, agr a PrintStream");

		ps.close();
		
		
	}

}
