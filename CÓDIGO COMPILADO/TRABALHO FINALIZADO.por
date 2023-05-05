programa
{
	inclua biblioteca Matematica --> m
	inclua biblioteca ServicosWeb --> w
	inclua biblioteca Arquivos --> a
	inclua biblioteca Texto --> t
	
	funcao inicio()
	
	{
		menu()
		inteiro opcao_escolhida
		escreva("|================================================================|\n")
		escreva("|              BOA NOITE COMO POSSO AJUDAR?                      |\n")
		escreva("|             ESCOLHA UMA DAS OPÇÕES Á CIMA                      |\n")
		escreva("|ESCOLHA --> ")
		leia(opcao_escolhida)
		seletor_programa(opcao_escolhida)
	}
	
	//FUNﾃ�ﾃグ MENU RESPONSAVEL POR MOSTRAR AS OPﾃ�ﾃ髭S 
	 funcao menu()
	{	
		
		escreva("|================================================================|\n")
		escreva("|  \n     SISTEMA DE HR  |   SENAI-LINHARES-ES                        |\n")
		escreva("|                                                                |\n")
		escreva("|================================================================|\n")
		escreva("|1 --> PROGRAMA CALCULAR ADICIONAL NOTURNO                       |\n")
		escreva("|================================================================|\n")
		escreva("|2 --> PROGRAMA CALCULAR FÉRIAS                                  |\n")
		escreva("|================================================================|\n")
		escreva("|3 --> PROGRAMA CALCULAR FGTS                                    |\n")
		escreva("|================================================================|\n")
		escreva("|4 --> PROGRAMA PARA SABER HORAS EXTRAS                          |\n")
		escreva("|================================================================|\n")
		escreva("|5 --> PROGRAMA CALCULAR IMPOSTO DE RENDA                        |\n")
		escreva("|================================================================|\n")															
		escreva("|6 --> PROGRAMA CALCULAR INSS                                    |\n")
		escreva("|================================================================|\n")																
		escreva("|7 --> PROGRAMA CALCULAR PERICULOSIDADE         	         |\n")
		escreva("|================================================================|\n")															
		escreva("|8 --> PROGRAMA CALCULAR PIS                                     |\n")
		escreva("|================================================================|\n")
		escreva("|9 --> PROGRAMA CALCULAR VALE TRANSPORTE                         |\n")
		escreva("|================================================================|     \n")
		escreva("|10 --> PROGRAMA PARA SEGURO DESEMPREGO                          |\n")
		escreva("|================================================================|     \n")
		escreva("|11 --> PROGRAMA PARA MOSTRAR O CONTRA CHEQUE DO FUNCIONﾃヽIO     |\n")
		escreva("|================================================================|     \n")
		escreva("|12 --> PROGRAMA PARA REALIZAR O CADASTRO DO FUNCIONARIO         |\n")
		escreva("|================================================================|     \n")	 
		escreva("|13 --> PARA SAIR DO PROGRAMA                                    |\n")
		escreva("|================================================================|     \n")	
	}
	
	// ---------- FUNÇÃO RESPONSÁVEL POR PEGAR O SALÁIO DO ADICIONAL NOTURNO ---------// 
	funcao salario_colaborador_adicional_noturno()
	{
		const real desconto = 0
		real salario 
		
		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		calculo_adicional_noturno(salario, desconto)

			logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_adicional_noturno()
		}
	}
	//--------- FUNÇÃO ADICIONAL NOTURNO ------------- //
	funcao real calculo_adicional_noturno(real salario, real aumento_noturno)
	{
		const real porcetagem_norturno = 0.2, carga_horaria = 220
		real  salario_base, valor_hora, horas_noturnas, adicional_noturno, valor_hora_trabalhada , salario_receber = 0

		
		escreva("Digite a quantidade de horas nortunas do trabalhador: ")
		leia(adicional_noturno)
		
		
		valor_hora = salario / carga_horaria

		valor_hora_trabalhada = valor_hora *  porcetagem_norturno
		adicional_noturno = valor_hora_trabalhada * adicional_noturno
		salario_receber = salario + adicional_noturno

		salario_receber = m.arredondar(salario_receber, 2)
		adicional_noturno = m.arredondar(adicional_noturno, 2)
		escreva("\nO salário bruto é: R$ ", salario_receber , "R$ \n")
		escreva("\nO adicional noturno é: R$ ", adicional_noturno , "R$ \n")
		aumento_noturno = adicional_noturno
		
		retorne aumento_noturno

	}

	// ---------- FUNÇÃO RESPONSÁEL POR PEGAR O SALÁIO DAS FERIAS---------//  
	funcao salario_colaborador_ferias()
	{
		const real desconto = 0
		real salario

		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		ferias(salario)

			logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_ferias()
		}
	}
		//--------- FUNÇÃO FERIAS------------- //
	funcao real ferias(real salario)
	{
		//calculo de fﾃｩrias
		const inteiro divisor = 3
		inteiro dias_ferias = 30
		real salario_ferias, terco_ferias, total_bruto, inss = 0, irrf = 0
		inss = desconto_inss(salario, inss)
		irrf = imposto_de_renda(salario,irrf) 
		limpa()

		terco_ferias = salario / divisor

		total_bruto = salario + terco_ferias

		salario_ferias = total_bruto - inss - irrf

		salario_ferias = m.arredondar(salario_ferias, 2)
		
		escreva("\n O trabalhador tem direito a ", dias_ferias, " dias de férias.", "\n")
		escreva("\n O salario das férias é: ", salario_ferias, "R$")	
		retorne salario		
	}
	
	// ---------- FUNÇÃO RESPONSÁEL POR PEGAR O SALÁIO DO FGTS ---------//  
	funcao salario_colaborador_fgts()
	{
		const real desconto = 0
		real salario
		
		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		calcaulo_fgts(salario, desconto)

		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_fgts()
		}
	}
	//--------- FUNÇÃO FGTS ------------- //
	funcao real calcaulo_fgts(real salario, real desconto_fgts)
	{
		const real porcentagem = 0.08
		real salario_do_empregado, total_pagar, total_receber

		total_receber = salario * porcentagem 
		total_receber = m.arredondar(total_receber, 2)
		desconto_fgts = total_receber
		
		escreva("\na quantidade que você ira receber de FGTS por mes é: ", total_receber, " ", "R$ \n")
		retorne desconto_fgts
	}
	
	// ---------- FUNÇÃO RESPONSÁEL POR PEGAR O SALÁIO DAS HORAS EXTRAS ---------//  
	funcao salario_colaborador_hora_extra()
	{
		const real desconto = 0
		real salario
		
		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		calculo_hora_extra(salario, desconto)
		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_hora_extra()
		}
	}
	//--------- FUNÇÃO FGTS ------------- //
	funcao real calculo_hora_extra(real salario, real aumento_hora_extra)
	{
		const real taxa_hora_extra100 = 2, taxa_hora_extra50 = 0.5, carga_horaria = 220
		real valor_hora100 = 0, valor_hora_extra100 = 0, valor_total_extra100 = 0, valor_hora50 = 0, valor_hora_extra50 = 0, valor_total_extra50 = 0, soma_extra100 = 0, soma_extra50 = 0, valor_bruto = 0
		real hora_extra_uteis, hora__feriado_domingo, hora_extra = 0
		cadeia trabalho_feriado_domingo, dias_uteis


		escreva("\no colaborador relizou trabalho em domingos e feriados?: \n")
		escreva("\n**** (s) para sim ou (n) para não) ***** \n")
		leia(trabalho_feriado_domingo)
		t.caixa_baixa(trabalho_feriado_domingo)
		se(t.caixa_baixa(trabalho_feriado_domingo) == "s")
		{
			escreva("\no colaborador relizou hora extra em dias uteis? \n")
			escreva("\n**** (s) para sim ou (n) para não) ***** \n")
			leia(dias_uteis)

			t.caixa_baixa(dias_uteis)
			se(t.caixa_baixa(dias_uteis) == "s")
			{	
				
				escreva("informe as horas extras trabalhadas em dias uteis: \n")
				leia(hora_extra_uteis)

				escreva("informe as horas extras trabalhadas em domingos e feriados: \n")
				leia(hora__feriado_domingo)

				// hora extra 100%
				valor_hora100 = salario/ carga_horaria
				valor_hora_extra100 = valor_hora100 * taxa_hora_extra100
				valor_total_extra100 = valor_hora_extra100 * hora__feriado_domingo
				soma_extra100 = valor_total_extra100

				// hora extra 50%
				valor_hora50 = salario / carga_horaria
				valor_hora_extra50 = valor_hora50 * taxa_hora_extra50
				valor_total_extra50 = valor_hora_extra50 * hora_extra_uteis
				soma_extra50 = valor_total_extra50 + valor_total_extra100

				valor_bruto = soma_extra50 + soma_extra100 + salario
				hora_extra = soma_extra50 + soma_extra100
				hora_extra = m.arredondar(hora_extra, 2)
				valor_bruto = m.arredondar(valor_bruto, 2)
				
				
				escreva("\nseu salário é: ",valor_bruto, "R$ \n")
				escreva("\nseu adicional de hora extra é: ",hora_extra, "R$ \n")
				
			}
			senao
			{
				escreva("informe as horas extras trabalhadas em domingos e feriados: \n")
				leia(hora__feriado_domingo)
				
				valor_hora100 = salario / carga_horaria
				valor_hora_extra100 = valor_hora100 * taxa_hora_extra100
				valor_total_extra100 = valor_hora_extra100 * hora__feriado_domingo
				soma_extra100 = valor_total_extra100
				valor_bruto = soma_extra100 + salario
				hora_extra = soma_extra50 + soma_extra100
				hora_extra = m.arredondar(hora_extra, 2)
				valor_bruto = m.arredondar(valor_bruto, 2)
				
				
				escreva("\nseu salário é: ",valor_bruto, "R$ \n")
				escreva("\nseu adicional de hora extra é: ",hora_extra, "R$ \n")
			}
		}
		senao
		{
				escreva("informe as horas extras trabalhadas em dias uteis: \n")
				leia(hora_extra_uteis)	

				valor_hora50 = salario / carga_horaria
				valor_hora_extra50 = valor_hora50 * taxa_hora_extra50
				valor_total_extra50 = valor_hora_extra50 * hora_extra_uteis
				soma_extra50 = valor_total_extra50
				valor_bruto = soma_extra50 + salario
				hora_extra = soma_extra50 + soma_extra100
				hora_extra = m.arredondar(hora_extra, 2)
				valor_bruto = m.arredondar(valor_bruto, 2)
				
				
				escreva("\nseu salário é: ",valor_bruto, "R$ \n")
				escreva("\nseu adicional de hora extra é: ",hora_extra, "R$ \n")
		}
		
		aumento_hora_extra = soma_extra100 + soma_extra50
		aumento_hora_extra = m.arredondar(aumento_hora_extra, 2)
		retorne aumento_hora_extra
	}

	// ---------- FUNÇÃO RESPONSÁVEL POR PEGAR O SALÁRIO DO IMPOSTO DE RENDA ---------// 
	funcao salario_colaborador_imposto_de_renda()
	{
		const real desconto = 0
		real salario

		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		imposto_de_renda(salario, desconto)

		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_imposto_de_renda()
		}
	}
	//--------- FUNÇÃO IMPOSTO DE RENDA ------------- //
	funcao real imposto_de_renda(real salario, real desconto_imposto_renda)
	{
		const real faixa_1 = 1903.98, faixa_2 = 2826.65,  porcentagem_faixa_2 = 0.075, faixa_3 = 3751.05, porcentagem_faixa_3 = 0.15, faixa_4 = 4664.68, porcentagem_faixa_4 = 0.22, porcentagem_faixa_5 = 0.275
		const real desconto_faixa2 = 142.80, desconto_faixa3 = 354.80, desconto_faixa4 =  636.13, desconto_faixa5 = 869.336
		real total_pagar, inss = 0
		inss = desconto_inss(salario, inss)
		salario = salario - inss
		
		se(salario < faixa_1)
		{
			total_pagar = 0
			escreva("\n isento do imposto de renda \n")
			
		}
		senao se(salario < faixa_2)
		{
			total_pagar = (salario * porcentagem_faixa_2) - desconto_faixa2
			total_pagar = m.arredondar(total_pagar, 2)
			
			escreva("\n o total para pagar de imposto de renda é: ", total_pagar, " ", "R$ \n")
			desconto_imposto_renda = total_pagar
		}
		senao se(salario < faixa_3)
		{
			total_pagar = (salario * porcentagem_faixa_3) - desconto_faixa3
			total_pagar = m.arredondar(total_pagar, 2)
			escreva("\n o total para pagar de imposto de renda é: ", total_pagar, " ", "R$ \n")
			desconto_imposto_renda = total_pagar
		}
		senao se(salario < faixa_4)
		{
			total_pagar = (salario * porcentagem_faixa_4) - desconto_faixa4   
			total_pagar = m.arredondar(total_pagar, 2)
			
			escreva("\n o total para pagar de imposto de renda é: ", total_pagar, " ", "R$ \n")
			desconto_imposto_renda = total_pagar
		}
		senao
		{
			total_pagar = (salario * porcentagem_faixa_5) - desconto_faixa5
			total_pagar = m.arredondar(total_pagar, 2)
			desconto_imposto_renda = total_pagar
			escreva("o total para pagar de imposto de renda é: ", total_pagar, " ", "R$ \n")
			
		}
		retorne desconto_imposto_renda
	}

	// ---------- FUNÇÃO RESPONSÁEL POR PEGAR O SALÁIO DO INSS --------//
	funcao salario_colaborador_inss()
	{
		const real desconto = 0
		real salario

		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		desconto_inss(salario, desconto)

		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_inss()
		}
	}
	//--------- FUNÇÃO INSS------------- //
	funcao real desconto_inss(real salario, real desconto)
	{
		const  real salario_minimo = 1302.00, dois_salarios_minimos = 2571.29, tres_salarios_minimos = 3856.94
		const real primeira_porcentagem = 0.075, segunda_porcentagem = 0.09, terceira_porcentagem = 0.012, quarta_porcentagem = 0.014
		real salario_liquido = 0, salario_descontado = 0,  restante_salario = 0

		se(salario <= salario_minimo)
		{
			salario_descontado = salario * primeira_porcentagem
			
			salario_liquido = salario - salario_descontado
			salario_liquido = m.arredondar(salario_liquido, 2)
			
			escreva("\no salario do funcionario é :", salario_liquido, "R$\n")
			desconto = desconto + salario_descontado
		}
		senao se(salario > salario_minimo ou salario <= dois_salarios_minimos)
		{
			salario_descontado = salario_minimo * primeira_porcentagem
			restante_salario = salario - salario_minimo
			restante_salario = restante_salario * segunda_porcentagem
			salario_liquido = salario - restante_salario - salario_descontado
			salario_liquido = m.arredondar(salario_liquido, 2)
			
			escreva("\no salario do funcionario é:", salario_liquido, "R$\n")
			desconto = desconto + restante_salario
		}
		senao se(salario > salario_minimo ou salario <= tres_salarios_minimos)
		{
			
			salario_descontado = salario_minimo * primeira_porcentagem
			restante_salario = salario - salario_minimo
			restante_salario = restante_salario * segunda_porcentagem
			salario_liquido = salario - restante_salario - salario_descontado
			salario_liquido = m.arredondar(salario_liquido, 2)
			
			escreva("\no salario do funcionario é:", salario_liquido, "R$\n")
			desconto = desconto + restante_salario
		}
		senao
		{
			
			salario_descontado = salario_minimo * primeira_porcentagem
			restante_salario = salario - salario_minimo
			restante_salario = restante_salario * segunda_porcentagem
			salario_liquido = salario - restante_salario - salario_descontado
			salario_liquido = m.arredondar(salario_liquido, 2)
			
			escreva("\no salario do funcionario é:", salario_liquido, "R$\n")
			desconto = desconto + restante_salario
		}
		retorne desconto 
	}

	// --------- FUNÇÃO RESPONSÁEL POR PEGAR O SALÁIO DA PERICULOSIDADE ---------//  
	funcao salario_colaborador_periculosidade()
	{
		const real desconto = 0
		real salario
		
		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		calculo_periculosidade(salario, desconto)
		
		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_periculosidade()
		}
	}
	//--------- FUNÇÃO PERICULOSIDADE------------- //
	funcao real calculo_periculosidade(real salario, real aumento_periculosidade)
	{
		const real porcetagem_adicional = 0.3
		real salario_funcionario, periculosidade, salario_receber = 0

		periculosidade = salario *  porcetagem_adicional 
		salario_receber = periculosidade + salario
		salario_receber = m.arredondar(salario_receber, 2)
		periculosidade = m.arredondar(periculosidade, 2)
		aumento_periculosidade = periculosidade
		
		escreva("o valor de adicional de periculosidade que o colaborador ira adicionar ao salário é: ", salario_receber, " ", "R$")
		escreva("o valor de adicional de periculosidade que o colaborador ira adicionar é: ", periculosidade, " ", "R$") 
		retorne aumento_periculosidade
	}

	// ---------- FUNÇÃO RESPONSÁVEL POR PEGAR O SALÁIO DO PIS ---------//  
	funcao salario_colaborador_pis()
	{
		const real desconto = 0
		real salario

		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		calculo_pis(salario, desconto)

		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_pis()
		}
	}
	//--------- FUNÇÃO PIS------------- //
	funcao calculo_pis(real salario, real desconto)
	{
		const real primeiro_valor = 1100, segundo_valor = 2100, terceiro_valor = 3200, quarto_valor = 4300, quantidade_de_meses = 12
		const real primeira_porcentagem = 0.075, segunda_porcentagem = 0.09, terceira_porcentagem = 0.1, quarta_porcentagem = 0.11
		real  pis
		inteiro  tempo_de_trabalho
		
		escreva("Quanto tempo de trabalho voce tem? \n")
		leia(tempo_de_trabalho)

		
		se(tempo_de_trabalho >= quantidade_de_meses)
		{
			escreva("tem direito ao pis \n")
			
			escreva("Digite o valor do salárioo: \n")
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
 	 	 	m.arredondar(pis, 2)
 	 	 	escreva("O valor do PIS é: R$", pis)

		}
		senao
		{
			escreva("voce não tem direito ao saque pis")
		} 
	}

	// ---------- FUNÇÃO RESPONSÁVEL POR PEGAR O SALÁIO DO VALE TRANSPORTE //  
	funcao salario_colaborador_vale_transporte()
	{
		const real desconto = 0
		real salario

		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		vale_transporte(salario, desconto)

		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			salario_colaborador_vale_transporte()
		}
	}
	//--------- FUNÇÃO VALE TRANSPORTE ------------- //
	funcao real vale_transporte(real salario, real gasto_vale)
	{	
		const real porcentagem = 0.06, dias_na_semana = 4, dias_no_mes = 20
		real valor_da_passagem, desconto_vt, gasto_mensal, quantidade_de_vale, valor_vale, desconto_vale = 0
		cadeia resposta

		 escreva("\no colaborador utiliza transporte publico? \n")
		 leia(resposta)
		 resposta = Texto.caixa_baixa(resposta)

		 se(Texto.caixa_baixa(resposta) == "s")
		 {
			 desconto_vale = salario * porcentagem
			 desconto_vale = m.arredondar(desconto_vale, 2)
				
			 escreva("\no valor a ser descontado do salário: ", desconto_vale, " ", "R$ \n")

			  escreva("\n deseja que o sistema calcule o se vale a pena utilizar o vale transporte? \n")
			  leia(resposta)

			  resposta = Texto.caixa_baixa(resposta)
			  se(Texto.caixa_baixa(resposta) == "s")
			  {
			  	
		 		escreva("\n digite a quantidade de vale transporte utilizado por dia: \n")
				leia(quantidade_de_vale)
				escreva("\n informe o valor da passagem: \n")
				 leia(valor_vale)
				
			  	gasto_mensal = quantidade_de_vale * valor_vale * dias_no_mes
			  	se(gasto_mensal >= desconto_vale)
			  	{
					escreva("\n vale a pena usar o beneficio \n")
			  	}
			  	senao
			  	{
					 escreva("\n nao vale a pena usar o beneficio. \n")
			  	}
			  }
		 }
		 senao
		 {
		 	escreva("\n obrigado por utilizar nosso sistema \n")
		 }
		 gasto_vale = desconto_vale
		 retorne gasto_vale
	}

	//--------- FUNÇÃO SEGURO DESEMPREGO ------------- //
	funcao seguro_desemprego()
	{
		const inteiro primeira_solicitacao = 12, segunda_solicitacao = 9, terceira_solicitacao = 6, mumero_cinco_parcelas = 24, numero_tres_parcelas = 23, numero_quatro_parcelas = 11
		cadeia resposta_do_empregado, resposta
		inteiro tempo_trabalhado
		
		escreva("o colaborador foi dispemsado por justa causa? \n")
		leia(resposta_do_empregado)
		t.caixa_baixa(resposta_do_empregado)
		
		se(t.caixa_baixa(resposta_do_empregado) == "s")
		{
			escreva("o colaborador está em situação de desemprego? \n")
			leia(resposta_do_empregado)
			t.caixa_baixa(resposta_do_empregado)

			se(t.caixa_baixa(resposta_do_empregado) == "s")
			{
				escreva("o colaborador possui renda propria? \n")
				leia(resposta_do_empregado)
				t.caixa_baixa(resposta_do_empregado)

				se(t.caixa_baixa(resposta_do_empregado) == "n")
				{
					escreva("o colaborador está recebendo beneficio de prestação continua da previdência social? \n")
					escreva("*** exceto pensão por morte ou auxilio-acidente ***** \n")
					leia(resposta_do_empregado)
					t.caixa_baixa(resposta_do_empregado)

					se(t.caixa_baixa(resposta_do_empregado) == "n")
					{
						inteiro numero

						escreva("1- Caso seja primeira solicitação do colaborador \n")
						escreva("2- Caso seja segunda solicitação do colabolaborador \n")
						escreva("3- Caso seja terceira ou mais solicitação do colabolaborador \n")
						leia(numero)


						escreva("informe a quantidade de tempo do colaborador está na empresa (em meses): \n")
						leia(tempo_trabalhado)
						escolha(numero)
						{
							caso 1:
								se(tempo_trabalhado >= primeira_solicitacao)
								{
									escreva("\n O colaborador tem direito ao seguro desemprego \n")
									se(tempo_trabalhado >= primeira_solicitacao e tempo_trabalhado > mumero_cinco_parcelas)
									{
										escreva("\n O colaborador tem direito 5 parcelas")
									}
									senao
									{
										escreva("\n O colaborador tem direito 4 parcelas")
									}
								}
								senao
								{
									escreva("\n O colaborador não tem direito ao seguro desemprego \n")
								}
							pare
							caso 2:
								se(tempo_trabalhado >= segunda_solicitacao)
								{
									escreva("\n O colaborador tem direito ao seguro desemprego \n")
									se(tempo_trabalhado >= segunda_solicitacao e tempo_trabalhado > numero_tres_parcelas)
									{
										escreva("\n O colaborador tem direito 5 parcelas")
									}
									senao se (tempo_trabalhado >= primeira_solicitacao e tempo_trabalhado > numero_quatro_parcelas)
									{
										escreva("\n O colaborador tem direito 4 parcelas")
									}
									senao
									{
										escreva("\n O colaborador tem direito 3 parcelas")
									}
								}
								senao
								{
									escreva("\n O colaborador não tem direito ao seguro desemprego \n")
								}
							pare
							caso 3:
								se(tempo_trabalhado > terceira_solicitacao)
								{
									escreva("\n O colaborador tem direito ao seguro desemprego \n")
									se(tempo_trabalhado >= mumero_cinco_parcelas)
									{
										escreva("\n O colaborador tem direito 5 parcelas")
									}
									senao se (tempo_trabalhado >= primeira_solicitacao e tempo_trabalhado < numero_tres_parcelas)
									{
										escreva("\n O colaborador tem direito 4 parcelas")
									}
									senao
									{
										escreva("\n O colaborador tem direito 3 parcelas")
									}
								}
								senao
								{
									escreva("\n O colaborador não tem direito ao seguro desemprego \n")
								}
							pare

							caso contrario:
								escreva("\n O colaborador não tem direito ao seguro desemprego \n")
						}
						}
						senao
						{
							escreva("\n O colaborador não tem direito ao seguro desemprego \n")
						}
					}
					senao
					{
						escreva("\n O colaborador não tem direito ao seguro desemprego \n")
					}
				}
				senao
				{
					escreva("\n O colaborador não tem direito ao seguro desemprego \n")
				}
			}
			senao
			{
				escreva("\n O colaborador não tem direito ao seguro desemprego \n")
			}

		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			seguro_desemprego()
		}
	}

	//--------- FUNÇÃO REALIZAR CADASTRO ------------- //
	funcao cadastro_funcionario()
	{
		
		cadeia fazer_ou_nao_outro_cadastro
		cadeia nome_completo, telefone, email, idade, cep, endereco_sem_cep, endereco, trocar_caracteres, logradouro, complemento, bairro, localidade, uf
		inteiro posicao_endereco, posicao_logradouro, posicao_complemento, posicao_bairro, posicao_localidade, posicao_uf

		
		
		escreva("Boa noite colaborador(a), seja bem vindo(a) ao nosso sistema!")
		
		escreva("\nInfome seu nome completo: ")
		leia(nome_completo)
		nome_completo = t.caixa_alta(nome_completo)

		escreva("Informe seu telefone: ")
		leia(telefone)
		telefone = t.caixa_alta(telefone)

		escreva("Informe seu email: ")
		leia(email)
		email = t.caixa_alta(email)

		escreva("Informe sua idade: ")
		leia(idade)
		idade = t.caixa_alta(idade)

		escreva("Informe seu CEP: ")
		leia(cep)
		

		//FAZER A BUSCA DO CEP E SEPARAR
		endereco = w.obter_dados("https://viacep.com.br/ws/"+ cep + "/json/")
		
		posicao_endereco = t.posicao_texto("ibge",endereco, 0)-1
		
		endereco_sem_cep = t.extrair_subtexto(endereco, 0, posicao_endereco)
	
		endereco_sem_cep = t.substituir(endereco_sem_cep, "\"","\n")
		endereco_sem_cep = t.substituir(endereco_sem_cep, ",","\n")
		escreva(endereco_sem_cep)

		//SUBSTITUIR TEXTO DO CEP
		trocar_caracteres = t.substituir(endereco_sem_cep, "\"", "\n")

		//POSICAO LOGRADOURO
		posicao_logradouro = t.posicao_texto("complemento",endereco, 0)		
		logradouro = t.substituir(endereco_sem_cep, "\"", "\n")
		logradouro = t.substituir(endereco_sem_cep, ",","\n")
		logradouro = t.extrair_subtexto(endereco_sem_cep, 25,posicao_logradouro)
		logradouro = t.caixa_alta(logradouro)

		//POSICAO COMPLEMENTO
		posicao_complemento = t.posicao_texto("bairro",endereco, 0)		
		complemento = t.substituir(endereco_sem_cep, "\"", "\n")
		complemento = t.substituir(endereco_sem_cep, ",","\n")
		complemento = t.extrair_subtexto(endereco_sem_cep, posicao_logradouro,posicao_complemento)
		complemento = t.caixa_alta(complemento)
		
		//POSICAO BAIRRO
		posicao_bairro = t.posicao_texto("localidade",endereco, 0)		
		bairro = t.substituir(endereco_sem_cep, "\"", "\n")
		bairro = t.substituir(endereco_sem_cep, ",","\n")
		bairro = t.extrair_subtexto(endereco_sem_cep, posicao_complemento,posicao_bairro)
		bairro = t.caixa_alta(bairro)

		//POSICAO LOCALIDADE 
		posicao_localidade = t.posicao_texto("uf",endereco, 0)		
		localidade = t.substituir(endereco_sem_cep, "\"", "\n")
		localidade = t.substituir(endereco_sem_cep, ",","\n")
		localidade = t.extrair_subtexto(endereco_sem_cep, posicao_bairro,posicao_localidade)
		localidade = t.caixa_alta(localidade)

		//POSICAO UF
		posicao_uf = t.posicao_texto("ibge",endereco_sem_cep, 0)		
		uf = t.substituir(endereco_sem_cep, "\"", "\n")
		uf = t.substituir(endereco_sem_cep, ",","\n")
		uf = t.extrair_subtexto(endereco_sem_cep, posicao_localidade,posicao_endereco)
		uf = t.caixa_alta(uf)
					
		logico arquivo_existe = a.arquivo_existe("/banco de dados.txt")
		se(arquivo_existe)
		{
			
			inteiro arquivo = a.abrir_arquivo("/banco de dados.txt", a.MODO_ACRESCENTAR)
			a.escrever_linha("\n", arquivo)
			
			a.escrever_linha("\n", arquivo)
			a.escrever_linha("NOME: "+ nome_completo, arquivo)
			a.escrever_linha("TELEFONE: "+ telefone, arquivo)
			a.escrever_linha("EMAIL: "+ email, arquivo)
			a.escrever_linha("IDADE: "+ idade, arquivo)
			a.escrever_linha("CEP: " +cep, arquivo)
			a.escrever_linha(logradouro, arquivo)
			a.escrever_linha(complemento, arquivo)
			a.escrever_linha(bairro, arquivo)
			a.escrever_linha(localidade, arquivo)
			a.escrever_linha(uf, arquivo)
			
			

		a.fechar_arquivo(arquivo)
		}
		senao 
		{
			inteiro arquivo = a.abrir_arquivo("/banco de dados.txt", a.MODO_ESCRITA)
			a.escrever_linha("\n", arquivo)
			
			a.escrever_linha("\n", arquivo)
			a.escrever_linha("NOME: "+ nome_completo, arquivo)
			a.escrever_linha("TELEFONE: "+ telefone, arquivo)
			a.escrever_linha("EMAIL: "+ email, arquivo)
			a.escrever_linha("IDADE: "+ idade, arquivo)
			a.escrever_linha("CEP: " +cep, arquivo)
			a.escrever_linha(logradouro, arquivo)
			a.escrever_linha(complemento, arquivo)
			a.escrever_linha(bairro, arquivo)
			a.escrever_linha(localidade, arquivo)
			a.escrever_linha(uf, arquivo)
			
		a.fechar_arquivo(arquivo)
		}

		logico resultado = voltar_ao_menu()

		se(resultado)
		{
			inicio()
		}
		senao 
		{
			limpa()
			cadastro_funcionario()
		}
	}

	//--------- FUNÇÃO RESPOSAVEL PELO SALÁIO DO COMPILADOR ------------- //
	funcao salario_colaborador_compilador_de_programas()
	{
		const real desconto = 0
		real salario
		
		escreva("\n informe o salário do funcionario: \n")
		leia(salario)
	
		compilador_de_programas(salario)

		logico resultado = voltar_ao_menu()

			se(resultado)
			{
				inicio()
			}
			senao 
			{
				limpa()
				salario_colaborador_compilador_de_programas()
			}
	}
	//--------- FUNÇÃO COMPILADOR ------------- //
	funcao compilador_de_programas(real salario)
	{
		real inss=0, irrf = 0, vale = 0, fgts = 0, periculosidade = 0, noturno = 0, hora_extra = 0
		cadeia resposa
		
		irrf = imposto_de_renda(salario, irrf)
		inss = desconto_inss(salario, inss)
		vale = vale_transporte(salario, vale)
		fgts = calcaulo_fgts(salario, fgts)
		noturno = calculo_adicional_noturno(salario, noturno)
		hora_extra = calculo_hora_extra(salario, hora_extra)

		limpa()
		escreva("o colaborador adicional de periculosidade? ")
		leia(resposa)
		t.caixa_baixa(resposa)
		irrf = m.arredondar(irrf, 2)
		se(t.caixa_baixa(resposa) == "s")
		{
			periculosidade = calculo_periculosidade(salario, periculosidade)
			
			limpa()
			escreva("|================================================================|\n")
			escreva("|  \n    CONTRA CHEQUE |   SENAI-LINHARES-ES                          |\n")
			escreva("|                                                                |\n")
			escreva("|================================================================|\n")
			escreva("|INSS: ",inss, "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|IRRF: ",irrf, "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|VALE TRANSPORTE: ",vale, "R$                                            |\n")
			escreva("|================================================================|\n")
			escreva("|FGST: ",fgts, "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|PERICULOSIDADE: ",periculosidade, "R$                                             |\n")
			escreva("|================================================================|\n")
			escreva("|ADICIONAL NOTURNO: ", noturno, "R$                                          |\n")
			escreva("|================================================================|\n")
			escreva("|HORA EXTRAS: ",hora_extra, "R$                                                |\n")
			escreva("|================================================================|\n")

			escreva("|================================================================\n")
			escreva("|TOTAL ADICIONADO: ", periculosidade + noturno + hora_extra + salario, "\n")
			escreva("|TOTAL DESCONTADO: ", inss + irrf + vale + fgts, "              \n")
			escreva("|================================================================\n")
		}
		senao
		{
			limpa()
			escreva("|================================================================|\n")
			escreva("|  \n    CONTRA CHEQUE |   SENAI-LINHARES-ES                          |\n")
			escreva("|                                                                |\n")
			escreva("|================================================================|\n")
			escreva("|INSS: ",inss, "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|IRRF: ",irrf, "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|VALE TRANSPORTE: ",vale, "R$                                            |\n")
			escreva("|================================================================|\n")
			escreva("|FGST: ",fgts, "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|ADICIONAL NOTURNO: ", noturno, "R$                                          |\n")
			escreva("|================================================================|\n")
			escreva("|HORA EXTRAS: ",hora_extra, "R$                                                |\n")
			escreva("|================================================================|\n")

			escreva("|================================================================\n")
			escreva("|TOTAL ADICIONADO: ", noturno + hora_extra + salario, "         \n")
			escreva("|TOTAL DESCONTADO: ", inss + irrf + vale + fgts, "              \n")
			escreva("|================================================================\n")
		}
	}

	//--------- FUNÇÃO SELETOR DE PROGRAMNAS ------------- //
	funcao seletor_programa(inteiro opcao)
	{
		escolha(opcao)
		{
			caso 1:
				salario_colaborador_adicional_noturno()
			pare
			caso 2:
				salario_colaborador_ferias()
			pare
			caso 3:
				salario_colaborador_fgts()
			pare
			caso 4:
				salario_colaborador_hora_extra()
			pare
			caso 5:
				salario_colaborador_imposto_de_renda()
			pare
			caso 6:
				salario_colaborador_inss()
			pare
			caso 7:
				salario_colaborador_periculosidade()
			pare
			caso 8:
				salario_colaborador_pis()
			pare
			caso 9:
				salario_colaborador_vale_transporte()
			pare
			caso 10:
				seguro_desemprego()
			pare
			caso 11:
				salario_colaborador_compilador_de_programas()
			pare
			caso 12:
				cadastro_funcionario()
			pare
			caso 13:
				encerrar_programa()
			pare

			caso contrario:
				escreva("\nescolha uma opção valida, obrigado p \n")
		}
	}
	
	//--------- FUNÇÃO VOLTAR AO MENU ------------- //
	funcao logico voltar_ao_menu()
	{
		cadeia voltar_menu_usuario
		faca
		{
			escreva("\n deseja valtar ao menu? (s)Sim, (n)NÃO: ")
			leia(voltar_menu_usuario)
			voltar_menu_usuario = t.caixa_baixa(voltar_menu_usuario)
		}enquanto(voltar_menu_usuario != "s" e voltar_menu_usuario != "n")
		
		se(voltar_menu_usuario == "s" )
		{
			retorne verdadeiro
		}
		senao
		{
			retorne falso
		}
	}

	//--------- FUNÇÃO PARA ENCERRAR O PROGRAMA ----------//
	funcao encerrar_programa()
	{	limpa()
		escreva("\nOBRIGADO POR UTILIZAR NOSSO PROGRAMA, VOLTE SEMPRE! \n")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 3208; 
 * @DOBRAMENTO-CODIGO = [57, 80, 107, 130, 154, 177, 191, 213, 307, 330, 379, 402, 457, 480, 497, 520, 571, 594, 643, 787, 924, 947, 1021, 1071, 1092];
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */