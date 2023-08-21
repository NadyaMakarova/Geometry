CREATE TABLE category
(
    id SERIAL PRIMARY KEY,
    name VARCHAR
);

CREATE TABLE product
(
    id SERIAL PRIMARY KEY,
    name VARCHAR
);

CREATE TABLE category_product
(
    id SERIAL PRIMARY KEY,
    category_id INTEGER NOT NULL REFERENCES category,
    product_id INTEGER NOT NULL REFERENCES product,
    UNIQUE (category_id, product_id)
);
INSERT INTO product (id, name)
VALUES (1, 'Салат'),
       (2, 'Мороженое'),
       (3, 'Хлебцы'),
       (4, 'Масло');

INSERT INTO category (id, name)
VALUES (1, 'Овощи'),
       (2, 'Диетическое'),
       (3, 'Сладость'),
       (4, 'Замороженное');

INSERT INTO category_product (category_id, product_id)
VALUES (1, 1),
       (1, 2),
       (2, 3),
       (2, 4),
       (3, 2),
       (3, 3);
SELECT p.name AS name, c.name AS name
FROM product p
LEFT JOIN category_product cp ON cp.category_id = p.id
LEFT JOIN category c ON c.id = cp.product_id;