# prcrec
_Victoria(codename: prcrec)_ is a simple recorder which records user's actions taken using keyboard and mouse wherever 
on the screen, doesnt matter on what window. 

Victoria is in BETA phase. It actually supports recording ASCII chars, it recognizes all system key like **_Alt_**, **_AltGr_**,**_Shift_** etc. It wont record characters from e.g. UTF-8, for example character: 'ś' will be wrote down as: [AltGr][s]

I used Win32 API to make all the application logic and a bit of reflection mechanism. The UI is built using modern WPF(Modern UI). 

The app can:
* record mouse x,y coodrinates according to foreground window,
* record keyboard input whenever it is typed(does not need to enter text to textbox, just type),
* fluent keyboard input method using all system keys(application record both keys pressed at a time),
* detect what window is focused,
* make a screen capture of the area near to the mouse click(in theory now),
* save the macro to the CSV file,
* work in the background without showing on the taskbar.

_Main view of an app_

![Main view](http://i.imgur.com/JNy5xE2.png)

_App in action_

![App in action](http://i.imgur.com/CzcBoOC.png)

**IMPORTANT NOTES**:
There is a need to add Modern UI(mui) packages using NuGet. packages.config file contains a record for it, however VS not always want to resolve dependency that way so then:
* remove reference,
* enter NuGet,
* find Modern UI(mui),
* Install(or reinstall it),
* Done. 



