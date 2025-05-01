# Invoice web app with CRUDs

This project was one of my fullstack workshop assignment. I've used ASP.Net Core framework.

## MVC
  - classic webdevelopment
  - works with server-side generated HTML files
  - the server send the generated HTML code to the client (which is the browser   in this case), and the browser displays it


## Assignment Description

### Folder stucture
In a root folder there are 4 layers: Data, Models, Views, Controllers.

### Layers
In the 'Models' layer I've created the entity with properties:
  - Id (integer)
  - PayerName (string)
  - Amount (integer)
  - IsPaid (bool)

In the 'Data' layer I've created the repository that handles basic CRUD operations in memory.

In the 'Controllers' layer I've made the InvoiceController, that contains methods, such as:
  - Index: listing all the invoices
  - Create: adding new invoice
  - Edit: updating invoice
  - Delete: removing invoice
  - MarkAsPaid: changing the IsPaid status to true (== paid)

View layer:
  - handles Bootstrap framework
  - Index.cshtml:
      - list invoice in table form (with all the properties)
      - IsPaid field: tick or cross (✔, ✖)
      - buttons for edit, delete, markaspaid functions
  - Create.cshtml:
      - a form for adding a new invoice
  - Update.cshtml:
      - a form for updating data of invoice

Validation with vanilla Javascript:
  - validation happens when creating a new invoice
  - if payername is longer than 50 characters and the amount is smaller than 0, then the button is disabled (it cannot be clicked)
