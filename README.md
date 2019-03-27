# BLCT | Developer Coding Assessment | C#.Net

Developer coding assessment to implement the RESTful endpoints.

### `Solution Information` section is the next `H1`

## About Test

### Overview

* Implement the following RESTful endpoints.
* Try to finish under 1 hour ( you can spend bit more minutes)
* Submit
    * Your gitHub
    * Or any public cloud storage
    * Or zip and email

### Technical Environment

* Asp.NET Web Api
* Or Asp.NET MVC Core
* Visual Studio 2015 Or 2017 compatible

### Assessment Point

* Separation of concern
* Precise Input & Output
* Code Readability and consistency

## Questions

### Question 1

* Browser Input 
    ```
    /api/arraycalc/reverse?productIds=1&productIds=2&productIds=3&productIds=4&productIds=5
    ```
* Browser Result
    ```
    [5,4,3,2,1]
    ```
* Condition
    * Implement with pure array manipulation
    * Don’t use Array.reverse() method
    * Don’t use Linq

### Question 2

* Browser Input 
    ```
    /api/arraycalc/deletepart?position=3&productIds=1&productIds=2&productIds=3&productIds=4&productIds=5
    ```
* Browser Result
    ```
    [1,2,4,5]
    ```
* Condition
    * Implement with pure array manipulation
    * Don’t use RemoveAt
    * Don’t use Linq


# Solution Information

## Time Taken

Roughly `1h 45m` including `README.md`, `UnitTesting` & some distractions from `Kids`!

## Used OS, Tools & Frameworks

* Linux Ubuntu
* Studio Code
* ASP .Net WebAPI (NetCore 2.2)
* NetCore CLI
* **NOTE** Haven't used `Microsoft Visual Studio` & `Resharper` at all.

## Resources For Help

* Microsoft .Net CLI website

## Endpoints

### `/api/arraycalc/reverse?productIds=<int>&productIds=<int>&...`

**Note:** You can append as many `&productIds=<int>` query parameters as you like!

```
# Example #
https://localhost:5001/api/arraycalc/reverse?productIds=1&productIds=2&productIds=3&productIds=4&productIds=5
```


### `/api/arraycalc/deletepart?position=<int>&productIds=<int>&...`

**Note:** You can append as many `&productIds=<int>` query parameters as you like!

```
# Example #
https://localhost:5001/api/arraycalc/deletepart?position=3&productIds=1&productIds=2&productIds=3&productIds=4&productIds=5
```

## Restore Packages

From the root of the repository where the file `blct.sln` resides,

```
# Tested #
[repo-root]$> dotnet restore
```

## Run Instructions

For the Mac & the Linux users, from the root of the repository where the file `blct.sln` resides,

```
# Tested #
[repo-root]$ dotnet run --project ./blct.webapi/blct.webapi.csproj
```

**OR**

```
[repo-root]$ bash blct.run.sh
```

For the Windows users, from the root of the repository where the file `blct.sln` resides,

```
# Not Tested #
[repo-root] > dotnet run --project \blct.webapi\blct.webapi.csproj
```

## Tests Instructions

For the Mac & the Linux users, from the root of the repository where the file `blct.sln` resides,

```
# Tested #
[repo-root]$ dotnet test ./blct.tests/blct.tests.csproj
```

**OR**

```
[repo-root]$ bash blct.tests.sh
```

For the Windows users, from the root of the repository where the file `blct.sln` resides,

```
# Not Tested #
[repo-root] > dotnet test \blct.tests\blct.tests.csproj
```