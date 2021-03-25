SELECT product_name 
FROM products
JOIN categories ON
products.product_id = categories.goods_id
