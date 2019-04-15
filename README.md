SuperAdventure
================
This is just another go at the online tuturial 
[Learn C# by Building a Simple RPG](https://scottlilly.com/learn-c-by-building-a-simple-rpg-index/) 
by Scott Lilly.

Every lesson has its own commit. 
This makes it very simple to follow and highlight the actual changes i the tutorial.

The source code is identical to the code provided by Scott Lilly, except the changes described below.


How to use the sample SQL database
----------------------------------
In Lesson 22 a SQL database is introduced.

This is great, but if you don't want to install a full "Microsoft SQL Server" 
and a huge management tool like "Microsoft SQL Server Management Studio" on your system, 
you can use the empty sample database files
 
    SampleDatabase/SuperAdventure.mdf_sample
    SampleDatabase/SuperAdventure.log_sample

The sample database is created and can be used by "Microsoft SQL Server 2016 Express LocalDB" which is part of the "Visual Studio 2017" workload ".NET desktop development".

To use the sample database, simply copy and rename the two files to the directory of your .exe file. This will typically be

    SuperAdventure/bin/Debug/SuperAdventure.mdf
    SuperAdventure/bin/Debug/SuperAdventure.log

and/or

    SuperAdventure/bin/Release/SuperAdventure.mdf
    SuperAdventure/bin/Release/SuperAdventure.log

Finally, the file PlayerDataMapper.cs has been changes a little bit
- `_connectionString` is set to use the default instance "MSSQLlocalDB" of "Microsoft SQL Server 2016 Express LocalDB".
-  The 
[fix provided by Joe Simper](https://scottlilly.com/learn-c-by-building-a-simple-rpg-index/lesson-22-3-creating-the-sql-to-save-and-load-the-saved-game-data/#comment-4486) 
is implemented.

