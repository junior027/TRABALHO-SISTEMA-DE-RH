programa
{
	inclua biblioteca Matematica --> m
	
	funcao inicio()
	{
		const real porcentagem = 0.08
		real salario_do_empregado, total_pagar, total_receber

		escreva("\ninforme o salário do funcionario: \n")
		leia(salario_do_empregado)

		total_receber = salario_do_empregado * porcentagem 
		total_receber = m.arredondar(total_receber, 2)
		
		escreva("\na quantidade que você ira receber por mes é: ", total_receber, " ", "R$ \n")
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 345; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {porcentagem, 7, 13, 11}-{salario_do_empregado, 8, 7, 20}-{total_pagar, 8, 29, 11}-{total_receber, 8, 42, 13};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */