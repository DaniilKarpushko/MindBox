# MindBox
<h1>SQL solution</h1>
CREATE TABLE products( id INT PRIMARY KEY IDENTITY, prod_name VARCHAR(255) NOT NULL);<br>
CREATE TABLE categories( id INT PRIMARY KEY IDENTITY, cat_name VARCHAR(255) NOT NULL);<br>
CREATE TABLE product_category( prod_id INT NOT NULL, cat_id INT NOT NULL,<br>
FOREIGN KEY(products_id) REFERENCES Products(id), <br>
FOREIGN KEY(category_id) REFERENCES Category(id));<br>
<br>
<br>
SELECT products.prod_name, categories.cat_name FROM<br>
products LEFT JOIN product_category AS pc ON products.id = pc.prod_id<br>
INNER JOIN category ON category.id = pc.cat_id;
