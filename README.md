# Exemplo de uso de GraphQL com .NET Core

  Neste repositório você terá acesso a uma aplicação exemplo feita com .NET Core 2.2 e NHibernate.

  Utilizei a lib GraphQL.Conventions para escrever o GraphQL Server.


## Preparação do ambiente
- O NHibernate está configurado para acessar um banco de dados PostgreSQL de nome **perb_flight_planner**. Para modificar, basta acessar o arquivo [/api/Perb.FlightPlanning.Api/appsettings.Development.json](https://github.com/MacaeTech/macae-tech-meetup-graphql-sample/blob/master/api/Perb.FlightPlanning.Api/appsettings.Development.json).
- O script que cria a estrutura do banco dados encontra-se em [/api/Perb.FlightPlanning.Shared/Infrastructure/SqlMigrator/001-postgres.sql](https://github.com/MacaeTech/macae-tech-meetup-graphql-sample/blob/master/api/Perb.FlightPlanning.Shared/Infrastructure/SqlMigrator/001-postgres.sql). Execute esse arquivo no seu banco PostgreSQL.

## Executando
- Execute o projeto Perb.FlightPlanning.Api
- Abra o navegador e acesse a URL https://localhost:5001/ui/playground e boa diversão!
