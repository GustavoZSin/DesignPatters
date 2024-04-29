using ChainsOfResponsabilityRequisicaoWeb;

Requisicao requisicao = new(Formato.XML);

Conta gustavo = new Conta("Gustavo", 500);
gustavo.Depositar(500);

Console.WriteLine(requisicao.Executa(gustavo));