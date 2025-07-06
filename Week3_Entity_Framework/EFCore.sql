CREATE DATABASE EFCOREDB;

USE EFCOREDB;

CREATE TABLE Categories(
	Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100)
);

CREATE TABLE Products (
	Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Price DOUBLE,
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

INSERT INTO Categories(Name) VALUES("Electronics"), ("Clothes");

INSERT INTO Products(Name, Price, CategoryId) VALUES ("Laptop", 90000, 1),
	("Saree", 2900, 2),
    ("Mobile Phone", 25000, 1),
    ("Jeans", 1500, 2),
    ("Earphones", 880, 1),
    ("Crop Top", 350, 2);

SHOW TABLES;
SELECT * FROM Products;
SELECT * FROM Categories;

