# 🚗 Driving License Management System (DVLD)

A professional, full-featured **C# Windows Forms desktop application** for automating the operations of a **Driving & Vehicle License Department (DVLD)**.  
The system covers applicant registration, license applications, exams scheduling, test management, license issuance, detainment processes, international license services, and full system administration.  

Designed with a **3-Tier Architecture**, a normalized SQL Server database, and role-based system user privileges.

---

## 🎯 Purpose & Scope

This system was built to replicate and automate the core operations of a governmental driving license department, ensuring:
- Safer roads by enforcing eligibility, tests, and age restrictions  
- Efficient management of driver applications, licenses, and services  
- Centralized control of license classes, fees, service requests, and penalties  
- Complete historical tracking, auditing, and reporting

---

## 📦 Key Features

### 🚘 License Services  
- New local license issuance (based on age, license class, and test pass requirements)  
- License renewal management  
- Lost license replacement  
- Damaged license replacement  
- License suspension and detainment management  
- International license issuance (for specific classes and valid licenses)

### 📑 Applications & Tests  
- Create and track service applications with dynamic fees and status history  
- Schedule medical, theoretical, and practical driving tests  
- Capture test results and control retake requests  
- Prevent applicants from bypassing eligibility or exam requirements

### 👥 Applicants & People Management  
- Add, edit, and search applicants with personal data, photo, nationality, and contact info  
- Prevent duplicate national IDs  
- Track license ownership status and service history  

### 👨‍💻 System User Management  
- Create and manage system users (admins, operators)  
- Assign role-based privileges  
- Enable/disable user accounts  
- Full audit tracking on all operational actions  

---

## 💰 Service Types & Standard Fees

| Service                                | Base Fee (USD) |
|:--------------------------------------|:--------------|
| New License Application               | 5 |
| Test Retake (per attempt)             | 5 + Test Fee |
| License Renewal                       | 10 |
| Lost License Replacement              | 20 |
| Damaged License Replacement           | 20 |
| License Suspension Removal            | 5 |
| International License Issuance        | 20 |

---

## 📝 License Classes

| Class ID | Category                        | Min Age | Validity (Years) | Fee (USD) |
|:----------|:--------------------------------|:----------|:----------------|:-----------|
| 1 | Light Motorbike | 18 | 5 | 15 |
| 2 | Heavy Motorbike | 21 | 5 | 30 |
| 3 | Private Car | 18 | 10 | 20 |
| 4 | Taxi / Limousine | 21 | 10 | 200 |
| 5 | Agricultural Vehicles | 21 | 10 | 50 |
| 6 | Mini / Medium Buses | 21 | 10 | 250 |
| 7 | Heavy Trucks / Vehicles | 21 | 10 | 300 |

---

## 🗃️ Database Structure (Summary)

Relational database in **SQL Server** with enforced foreign keys, 1:M relationships, and audit fields.

**Main Tables:**
- `People` → Applicant/Person info (unique national ID)
- `Applications` → Service requests for all services
- `ApplicationTypes` → Catalog of available services & fees
- `LicenseClasses` → License categories configuration
- `LocalDrivingLicenseApplications` → New license issuance applications
- `TestTypes` → Medical, Theoretical, Practical tests
- `TestAppointments` → Scheduled test dates
- `Tests` → Test results and notes
- `Licenses` → Issued license records (type, expiry, driver)
- `DetainedLicenses` → Detained license records and fines
- `Users` → System users linked to `People` table
- `Countries` → Nationality reference

> 📄 See full ERD diagram in `/DataBase/DVLD_Schema.pdf`

---

## 🏗️ Technology & Architecture

| Component       | Technology |
|:----------------|:-------------|
| Language        | C# (.NET 8.0) |
| UI Framework    | Windows Forms |
| Backend Database | Microsoft SQL Server 2022+ |
| Architecture    | 3-Tier (Presentation, Business Logic, Data Access) |
| IDE & Tools     | Visual Studio 2022+, SQL Server Management Studio (SSMS) |

---

## 📥 Setup & Deployment

1. **Clone the repository**
   ```bash
   git clone https://github.com/Adhamalkhateeb/Driving-License-Managment-System.git
2. **Open SQL Server Management Studio (SSMS)**
 * Restore the provided SQL Server database backup or execute the provided .sql script.
 * Replace the existing connection string with your SQL Server instance settings.

3. **Open the solution file Driving-License-Managment-System.sln in Visual Studio**
 * Locate clsDataAccessSettings.cs
 * Replace the existing connection string with your SQL Server instance settings.
 * Build and Run the Application
   
4.Set DVLD as your startup project
 * Build the solution (Ctrl+Shift+B)
 * Run (F5)
 * Use UserName: Adham_ad / Password: 4321



## 🔐 User Roles & Privileges
* Admins → Full access to all services, configuration, and reports
* Operators → Access to applicant records, license services, and test management
* Audit logs track every system action (user, date, and operation)

## 🔒 Remember Me & Password Management

The system supports a "Remember Me" feature for easier login, where the current user's password is securely stored in the Windows Registry. This functionality ensures that users do not need to manually enter their credentials every time they open the application.

### How It Works:
1. **Encryption:**  
   When the "Remember Me" option is selected during login, the system encrypts the user's password using a secure algorithm before storing it in the Windows Registry. This ensures that even if someone gains unauthorized access to the registry, the password remains protected.

2. **Storage:**  
   The encrypted password is saved to the Windows Registry, making it accessible across sessions. The password is not stored in plaintext, providing an extra layer of security.

3. **Decryption:**  
   On the next system launch, the application retrieves the encrypted password from the Windows Registry, decrypts it, and automatically fills in the password field, allowing the user to log in without manually entering the password.

4. **Security Considerations:**  
   - The encrypted password is stored in a secure registry key.
   - The system uses modern encryption algorithms to ensure the password remains safe during storage.
   - The password is decrypted only during the login process, and the decrypted password is never stored in plaintext anywhere in the application.

This feature enhances user convenience while maintaining a high level of security by ensuring passwords are stored and handled securely.


## 📸 screenshots for showcase

![image](https://github.com/user-attachments/assets/d609f37a-011d-4536-a5dc-9a2087c45ab7)

![image](https://github.com/user-attachments/assets/90975207-a73a-4d09-8f82-55b256bf394d)

![image](https://github.com/user-attachments/assets/435f81e3-0429-480f-a297-6382c5bc5325)

![image](https://github.com/user-attachments/assets/e8fce8d8-7d6e-47d4-9309-dd153eeb3165)

![image](https://github.com/user-attachments/assets/32811a88-f2b6-4804-8732-147e260b0121)






## 📊 Future Enhancements
* 📈 Include advanced reporting (issued licenses by type/date/month)
* 🌐 Add multi-language support (Arabic & English interface toggle)
* 📄 Auto-generate printable license card PDF formats

## 📜 License
This project is licensed under the MIT License.

## ✨ Author
Adham Alkhateeb
