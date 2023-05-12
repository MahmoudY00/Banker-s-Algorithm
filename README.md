# Banker-s-Algorithm

This project was written in C# and consists of Three Windows Forms . The First is for getting the number of processess and resources from the user. The Second Form , the user is asked to enter 4 tables ( Total Resources , Avaliable Resources , Current Allocation and Maximum Need) and there is an addition section if asking for requesting resource for a process , also the user get an output in table called (Remaining Need).The last Form is for showing the steps for the user.


## Form1's Function :
`Enter_Click()` Method
This method is an event handler that is called when the user clicks the "Enter" button in Form1. It checks whether both the process and resource text boxes are not empty and whether their contents are valid integers. If both conditions are true, it stores the entered values in no_of_process and no_of_resources variables and opens Form2. If either condition is false, it displays a message box asking the user to enter valid values.



## Form2's Functions:

`TotalResources()` Method

This method is used to populate the `dataGridView1` object with the total number of resources entered by the user in `Form1`. It sets the `ColumnCount` and `RowCount` properties of `dataGridView1` to the total number of resources and 1, respectively. It then assigns a name to each column based on its index.

`AvaliableResources()` Method

This method is used to populate the `dataGridView2` object with the total number of resources entered by the user in `Form1`. It sets the `ColumnCount` and `RowCount` properties of `dataGridView2` to the total number of resources and 1, respectively. It then assigns a name to each column based on its index.

 `CurrentAllocation()` Method

This method is used to populate the `dataGridView3` object with the current allocation of resources to each process entered by the user in `Form1`. It sets the `ColumnCount` and `RowCount` properties of `dataGridView3` to the total number of resources and processes, respectively. It assigns a name to each column based on its index and a header value to each row based on its index.

 `MaxNeed()` Method

This method is used to populate the `dataGridView4` object with the maximum need of resources for each process entered by the user in `Form1`. It sets the `ColumnCount` and `RowCount` properties of `dataGridView4` to the total number of resources and processes, respectively. It assigns a name to each column based on its index and a header value to each row based on its index.

 `RemainingNeed()` Method

This method is used to populate the `dataGridView5` object with the remaining need of resources for each process entered by the user in `Form1`. It sets the `ColumnCount` and `RowCount` properties of `dataGridView5` to the total number of resources and processes, respectively. It assigns a name to each column based on its index and a header value to each row based on its index.

`dataGridView1_CellEndEdit` Event Handler

This is an event handler for the `CellEndEdit` event of the `dataGridView1` object. It is triggered when the user finishes editing a cell in the grid. The purpose of this event handler is to validate the input entered by the user.
The code first checks if the edited cell has a valid row and column index. Then, it checks if the cell value is null or empty. If so, it shows a message box asking the user to enter a value and sets the cell value to an empty string.
If the cell value is not null or empty, the code tries to parse the cell value to an integer. If the parsing fails or the value is negative, it shows a message box asking the user to enter a positive integer value and sets the cell value to an empty string.
Finally, if the input is valid, the code does nothing and the user can proceed with editing other cells.


`dataGridView2_CellEndEdit()` Method

This method is an event handler for the `CellEndEdit` event of `dataGridView2`. It is triggered when the user finishes editing a cell in the grid. The method checks whether the edited cell contains a positive integer value. If the value is empty or not an integer or negative, it displays a message box with an error message and sets the cell value to an empty string. Otherwise, it does nothing.

`dataGridView3_CellEndEdit()` Method

This method is an event handler for the `CellEndEdit` event of `dataGridView3`. It is triggered when the user finishes editing a cell in the grid. The method checks whether the edited cell contains a positive integer value. If the value is empty or not an integer or negative, it displays a message box with an error message and sets the cell value to an empty string. Otherwise, it does nothing.

`dataGridView4_CellEndEdit()` Method

This method is an event handler for the `CellEndEdit` event of `dataGridView4`. It is triggered when the user finishes editing a cell in the grid. The method checks whether the edited cell contains a positive integer value. If the value is empty or not an integer or negative, it displays a message box with an error message and sets the cell value to an empty string. Otherwise, it does nothing.

 `enterdata()` Method

