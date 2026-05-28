FROM mcr.microsoft.com/playwright/dotnet:v1.53.0-noble

WORKDIR /app

COPY . .

RUN dotnet restore

RUN dotnet build

RUN pwsh bin/Debug/net8.0/playwright.ps1 install

CMD ["dotnet", "test"]