package br.com.alura.java.io.teste;

import java.io.BufferedWriter;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.Writer;

public class TesteEscrita {

	public static void main(String[] args) throws IOException {
		
		//fluxo de entrada com arquivo
		
		OutputStream fos = new FileOutputStream("lorem2.txt");
		Writer  osw  = new OutputStreamWriter(fos);
		BufferedWriter bw = new BufferedWriter (osw);
		
		bw.write("testando as saidas em java com a classe java.io");
		bw.newLine();
		bw.newLine();
		bw.write("mais um teste sendo realizado para saida ");
		
		
		bw.close();
		
	}

}
