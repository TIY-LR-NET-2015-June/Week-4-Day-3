# Week-4-Day-3


Today
----
1. Review MVC
1. action results
1. vanity urls

```c#
  routes.MapRoute(
              name: "AllSchools",
              url: "GetAllSchools/{currentPage}",
              defaults: new { controller = "School", action = "ShowAll", numberPerPage=5, currentPage = 1 }
          );
```

#Homework

Normal
-----
1. Fork and Clone this repo, submit the homework by doing a pull request (PR)
2. Grab the file users.txt in this repo and place it in a folder in your application called "files". The format of users.txt is firstname _space_ lastname _space_ emailaddress
3. Display the content of users.txt as an html table. (i.e open and parse the file in a model of People)
3. Provide a link to download the parsed list of users as an actual csv file (header, rows, and using commas)
4. Create a vanity url "localhost/UserCSV" for this link.


Nightmare
-------
Restrict access using the Authorize() attribute when downloading the csv
Create a login page where I can type "admin"/"secret1234" as my username/password to get access.




Create a login system (hard code passwords)
