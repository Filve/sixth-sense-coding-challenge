# .NET Core Coding Challenge

Implement a REST API to manage products and orders.
Entities are defined as:
Products: id, name, description, unit price, stock quantity
Orders: id, date, company code, list of ordered products (each one with id, unit price, ordered quantity)
Endpoints

# PRODUCTS
An endpoint that returns the list of all the products; results must be paged
An endpoint that returns a single product
An endpoint for creating a new product, with the following requirements:
There cannot exist two products with the same name and description
Unit price cannot exceed 1000 €
If the creation is successful must return the created product

# ORDERS
An endpoint that returns all the orders and the total amount of each; results must be paged
An endpoint for the creation of a new order, with the following requirements:
At least one product must be specified
A company must not have placed an order on the same day
The number of ordered products must be present in stock
Total must be at least 100 €
If the creation is successful must return the created order and its total amount
When an order is placed, the quantity ordered from stock must be simultaneously subtracted
The rule for calculating the total amount of each individual order varies according to the company code; to date, there are two companies in the 
system with the following logics:
COMPANY_1: the sum of (quantity * unit price) of the various products + fixed management cost of 0.02% of the total;
COMPANY_2: the sum of (quantity * unit price) of the various products + fixed administrative cost of 1 €
Consider in general that new companies with different algorithms for calculating the total amount of an order may be added in the future.

# Technical requirements
The solution must be implemented using .NET Core 3+
All the components must be unit-testable and well documented
Use dependency injection for injecting the components
The business logic must be easily identifiable and separated from any infrastructural code

# Optional requirements
Products and orders databases are considered distinct databases. Consequently, the update of a product stock when an order is placed 
must be a different transaction
Use repository and unit of work patterns
Protect APIs with JWT authorizatio
