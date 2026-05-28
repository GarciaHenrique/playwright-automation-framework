# QA Automation Framework (.NET + Playwright)

Framework de automação de testes UI e API construído com Playwright e .NET 8.

O projeto simula uma arquitetura de automação utilizada em ambientes reais de engenharia de qualidade, com foco em organização, escalabilidade e execução independente de ambiente.

---

# 🎯 Objetivo

Este framework foi desenvolvido para demonstrar:

- Automação de testes UI e API
- Estrutura baseada em Page Object Model
- Organização de código escalável
- Execução independente via Docker
- Integração com CI/CD
- Geração de relatórios automatizados

---

# 🏗 Arquitetura do Framework

O framework segue uma estrutura baseada em camadas:

## 📦 Camadas do sistema

- **Tests** → Casos de teste
- **Pages** → Page Object Model (abstração da UI)
- **Core** → BaseTest e controle do ciclo de execução
- **Utils** → Helpers (screenshots, logs e utilitários)

---

## 🔁 Fluxo de execução

1. O teste é iniciado pelo NUnit
2. O BaseTest inicializa o browser com Playwright
3. As Pages encapsulam as ações da interface
4. Os Utils capturam evidências (screenshots e logs)
5. O Allure registra os resultados da execução
6. O browser é encerrado ao final do teste

---

# 🚀 Funcionalidades

- Automação de testes UI com Playwright
- Automação de testes de API
- Page Object Model (POM)
- Execução via Docker
- Captura de screenshots em falhas
- Relatórios com Allure
- Estrutura preparada para CI/CD

---

# 🐳 Execução via Docker

## 🔨 Build da imagem

```bash
docker build -t qa-framework .
```

## ▶ Execução dos testes

```bash
docker run qa-framework
```

---

# 📊 Relatórios (Allure)

Após a execução dos testes:
```bash
allure serve allure-results
```

### O relatório inclui:

- Status dos testes
- Logs de execução
- Evidências (screenshots quando aplicável)

---

# ⚙️ CI/CD

Este projeto possui integração com GitHub Actions para execução automática dos testes em cada push.

---

# 💡 O que este projeto demonstra

Este framework demonstra capacidade de:
- Construir automação estruturada e escalável
- Aplicar boas práticas de engenharia de testes
- Trabalhar com containers (Docker)
- Integrar testes em pipeline CI/CD
- Organizar código de forma profissional e modular

---