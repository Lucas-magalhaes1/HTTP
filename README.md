# SimpleHttp

Este é um exemplo simples de uma aplicação com ASP.NET Core que demonstra como lidar com requisições HTTP básicas e como configurar o tratamento de erros para diferentes códigos de status.

## Funcionalidades

- Responde a requisições GET, POST e a diferentes códigos de status (401, 403, 404, 500).
- Exibe mensagens específicas para cada código de status.

## Como executar

 Acesse os diferentes endpoints para testar as funcionalidades no programa:
   - `GET /Home/Index` - Retorna uma mensagem de sucesso para requisições GET.
   - `POST /Home/Post` - Retorna uma mensagem de sucesso para requisições POST.
   - `GET /Home/Unauthorized` - Retorna um erro 401 (Unauthorized).
   - `GET /Home/Forbidden` - Retorna um erro 403 (Forbidden).
   - `GET /Home/NotFound` - Retorna um erro 404 (Not Found).
   - `GET /Home/InternalServerError` - Retorna um erro 500 (Internal Server Error).

