Ana Carolin Tavares Brandão - RM552283 - 2TDSPJ
---

# Exame2tds.API

Este projeto é uma **Web API** desenvolvida com **C#** utilizando **MongoDB** para persistência de dados e **Machine Learning** com **ML.NET**. A aplicação oferece operações CRUD e uma funcionalidade de previsão de dados utilizando um modelo de Machine Learning.

---

## **Tecnologias Utilizadas**

- **.NET 6** ou superior
- **MongoDB** para banco de dados
- **ML.NET** para Machine Learning
- **Swagger** para documentação da API
- **Dependências**:
  - MongoDB.Driver
  - Microsoft.ML

---

## **Como Rodar o Projeto**

### **1. Pré-requisitos**

- **.NET SDK** instalado (versão 6 ou superior).
- **MongoDB** instalado e em execução localmente ou em um servidor acessível.

### **2. Clonar o Repositório**

```bash
git clone https://github.com/username/Exame2tds.API.git
```

### **3. Configuração do MongoDB**

- Acesse o arquivo `appsettings.json` e configure a string de conexão com o MongoDB:

```json
{
  "MongoDbSettings": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "Exame2tdsDB"
  }
}
```

### **4. Instalar Dependências**

Na raiz do projeto, execute o comando para restaurar as dependências:

```bash
dotnet restore
```

### **5. Rodar o Projeto**

Execute o projeto com o comando:

```bash
dotnet run
```

O servidor estará disponível em `https://localhost:7189/swagger/index.html`.

### **6. Acessar a Documentação do Swagger**

Após rodar a API, acesse a documentação interativa da API através do Swagger em:

```
https://localhost:7189/swagger/index.html
```

---

## **Principais Funcionalidades da API**

### **Operações CRUD**

- **GET /api/Data**: Retorna todos os dados armazenados no banco MongoDB.
- **POST /api/Data**: Cria um novo registro de dados no banco MongoDB.
- **GET /api/Data/{id}**: Retorna os dados de um item específico com o `id`.
- **PUT /api/Data/{id}**: Atualiza os dados de um item específico com o `id`.
- **DELETE /api/Data/{id}**: Deleta um item específico com o `id` do banco MongoDB.

Essas operações permitem gerenciar os dados armazenados no MongoDB, realizando a criação, leitura, atualização e exclusão dos registros.

---

## **Lógica do Componente de Machine Learning**

A aplicação inclui uma funcionalidade de Machine Learning utilizando **ML.NET** para previsão de dados. O modelo foi desenvolvido para analisar dados e fazer previsões baseadas em entradas fornecidas.

### **Estrutura do Modelo de ML**

- **PredictionModel.cs**: Define o modelo de dados usado para a previsão. Esse modelo contém os campos que o algoritmo de ML precisa para realizar as análises.
  
- **PredictionService.cs**: Serviço que processa os dados e executa a lógica de Machine Learning. Aqui, o modelo é carregado, os dados são analisados e a previsão é gerada.

- **MLController.cs**: Controlador da API que expõe uma rota (`POST /api/ML/forecast`) para fazer previsões com base em novos dados fornecidos pelo usuário.

### **Exemplo de Previsão com Machine Learning**

Para usar o modelo de previsão, envie um `POST` para a seguinte rota:

```
POST /api/ML/forecast
```

**Corpo da Requisição (JSON)**:

```json
{
  "feature1": 2.3,
  "feature2": 5.4
}
```

**Resposta (JSON)**:

```json
{
  "prediction": 10.5
}
```

---

## **Demonstração Funcional da API**

### **Operações CRUD**

- **GET /api/Data**: Retorna uma lista de todos os registros de dados. Exemplo de resposta:

```json
[
  {
    "id": "1",
    "field1": "value1",
    "field2": "value2"
  },
  {
    "id": "2",
    "field1": "value3",
    "field2": "value4"
  }
]
```

- **POST /api/Data**: Cria um novo registro de dados. Exemplo de corpo da requisição:

```json
{
  "field1": "new_value1",
  "field2": "new_value2"
}
```

**Resposta**:

```json
{
  "id": "new_generated_id",
  "field1": "new_value1",
  "field2": "new_value2"
}
```

- **GET /api/Data/{id}**: Retorna os dados de um item específico. Exemplo:

```json
{
  "id": "1",
  "field1": "value1",
  "field2": "value2"
}
```

- **PUT /api/Data/{id}**: Atualiza um item específico com base no `id`. Exemplo de corpo da requisição:

```json
{
  "field1": "updated_value1",
  "field2": "updated_value2"
}
```

- **DELETE /api/Data/{id}**: Deleta um item específico.

---

## **Considerações Finais**

A API está pronta para ser utilizada e demonstra as operações CRUD básicas com integração ao MongoDB. A parte de Machine Learning permite realizar previsões de dados com base no modelo treinado com ML.NET.

A documentação Swagger oferece uma interface amigável para testar todas as funcionalidades da API diretamente no navegador.

---

