Contract Monthly Claim System (CMCS)

Project Overview
The Contract Monthly Claim System (CMCS) is a .NET Core web application
designed to streamline the process for Independent Contractor lecturers to submit
their claims for approval. The system allows lecturers to submit claims, upload supporting documents, 
and track the status of their claims. Program coordinators and academic managers can review, approve, 
or reject these claims through an intuitive dashboard.

Features
Part 1 Updates
User Interface Design:

Created a visually appealing and user-friendly interface for the login page, including options for lecturer and administrator login.
Designed forms for lecturers to submit claims, including fields for hours worked, hourly rate, and additional notes.
Basic Functionality:

Implemented a prototype where lecturers can submit claims at any time.
Claims Table:

Set up the Claims table in the LecturerDb database using SQL Server Object Explorer in Visual Studio.
Part 2 Updates
Enhanced Claim Submission:

Lecturers can submit claims with a well-designed form and a prominently displayed 'Submit' button.
Integrated the ability for lecturers to upload supporting documents with file type restrictions (.pdf, .docx, .xlsx) and a file size limit.
Admin Dashboard for Verification:

Created a separate view for program coordinators and academic managers to easily verify and approve or reject claims.
Added buttons for each claim to approve or reject, allowing for streamlined management.
Claim Status Tracking:

Implemented a transparent tracking system to show the status of each claim (e.g., 'Pending', 'Approved', 'Rejected').
Claims status updates in real-time as coordinators or managers take action.
Error Handling and Unit Testing:

Developed error handling mechanisms to display meaningful error messages to users.
Initiated unit testing for key functionalities to ensure reliability and consistency.
Version Control:

Regularly committed and pushed changes to the GitHub repository with clear and descriptive commit messages.
Technologies Used
Frontend: HTML, CSS, JavaScript, Razor Pages
Backend: ASP.NET Core
Database: SQL Server
Version Control: Git and GitHub
