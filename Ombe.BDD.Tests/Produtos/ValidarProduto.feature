Funcionalidade: Produto - Valida 
	Como um usuario
	Eu desejo validar situacao do produto no app
	Para que eu possa conhecer a sitacao do usuario no app

Cenario: Produto ativo
Dado Que um usuario acesse o app
Quando O usuario acessar qualquer funcionalidade de produto
E O produto estiver ativo
Entao O usuario recebera uma mensagem de ola

Cenario: Produto desativado
Dado Que um usuario acesse o app
Quando O usuario acessar qualquer funcionalidade de produto
E O produto estiver desativado
Entao O usuario recebera uma mensagem de erro

Cenario: Resumo dados do produto
Dado Que um usuario acesse opcao checar cadastro produto
Quando O usuario inserir o valores de pesquisa
E O produto estiver ativo
Entao O usuario recebera resumo do cadastro produto