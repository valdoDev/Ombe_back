Funcionalidade: Favoritos - Excluir 
	Como um usuario
	Eu desejo excluir produto como favorito no app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Excluir favorito com sucesso
Dado Que um usuario acesse opcao de cadastro favorito
Quando O usuario inserir informacoes
E tocar no botao excluir
Entao O usuario recebera uma mensagem de sucesso

Cenario: Excluir favorito inexistente
Dado Que um usuario acesse opcao de cadastro favorito
Quando O usuario inserir informacoes
E tocar no botao excluir
E codigo favorito nao existir na base
Entao O usuario recebera uma mensagem de erro

Cenario: Excluir favorito com dados incompletos
Dado Que um usuario acesse opcao de cadastro favorito
Quando O usuario inserir informacoes incompletas
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de erro