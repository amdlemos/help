# Introdução ao .NET

- Passado, presente e futuro do .NET
- O que é, como e onde usar .NET
- Quem usa .NET?

Microsoft iniicou nos anos 70 criando linguagens de programação, ex: Basic. Nos anos 80 surge o DOS, que foi utilizado como OS padrão para computadores IBM.
No fim dos anos 90, a Microsoft tentou consolidar as ferramentas de desenvolvimento (IDEs e runtimes) com o Visual Studio 97
- Visual BAsic 5
- Visual FoxPro 5
- C++ 5
- J++
Em 1998:
- VB 6
- Visual FoxPro 6
- C++ 6
- J++ 6

### História
Em 1999 Scott Guthrie criou uma ferramenta web com Java e a chamou de ASP+ (depois chamou ASP Next e depois ASPX). Jason Zander ajudou na criação de um common runtime para VB e C+++ (CLR).
Java ia bem, então a Sun Microsystems fez um acordo para a Microsoft não mexe mais com Java, assim, Anders Hejlsberg começou a trabalhar no C#.
Em 2000 a Microsoft lança o novo ambiente de desenvolvimento .NET 1.0 - inicialmente chamado de NEXT GENERATION WINDOWS SERVICES (NGWS).
Em 2001 Miguel de Icaza começa a trabalhar no projeto Mono, uma reimplementação blackbox do .NET, open source e multiplataforma. 
Em 2002 lançamento do VS .NET com C# 1.0.
Em 2003 lançamento do .NET 1.1 com o Visual Studio 2003. Trabalharam em melhorias na CLR para lançar a CLR 2. 
Em 2005 é lançado o .NET 2.0 com C# 2.0 no VS 2005. Microsoft começa a atingir seu objetivo inicial, inclusive evoluindo na web. 
2007/2008 lançamento do .NET 3.5 com C# 3.0 no VS 2008, com Silverlight, WPF e WCF. 
Microsoft contrata um time de pessoas que tinham uma pegada open source e começam a atuar na criação do ASP.NET MVC, começa a se falar em Windows Azure.
Em 2010 ocorre o lançamento do .NET 4.0 no VS 2010 e também com F#.
Microsoft lança Windows Azure e Anders Hejlsbert começa a trabalhar no TypeScript. 
Em 2011 Miguel de Icaza inicia Xamarin, basicamente ele desenvolvia em C# aplicativos que rodam em Android e iOS. 
Em 2012 lançamento do .NET 4.5 com C# 5.0 no VS 2012 e lançamento do TypeScript.
Em 2013 .NET 4.5.1 no VS 2013. Inicio do Roslyn com novo compilador para C# e VB.NET. Microsoft continua atuando mais na frente JS e aumenta também a incorporação de ferramentas open source ao ambiente. 
Ja temos aqui o ASP.NET mais consolidado com MVC, Web API e SignalR.
Em 2014 Satya Nadella se torna CEO da Microsoft e direciona o foco da empresa para Cloud e neste mesmo ano é criado a .NET Foundation. Windows Azure passa a se chamar Microsoft Azure e é introduzido o coneito de ASP.NET vNext, posteriormente chamado de ASP.NET Core.
2015 lançamento do .NET 4.6 com C# 6.0 no VS 2015 e lançamento do VS Code, open source e multiplataforma. 
Em 2016 Microsoft adquire a Xamarin e adiciona o produto como parte de sua stack .NET e projetos open source. Lançamento do Visual Studio for Mac. Também é lançado o .NET Core 1.0, totalmente novo, open source e multiplataforma. 
Em 2017 ocorre o lançamento do .NET Framework 4.7 com C# 7.0 no VS 2017. Lançamento do .NET Core 2.0 com C# 7 no VS 2017, VS Code ou VS for Mac 2017.
Em 2019 lançamento do .NET Framework 4.8 com C# 7.3 no VS 2019. Lançamento do .NET Core 3.0 com C# 8.0 no VS 2019, VS Code e VS for Mac. 

