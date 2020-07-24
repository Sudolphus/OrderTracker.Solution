# _Order Tracker_

#### _An app to track orders, 7.24.29_

#### By _**Micheal Hansen**_

## Description

_An app designed to help Pierre from the Bakery keep track of all the Vendors he's supplying and the orders he is supplying them with._

## Specifications

| Spec | Input | Output |
| :--- | :---: | ---: |
|Program tracks Vendors|GET|List of vendors|
|Program can add new Vendors|Add new Vendor("Suzie's")|Vendors = {"Suzie"}|
|Program can display all Orders by a given Vendor|"Suzie's"|Orders={Bread = 0, Pastries = 0}|
|Program can add new Orders to a Vendor|"Suzies->Order 3 Bread, 5 Pastries"|Orders={Bread = 3, Pastries = 5}|
|Program 


## Setup/Installation Requirements

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## Known Bugs

_None currently known_

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

* _VSCode_
* _C# and .NET_