This method is used to populate the matrices that will be used in the banker's algorithm calculations. It creates arrays to hold the total resources, available resources, current allocation and maximum need for each resource and process. 
The `for` loops iterate through the data in the `dataGridView` objects and assign values to the corresponding arrays. If a cell contains an invalid value, such as a negative number or non-integer, an error message is displayed and the program exits.
Overall, this method is responsible for converting the data input by the user into a format that can be used by the banker's algorithm to determine whether a given state is safe or not.

 `Remain()` Method

This method is used to calculate the remaining resources needed for each process, based on its maximum need and current allocation. It populates the `Remain_Need` array with the calculated values and updates the corresponding cells in `dataGridView5`. 
It uses nested `for` loops to iterate through each process and each resource. It calculates the remaining need by subtracting the current allocation from the maximum need, and assigns the result to the corresponding element in the `Remain_Need` array. It then updates the corresponding cell in `dataGridView5` with the calculated value.

 `Enter2_Click()` Method

This method is called when the "Enter" button is clicked. It first calls the enterdata method to retrieve data from the input grids and populate the data arrays. Then, it calls the Remain method to calculate the remaining need of each process for each resource. After that, it sets all input grids as read-only. It then calls the Request and logic methods to perform the main logic of the program.

 `button1_Click()` Method

This method is called when the "Help" button is clicked. It simply displays a message box to provide help to the user.

 `comboboxcreaation()` Method

This method is called during the initialization of the form to populate two combo boxes with the process and resource names. It creates a list of strings containing the names of all processes/resources and adds them to the respective combo boxes using the AddRange method.


 `Request()` Method
The method first checks that the user has entered a valid number of resources to request and that a process and a resource have been selected from the corresponding combo boxes. If the input is valid, the method checks that the requested resources are available.
If the requested resources are available, the method subtracts them from the available resources and updates the corresponding cells in the "Available" and "Allocation" data grids.
If the requested resources are not available, the method displays an error message indicating that the system is in an unsafe state.

 `logic()` Method
The method first initializes some variables and data structures, including a boolean variable x that indicates whether the algorithm is still running, and two arrays checkarr and test that are used to track changes to the available resources.
The algorithm then enters a while loop that continues until the x variable is set to false. Within the loop, the method iterates through each row and column of a DataGridView object (dataGridView5) that represents the current state of the system. For each row and column, the algorithm checks whether the available resources are greater than or equal to the remaining need for that process. If they are, the process is added to a list of safe processes and its allocated resources are released back to the available resources. If the available resources are not sufficient, the process is skipped and the algorithm moves on to the next row and column.
After iterating through all processes, the algorithm checks whether any changes have been made to the available resources by comparing the checkarr and Avaliable_Resources arrays. If the arrays are equal, the algorithm sets x to false and exits the loop, indicating that the system state is safe. Otherwise, the algorithm continues iterating.
If the algorithm finishes iterating and all processes have been added to the safe list, the method displays a "Safe" message box. Otherwise, it displays an "Unsafe" message box. Finally, the method displays a message box with the names of all safe processes.

 `Steps_Button_Click` Method 
The method is an event handler that is called when the "Steps" button is clicked in the user interface. When the button is clicked, it creates a new instance of `Form3` and shows it to the user.

 `print_available` Method 
The method returns a string that represents the current state of the available resources. It does this by iterating over the `Avaliable_Resources` array and appending each value to the `avaliable_s` string. Finally, it returns a string that says "Available Resources =" followed by the `avaliable_s` string.

## Form3's Functions:

 `print_steps()` Method 
The Method is responsible for printing the contents of the `steps` list onto the `richTextBox1` control in the form. It iterates through each element of the `steps` list and appends its value to the `richTextBox1` control using the `Text` property. The contents of the `steps` list are concatenated with the existing text in the `richTextBox1` control, so the new steps will be added at the end of the existing text.This method is likely used to display the progress and results of the algorithm to the user in a readable format.


 ## Some Screenshoots for the Windows Forms:
 
![image](https://github.com/MahmoudY00/Banker-s-Algorithm/assets/82828832/ff1895da-f3cf-4f8d-9d79-1394b4cc3555)

![image](https://github.com/MahmoudY00/Banker-s-Algorithm/assets/82828832/0da44024-0c3e-4a35-b386-0fe0cfb83404)

![image](https://github.com/MahmoudY00/Banker-s-Algorithm/assets/82828832/0fe96b9a-f118-43f4-b007-c423beb131c5)



