# Driving & Vehicle License Department (DVLD) Management System

## Overview
The **DVLD Management System** is a software solution designed to handle the issuance and management of driving licenses. It facilitates various services, including license applications, renewals, replacements, and revocations while ensuring compliance with legal regulations. The system streamlines license processing, applicant verification, and payment tracking.

## Features
### License Management
- Issue new driving licenses.
- Renew expired licenses.
- Replace lost or damaged licenses.
- Revoke or suspend licenses as per legal requirements.

### Application Processing
- Accept and process applications for different license types.
- Track the status of applications (New, Completed, Canceled, etc.).
- Validate applicants' personal details and previous records.
- Maintain applicant profiles to avoid duplicate entries.

### License Categories & Requirements
- **Category 1:** Small Motorcycles (Minimum age: 18, Fee: $15, Validity: 5 years)
- **Category 2:** Heavy Motorcycles (Minimum age: 21, Fee: $30, Validity: 5 years)
- **Category 3:** Regular Cars (Minimum age: 18, Fee: $20, Validity: 10 years)
- **Category 4:** Commercial Vehicles (Taxis/Limousines) (Minimum age: 21, Fee: $200, Validity: 10 years)
- **Category 5:** Agricultural Vehicles (Minimum age: 21, Fee: $50, Validity: 10 years)
- **Category 6:** Medium-Sized Buses (Minimum age: 21, Fee: $250, Validity: 10 years)
- **Category 7:** Trucks & Heavy Vehicles (Minimum age: 21, Fee: $300, Validity: 10 years)

### Testing & Validation
- **Vision Test:** Ensures applicants meet required visual standards.
- **Theoretical Test:** Evaluates knowledge of traffic laws and regulations.
- **Practical Driving Test:** Assesses real-world driving ability.
- Failed tests require reattempts with applicable fees.

### Additional Services
- Issue international driving licenses.
- License inquiry services based on national ID or license number.
- License release service for previously suspended licenses.

## System Entities
### Applicant Details
Each applicant is uniquely identified and must provide:
- National ID
- Full Name
- Date of Birth
- Address
- Phone Number
- Email
- Nationality
- Profile Picture

### License Data
Each license issued contains:
- License Number
- Holder’s Photo
- Holder’s National ID & Personal Details
- License Category
- Issuance & Expiry Dates
- Special Conditions

### Application Data
Each application includes:
- Application ID
- Application Date
- Applicant’s National ID
- Requested Service Type
- Status (New, Completed, Canceled, etc.)
- Fees Paid

## System Management
### User Management
- Add, edit, and delete system users.
- Assign roles and permissions.
- Freeze or activate user accounts.

### Application Handling
- Search applications by ID or applicant’s national ID.
- Filter applications by status.
- Modify application details if needed.

### License Class Management
- Update minimum age requirements.
- Modify validity periods.
- Adjust fees for each license type.

### Testing Management
- Adjust fees for different tests.
- Maintain records of test results.

## Technology Stack
- **Backend:** ASP.NET Core MVC (Entity Framework Core, Clean Architecture)
- **Frontend:** TBD (e.g., React, Angular, Blazor)
- **Database:** SQL Server / PostgreSQL
- **Authentication & Authorization:** ASP.NET Identity / JWT
- **Cloud Services:** Cloudinary (for image management)

## Installation & Setup
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/dvld-management.git
   ```
2. Navigate to the project directory:
   ```sh
   cd dvld-management
   ```
3. Install dependencies:
   ```sh
   dotnet restore
   ```
4. Set up the database:
   ```sh
   dotnet ef database update
   ```
5. Run the application:
   ```sh
   dotnet run
   ```
## Contact
For any questions or contributions, contact:
- **Your Name**: Ahmed waleed
- **Email**: A7mddarwish7dev@gmail.com
