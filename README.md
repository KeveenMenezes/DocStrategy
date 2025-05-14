# DocStrategy

## Sobre o Projeto
O **DocStrategy** é um projeto desenvolvido com foco em arquitetura limpa e princípios de design orientados a objetos. Ele utiliza padrões de projeto e boas práticas para garantir modularidade, escalabilidade e facilidade de manutenção. O objetivo principal é gerenciar documentos, como certidões de casamento e nascimento, através de uma API RESTful.

## Arquitetura
O projeto segue uma arquitetura em camadas, separando responsabilidades de forma clara:

- **Core**: Contém a lógica de domínio e as entidades principais do sistema e implementa os casos de uso e estratégias específicas para o processamento de documentos.
- **Infra**: Adapta o sistema para interagir com fornecedores externos e serviços de infraestrutura.
- **Presentation**: Implementa a API Web, incluindo controladores, mapeadores e injeção de dependências.

## Principais Funcionalidades
- Solicitação de documentos (ex.: certidões de casamento e nascimento).
- Mapeamento de DTOs para entidades de domínio utilizando o padrão **Mapper**.
- Estratégias para integração com diferentes fornecedores de documentos.
- Tratamento de exceções e validação de dados.

## Design Patterns Utilizados

### Strategy Pattern
O projeto utiliza o **Strategy Pattern** para lidar com diferentes fornecedores de documentos. Cada fornecedor é encapsulado em uma estratégia específica que implementa a interface `IFornecedorStrategy`. O `DocumentoContext` é responsável por selecionar dinamicamente a estratégia apropriada com base no tipo de documento solicitado.

**Vantagens**:
- Extensibilidade: Adicionar novos fornecedores é simples e não impacta o restante do sistema.
- Manutenção: A lógica de cada fornecedor está isolada, facilitando alterações e correções.
- Reutilização: O mesmo contexto pode ser usado em diferentes partes do sistema.

### Mapper Pattern
O **Mapper Pattern** é utilizado para converter objetos entre diferentes camadas, como DTOs e entidades de domínio. Isso garante a separação de responsabilidades e mantém o código mais limpo.

## Tecnologias Utilizadas
- **ASP.NET Core**: Para a construção da API Web.
- **Dependency Injection**: Para gerenciar dependências e promover o desacoplamento.
- **Padrões de Projeto**: Strategy, Mapper, Controller, entre outros.
