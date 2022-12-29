Funcionalidade: Avaliacao - Interacao 
	Como um usuario
	Eu desejo interagir com avaliacao de um produto no app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Interagir avaliacao com sucesso
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de sucesso

Cenario: Interagir avaliacao existente
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes
E tocar no botao cadastrar
E codigo produto e usuario ja estiverem cadastrado
Entao O usuario recebera uma mensagem de erro

Cenario: Interagir avaliacao com dados incompletos
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes incompletas
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de erro