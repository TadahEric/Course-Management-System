Feature: Project

#1. Delete all records from the Projects table
#2. Populate the Projects table with atleast two records i.e. 'Load Testing' and 'Mobile Testing'
Scenario: Project_01_Verify that existing records can be retrieved from Project resource
	Given that TMS web services with resource Projects is loaded for a GET call	
	Then the status code must be equal to OK
	And the following records must be retrieved from Projects table
	| Name           |
	| Load Testing   |
	| Mobile Testing |


#1. Delete all records from the Projects table
Scenario: Project_02_Verify that a new Project record can be created 
	Given that TMS web services with resource Projects is loaded for a POST call	
	Then the status code must be equal to Created	
	#option1
	And the following record should appear on the Projects table
	| Name           |
	| Mobile Testing |
	#option2
	And the Projects table should have Mobile Testing on the Name column

#1. Delete all records from the Projects table
#2. Populate the Projects table with a record i.e.'Load Testing' 
#3. Retrieve the Id to use for PUT method
Scenario:Project_03_Verify that an existing Projects record can be modified 
	Given that TMS web services with resource Projects is loaded for a PUT call	
	Then the status code must be equal to NoContent
	#option1
	And the following record should appear on the Projects table
	| Name           |
	| Cyber Security |
	#option2
	And the Projects table should have Cyber Security on the Name column

#1. Delete all records from the Projects table
#2. Populate the Projects table with a record i.e. 'Load Testing' 
#3. Retrieve the Id to use for DELETE method
Scenario:Project_04_Verify that an existing record can be deleted from Project resource
	Given that TMS web services with resource Projects is loaded for a DELETE call	
	Then the status code must be equal to OK
	And the following record should appear on the Projects table
	| Name           |
