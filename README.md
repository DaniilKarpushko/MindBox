# MindBox

<h2>SQL solution</h2>
CREATE TABLE products( id INT PRIMARY KEY IDENTITY, prod_name VARCHAR(255) NOT NULL);<br>
CREATE TABLE categories( id INT PRIMARY KEY IDENTITY, cat_name VARCHAR(255) NOT NULL);<br>
CREATE TABLE product_category( prod_id INT NOT NULL, cat_id INT NOT NULL,<br>
FOREIGN KEY(products_id) REFERENCES Products(id), <br>
FOREIGN KEY(category_id) REFERENCES Category(id));<br>

SELECT products.prod_name, categories.cat_name FROM<br>
products LEFT JOIN product_category AS pc ON products.id = pc.prod_id<br>
INNER JOIN category ON category.id = pc.cat_id;

<h2>Other</h2>
Был ли у вас опыт веб-разработки? - Коммерческого опыта нет, но есть пару пет проектов, которые лежат на этом гит аккаунте.<br>
<a href="https://github.com/DaniilKarpushko/TgBot-Algorithm">ТГ бот</a><br>
<a href="https://github.com/DaniilKarpushko/EarthMagnitudePhysics">Поиск магнитной индукции в заданной точке</a><br>
Готовы ли выйти на фуллтайм (удаленно/офис/гибрид) в случае успешного завершения стажировки через 3-4 месяца? - Готов.


