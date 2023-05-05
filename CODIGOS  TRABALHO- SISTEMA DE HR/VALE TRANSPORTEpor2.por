programa
{
	inclua biblioteca Texto
	
	funcao inicio()
	{
		const real porcentagem = 0.06
		real salario, valor_da_passagem, desconto_vt, gasto_mensal, quantidade_de_vale, valor_vale, desconto_vale = 0
		cadeia resposta

		 escreva("digite o valor do salario: ")
		 leia(salario)

		 escreva("o colaborador utiliza transporte publico? ")
		 escreva("*** exceto pensão por morte ou auxílio-acidente ***** \n")
		 leia(resposta)
		 resposta = Texto.caixa_baixa(resposta)

		 se(Texto.caixa_baixa(resposta) == "s")
		 {
			 desconto_vale = salario * porcentagem
				
			 escreva("o valor a ser descontado do salário é: ", desconto_vale, " ", "R$")

			  escreva("deseja que o sistema calcule o se vale a pena utilizar o vale transporte? ")
			  leia(resposta)

			  resposta = Texto.caixa_baixa(resposta)
			  se(Texto.caixa_baixa(resposta) == "s")
			  {
			  	
		 		escreva("digite a quantidade de vale transporte utilizado por dia: ")
				leia(quantidade_de_vale)
				escreva("informe o valor da passagem: ")
				 leia(valor_vale)
				
			  	gasto_mensal = quantidade_de_vale * 4 * valor_vale * 20

			  	se(gasto_mensal >= desconto_vale)
			  	{
					escreva("vale a pena usar o beneficio")
			  	}
			  	senao
			  	{
					 escreva("nao vale a pena usar o beneficio.")
			  	}
			  }
		 }
		 senao
		 escreva("obrigado por utilizar nosso sistema")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1122; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {gasto_mensal, 8, 48, 12}-{valor_vale, 8, 82, 10}-{desconto_vale, 8, 94, 13};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */