
int numeroUm, numeroDois;
double resultado;

numeroUm = 15;
numeroDois = 2;
resultado = numeroUm / numeroDois;

Console.WriteLine("o resultado sem o casting fica : " + resultado);

resultado = (double) numeroUm / numeroDois;

Console.WriteLine("o resultado depois do casting fica : " + resultado);

Console.WriteLine("casting é a conversao explicita de um tipo para o outro");
Console.WriteLine("lembrando que só é possivel converter de int para float pois nao perde dados");