Funcionalidade: Usuario - Atualizar cadastro Usuario
	Como um usuario
	Eu desejo atualizar cadastro no app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Atualizar usuario com sucesso
Dado Que um usuario acesse opcao de cadastro
Quando O usuario altera informacoes
E tocar no botao atualizar
Entao O usuario recebera uma mensagem de sucesso

Cenario: Atualizar usuario com erro
Dado Que um usuario acesse opcao de cadastro
Quando O usuario altera informacoes
E tocar no botao atualizar
E dados estivem incosistente
Entao O usuario recebera uma mensagem de erro