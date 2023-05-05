programa
{
	
	funcao inicio()
	{
		const real primeiro_valor = 1100, segundo_valor = 2100, terceiro_valor = 3200, quarto_valor = 4300, quantidade_de_meses = 12
		const real primeira_porcentagem = 0.075, segunda_porcentagem = 0.09, terceira_porcentagem = 0.1, quarta_porcentagem = 0.11
		real salario, pis
		inteiro  tempo_de_trabalho
		
		escreva("Quanto tempo de trabalho voce tem? \n")
		leia(tempo_de_trabalho)

		
		se(tempo_de_trabalho >= quantidade_de_meses)
		{
			escreva("tem direito ao pis \n")
			
			escreva("Digite o valor do salário: \n")
 	 	 	leia(salario)

 	 	 	se(salario <= primeiro_valor)
 	 	 	{
 	 	 		pis = salario * primeira_porcentagem
 	 	 	}

 	 	 	senao se(salario <= segundo_valor) 
 	 	 	{
 	 	 		pis = salario * segunda_porcentagem 
 	 	 	}

 	 	 	senao se(salario <= terceiro_valor)
 	 	 	{
 	 	 		pis = salario * terceira_porcentagem
 	 	 	}
 	 	 	senao se(salario <= quarto_valor)
 	 	 	{
 	 	 		pis = salario * quarta_porcentagem	
 	 	 	}
 	 	 	senao
 	 	 	{
				pis = 474.07
 	 	 	}
 	 	 	escreva("O valor do PIS é: R$", pis)

		}
		senao
		{
			escreva("voce não tem direito ao saque pis")
		}
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 552; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */