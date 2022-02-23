# BeGreen - 2021
## Equipe "The V's" / ODS 11 - Hacking.Rio 2021
### BeGreen: Gameficação+5G+Hábitos Saudáveis = Cidades+sustentáveis-poluídas-congestionadas
### Descrição do Desafio TIM 5G

https://www.youtube.com/watch?v=TPbsoOjL5nE&list=PL2L7uJK-k6XKPe0sLP3T2DSai2oVfJRpK&index=26

### Apresentação

Com o intuito de ajudar a mitigar a emissão de gás carbônico, incentivar o uso de transportes alternativos, conscientizar a sociedade sobre hábitos mais sustentáveis, assim como divulgar empresas e órgãos parceiros e fornecer descontos em estabelecimentos, idealizamos o **BeGreen**.

Trata-se de uma solução híbrida (*web* e *mobile*), onde serão disponibilizadas ofertas de empresas e órgãos parceiros em pontos específicos da cidade através de **gamificação** para usuários que estejam utilizando meios de transporte alternativo. 

### O Produto

Os centros urbanos estão cada vez mais populosos e vêm sofrendo com a intensificação do trânsito em decorrência de um aumento do uso de carros particulares. Esses fatores geram uma crescente na emissão de gases tóxicos e poluentes, como o gás carbônico e uma piora na qualidade de vida da socidade. Nesse contexto, a presente solução foi idealizada para tentar mitigar tais problemas e ajudar na conscientização da sociedade, se alinhando com o **Objetivo de Desenvolvimento Sustentável da ONU de Cidades e Comunidades Sustentáveis (desafio do cluster ODS 11 - Hacking.Rio 2021)**. 

Pensando em atrair mais usuários e ainda divulgar empresas e órgãos parceiros, o **BeGreen** traz a gamificação por geolocalização, onde o usuário poderá coletar ofertas de parceiros em pontos específicos da cidade. Essa *feature* pretende estimular meios de transporte menos nocivos ao meio ambiente e mais saudáveis para os usuários, intensificar o turismo e o ecoturismo, e ajudar a economia, beneficiando tanto clientes como os parceiros da plataforma.

Além disso, com a **tecnologia 5G**, a plataforma traz uma solução inovadora, sendo capaz de fornecer dados relevantes de forma muito mais rápida e precisa para que órgãos públicos e privados possam desenvolver estudos em diversas vertentes e estratégias que possam beneficiar a qualidade de vida da sociedade como um todo.

### Business Canvas da proposta de solução

*Clique para visualizar o item do Canvas de forma detalhada*

