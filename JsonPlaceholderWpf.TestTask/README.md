# README #

JsonPlaceholder Test Task for http://zivver.com

.NET Framework 4.6.1
WPF app

### What is this repository for? ###

This is a simple test task represented as a WPF app. When you run it, it will make the http request to gather the data from the url specified in the app.config (https://jsonplaceholder.typicode.com/posts), then it will display 100 squares with the Ids. When you click on any square it will automatically update the title of all the squares showing UserId instead of the Id. When you click again, it will show Id and so on and on.
 

### Technical details ###

1) According to the request the app is based on MVVM pattern, which means there are limitted approaches in development as it's not possible to use events - they would break the whole MVVM pattern approach.
Additionally the app is not using such the MVVM frameworks as MVVM Light/Caliburn.
Such the limitation made me using a single button which catches the Click, otherwise I would probably use some events (tunneling, most probably).

2) The test Task specifies that each square has the following dimention: 10 rows x 10 columns, however it's not clear how to calculate such the size if working with the canvas or TextBlock, so I used the hardcoded square size of 100x100 and using TextBlock for this.

3) There are no requirements on how to place the squares, so I placed them all vertically

4) The screen size is not freezed, so you can change it.

 