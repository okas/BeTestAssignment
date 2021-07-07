# BE test assignment

## Assignment

This repository contains some existing solution with REST API back end and React front end.
Back end has some resources of users and companies that are seeded to database.

Your task is to create a RESTful sub-resource to companies for contracts with create, read and update operations.
It should not be independent resource.

A contract is a link between users and companies.
One company can have many contracts with different users and vise versa.

Contract needs to have additionally user occupation in this company, contract start date and optional end date.

### Before starting the assignment

Send me your estimate, how long does it take for you and when it might be finished.
If you have any questions before or during the assignment don't hesitate to ask.

### After completing the assignment

Send me your code or link to repository. Also give some feedback about the assignment, how hard it was for you and what
you would do differently.

## Setting up the project

Install [.Net Core 3.1](https://dotnet.microsoft.com/download) and/or your favourite IDE.

Clone the repository to your computer and run the following in repository directory:

    cd BeTestAssignment
    dotnet build
    dotnet ef database update

When project is running, API description in available in swagger https://localhost:5001/swagger/ .

To get authentication token, access https://localhost:5001/fetch-data , create account for youself or use one of seeded user accounts, and snatch the authorization token from request header to `weatherforecast`.
