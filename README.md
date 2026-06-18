# Employee Management DevOps

Employee Management System built using **ASP.NET MVC 5 (.NET Framework 4.8)** to demonstrate a complete enterprise-style **CI/CD pipeline** using **GitLab Runner**, **MSBuild**, **PowerShell**, and **IIS**.

---

# Features

### Employee Management

* Create Employee
* View Employees
* Update Employee
* Delete Employee
* Search Employee

### DevOps Features

* Git & GitHub
* GitLab Repository
* GitLab Runner (Windows Shell Executor)
* Automated Build using MSBuild
* Automated Unit Testing (MSTest)
* Automated Packaging
* IIS Deployment
* Deployment Backup
* IIS Application Pool Restart
* Health Check Validation
* Automatic Rollback
* Deployment Versioning
* Deployment Logging

---

# Technology Stack

## Application

* ASP.NET MVC 5 (.NET Framework 4.8)
* C#
* Entity Framework 6
* SQL Server Express
* Razor Views
* Bootstrap 5

## DevOps

* Git
* GitHub
* GitLab
* GitLab Runner
* MSBuild
* MSTest / VSTest
* PowerShell
* IIS

---

# CI/CD Pipeline

The GitLab pipeline executes the following stages automatically:

1. Build
2. Test
3. Package
4. Backup
5. Deploy
6. Restart IIS
7. Health Check
8. Automatic Rollback (if required)

---

# Deployment Workflow

```
Developer
    │
    ▼
GitLab Repository
    │
    ▼
GitLab Runner
    │
    ▼
MSBuild
    │
    ▼
Unit Testing
    │
    ▼
Package Application
    │
    ▼
Versioned Release
    │
    ▼
Backup Current Deployment
    │
    ▼
Deploy to IIS
    │
    ▼
Restart IIS
    │
    ▼
Health Check
    │
    ├── Success → Deployment Complete
    │
    └── Failed → Automatic Rollback
```

---

# Versioning

Each deployment generates a unique version using the GitLab Pipeline ID.

Example:

```
EmployeeManagement_101.zip
EmployeeManagement_102.zip
EmployeeManagement_103.zip
```

Current deployed version:

```
C:\Deployments\Current\version.txt
```

---

# Deployment Logging

Deployment history is maintained in:

```
C:\Deployments\Logs\deployment.log
```

Example:

```
101    Success     19-Jun-2026 10:15:20
102    Success     19-Jun-2026 11:30:15
103    RolledBack  19-Jun-2026 12:05:42
```

---

# Testing

Implemented MSTest unit tests for:

* Employee ID Validation
* Employee Name Validation
* Employee Email Validation
* Employee Department Validation

**Test Results**

* Total Tests: 4
* Passed: 4
* Failed: 0

---

# Deployment Structure

```
C:\Deployments

├── Releases
├── Current
├── Backups
└── Logs
```

---

# Project Status

* ✅ Phase 1 – CRUD Application
* ✅ Phase 2 – Source Control
* ✅ Phase 3 – Unit Testing
* ✅ Phase 4 – CI Pipeline
* ✅ Phase 5 – IIS Deployment
* ✅ Phase 6 – Continuous Deployment
* ✅ Phase 7 – Automatic Rollback
* ✅ Phase 8 – Versioning
* ✅ Phase 9 – Deployment Logging

---

# Repository Structure

```
EmployeeManagementSystem/
│
├── EmployeeManagementSystem/
├── EmployeeManagementSystem.Tests/
├── DevOps/
│   └── rollback.ps1
├── .gitlab-ci.yml
├── README.md
└── EmployeeManagementSystem.slnx
```

---

# Future Enhancements

* Docker Containerization
* Kubernetes Deployment
* Azure DevOps Integration
* SonarQube Code Analysis
* Multi-Environment Deployment

---

# Author

**Aaditya Aaliwal**

DevOps Intern Project
