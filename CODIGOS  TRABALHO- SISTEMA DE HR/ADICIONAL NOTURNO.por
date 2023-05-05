programa
{
	inclua biblioteca Matematica --> m
	
	funcao inicio()
	{
		const real porcetagem_norturno = 0.2
		 real  salario_base, valor_hora, horas_noturnas, adicional_noturno, carga_horaria, valor_hora_trabalhada , salario_receber = 0
		
		escreva("Digite o valor do salário: ")
		leia(salario_base)

		escreva("Digite caga horaria trabalhador: ")
		leia(carga_horaria)
		
		escreva("Digite a quantidade de horas nortunas do trabalhador: ")
		leia(adicional_noturno)
		
		
		valor_hora = salario_base / carga_horaria

		valor_hora_trabalhada = valor_hora *  porcetagem_norturno
		adicional_noturno = valor_hora_trabalhada * adicional_noturno
		salario_receber = salario_base + adicional_noturno

		salario_receber = m.arredondar(salario_receber, 2)
		adicional_noturno = m.arredondar(adicional_noturno, 2)
		escreva("\nO salário bruto é: R$ ", salario_receber , "R$ \n")
		escreva("\nO adicional noturno é: R$ ", adicional_noturno , "R$ \n")
	} 
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 806; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */