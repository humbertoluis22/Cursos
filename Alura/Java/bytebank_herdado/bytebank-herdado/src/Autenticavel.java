
//contrato autentucavel
// quem assina o contrato, precisa  implementar
//metodo setSenha
//metodo Autentica


public abstract interface Autenticavel  {

	public abstract void setSenha(int senha);
	
	
	public  abstract boolean autentica(int senha) ;
	
		
	
}
