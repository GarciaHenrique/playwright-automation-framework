# QA Automation Framework (.NET + Playwright)

Framework de automação de testes UI e API construído com .NET 8 e Playwright.

Este projeto implementa uma arquitetura de testes inspirada em ambientes reais de engenharia de qualidade, com foco em escalabilidade, confiabilidade e execução automatizada via CI/CD e Docker.

---

# 🧭 Visão Geral

O framework foi projetado para suportar automação de testes de aplicações web e APIs, seguindo padrões utilizados em equipes de QA Automation em ambientes corporativos.

Ele permite:

- Execução local e em container (Docker)
- Execução automatizada via CI/CD (GitHub Actions)
- Estrutura escalável baseada em Page Object Model
- Geração de relatórios com Allure

---

# 🏗 Arquitetura

## 📦 Estrutura do projeto

- **Tests** → Casos de teste (UI e API)
- **Pages** → Abstração da camada de UI (Page Object Model)
- **Core** → Configuração do ciclo de execução (BaseTest)
- **Utils** → Utilitários (screenshots, helpers, logging)

---

## 🔁 Fluxo de execução dos testes

```text id="enterprise-flow"
1. NUnit inicia execução do teste
2. BaseTest inicializa Playwright (browser/context/page)
3. Page Objects executam ações na UI
4. Utils capturam evidências (screenshots/logs)
5. Allure registra resultados da execução
6. TearDown finaliza browser e contexto
```

---

## 🚀 Funcionalidades

- Automação de testes UI com Playwright
- Automação de testes de API
- Page Object Model (POM)
- Execução paralela de testes
- Captura automática de screenshots em falhas
- Integração com Allure Reports
- Execução via Docker
- Integração com CI/CD (GitHub Actions)

---

# ▶️ Como executar localmente

### 1. Pré-requisitos
- .NET 8 SDK
- Node.js (para dependências do Playwright)
- PowerShell (Windows)

---

### 2. Clonar o repositório
```bash
git clone https://github.com/GarciaHenrique/playwright-automation-framework.git
cd playwright-automation-framework
```

---

### 3. Restaurar dependências
```bash
dotnet restore
```

---

### 4. Instalar browsers do Playwright
```bash
pwsh bin/Debug/net8.0/playwright.ps1 install
```

---

### 5. Executar testes
```bash
dotnet test
```

---

# 🐳 Execução com Docker

### Build da imagem
```bash
docker build -t qa-framework .
```
### Executar testes
```bash
docker run qa-framework
```

---

# 📊 Relatórios (Allure)

Após a execução dos testes:
```bash
allure serve allure-results
```

### Informações do relatório:
- Status dos testes (pass/fail)
- Histórico de execução
- Evidências (screenshots em falhas)
- Logs detalhados

---

## ⚙️ CI/CD (GitHub Actions)

O projeto possui pipeline automatizado que executa:
- Build do projeto
- Execução dos testes
- Geração de resultados
- Upload de artifacts

Execução automática ocorre em:
- Push na branch main
- Pull Requests

---

## 📸 Evidências de Teste

O framework gera automaticamente:
- Screenshots em falhas
- Logs de execução
- Resultados do Allure

---

## 🧪 Exemplo de Teste
```C#
[Test]
public async Task Login_ShouldBeSuccessful()
{
    await loginPage.Login("standard_user", "secret_sauce");
    Assert.IsTrue(await homePage.IsLoaded());
}
```

---

# 💡 Decisões de Arquitetura

### Page Object Model
Separação da lógica de teste e da UI para facilitar manutenção e escalabilidade.

### BaseTest
Centraliza:
- inicialização do Playwright
- lifecycle do browser
- teardown automático

### Docker
Garante execução consistente do framework em qualquer ambiente.

### CI/CD
Permite execução automática dos testes em pipeline, simulando ambiente real de entrega contínua.

---

# 🎯 Objetivo do Projeto

### Este framework demonstra capacidade de:
- Construir automação de testes escalável
- Aplicar boas práticas de engenharia de software em QA
- Trabalhar com CI/CD e containers
- Estruturar projetos de automação em nível profissional

---

# 🚀 Status do Projeto

✔ Testes automatizados funcionando
✔ Estrutura POM implementada
✔ Execução via Docker
✔ Integração com GitHub Actions
✔ Relatórios com Allure

---