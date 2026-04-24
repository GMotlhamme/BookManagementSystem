Problem: Library Book Management System
A small community library requires a simple web application to store and manage books.
The system must allow the librarian to:
•	Add a new book 
•	View all books 
•	Edit book details 
•	Delete a book 
The application must use a database to store records permanently.

Create the Book model must contain the following fields:
•	Id 
•	Title 
•	Author 
•	Category 
•	CopiesAvailable 

Unit Testing for Library System
As part of the system, you are required to implement basic unit tests to verify that the Book model behaves correctly.
The purpose of this task is to ensure that the core logic of your application is functioning correctly before integrating other components.

You must implement the following method inside the Book model:
public bool IsAvailable()
This method must:
•	Return true if CopiesAvailable > 0 
•	Return false if CopiesAvailable == 0 

Unit Test Requirements
You must create unit tests using xUnit to verify the following:
1. Assert True
Test that a book is available when:
•	CopiesAvailable = 5 
Expected result: true

2. Assert False
Test that a book is NOT available when:
•	CopiesAvailable = 0 
Expected result: false

3. Assert Equal
Test that the Book properties are correctly assigned:
Use the following values:
•	Title = "Database Systems" 
•	Author = "John Smith" 
•	Category = "IT" 
Verify that the values stored in the object match the expected values.

