# QuickPC-Payroll-Management-System
A QuickPC payroll management system is a software program designed to organize all the tasks of employee payment and tax filing. These tasks include keeping track of hours, calculating wages, tracking attendance, withholding taxes and deductions, printing and delivering checks, completing direct deposits, paying premiums to insurance carriers, and/or paying employment taxes to the government. Based on C# and C++

QuickPC payroll is something that has to be done accurately and regularly, so it makes sense for companies to monitor staff income in a system that automates these processes. Payroll software can mitigate errors, improve compliance, and save time. With increasingly easy-to-use options, they can also maintain more control of the payroll process with this software, which allows them to compile reports at their own pace and make changes quickly if the need arises.

Update Data – Containing Account Information of the QuickPC Shop such as creating new account for new employee and also for old staff to make their account updated information needed.
Every employee requires to input their information based on system requirements field to monitor their salary and payroll.

Staff Account

•	ID Number	-	For new user ID number are freely to choice their 4-digit number 
“Find Button”	-	For old user they have unique ID number to input to find and automatically filled the rest for quick updating information.

•	Full Name	-	Contains First name, Middle name/initial and Surname.

•	Birthday	-	Choose your birth date in computer calendar.

•	Current Address	-	Full details of your current address of living.

•	Phone Number	-	Input your subscriber identification module (SIM) card

•	Job Position	-	Choose your destination work position in shop.

•	Email Address	-	Your personal/business email address (Gmail and Yahoo mail).

Buttons 
•	Create New Account	-	Required to filled all textbook to insert into system database.
•	Menu	-	Simple back to main screen of the application.
•	Update Account	-	After editing new information of old profile, update your latest data to system database.
•	Close	- Exit application.

Payroll Account - Calculates Deductions and Net Income, after an employee’s gross income has been determined, payroll software automatically calculates deductions such as taxes, insurance, and retirement savings. Deduction amounts are automatically subtracted, and a check is drawn.

•	Staff ID Number	-	Input your created unique 4-digit number.
“Search Button”	-	For old user they have unique ID number to input to find and automatically filled the Name and Job position information.
•	Name	-	Automatically filled by search button.
•	Job Position	-	Automatically filled by search button.
•	Current date	-	Automatically filled based on computer system date time.
•	Monthly Basic Pay	-	Input your basic amount of your salary.
•	Overtime hours	-	Input your recorded overtime in a month by hours.
•	Holiday work	-	Input if your work on holiday of the month.
•	Deductions	-	Including your Absences/Tardiness in a month by hours.
•	Taxable Income	-	The income tax was responsible for consuming a quite huge chunk of an employee’s salary including the SSS + PhilHealth + PAG-IBIG + Deductions Due to Absences/Tardiness.
•	Total Deduction	-	Your overall income tax calculated based on your monthly basic salary, automatically filled by “calculated” button.
•	Total Salary	-	Your overall payout that can get on hand with deduction of taxes and based on your filled out overtime or holiday work day, automatically filled by “calculated” button.
o	Buttons
	Calculate	-	Computing your filled amount on monthly basic pay, overtime hours, holiday work day, deduction and income-tax by the application formula.
	Menu	-	Simple back to main screen of the application.
	Close	- Exit application.

How calculated?
Here’s how to compute holiday pay:
Pay for work on a regular holiday (first eight hours) = (Basic wage + COLA) x 200%. For example, if your daily rate is PHP 1,000, your holiday pay should be calculated as follows:
PHP 1,000 x 2 = PHP 2,000
Here’s how to compute overtime hour and deductions due to absences/tardiness pay:
Let’s say your hourly rate is PHP 125, and you worked overtime or absences for two hours (for total overtime or absences of 10 hours). Here’s how to calculate your regular overtime or absence pay:
PHP 125 x 10 hours = PHP 1,250
Here’s how to compute for the Taxable:
Before anything else, you’ll need to compute for your taxable income, which is your basic salary minus your contributions.
Taxable = SSS + ((Monthly Basic Pay * PhilHealth) / 2) + PAG-IBIG
Suppose that you are earning P23000 a month, the computation for the taxable income will be as follows:
Taxable = 581.30 + ((23000 * 0.0275) / 2) + 100.00 
Taxable = 997.55
Here’s how to compute for the overall salary:
*Additional pays like holiday and overtime pays.
Total salary = (Monthly Basic Pay + Additional Pay) – (SSS + PhilHealth + PAG-IBIG + Deductions Due to Absences/Tardiness)
Reference of computing: https://www.taxumo.com/tax-computation-philippines/

Payroll Account History 
Application previously computed payroll of the employees recorded into Microsoft SQL Server Database.
o	Buttons
	Menu	-	Simple back to main screen of the application.
	Refresh	-	Update new calculated payroll.
	Close	- Exit application.
