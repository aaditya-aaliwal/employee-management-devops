# Employee Management DevOps

Employee Management System built using **ASP.NET MVC 5 (.NET Framework 4.8)** to demonstrate a complete **CI/CD pipeline** with GitLab Runner and IIS deployment.

---

## Features
=======
* Employee CRUD Operations
* Employee Search
* SQL Server Database
* Entity Framework 6
* Bootstrap 5 UI
* MSTest Unit Testing
* GitLab CI/CD Pipeline
* IIS Automated Deployment
* Backup Before Deployment
* Automatic IIS Application Pool Restart
* Deployment Health Check
* Deployment Validation

---

## Tech Stack

* ASP.NET MVC 5
* .NET Framework 4.8
* C#
* Entity Framework 6
* SQL Server Express
* Bootstrap 5
* MSTest
* Git
* GitHub
* GitLab
* GitLab Runner (Windows Shell Executor)
* MSBuild
* IIS
* PowerShell
>>>>>>> develop

---


=======
## CI/CD Pipeline

The GitLab CI/CD pipeline performs the following stages automatically:

1. Build
2. Unit Testing
3. Package Generation
4. Backup Current Deployment
5. Deploy to IIS
6. Restart IIS Application Pool
7. Health Check
8. Deployment Validation

---

## Testing

Implemented MSTest framework with unit tests for:

* Employee ID Validation
* Employee Name Validation
* Employee Email Validation
* Employee Department Validation

### Test Results

* Total Tests: **4**
* Passed: **4**
* Failed: **0**

---

## Deployment

The application is automatically deployed to IIS after a successful pipeline execution.

Deployment directory:

```text
C:\Deployments\Current
```

Backup directory:

```text
C:\Deployments\Backups
```

---

## Project Status

✅ Phase 1 – CRUD Application

✅ Phase 2 – Git Workflow & Branching

✅ Phase 3 – Unit Testing

✅ Phase 4 – Continuous Integration (CI Pipeline)

✅ Phase 5 – IIS Configuration

✅ Phase 6 – Continuous Deployment (CD Pipeline)

* Backup Stage
* Deploy Stage
* IIS Restart
* Health Check
* Deployment Validation

---

## Upcoming Work

* Phase 7 – Automatic Rollback
* Versioned Releases
* Deployment Logging
* Final Documentation

---

## Repository Structure

```text
EmployeeManagementSystem/
│
├── EmployeeManagementSystem/
├── EmployeeManagementSystem.Tests/
├── .gitlab-ci.yml
├── README.md
└── EmployeeManagementSystem.slnx
```
