
Ecommerce API Project
This project is an Ecommerce API built using .NET 6 and C# with a focus on Domain Driven Design (DDD) principles. It provides endpoints for managing products, categories, and product attributes. Entity Framework Core is used for database operations, and asynchronous functions are employed for improved performance.
Table of Contents
•	Models
•	Controllers
•	Services
•	Asynchronous Functions
•	Migrations
Models
1.	Product Model:
•	Id: Unique identifier for the product.
•	Name: Name of the product.
•	Description: Description of the product.
•	CategoryId: Identifier for the associated category.
•	Attributes: List of attributes associated with the product.
2.	Category Model:
•	Id: Unique identifier for the category.
•	Name: Name of the category.
•	ParentId: Identifier for the parent category (optional).
•	Products: List of products associated with the category.
3.	Attribute Model:
•	Id: Unique identifier for the attribute.
•	Name: Name of the attribute.
•	Values: List of values associated with the attribute.
Controllers

1.	CategoriesController:
•	CRUD operations for categories.
•	Hierarchical structure.
•	Asynchronous functions.
2.	ProductsController:
•	CRUD operations for products.
•	Hierarchical structure.
•	Relationships with categories and attributes.
•	Asynchronous functions.
Services
1.	CategoriesService:
•	Business logic for category operations.
2.	ProductsService:
•	Business logic for product operations.
Asynchronous Functions
•	Utilize async and await for database operations.
•	Use asynchronous versions of Entity Framework Core methods.
Migrations
•	Create clear and concise migrations for managing the database schema.
•	Use Entity Framework Core migrations to keep the database schema in sync with the model.
