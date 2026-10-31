# ScreenSound — modelos, menus e experimento com IA

Projeto de estudo em C# com alvo .NET 8. `ScreenSound/ScreenSound.csproj` referencia o pacote `OpenAI` versão 1.11.0. O projeto reúne modelos de banda, álbum, música e avaliação, menus correspondentes e uma pasta de desafios sobre herança e interfaces.

## O que a entrada faz

A entrada atual `ScreenSound/Program.cs` cria um cliente `OpenAIAPI` com um valor placeholder, monta uma conversa solicitando um resumo de uma banda e aguarda uma resposta remota. Ela não inicia os menus musicais presentes na árvore.

Esse experimento depende de configuração válida e de um serviço externo, sujeito a disponibilidade e possíveis custos. Não coloque credenciais no código. O cliente precisa de credenciais válidas e configuração compatível com o serviço para enviar a solicitação.

Os menus e os desafios são exemplos de estudo separados da entrada ativa; não formam um fluxo integrado com esse experimento de IA.
