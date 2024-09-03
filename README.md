# MindBox
<h1>SQL solution</h1>
<p>CREATE TABLE products( id INT PRIMARY KEY IDENTITY, prod_name VARCHAR(255) NOT NULL);<br>
<p>CREATE TABLE categories( id INT PRIMARY KEY IDENTITY, cat_name VARCHAR(255) NOT NULL);<br>
<p>CREATE TABLE product_category( prod_id INT NOT NULL, cat_id INT NOT NULL,<br>
<p>FOREIGN KEY(products_id) REFERENCES Products(id), <br>
<p>FOREIGN KEY(category_id) REFERENCES Category(id));</p>
<br>
<br>
<p>SELECT products.prod_name, categories.cat_name FROM<br>
<p>products LEFT JOIN product_category AS pc ON products.id = pc.prod_id<br>
<p>INNER JOIN category ON category.id = pc.cat_id;</p>
