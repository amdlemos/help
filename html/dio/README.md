# HTML

## História
Criado por Tim Berners-Lee em 1991 para melhorar a comunicação entre ele e seus colegas de trabalho, desde então já surgiram 5 versões e o HTML se tornou a base da web.

## Semântica
A semântica nos permite descrever mais precisamente o no sso conteúdo, agora um bloco de texto não é apenas uma div, agora é um article e tem mais significado assim. E temos vários elementos para ressignificar as divs: section, header, article, aside, footer, h1-h6.

## Principais elementos HTML
- Textos e links: h1-h6, p e a
- Imagens: img
- Listas, ul, ol e li

## Estrutura Básica
```html
<!DOCTYPE html> 
<html>
	<head>
		<Meta>
		<title></title>
	</head>
	<body>
	</body>
</html>
```

## Sites
- tinypng.com

# CSS
Após a criação do HTML a necessidade de formatar as páginas ficou evidente, assim, em 1996, foi criada a linguagem de estilo que conhecemos por CSS.

Uma regra CSS é representada por um seletor ou um grupo de seletores, então dentro de um par de chaves adicionamos as declarações. As declarações são formadas por uma propriedade e um valor.

Podemos colocar vários seletores em uma regra separando-os por vírgula.

E há um último detalhe nesse exemplo: a pseudo-classe. Elementos HTML sofrem alterações causadas pela interação do usuário, como mover o mouse por cima ou clicar nesse elemento. Ex: hover.



## Seletores
São apenas elementos HTML

## Declarações
As declarações ficam entre chaves e é formada por uma propriedade e um valor.

## Classes
A classe é representada de forma parecida do ID, mas é precedida por um ponto em vez do hash.
<div class="my-class"></div>
```css
.my-class {
	propriedade: valor
}
```

## ID 
É representado pelo símbolo # (hash) seguido de um nome para esse ID.
<div id="my-id"></div>
```css
#my-id {
	propriedade: valor
}
```
E a diferença mais importante entre eles é a forma como devem ser usados: o ID só pode ser usado uma vez em uma página HTML enquanto a classe não tem restrições.

## Box model
O navegador representa cada elemento HTML  como uma caixa retangular, isso é o box-model. Essa caixa é composta por 4 áreas: o conteúdo, o padding, a borda e a margem e com CSS nós alteramos a aparência dessa caixa
- margin: espaçamento entre elementos
- border: cirdundam o padding e conteudo
- padding: espaçamento entre a borda e conteúdo
- content: representação do seu bloco

## Padding e Margin
```css
.padding {
	/* top, right, bottom, left */
	padding: 10px, 15px, 5px, 0;	
}

.background {
	background-color: green;
	background-image: url("");
	background: #008000;
}

.border {
	border: 3px solid blue;
	border-top: 2px dotted green;
	border-right: 4px dashed pink;
	border-width: 3px;
	border-color: #505050;
	border-style: solid;
	border-top-width: 3px;
	border-top-color: blue;
	border-top-style: solid;
}

.border-radius {
	border-radius: 10px;
	border-radius: 50%;
	border-radius: 10% 20%;
	border-radius: 10px 20px 15px 22px;
}

```

## font-family

```css
font-family: Arial, Verdana;
font-style: normal;
font-style: italic;
font-size: 16px;
font-weight: normal;
font-weight: bold;
text-transform: uppercase, lowercase, capitalize;
text-decoration: underilne, overline, line-through;
} 
```

## list-style-type
```css
ul {
	list-style-type: square;
}

ol { 
	list-style-type: upper-roman;
}

ul {
	list-style-type: "\1f44D";
}

ul {
	list-style-type: url("image.png");
}
```

## Dimensão e alinhamento
- Width: largura
- Height: altura
- Max-width: largura máxima
- Max-height: altura máxima
- Margin
- Text align: alinhar textos, left, right, center and justify.
