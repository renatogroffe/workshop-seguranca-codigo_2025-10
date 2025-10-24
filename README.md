# workshop-seguranca-codigo_2025-10
Conteúdos do Workshop "Implementando Segurança em Código na prática: de aplicações à infraestrutura com GitHub Actions!", realizado durante evento promovido pela FIAP em São Paulo-SP no dia 25/10/2025.

Docker, Kubernetes, Linux, GitHub Actions, .NET, Checkov, KICS, Gitleaks, Kor...

## Implementando Segurança em Código na prática: de aplicações à infraestrutura com GitHub Actions!

Aprenda neste workshop como implementar soluções para análise de código em aplicações e em scripts de infraestrutura na prática, automatizando a execução destas checagens com o GitHub Actions, Linux e diversas ferramentas open source!

Acesse este conteúdo via QRCode e também nos apoiem 🙌, deixando um star ⭐ no repositório do GitHub:

![QRCode Conteúdo](img/qrcode-readme.png)

Instrutores (links apontando para o LinkedIn, nos adicionem lá 😉):
- Renato Groffe [LinkedIn](https://www.linkedin.com/in/renatogroffe/) :: [GitHub](https://github.com/renatogroffe)
- Marcio Nizzola [LinkedIn](https://www.linkedin.com/in/nizzola/) :: [GitHub](https://github.com/nizzola)

Algumas de nossas comunidades técnicas (links para Meetup e YouTube):
- [.NET São Paulo](https://www.meetup.com/dotnet-Sao-Paulo/)
- [Azure Talks](https://www.meetup.com/azure-talks/)
- [DevOps Professionals](https://www.meetup.com/DevOps-Professionals/)
- [Canal .NET](https://www.youtube.com/canaldotnet)
- [Azure na Prática](https://www.youtube.com/azurenapratica)
- [Coding Night](https://www.youtube.com/codingnight)

Referências utilizadas:
- [GitHub Actions](https://docs.github.com/en/actions)
- [APIsec University - Certificações online gratuitas](https://www.apisecuniversity.com/)
- [Gitleaks](https://github.com/gitleaks/gitleaks)
- [Checkov - CLI Command Reference](https://www.checkov.io/2.Basics/CLI%20Command%20Reference.html)
- [KICS - CLI Command Reference](https://docs.kics.io/latest/commands/)
- [Kor: a Golang Tool to discover unused Kubernetes Resources](https://github.com/yonahd/kor)
- [Uploading a SARIF file to GitHub - GitHub Docs](https://docs.github.com/en/code-security/code-scanning/integrating-with-code-scanning/uploading-a-sarif-file-to-github)

A seguir estão as instruções passo a passo para a execução das atividades práticas.

Na pasta **slides** estão outros materiais, que poderemos abordar durante o workshop havendo uma sobra de tempo.

Para os testes com o Job que será publicado no cluster Kubernetes utilizamos uma das APIs públicas catalogadas em:
https://github.com/public-apis/public-apis

Foi a API Bacon Ipsum 😂:
https://baconipsum.com/json-api/

Através do endpoint:
https://baconipsum.com/api/?type=meat-and-filler

Nosso cluster de testes foi criado via kind, um emulador de Kubernetes muito útil para testes:
https://kind.sigs.k8s.io/

---

### 0. Pré-requisitos

Caso ainda não tenha uma conta no GitHub, comece instalando um aplicativo de One-Time Password (OTP) em seu celular. Recomendamos o Microsoft Authenticator, com versões para Android e iOS: https://www.microsoft.com/pt-br/security/mobile-authenticator-app

Em seguida crie sua conta no GitHub usando um e-mail e nome válidos, com o link a seguir trazendo algumas instruções úteis e lembrando da necessidade se habilitar o MFA (autenticação multifator): https://docs.github.com/pt/get-started/start-your-journey/creating-an-account-on-github


---

### 1. Preparando o repositório para estudos
