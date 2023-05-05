programa
{
	inclua biblioteca Matematica --> m
	
	funcao inicio()
	{
		const real porcetagem_adicional = 0.3
		real salario_funcionario, periculosidade, salario_receber = 0

		escreva("informe o salário do colaborador: ")
		leia(salario_funcionario)

		periculosidade = salario_funcionario *  porcetagem_adicional 
		salario_receber = periculosidade + salario_funcionario
		salario_receber = m.arredondar(salario_receber, 2)
		escreva("o valor de adicional de periculosidade que o colaborador ira adicionar ao salário é: ", salario_receber, " ", "R$")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 539; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */