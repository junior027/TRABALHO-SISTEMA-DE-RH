programa
{
	
	funcao inicio()
	{
		real salario_do_empregado, total_pagar, total_receber_mes, total_receber, tempo_trabalhado

		escreva("informe o salário do funcionario: \n")
		leia(salario_do_empregado)

		escreva("informe o tempo de casa do empregado em meses: \n")
		leia(tempo_trabalhado)

		total_receber_mes = salario_do_empregado * 0.08

		total_receber = total_receber_mes * tempo_trabalhado
		escreva("a quantidade que você ira receber é: ", total_receber, " ", "R$")
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 0; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */