programa
{
	
	funcao inicio()
	{
		//TELA MENU
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

		//TELA DE DE DIGITAÇÃO DE ESCOLHA

		escreva("|================================================================|\n")
		escreva("|              BOA NOITE COMO POSSO AJUDAR?                      |\n")
		escreva("|             ESCOLHA UMA DAS OPÇÕES Á CIMA                      |\n")
		escreva("|ESCOLHA --> ")

		//TELA EXIBÇÃO FINAL

			escreva("|================================================================|\n")
			escreva("|  \n    CONTRA CHEQUE |   SENAI-LINHARES-ES                          |\n")
			escreva("|                                                                |\n")
			escreva("|================================================================|\n")
			escreva("|INSS: ","inss", "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|IRRF: ","irrf", "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|VALE TRANSPORTE: ","vale", "R$                                            |\n")
			escreva("|================================================================|\n")
			escreva("|FGST: ","fgts", "R$                                                       |\n")
			escreva("|================================================================|\n")
			escreva("|PERICULOSIDADE: ","periculosidade", "R$                                             |\n")
			escreva("|================================================================|\n")
			escreva("|ADICIONAL NOTURNO: ", "noturno", "R$                                          |\n")
			escreva("|================================================================|\n")
			escreva("|HORA EXTRAS: ","hora_extra", "R$                                                |\n")
			escreva("|================================================================|\n")

			escreva("|================================================================\n")
			escreva("|TOTAL ADICIONADO: ", "periculosidade" + "noturno" + "hora_extra" + "salário", "\n")
			escreva("|TOTAL DESCONTADO: ", "inss + irrf + vale + fgts", "              \n")
			escreva("|================================================================\n")
	}

	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 3191; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */