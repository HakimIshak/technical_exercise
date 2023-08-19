# Selenium Automation Test: Amazon Laptop Price Verification

This repository contains a simple Selenium automation test script written in C# to validate the price of a laptop on Amazon.

## Setup

### Prerequisites

- Visual Studio with .NET Core
- Visual Studio with Selenium.Support
- Visual Studio with Selenium.WebDriver
- Get chromeDriver with step below:
  1. Open cmd and navigate to project directory ".\technical_exercise\"
  2. Run a batch file in cmd ("run_test.bat")

### Installation

1. Clone this repository to your local machine.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build the solution to restore NuGet packages.

## Usage

1. Open the `SeleniumTest.cs` file located in the `technical_exercise` namespace.
2. Modify the `MaximumAllowedPrice` constant if needed (default is $100).
3. Run the test by executing the test method named `VerifyPrice` or pressing CTRL+R,T.

## Script Explanation

The script performs the following steps:

1. Opens Amazon website and searches for "laptop".
2. Waits for search results to load.
3. Clicks on the first search result (laptop product).
4. Waits for the product page to load.
5. Extracts the price of the laptop and verifies it's greater than the allowed maximum price.
