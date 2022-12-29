Funcionalidade: Avaliacao - Valida 
	Como um usuario
	Eu desejo validar situacao de avaliacoes no app
	Para que eu possa conhecer a situacao da avaliacao no app

Cenario: Avaliacao existente
Dado Que um usuario acesse opcao checar avaliacao
Quando O usuario inserir o valores de pesquisa
E A avaliacao existir na base
Entao O usuario recebera um retorno posito

Cenario: Avaliacao inexistente
Dado Que um usuario acesse opcao checar avaliacao
Quando O usuario inserir o valores de pesquisa
E A avaliacao nao existir na base
Entao O usuario recebera uma mensagem de erro

Cenario: Resumo dados do favorito
Dado Que um usuario acesse opcao checar avaliacao
Quando O usuario inserir o valores de pesquisa
E A avaliacao existir na base
Entao O usuario recebera resumo do cadastro produto