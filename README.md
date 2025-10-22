# 🧠 SeleniumAIFramework

![.NET](https://img.shields.io/badge/.NET-9.0-blue?logo=dotnet)
![Selenium](https://img.shields.io/badge/Selenium-4.37-brightgreen?logo=selenium)
![NUnit](https://img.shields.io/badge/NUnit-3.13.3-orange?logo=nunit)
![Allure](https://img.shields.io/badge/Allure-Reports-ff69b4?logo=allure)
![License](https://img.shields.io/badge/license-MIT-lightgrey)

---

## 🧩 Overview

**SeleniumAIFramework** is a modular, scalable automation framework built using:

-   **Selenium WebDriver**
-   **NUnit** for structured test execution
-   **Allure Reports** for beautiful test reporting
-   **Page Object Model (POM)** architecture

This framework was designed to showcase **clean, maintainable**, and **production-ready** automation practices used in modern QA teams.

---

## ⚙️ Features

-   Modular **Page Object Model** design
-   Cross-browser ready (Chrome by default)
-   Allure reporting for test results
-   NUnit test framework integration
-   Easy-to-read, maintainable test structure
-   Supports future extensions like parallel execution, CI/CD, and logging

---

## 🧱 Folder Structure

```
SeleniumAIFramework/
├── bin/                       # Compiled binaries (ignored by Git)
├── Models/                    # Data models (if any)
├── obj/                       # Build artifacts (ignored by Git)
├── Pages/                     # Page Object Model (POM) classes
├── Tests/                     # Test classes
├── .gitignore                 # Git ignore rules
├── README.md                  # Project documentation
├── SeleniumAIFramework.csproj # Project config
└── SeleniumAIFramework.sln    # Solution file
```

## 🧪 Running Tests & Allure Reports

To execute all NUnit tests:

```bash
dotnet test
```

### 📊 Generate Allure Report

1. Install Allure CLI (if not installed):

    - macOS: `brew install allure`
    - Windows: [Download from Allure website](https://docs.qameta.io/allure/#_installing_a_commandline)

2. After running tests, generate and view the report:

```bash
allure serve bin/Debug/net9.0/allure-results
```

---

## 🚀 Roadmap / Upcoming Enhancements

-   Add configuration file (`AppSettings.json`)
-   Integrate parallel test execution
-   Add logging with NLog or Serilog
-   Integrate GitHub Actions for CI/CD
-   Cross-browser testing (Edge, Firefox)
-   Add Slack or email notifications for test results

---

## 📝 Project Info

| Browser          | Framework | Test Framework | Reporting |
| ---------------- | --------- | -------------- | --------- |
| Chrome (default) | .NET 9.0  | NUnit          | Allure    |

## 👨‍💻 Author

**Mxoleleni Ndlovu**  
Quality Assurance Engineer | Manual & Automation Testing  
🧠 “Building reliable test automation, one framework at a time.”
| **Browser** | Chrome (default) |
| **Framework** | .NET 9.0 |
