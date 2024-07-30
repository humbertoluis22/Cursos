package br.com.alura.java.io.teste;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutput;
import java.io.ObjectOutputStream;

public class TesteSerializacao {

	public static void main(String[] args) throws  IOException, ClassNotFoundException {

//	String nome = "Humberto Luis";
//	ObjectOutputStream oos= new ObjectOutputStream(new FileOutputStream("obejto.bin"));
//	oos.writeObject(nome);
//	oos.close();
	
	ObjectInputStream ios=new  ObjectInputStream(new FileInputStream("obejto.bin"));
	String nome =(String)ios.readObject();
	ios.close();
	System.out.println(nome);
	
	}

}