![Canvas ODS 11 - Tim - The Vs](https://user-images.githubusercontent.com/72507215/143767744-1fe7573c-c49a-414c-84f3-c3b80de372fb.jpg)


### Backlog do produto

*Clique para visualizar o item do Backlog de forma detalhada*

![image](https://user-images.githubusercontent.com/72507215/143767701-46477650-4d60-4eac-a7ec-657d80fc3982.png)


### Arquitetura descritiva e desenho da solução

![BeGreenArquitetura](https://user-images.githubusercontent.com/72507215/143767175-ff37f181-eebb-43ba-9716-763234fe9042.jpg)

* Bootstrap v5.0
* Angular v8.3
* .NET 5
* C# v9
* SQLite v5.0.12
* Git versão 2.34.1
* GitHub versão atual

### Requisitos de Hardware

**Servidor**
* Computador com perfil servidor, velocidade de processamento mínima de 2.0 GHz e 4 *cores*, pelo menos 16 GB de memória RAM.

**Cliente**
* Computador com velocidade de processamento mínima de 1.0 GHz e 4 *cores*, pelo menos 4 GB de memória RAM.
* Para dispositivos móveis, não foram realizados testes estatísticamente significativos, mas o perfil deve ser aproximadamente o mesmo do definido anteriormente para computadores pessoais.

### Requisitos de Software

**Servidor**
* Visual Studio 2019 ou superior
* Banco de dados SQLite v5.0.12

**Cliente**
* Navegador Chrome Versão 96.0.4664.45 (Versão oficial) 32 ou 64 bits
* Para dispositivos móveis, via navegador no Android ou iOS por Web App da aplicação

### Instruções para colocar o sistema em produção 📝

Antes de dar o *build* no projeto, é necessário fazer a criação do banco de dados. Abaixo disponibilizamos o passo a passo.

*  No Visual Studio 2019 (ou versão superior), no menu superior, selecione **Ferramentas > Gerenciador de Pacotes do Nuget > Console do Gerenciador de pacotes** ou **Tools > Nuget Package Manager > Package Manager Console** 

*  No console que irá abrir, digite *Add-Migration PrimeiraMigracao* 
*  Depois de aparecer no console a mensagem "Build succeeded. To undo this action, use Remove-Migration.", digite *Update-Database*
*  Pronto! Agora é só rodar o projeto e explorar as nossas features.

### Instruções de funcionamento do sistema com Telas 📝

Observação: Nesta versão 1.0 do sistema (MVP), nem todas as funcionalidades do backlog foram implementadas. Nas telas abaixo, estas funcionalidades não implementadas, estão marcadas com a tarja "em construção" 🔨 e estarão disponíveis na próxima versão estável (versão 2.0 do sistema).

*Funcionalidades Usuário*
* Login - Se não tem cadastro, selecione "Não tem conta ainda? Cadastre-se"

![image](https://user-images.githubusercontent.com/72507215/143768151-f83f0e18-86d1-41e5-a8ec-7c249d3992a8.png)

* Cadastro - Selecione "Usuário" no campo "Tipo de Cadastro"

![image](https://user-images.githubusercontent.com/72507215/143768856-6fe2d7b6-02f9-4377-a2bc-828e18ee22ee.png)

* Cadastro Usuário - Cadastre-se e volte para a tela de login para entrar no sistema

![image](https://user-images.githubusercontent.com/72507215/143769105-e0406199-c234-46c3-b641-ea71bd201bbb.png)

* Home - Tela com a funcionalidade de geolocalização, onde o usuário pode visualizar no mapa e coletar as ofertas próximas a ele

![image](https://user-images.githubusercontent.com/72507215/143769365-e3027853-cc1e-4160-baa9-24198bddeece.png)

* Carteira e QR code - A partir da tela **Home**, é possível acessar a tela de **Carteira** que permite visualizar as ofertas coletadas ativas e o histórico de ofertas, além de permitir ao usuário gerar um *QR code* para utilização da mesma clicando em "GerarQrCode"

![image](https://user-images.githubusercontent.com/72507215/143769503-90727aeb-8cc3-4143-981a-0b842c465156.png)

![image](https://user-images.githubusercontent.com/72507215/143769512-16a82235-aaa0-4ea7-8d0d-383d357dab3a.png)

* Carbono - A partir da tela **Home**, é possível acessar a tela de **Carbono** que permite visualizar a quantidade de gás carbônico que o cliente contribuiu na redução

![image](https://user-images.githubusercontent.com/72507215/143769596-226641fd-e863-423d-9468-f017a931d696.png)

* Perfil - A partir da tela **Home**, é possível acessar a tela de **Perfil** que permite ao usuário visualizar e editar seu perfil (em construção 🔨)

![image](https://user-images.githubusercontent.com/72507215/143769639-208ade2d-63db-4473-90f4-b436ab82a82a.png)

* Blog - A partir da tela **Home**, é possível acessar a tela de **Blog** que traz conteúdos relevantes sobre o tema da sustentabilidade

![image](https://user-images.githubusercontent.com/72507215/143769735-b8fb897a-ed83-419c-814c-08627f5c82d7.png)

*Funcionalidades Parceiro*

* Cadastro - Selecione "Parceiro" no campo "Tipo de Cadastro"

![image](https://user-images.githubusercontent.com/72507215/143768856-6fe2d7b6-02f9-4377-a2bc-828e18ee22ee.png)

* Cadastro Parceiro - Cadastre-se e volte para a tela de login para entrar no sistema

![image](https://user-images.githubusercontent.com/72507215/143769078-c34635a8-be79-485d-9ff4-d80612fc9da8.png)

* Home 

![image](https://user-images.githubusercontent.com/72507215/143770151-59c6fffc-edfd-4dd7-b2ba-cc53eb9e5aba.png)


* Cadastro de Ofertas - A partir da tela **Home**, é possível acessar a tela de **Cadastro de Ofertas** selecionando "Cadastro Ofertas" que permite ao parceiro cadastrar suas ofertas (em construção 🔨)

![image](https://user-images.githubusercontent.com/72507215/143769639-208ade2d-63db-4473-90f4-b436ab82a82a.png)

* Editar Ofertas - A partir da tela **Home**, é possível acessar a tela de **Editar Ofertas** que permite ao parceiro editar suas ofertas (em construção 🔨)

![image](https://user-images.githubusercontent.com/72507215/143769639-208ade2d-63db-4473-90f4-b436ab82a82a.png)

* Relatórios - A partir da tela **Home**, é possível acessar a tela de **Relatórios** que disponibiliza informações relevantes sobre as campanhas do parceiro (em construção 🔨)

![image](https://user-images.githubusercontent.com/72507215/143769639-208ade2d-63db-4473-90f4-b436ab82a82a.png)

### Outras funcionalidades 📝

Para poder visualizar e testar todos os CRUDs do sistema que ainda não estão integrados com o *front end* nesta versão 1.0 (MVP), implementamos uma interface para a API via Swagger, de tal forma que todas as funcionalidades previstas para as próximas versões possam ser exploradas.

![image](https://user-images.githubusercontent.com/72507215/143770530-d1811465-6c07-413d-a5f1-0313e9c9295c.png)

![image](https://user-images.githubusercontent.com/72507215/143770536-00828ed4-c554-4f9b-b173-0814f3072ba3.png)


