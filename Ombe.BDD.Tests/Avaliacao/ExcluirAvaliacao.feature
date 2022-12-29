Funcionalidade: Avaliacao - Excluir 
	Como um usuario
	Eu desejo validar situacao de avaliacoes no app
	Para que eu possa conhecer a situacao da avaliacao no app

Cenario: Excluir avaliacao com sucesso
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes
E tocar no botao excluir
Entao O usuario recebera uma mensagem de sucesso

Cenario: Excluir avaliacao inexistente
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes
E tocar no botao excluir
E codigo favorito nao existir na base
Entao O usuario recebera uma mensagem de erro

Cenario: Excluir avaliacao com dados incompletos
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes incompletas
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de erro