

dotnet sonarscanner begin /k:"proyectofinaldecalidad" /d:sonar.host.url="https://sonar-test.bit2bittest.com" /d:sonar.login="99952357b16bce652a94e0d334a409d5c202f1d4"
dotnet build ProyectoFinalDeCalidad.sln
dotnet sonarscanner end /d:sonar.login="99952357b16bce652a94e0d334a409d5c202f1d4"