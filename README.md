# Driving & Vehicle License Department (DVLD)

## Overview

This project is a **Driving License Management System** designed for governmental institutions responsible for issuing and managing driver licenses and vehicle-related services.

The system is implemented using a **3-Tier Architecture**, which includes:
- **Presentation Layer**: user interface for interacting with the system
- **Business Logic Layer**: processes all application logic, rules, and workflows
- **Data Access Layer**: handles database communication and data persistence

---

## Core Functionalities

### 1. License Services

The system provides the following license-related services:

| Service                           | Description                                            | Fee (USD)        |
|-----------------------------------|--------------------------------------------------------|------------------|
| First-Time License                | Apply for a new driving license                        | $5 + class fee   |
| Re-Test                           | Re-book a failed exam                                  | $5 + exam fee    |
| License Renewal                   | Renew an expired license                               | $10              |
| Lost License Replacement          | Replace a lost license                                 | $20              |
| Damaged License Replacement       | Replace a damaged license                              | $20              |
| License Unblocking                | Unblock a previously held license                      | $5               |
| International License             | Issue an international license (Class 3 only)          | $20              |

---

### 2. License Classes

| Class | License Type            | Minimum Age | Validity (Years) | Class Fee (USD) |
|-------|--------------------------|-------------|------------------|-----------------|
| 1     | Small Motorcycles        | 18          | 5                | $15             |
| 2     | Heavy Motorcycles        | 21          | 5                | $30             |
| 3     | Regular Cars             | 18          | 10               | $20             |
| 4     | Commercial Vehicles      | 21          | 10               | $200            |
| 5     | Agricultural Vehicles    | 21          | 10               | $50             |
| 6     | Small/Medium Buses       | 21          | 10               | $250            |
| 7     | Trucks/Heavy Vehicles    | 21          | 10               | $300            |

---

### 3. Application Process

Applicants must follow this process to obtain a license:

1. Submit a service request.
2. Ensure no existing pending request of the same type exists.
3. Meet age and license class requirements.
4. Pass the following exams (in order):
   - **Medical/Vision Test** ($10)
   - **Written Exam** ($20, 100 points, offline)
   - **Practical Driving Test** (fee varies by class)
5. Re-testing is allowed if failed, by booking and paying again.
6. Upon success, a license is issued including:
   - License ID
   - Photo
   - National ID
   - Full Name
   - Birth Date
   - License Class
   - Issue/Expiry Dates
   - Notes and status

---

### 4. Person & Request Management

- Every person is uniquely identified by their national ID.
- Duplicate entries are not allowed.
- Each request is linked to a person and has a trackable status (New, Cancelled, Completed).
- Admin users can:
  - Add/Edit/Delete person records
  - Add/Edit/Delete and filter service requests
  - Search by national ID or request ID

---

### 5. Admin Panel Features

Admin functionalities include:

- **User Management**:
  - Add/edit/delete users
  - Assign roles and freeze/unfreeze accounts

- **License Operations**:
  - Manage license classes (fees, age, validity)
  - Block/unblock licenses and manage fines
  - View complete license history for individuals

- **Examination Configuration**:
  - Set or update exam types and their respective fees

- **Audit Logging**:
  - Every system action is logged with timestamp and user identity

---

## Architecture

The project follows the **3-Tier Architecture** model:

- **Presentation Layer**: user-facing interface (e.g., admin dashboard)
- **Business Logic Layer**: service rules, workflows, and data processing
- **Data Access Layer**: CRUD operations and data validation

---

## Notes

- A person may hold multiple licenses of different classes, but not duplicate classes.
- International licenses are restricted to valid Class 3 license holders.
- The system enforces all legal and operational rules through strict validation.
- All licenses, requests, exams, and user activities are fully traceable and manageable through the admin panel.

---

## License

© 2023 ProgrammingAdvices.com
