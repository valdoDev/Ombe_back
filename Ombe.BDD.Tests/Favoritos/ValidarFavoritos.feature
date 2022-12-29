Funcionalidade: Favorito - Valida 
	Como um usuario
	Eu desejo validar situacao do favorito no app
	Para que eu possa conhecer a situacao do favorito no app

Cenario: Favorito existente
Dado Que um usuario acesse opcao checar favorito
Quando O usuario inserir o valores de pesquisa
E O favorito existir na base
Entao O usuario recebera um retorno posito

Cenario: Favorito inexistente
Dado Que um usuario acesse opcao checar favorito
Quando O usuario inserir o valores de pesquisa
E O favorito nao existir na base
Entao O usuario recebera uma mensagem de erro

Cenario: Resumo dados do favorito
Dado Que um usuario acesse opcao checar favorito
Quando O usuario inserir o valores de pesquisa
E O favorito existir na base
Entao O usuario recebera resumo do cadastro produto