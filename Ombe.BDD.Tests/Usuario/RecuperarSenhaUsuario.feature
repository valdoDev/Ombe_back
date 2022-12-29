Funcionalidade: Usuario - Recuperar senha Usuario
	Como um usuario
	Eu desejo recuperar senha do app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Recuperar senha usuario com sucesso
Dado Que um usuario acesse opcao de recuperacao senha
Quando O usuario inserir e-mail
E tocar no botao recuperar senha
Entao O usuario recebera uma mensagem de sucesso
E O usuario recebera um e-mail com nova senha

Cenario: Recuperar senha usuario desativado com erro
Dado Que um usuario acesse opcao de cadastro
Quando O usuario inserir e-mail
E tocar no botao recuperar senha
E usuario desativado
Entao O usuario recebera uma mensagem de erro

Cenario: Recuperar senha usuario e-mail inexistente com erro
Dado Que um usuario acesse opcao de cadastro
Quando O usuario inserir e-mail
E tocar no botao recuperar senha
E e-mail inexistente
Entao O usuario recebera uma mensagem de erro