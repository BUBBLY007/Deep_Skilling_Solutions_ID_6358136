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

INSERT INTO Products(Name, Price) VALUES ("Laptop", 90000),
	("Saree", 2900),
    ("Mobile Phone", 25000),
    ("Jeans", 1500),
    ("Earphones", 880),
    ("Crop Top", 350);

SHOW TABLES;
SELECT * FROM Products;
SELECT * FROM Categories;
