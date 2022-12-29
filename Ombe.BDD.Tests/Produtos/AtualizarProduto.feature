Funcionalidade: Produto - Atualizar cadastro
	Como um usuario
	Eu desejo atualizar cadastro de produto no app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Atualizar produto com sucesso
Dado Que um usuario acesse opcao de cadastro produto
Quando O usuario altera informacoes
E tocar no botao atualizar
Entao O usuario recebera uma mensagem de sucesso

Cenario: Atualizar produto com erro
Dado Que um usuario acesse opcao de cadastro produto
Quando O usuario altera informacoes
E tocar no botao atualizar
E dados estivem incosistente
Entao O usuario recebera uma mensagem de erro