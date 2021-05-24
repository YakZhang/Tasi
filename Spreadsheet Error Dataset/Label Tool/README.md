# TasiErrorLabelTool

TasiErrorLabelTool is a C# excel plugin which can help you label error cells in spreadsheets.

## QuickStart

### Install plugin

First you need to install the plugin `TasiErrorLabelTool` in Microsoft Office Excel.

1. Open `TasiErrorLabelTool.sln` with Visual Studio 2019.

2. Click the button `Start` to run the program.

3. The Excel program will be opened automatically, then click `open` to open file  `GroundtruthStatistics.xlsx`.

4. Select the panel `Add-ins` in the top menu bar, you can find an excel plugin `TasiErrorLabelTool` is installed by the C# program.

5. If you can load the plugin successfully, now stop the program in Visual Studio 2019.

   1. The file `GroundtruthStatistics.xlsx` will be closed as the program stopped.

### Label error cells

Now, you can use the plugin to label error cells in spreadsheets, and the data will be written to `GroundtruthStatistics.xlsx` automatically.

1. Open the excel file `GroundtruthStatistics.xlsx`. 

   (Note that the file `GroundtruthStatistics.xlsx` need to be opened when you label error cells.)

2. Open the spreadsheet in which you want to label error cells.

3. Select the error cell.

4. Click the button  `addError`, then:

   1. The error cell's location (e.g., E3) will be added in the edit box `Error`. 
   2. Comment will be added in the selected cell, and the comment's content is "Error".

5. You can repeat step3 and step4 for multiple times to add more error cells in the edit box `Error`.

6. Choose an error reasons for this error cell in the combo box `addType`.

   1. Formula error：The corresponding cells contain inconsistent formulas.
   2. Missing formula error：A cell is supposed to contain a formula, but it does not.
   3. Other：Other patterns.

7. Click button `addGroup`, then:

   Information of this error cell will be written to `GroundtruthStatistics.xlsx` as a new row, including the spreadsheet name and worksheet and so on.
