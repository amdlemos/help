# Vue Mastery 
### Creating the Vue App
```javascript
// mains.js
const app = Vue.createApp({
	data() {
		return {
			cart: 0,
			product: 'Socks',
			brand: 'Vue Mastery'
			image:'./path',
			inStock: true,
			invertory: 100, 
			details: ['40% cotton', '30% wool', '20% polyester'],
			variants: [
				{ id: 2234, color: 'green', image: 'path', quantity: 50 },
				{ id: 2235, color: 'blue', image: 'path', quantity: 0}]
			]
		}
	},
	methods: {
		addToCart() {
			this.cart += 1;
		},
		updateImage(variantImage) {
			this.image = variantImage;
		}
	},
	computed: {
		title() {
			return this.brand + '' + this.product
		},
		image() {
			return this.variants[this.selectdVariant].image
		},
		inStock() {
			return this.variants[this.selectdVariant].quantity
		}
	}

})
```

```<!DOCTYPE html>
// index.html
<html>
<head>
	<meta charset="utf-8">
	<title></title>
</head>
<body>
	<div id="app">

	</div>

	<!-- Import App -->
	<script src="./main.js"></script>

	<!-- Mount App -->
	<script>
		//  
		const mountedApp = app.mount('#app')
	</script>
</body>
</html>

```
### Attribute Binding
```html
<img v-bind:src="image">
// or
<img :src="image"
```
### Conditional Rendering
```html
<div class="product-info">
	<h1> {{product }} </h1>
	<p v-if="inStock"> In Stock</p>
	<p v-else>Out of Stock</p>

	<p v-show="inStock">InStock</p>

	// or

	<p v-if="invertory > 10"> In Stock</p>
	<p v-else-if="inventory <=10 && inventory > 0">Almost sold out!</p>
	<p v-else> Out of Stock</p>
</div>
```
### List Rendering
```html
<ul>
	<li v-for="detail in details">{{ detail }}</li>
</ul>

<div 
	v-for="variant in variants" 
	:key="variant.id" 
	@mouseover="updateImage(variant.image)"
	class="color-circles"
	:style="{ backgroundColor: variant.color }">	
</div>
```
### Event Handling
```html
<button class="button" v-on:click="cart += 1"> Text</button>

<button 
	class="button" 
	:class="{ disabledButton: !inStock }"
	:class="[isActive ? activeClass : '']"
	:disabled="!inStock"
	@click="addToCart"> 
	Add to Cart
</button>


```
### Class & Style Binding
```css
.color-circle {
	width: 50px;
	height: 50px;
	margin-top: 8px;
	border: 2px solid #d8d8d8;
	border-radius: 50%;
}

.disabledButton {
	background-color: #d8d8d8;
	cursor: not-allowed;
}
```
### Computed Properties



### Components & Props

### Communicating Events

### Forms & v-model