### O que é, como e onde usar .NET
- É uma estrutura para desenvolvimento de software criada pela Microsoft. 
- .NET Standard Library
- Cada implementação inclui um ou mais .NET Runtimes
    - .NET Core: CoreCLR e CoreRT
    - .NET Framework: CLR
    - UWP: .NET Native
    - Mono: Mono Runtime
- Linguagens:  
    - C#
    - F#
    - VB
- Onde
    - Desktop: WPF, Windows Forms, UWP
    - Web: ASP.NET
    - Cloud: Azure
    - Mobile: Xamarin
    - Gaming: Unity
    - IoT: ARM32, ARM64
    - AI: ML.NET
    - .NET for Apache Spark
- Quem
    - Saraiva
    - Casas Bahia
    - Unimed
    - BR
    - ...etc
    - Itau
    - Azul
    - linx
    - stackoverflow

### Preparando o ambiente
- Instalar .NET SDK
- Instalar VS Code

### Conhecendo a CLI do .NET

```shell
dotnet --help
dotnet new --help
```

### Criando uma aplicação console

- new
    ```bash
    dotnet new console
    dotnet new console -h
    dotnet new console -n projectName
    ```
- restore: restaura os pacotes, atualiza/instala.
    ```bash
    dotnet restore
    ```
- build: restaura as pacotes e faz o build
    ```bash
    dotnet build
    dotnet build -p path/path2
    ```


Pasta bin são os binários da aplicação.

## Conhecendo o C#
- O que é C#
- Como funciona
- Estrutura de programa

### O que é o C#?
C# é uma linguagem elegante, orientada a objeto e fortemente tipada. A Sintaxe do C# é similar a do C, C++ e Java. Suporta os conceitos de encapsulamento, herança e polimorfismo (OO)
Os programas C# são executados no .NET, que inclui: 
- CLR
- Conjunto unificado de bibliotecas de classes. 
Atualmente o compilador do C# é o Roslyn.

### Como funciona?
O código-fonte escrito em C# é compilado em uma linguagem intermediária (IL). O Código e os recursos de IL são armazenados no disco em um arquivo executável chamado assembly, geralmente com um extensão .exe ou .dll.
Quando o programa C# é executado, o assembly é carregado no CLR. Em seguida o CLR executará a compilação just in time (JIT) para converter o código IL em instruções de máquina nativas. 
O CLR também fornece outros serviços
- Garbage Collector
- Exception Hanlder
- Resources Manager

Além do sserviços de tempo de execulão, o .NET também inclui uma extensa biblioteca com milhares de classes que fornecem uma ampla variedade de funcionalidades úteis, desde entrada e saída de arquivos, manipulação de cadeias de caracteres, análise XML, etc.

### Estrutura de Programa
Os principais conceitos organizacionais em C# são
- programas
    - programças c# consistem em um ou mais arquivos
    - os programas declaram tipos, que contêm membros e podem ser organizados em namespaces
- namespaces
- tipos
    - classes e interfaces são exemplos de tipos
- membros
    - Campos, métodos, propriedades e eventos são exemplos de membros.
- assemblies
    - quando os programas c# são compilados, eles são fisicamente empacotados em assemblies. 
    - os assemblies gralmente têm a extensão de arquivo .exe ou .dll, dependendo se são aplicações ou bibliotecas.

### Tipos de Valores
- Tipos de Valor
	- Váriaveis de tipos de valor contêm diretamente seus dados. As variáveis têm sua própria cópia dos dados e não é possível que as operações afetem outra variável, exceto nos casos das variáveis de parâmetro ref e out.
	- sbyte, short, int, long, byte, ushort, uint, ulong
	- char
	- float, double, decimal
	- bool
	- enum, struct e tipos nullable
