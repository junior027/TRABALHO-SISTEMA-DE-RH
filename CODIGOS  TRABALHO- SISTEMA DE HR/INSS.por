programa
{
	inclua biblioteca Matematica --> m
	
	funcao inicio()
	{
		inteiro opcao=0
		desconto_inss(opcao)
	}

	
	funcao real desconto_inss(real desconto)
	{
		const  real salario_minimo = 1302.00, dois_salarios_minimos = 2571.29, tres_salarios_minimos = 3856.94
		const real primeira_porcentagem = 0.075, segunda_porcentagem = 0.09, terceira_porcentagem = 0.012, quarta_porcentagem = 0.014
		real salario_funcionario, valor_liquido = 0, valor_descontado = 0,  restante_valor = 0

		escreva("informe o salario do funcionario: ")
		leia(salario_funcionario)

		se(salario_funcionario <= salario_minimo)
		{
			valor_descontado = salario_funcionario * primeira_porcentagem
			
			valor_liquido = salario_funcionario - valor_descontado
			m.arredondar(valor_liquido, 2)
			
			escreva("O salário do funcionário com o desconto é :", valor_liquido, "R$")
			desconto = desconto + valor_descontado
		}
		senao se(salario_funcionario > salario_minimo ou salario_funcionario <= dois_salarios_minimos)
		{
			valor_descontado = salario_minimo * primeira_porcentagem
			restante_valor = salario_funcionario - salario_minimo
			restante_valor = restante_valor * segunda_porcentagem
			valor_liquido = salario_funcionario - restante_valor - valor_descontado
			valor_liquido = m.arredondar(valor_liquido, 2)
			
			escreva("O salário do funcionário com o desconto é :", valor_liquido, "R$")
			desconto = restante_valor + valor_descontado
		}
		senao se(salario_funcionario > salario_minimo ou salario_funcionario <= tres_salarios_minimos)
		{
			
			valor_descontado = salario_minimo * primeira_porcentagem
			restante_valor = salario_funcionario - salario_minimo
			restante_valor = restante_valor * segunda_porcentagem
			valor_liquido = salario_funcionario - restante_valor - valor_descontado
			valor_liquido = m.arredondar(valor_liquido, 2)
			
			escreva("O salário do funcionário com o desconto do INSS é:", valor_liquido, "R$")
			desconto = restante_valor + valor_descontado
		}
		senao
		{
			
			valor_descontado = salario_minimo * primeira_porcentagem
			restante_valor = salario_funcionario - salario_minimo
			restante_valor = restante_valor * segunda_porcentagem
			valor_liquido = salario_funcionario - restante_valor - valor_descontado
			valor_liquido = m.arredondar(valor_liquido, 2)
			
			escreva("O salário do funcionário com o desconto é :", valor_liquido, "R$")
			desconto = restante_valor + valor_descontado
		}
		retorne desconto 	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 824; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {desconto, 12, 32, 8}-{valor_liquido, 16, 28, 13};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */