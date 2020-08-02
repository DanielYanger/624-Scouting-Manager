# 624-Scouting-Manager

## Introduction 
This is the code for the 624 Scouting Manager, part of the 624 Scouting system. The purpose of the 624 Scouting Manager is to automatically generate a schedule compatable with the 624 Scouting Apps as well as automatically merge collected data to a single CSV.

## Requirements
Update: Starting with version 2.0.0, Python is no longer needed to run the application. All the code has been rewritten natively in C# (rather than referencing external python scripts). That means all you need to do is install the .msi file. Additionally, you no longer need an API key as one associated with the team is being used.

## Guide
Once you have installed all the necessary components, you can proceed to use the 624 Scouting Manager.

### Import Data
Select the file that you wish to import by navigating to the location of the data on the tablet and select whether it is pit data or match data. Click import and wait. If you have just installed puthon, it may take a moment as it installs the pandas library. The CSV will appear on your desktop. 

### Generate Schedule
For this option, you will need to event code. To get the event code, navigate to TBA and search up the event. It is the year of the event combined with the code that appears when searching up an event in TBA. For example, the 2019 Newton divison event code would be 2019new. Note that the code should be lowercase. 