- Tipos de referência
	- Variáveis de tipos de referência armzenam referências a seus dados. É possível que duas variáveis façam referência ao mesmo objeto e, portanto, que operações em uma variável afetem o objeto referenciado pela outra variável.
	- class, object, string
	- int[], etc
	- interface, delegate 
- Instruções
	- ações de um programa são expressas usando instruções
	- declaração de variáveis e contantes
	- if
	- switch
	- while
	- do
	- for
	- foreach
	- break
	- continue
	- return
	- throw
	- try.. catch.. finaly
	- using
- Arrays
Um array é uma estrutura de dados que contém um número x de elementos, todos do mesmo tipo, que são cessados através de índices computados. São tipos de referência e a declaração de uma variável array simplesmente reserva espaço para uma referência de uma instância de array.
Ao criar um array é especificado o tamanho da nova instância, que é fixo durante todo o tempo de vida da instância. Os índices dos elementos de um array variam de 0 a x-1.
	```csharp
	// Array unidimensional
	int[] a = new int[10];
	// Array multidimensional
	int[,] a2 = new int[10, 5];
	```
	- inicializador de array
	int [] a = new int [] {1, 2, 3};
	int [] a = {1, 2, 3};
- Classes
	Classes são os tipos mais fundamentais do C#, uma classe é uma estrutura de dados que combina estado (campos) e ações (métodos).as classes suportam herança e polimorfismo, mecanismos pelos quais as classes derivadas podem estender e especializar as classes baseas classes suportam herança e polimorfismo, mecanismos pelos quais as classes derivadas podem estender e especializar as classes base
- Objetos	
	Objetos são instâncias de uma classe.
- Membros
	Os membros de uma classe podem ser estáticos ou membros da instância. Membros estáticos pertencem a classe e membros de intância pertencem ao objeto. (Constantes, variáveis, métodos, propriedades, construtores, etc)
	Cada membro de uma classe tem uma acessibilidade associada que controla as regiões do texto do programa que podem acessar o membro, public, protected, internal, private. 
- Herança
	Uma declaração de classe pode especificar uma clase base, herdando os membros public, internal e protected da classe base.- Métodos
	Um método é um membro que implementa uma computação ou ação que pode ser executada por um objeto ou classe. 
- Structs
	Como as classes, as structs são estruturas de dados que podem conter membros de dados e membros de ação, mas, difirente das classes, as structs são tipos de valor e não requerem alocação de heap. Uma variável de um tipo de struct armazena diretamente os dados da estrutura, enquanto uma variável de um tipo de classe armazena uma referência a um objeto alocado na memória. 
	Structs não aceitam herança, são úteis para pequenas estruturas de dados que possuem semântica de valor: números complexos, pontos em um sistema de coordenadas ou pares de chave-valor em um dicionário são bons exemplos de utilização. O uso de structs em vez de classes para pequenas estruturas de dados pode fazer uma grande diferença no número de alocaçãoes de memória. Construtores de structs são chamados com o operador new, semelhanta a um construtor de classe, mas em vez de alocar dinamicamente um objeto no heap gerenciado e retornar uma referência a ele, um construtor struct simplesmente retorna o próprio valor struct (normalmente em um local temporário na stack), e esse valor é copiado conforme necessário. 	
- Interfaces
	Uma interface define um contrato que pode ser implementado por classes e structs. Uma interface poe conter métodos, propriedades, eventos e indexadores. Uma interface não fornece implementações dos membros que define - apenas suas "assinaturas". As interfaces podem empregar herança múltipla. 
- Enums
	Um enum é um tipo de valor distinto com um conjunto de constantes nomeados. Você define enumerações quando precisa definir um tipo que pode ter um conjunto de valores discretos. Eles usam um dos tipos de valor integral como armazenamento subjacente. Eles fornecem significado semântico aos valores discretos. 
	Cada tipo de enum possui um tipo integral correspondente chamado tipo subjacente do tipo de enum, um tipo de enumeração que não declara explicitamente um tipo subjacente tem um tipo subjacente int. 

