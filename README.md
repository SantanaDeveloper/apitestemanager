

  

# API Teste Manager 

  

API de teste de conhecimento com objetivo de comparar dados Json.

  

### _Tecnologias utilizadas_

C# .Net Core

Dapper

Swagger

PostgreSQL

  
  

![Base Api](https://programathor.com.br/blog/wp-content/uploads/2018/08/o-que-%C3%A9-api-676x355.jpg)

  
  


### Instalação

  

- Clone ou faça o download do repositório.

- Crie uma database no postgree com o nome apimanager e importe o arquivo "apimanager.sql".

- Configure o appsettings.json de acordo com o seu ambiente.

- Execute os testes para verificar se está tudo certo.

### Como usar
- O Swagger foi disponibilizado para auxiliar no uso.
- A rota /v1/diff lista todos os conjuntos de dados inseridos na DB.
- A rota /v1/diff/{id} recebe como parâmetro um id, esse id é obtido quando se insere o json da esquerda.
- Na rota /v1/diff/left deve ser inserido um Json, e tem como retorno um id que deve ser inserido na rota ​/v1​/diff​/right
- Na rota ​/v1​/diff​/right deve ser inserido o id retornado na rota ​/v1​/diff​/left e um dado no formato Json.

### Comparações
- Para comparar basta usar a rota  /v1/diff/{id} informando o id do conjunto (No caso o retorno do IdLeft).
- Depois de informar o id, o sistema processa os 2 dados e retorna com o resultado da comparação.

## Autor

* **João Paulo Santana**  - [Linkedin](https://linkedin.com/in/joaopaulosant/)
