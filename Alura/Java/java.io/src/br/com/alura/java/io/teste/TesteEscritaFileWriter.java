package br.com.alura.java.io.teste;

import java.io.BufferedWriter;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.Writer;

public class TesteEscritaFileWriter {

	public static void main(String[] args) throws IOException {
		
		//fluxo de entrada com arquivo
		
//		OutputStream fos = new FileOutputStream("lorem2.txt");
//		Writer  osw  = new OutputStreamWriter(fos);
//		BufferedWriter bw = new BufferedWriter (osw);

		
		//segunda aula
//		
//		FileWriter fw= new FileWriter("lorem2.txt");
//		fw.write("testando as saidas em java com a classe java.io com a classe filewriter");
//		//fw.write("\n");  //caracter especial para pular linha  
//		fw.write(System.lineSeparator()); //para pular linha em qualquer sistema operacional
//		fw.write("continuando os testes");
//		
//		
//		fw.close();
		
		
		FileWriter fw= new FileWriter("lorem2.txt");
		BufferedWriter bw = new BufferedWriter(fw);
		bw.write("codigo mais avançado e elegante ");
		bw.newLine();
		bw.write("usando outra classe, agr a BufferedWriter ");
		bw.close();
		
		
		
//		bw.write("testando as saidas em java com a classe java.io");
//		bw.newLine();
//		bw.newLine();
//		bw.write("mais um teste sendo realizado para saida ");
		
		
//		bw.close();

		
		
	}

}
