# Vendor and Order Tracker

Vendor and Order Tracker is an ASP.NET Core MVC web application designed to help bakery owners like Pierre track their vendors and the orders associated with each vendor. The application allows users to create and manage vendors, add orders to each vendor, and view the details of each order.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Known Issues](#known-issues)
- [Future Improvements](#future-improvements)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Features

- Create and manage vendor profiles, including name and description
- Add orders to vendors, with order title, description, price, and date
- View order details, including the ability to edit and delete orders
- Search functionality for vendors and orders
- Custom CSS and JavaScript for an enhanced user experience

## Technologies Used

- C#
- ASP.NET Core
- MVC (Model-View-Controller) architectural pattern
- Razor Views
- Entity Framework Core
- LINQ
- HTML, CSS, JavaScript

## Getting Started

### Prerequisites

To set up and run this project locally, you'll need to have the following installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download)
- A code editor, such as [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:
`https://github.com/JBShaffer91/VendorOrderTracker.git`

2. Navigate to the project directory:
`cd VendorOrderTracker.Solution`

3. Install the required packages:
`dotnet restore`

4. Build the application:
`dotnet build`

5. Run the application:
`dotnet run --project VendorOrderTracker`


The application should now be running at `http://localhost:5000` (or another specified port).

## Usage

1. Visit the application in your browser at `http://localhost:5000`.
2. Click on the 'Vendors' link to view the list of vendors.
3. Use the 'Add a new Vendor' link to create a new vendor profile.
4. Click on a vendor's name to view their associated orders.
5. Use the 'Add Order' button to create a new order for a specific vendor.
6. Click on an order's title to view its details, edit, or delete the order.

## Known Issues

This application is thoroghly tested. At the time of the last commit, there were no known issues. If you encounter any bugs or other issues, please open a new issue on GitHub.

## Future Improvements

- Add authentication and authorization
- Add a shopping cart feature
- Add a payment processing feature
- Add a feature to track inventory

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue to discuss any changes or improvements you'd like to make.

## License

`Copyright 2023 Justin Shaffer`

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## Contact

Justin Shaffer - justinbshaffer91@gmail.com

Project Link: https://github.com/JBShaffer91/VendorOrderTracker
