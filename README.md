# QA Automation Framework (.NET + Playwright)

Framework de automação de testes UI e API construído com Playwright e .NET 8.

O projeto simula uma arquitetura de automação utilizada em ambientes reais de engenharia de qualidade, com foco em organização, escalabilidade e execução independente de ambiente.

---

## 🎯 Objetivo

Este framework foi desenvolvido para demonstrar:

- Automação de testes UI e API
- Estrutura baseada em Page Object Model
- Organização de código escalável
- Execução independente via Docker
- Integração com CI/CD
- Geração de relatórios automatizados

---

## 🏗 Arquitetura do Framework

O framework segue uma estrutura baseada em camadas:

- **Tests** → Casos de teste
- **Pages** → Page Object Model (UI abstração)
- **Core** → BaseTest e configuração do ciclo de execução
- **Utils** → Helpers como screenshots e utilitários

### Fluxo de execução:

1. O teste é iniciado dentro do NUnit
2. BaseTest inicializa o browser com Playwright
3. Pages encapsulam ações da interface
4. Utils capturam evidências (screenshots/logs)
5. Allure registra os resultados da execução
6. O browser é encerrado ao final do teste

---

## 🚀 Funcionalidades

- Testes automatizados de UI com Playwright
- Testes de API
- Page Object Model (POM)
- Execução via Docker
- Captura de screenshots em falhas
- Relatórios com Allure
- Estrutura pronta para CI/CD

---

## 🐳 Execução via Docker

### Build da imagem:

```bash
docker build -t qa-framework .
```
### Execução:

```bash
docker run qa-framework
```

---

## 📊 Relatórios (Allure)

Após execução dos testes:

```bash
allure serve allure-results
```

O relatório fornece:

Status dos testes
Logs de execução
Evidências (screenshots quando aplicável)

---

## ⚙️ CI/CD

O projeto possui integração com GitHub Actions para execução automática dos testes em cada push.

---

## 💡 O que este projeto demonstra

### Este framework demonstra capacidade de:

- Construir automação estruturada
- Aplicar boas práticas de engenharia de testes
- Trabalhar com containers (Docker)
- Integrar execução em pipeline CI/CD
- Organizar código de forma escalável

---