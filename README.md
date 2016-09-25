# Telefonica_DirectoryWatcher
This dir watcher was developed for Telefonica Israel development department.
The request was to create simple yet stong, robust and well archtectured component to listen to file system modifications.


This solution contains software as described in the doc sent to me last week.

Solution layers:
-UI
	- The highest layer and utlized to next folowings
	- Contains UI and applicaiton boot straper
- Common
	- Utilized the Core layer
	- Conains domain specific types
	- IWatchService as entry point for domain business logic
	
- Core
	- Lowest layer
	- Contains reusable types to perform general application tasks (Ioc container and pub-sub pattern implementation)
- Tests
	- Some unit tests I used during programming

Application Flow:
1. UI starts and triggers Bootstrapper's type Load Method, which init the application
2. After selecting the watched and destination directories, the watched folder is watched. 
3. Whenever NEW file is found in the watched folder, system's event publisher (pub-sub) triggers all handling method in consumers
	3.1. Dedicated consumer for copying the file is triggered and copy the file to destination

Before Execution
- Open the solution in visual studio (the solution was created using wrote in VS2015)
- Open 'Package Manager Console' (Tools --> Nuget Package Manager --> Package Manager Console)
- Launch 'Update-Package' command in Package Manager Console

Please note: 
1. This is basically a draft which ignores many issues such what if selected destination folder is same as selected watch folder, who responsible to set file destination path, logging etc.

