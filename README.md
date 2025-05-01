# TieMention 🎬📚🎵

Um site inspirado no conceito do WhoSampled, mas focado em rastrear e catalogar menções de obras em outras obras através de diferentes mídias como filmes, séries, desenhos animados, livros, músicas e muito mais.

Tecnologias Utilizadas 🛠️

    .NET 9 - Framework principal para desenvolvimento backend

    Blazor - Para componentes interativos e renderização dinâmica

    JavaScript - Funcionalidades complementares no frontend

    CSS - Estilização e design responsivo

    HTML - Estrutura básica das páginas

    Entity Framework Core - ORM para acesso e gerenciamento de banco de dados

    PostgreSQL - Banco de dados relacional

Funcionalidades Principais ✨

    🎥 Catalogar referências entre diferentes tipos de mídia

    🔍 Sistema de busca avançada por obras e tipos de menção

    📊 Visualizações gráficas de conexões entre obras

    👥 Perfis de usuários com contribuições e listas pessoais

    🏷️ Sistema de tags e categorização de menções

    📱 Design responsivo para todos os dispositivos

Configuração do Ambiente de Desenvolvimento ⚙️

    Clone o repositório:
    bash

git clone https://github.com/RaquelAFerreira/TieMention.git
cd TieMention

Restaure as dependências:
bash

dotnet restore

Configure o banco de dados:

    Atualize a connection string no appsettings.json

    Execute as migrations:
    bash

    dotnet ef database update

Execute o projeto:
bash

    dotnet run

