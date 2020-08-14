# _Frederick-Ernest_

#### _A Program to track Machine maintanence and Engineer registry, 8/7/2020_

#### By _**Frederick Ernest**_

## Description

_Establish many to many relationship between Flavors and Treats, behind Auth wall made with Identity_

## Specs

| Spec | Input | Output |
| :-------------      | :------------- | :------------- |
| ** 1. Program will take user input to create a Flavor object, and store it in a Database Table| Name: "Sweet"| Sweet |
| ** 2. Program will take user input to create a Treat object, and store it in a Database Table| Type: "Cake"| Cake |
| ** 3. Program will allow the creation of associations between Flavors and Treats, and Treats to Flavors (many to many database relationship)| User Selects Cake treat to be added to Chocolate flavor| "Cake belongs to Chocolate"|
| ** 4. Program will allow the creation of associations between Flavors and Treats, and Treats to Flavors (many to many database relationship)| User Selects Chocolate Flavor to be added to Cake Treat| "Chocolate belongs to Cake"|

## Setup/Installation Requirements

* _Clone or download this repository located at https://github.com/fetonecontrol/PierreAuth
* _Run $ dotnet restore to download all dev dependencies_
* _Run $ dotnet build to create project_
* _In MySql WorkBench, select Data Import from the Server tab, navigate to the root directory of this folder, and select frederick_ernest.sql_

## Known Bugs

_No known bugs_

## Support and contact details

_{Please contact me at with any known bugs or support issues.}_

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _MySql
* _Many to Many database relationships_
* _Entity Framework_
* _Identity Authorization_
* _Razor_
* _GitHub_

### License

*Copyright (c) 2020 **_Frederick-Ernest MIT License_**