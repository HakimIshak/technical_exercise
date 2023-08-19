# Selenium Automation Test: Amazon Laptop Price Verification

This repository contains a simple Selenium automation test script written in C# to validate the price of a laptop on Amazon.

## Setup

### Prerequisites

- Visual Studio with .NET Core
- Visual Studio with Selenium.Support
- Visual Studio with Selenium.WebDriver

### Installation

1. Clone this repository to your local machine.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build the solution to restore NuGet packages.

## Usage

1. Clone repo from : 
2. Open the `Tests.cs` file located in the `TechnicalExercise` namespace.
3. Modify the `MaximumAllowedPrice` constant if needed (default is $100).
4. Run the test by executing the test method named `VerifyPrice`.

## Script Explanation

The script performs the following steps:

1. Opens Amazon website and searches for "laptop".
2. Waits for search results to load.
3. Clicks on the first search result (laptop product).
4. Waits for the product page to load.
5. Extracts the price of the laptop and verifies it's greater than the allowed maximum price.

## How to run test

chmod +x run_test.sh
./run_test.sh

