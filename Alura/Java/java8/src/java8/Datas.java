package java8;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.Month;
import java.time.Period;
import java.time.format.DateTimeFormatter;

public class Datas {
	public static void main(String[] args) {
		LocalDate hoje = LocalDate.now();
		System.out.println(hoje);
		
		LocalDate olimpiadasRio = LocalDate.of(2016, Month.JUNE, 5);
		
		int anos = hoje.getYear() - olimpiadasRio.getYear();
		System.out.println(anos);
		
		Period periodo= Period.between(hoje, olimpiadasRio);
		System.out.println(periodo);
		
		LocalDate proximasOlimpiadas = olimpiadasRio.plusYears(8);
		System.out.println(proximasOlimpiadas);
		
		DateTimeFormatter formatador = DateTimeFormatter.ofPattern("dd/MM/yyyy");
		
		String valorFormatado =proximasOlimpiadas.format(formatador);
		System.out.println(valorFormatado);
		
		
		DateTimeFormatter formatadorComHoras = DateTimeFormatter.ofPattern("dd/MM/yyyy hh:mm");

		LocalDateTime agora = LocalDateTime.now();
		System.out.println(agora.format(formatadorComHoras));
		
		LocalTime intervalo =  LocalTime.of(15, 30);
		System.out.println(intervalo);
		
		
	}
	

}
