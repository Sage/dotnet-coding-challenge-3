# .NET Coding Challenge
This coding challenge is for a .NET developer. We are making the assumption that you are familiar with .NET Core, MVC and REST.
Your task is to build an API that manages users using the scaffolded controller which has already been provided.
There is no strict time limit and you won't be judged on how long it took you to complete, however we would like you to spend no more than 2 hours on this.

1. You must use .NET Core and C#
2. The API should be a ASP.NET Core Web API project
3. The API should consume and return data as JSON
4. You do not need to consider any security implications. This includes using HTTPS or attempting to provide any Authorization/Authentication
6. You do not need any persistent storage. Please use the in-memory cache which has been provided
7. You can use any NuGet package but be prepared to justify its usage

## Specification
We want you to develop an API that exposes one RESTful endpoint. This endpoint should provide standard CRUD functionality for **Users**.

### Users
#### URL Formats
**POST**
```
/api/users
```
**GET**
```
/api/users
/api/users/{id}
```
**DELETE**
```
/api/users/{id}
```
**PUT**
```
/api/users/{id}
```
#### Fields
| Field Name  | Data Type  | Required | Validation                               |
|--           |--          |--        |--                                        |
| FirstName   | `string`   | true     | max length 128                           |
| LastName    | `string`   | false    | max length 128                           |
| Email       | `string`   | true     | must validate to a typical email address |
| DateOfBirth | `DateTime` | true     | must validate to a valid date            |

 - Every user must have a unique email address
 - The user when created must be 18 years or older at the time of the request
 - When returning one user or a list of users return back the age of the user in addition to the date of birth

## How we will assess your work
We are looking production quality code which utilises design patterns where appropriate and conforms to best practices and principles such as SOLID, etc. Other things we will take into consideration:

 - Code should be testable
 - We expect you to be mindful of correct HTTP status code usage