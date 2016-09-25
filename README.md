# Telefonica_DirectoryWatcher
This dir watcher was developed for Telefonica Israel development department.
The request was to create simple yet strong, robust and well architectured component to listen to directory changes. 
The component must be stand alone and not to rely on any external services and/or third-party libraries.
The suggestted solution copies every new file in source directory to destination directory.

The implementation includes:
* IoC resolver (dependency injectopn)
* pub-sub pattern implementation
* basic unit testing (to the core components only)
* relatively flat architecture
* simple UI



During implementation I created simple dependency injection container which manages all applicaiton dependencies.

~~This solution contains software as described in the doc sent to last week.~~

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

###Application Flow:
1. UI starts and triggers Bootstrapper's type Load Method, which init the application
2. After selecting the watched and destination directories, the watched folder is watched. 
3. Whenever NEW file is found in the watched folder, system's event publisher (pub-sub) triggers all handling method in consumers
	3.1. Dedicated consumer for copying the file is triggered and copy the file to destination

###Before Execution
####To run the unit tests I used xunit. to download xunit package, please follow the next steps:
- Open the solution in visual studio (the solution was created using wrote in VS2015)
- Open 'Package Manager Console' (Tools --> Nuget Package Manager --> Package Manager Console)
- Launch 'Update-Package' command in Package Manager Console

###Please note: 
1. This is basically a draft which ignores many issues such what if selected destination folder is same as selected watch folder, who responsible to set file destination path, logging etc.

