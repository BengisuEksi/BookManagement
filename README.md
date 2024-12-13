# Book Management System

This project is a book management system developed using C# and SQL. It focuses on showcasing the usage of SQL Triggers and is centered around book addition/deletion scenarios.

## What is an SQL Trigger?
A trigger is a stored procedure in a database that automatically executes whenever a specified event occurs in the database. For example, a trigger can be invoked when a row is inserted into a specified table or when specific columns in a table are updated. Triggers belong to a special class of stored procedures that are automatically invoked in response to database server events. Each trigger is associated with a specific table.

Key Features of SQL Triggers:
Automatic Execution: Triggers fire automatically when the defined event occurs (e.g., INSERT, UPDATE, DELETE).
Event-Driven: Triggers are tied to specific events occurring in the database.
Table Association: A trigger is linked to a specific table or view and operates whenever changes are made to the table’s data.

Syntax:

CREATE TRIGGER (trigger_name)

[BEFORE | AFTER]  
{INSERT | UPDATE | DELETE}

ON (table_name) 
(FOR EACH ROW)

trigger_body

For more information, [visit here](https://www.geeksforgeeks.org/sql-trigger-student-database/).

## The Project
This application aims to demonstrate the practical usage of SQL Triggers while implementing the core functionalities of a book management system.
### Application

1. C# Forms

Main Form:

- Functions:
  * Add a book
  * Update a book
  * Delete a book

- DataGridView: Displays the list of books in the library.
- Count Label: Shows the total number of books in the library.
- Recycle Bin Button: Opens a secondary form to view deleted books.

Recycle Bin Form:
- DataGridView: Lists deleted books.
- Save the Selected Book Button: Restores a selected book to the main books table.
- Return to Main Page Button: Returns to the main form.

2. SQL Tables

Books Table:
* Columns:
   * ID
   * Name
   * Author
   * Page
   * Publisher
   * Genre

Counter Table:
* Columns:
  * Quantity: Represents the total number of books in the system.

Books Back-Up Table:
* Columns: Identical to the columns in the Books table.

3. SQL Triggers
* Book Addition: When a new book is added, the count is incremented.
* Book Deletion: When a book is deleted, the count is decremented. The deleted book is moved to the "Deleted Books" table.
* Book Restoration: When a book is restored, it is moved back to the Books table, removed from the deleted books section, and the count is updated.

4. Usage
* Adding a Book: Enter book details (name, author, page count, publisher, genre).
Click the "Add" button.
* Deleting a Book: Select the book to delete from the list.
Click the "Delete" button.
* Viewing Deleted Books: Click the "Recycle Bin" button to open the deleted books form.
* Restoring a Book: In the deleted books form, double-click on the book to restore.
Click the "Restore Book" button to move the book back to the main books table.
*Returning to Main Form: Click the "Return to Main Page" button.

5. Requirements
- Development Environment: Visual Studio 2022
- Database: SQL Server
- Programming Language: C#
- Framework: .NET Framework
  
![1](https://github.com/user-attachments/assets/7b60decc-8dd8-4e18-886a-8786fa12535b)

![2](https://github.com/user-attachments/assets/e54e479b-bb28-444d-bb6e-3afd175b5eb2)

![3](https://github.com/user-attachments/assets/890deda3-49a1-48af-a83a-67d2139512d5)

![4](https://github.com/user-attachments/assets/9bde831f-ecc9-48b0-8758-e57f0b7fc04a)

![5](https://github.com/user-attachments/assets/88ca9e56-fd63-472b-8626-16752837a6ff)

![6](https://github.com/user-attachments/assets/40fc933b-a5a9-4169-ab26-49b481f369e7)

![7](https://github.com/user-attachments/assets/01864da7-3b9c-4ad5-8ac8-8d61bcbd513a)

![8](https://github.com/user-attachments/assets/36197bee-b2df-45a9-bd3f-44cf3c46ae35)

![9](https://github.com/user-attachments/assets/c4487919-5913-4cbf-ac33-e24e88686abc)
