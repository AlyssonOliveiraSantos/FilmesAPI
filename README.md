# 🎬 FilmeAPI

Uma API REST para gerenciar um catálogo de filmes, desenvolvida com .NET, Proxies, AutoMapper e Newtonsoft.Json.

## 🚀 Tecnologias utilizadas
- **.NET 8+**
- **AutoMapper**
- **Newtonsoft.Json**
- **Entity Framework Core** (SQL Server)
- **Proxies para Lazy Loading**

## 📌 Como rodar o projeto
1. Clone o repositório:
   ```bash
   git clone https://github.com/AlyssonOliveiraSantos/FilmesAPI.git

2. Entre no diretório:
    cd FilmeAPI

3. Instale as dependências:
    dotnet restore


4. Configuração da String de Conexão:
    Abra o arquivo appsettings.json.
    Substitua a string de conexão com os dados do seu banco de dados. Exemplo:

"ConnectionStrings": {
  "DataBase": "Server=seu-servidor; Database=Filmes; User Id=seu-usuario; Password=sua-senha; TrustServerCertificate=True"
}


5. Rode a aplicação:
    dotnet run



📌 Endpoints da API

🎥 Filmes
| Método  | Rota                              | Descrição                                    |
|---------|-----------------------------------|----------------------------------------------|
| GET     | `/filmes`                         | Retorna todos os filmes                      |
| GET     | `/filmes?nomeCinema=Cinema%20Api` | Retorna todos os filmes filtrados por cinema |
| GET     | `/filmes/{id}`                    | Retorna um filme específico                  |
| POST    | `/filmes`                         | Adiciona um novo filme                       |
| PUT     | `/filmes/{id}`                    | Atualiza um filme existente                  |
| PATCH   | `/filmes/{id}`                    | Atualiza parcialmente um filme               |
| DELETE  | `/filmes/{id}`                    | Remove um filme    


📝 Exemplo de Requisição
```json

{
  "titulo": "Star Wars",
  "genero": "aventura",
  "duracao": 180 
}
````

 Atualizar parcialmente um filme (PATCH /filmes/{id})
```json
 [
    {
        "op": "replace",
        "path": "/genero",
        "value": "Ação"
    }
 ]
````

#### 📍 Endereços  

| Método  | Rota             | Descrição                      |
|---------|-----------------|--------------------------------|
| GET     | `/endereco`      | Retorna todos os endereços     |
| GET     | `/endereco/{id}` | Retorna um endereço específico |
| POST    | `/endereco`      | Adiciona um novo endereço      |
| PUT     | `/endereco/{id}` | Atualiza um endereço existente |
| DELETE  | `/endereco/{id}` | Remove um endereço             |


📝 Exemplo de Requisição
```json

{
  "Logradouro": "Rua das APIs",
  "Numero": "10"
}
````

#### 🎭 Cinemas  

| Método  | Rota                   | Descrição                                           |
|---------|------------------------|-----------------------------------------------------|
| GET     | `/cinema`              | Retorna todos os cinemas                            |
| GET     | `/cinema?enderecoId=1` | Retorna todos os cinemas em um determinado endereço |
| GET     | `/cinema/{id}`         | Retorna um cinema específico                        |
| POST    | `/cinema`              | Adiciona um novo cinema                             |
| PUT     | `/cinema/{id}`         | Atualiza um cinema existente                        |
| DELETE  | `/cinema/{id}`         | Remove um cinema                                    |


📝 Exemplo de Requisição
```json

{
  "Nome": "Cinema Api",
  "EnderecoId": 1
}
````

#### 🎭 Sessões  

| Método  | Rota           | Descrição                     |
|---------|--------------|-----------------------------|
| GET     | `/sessao`      | Retorna todas as sessões      |
| GET     | `/sessao/{id}` | Retorna uma sessão específica |
| POST    | `/sessao`      | Adiciona uma nova sessão      |

📝 Exemplo de Requisição
```json

{
  "FilmeId": "1",
  "CinemaId": "1"
}
````

✅ Conclusão
Este projeto fornece uma API robusta para gerenciar filmes, cinemas e sessões, com um modelo de dados bem estruturado e relacionamentos definidos. Sinta-se à vontade para contribuir ou adaptar conforme necessário! 🎬🍿

