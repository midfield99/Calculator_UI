Calculator_UI
Overview. This is a demonstration of calling python scripts from a C# program and automatically creating a nuget package**.

Note: Still need to debug automatically creating the nuget package. It worked on my local repo, but it failed on the cloned repo I tested. So that needs to be fixed. The frontend and backed worked in my cloned repo though.

Input Syntax: Calculator uses polish notation. Mathmatical operators are binary. So operators can only have two arguements Spaces separate different atoms for the grammar. Parentheses are assusmed. For instance "+ * 2 3 5" is equivelent to "(+ (* 2 3) 5)". Check checks the string. It just checks syntax. The string has the possibility of still being invalid. For instance "/ 6 0" is valid syntax but throws a divide by zero error. This is executed by calling calc_interface.py and using a flag with main to choose the right function. = evaluates the string. This is executed by called a specific function in the python script.

Basic Design. Calculator_UI: The UI for the calculator calls Python_Accessor for all backend work. Python_Accessor: C# project to call python scripts. Python_AccessorTests: A few tests to test that C# can access the python scripts.

calc.py: Main class for evaluating expressions. calc_interface.py: an interface for interacting with calc.py calc_test.py A more extensive set of tests to check calc.py

calc.py Approach: I initially started a more functional approach to the calculator. Hence calc just calls .valid() on the input and then .evaluate() on the input if valid. But that was slightly a pain in python. Lisp probably would have been a better choice. So if I was redoing it I would probably try out a stack based approach first. I think that would have been more appropriate.

calc_interface.py Approach: this provides an interface for calc.py. This technically is not necessary, I could directly call a function from a python file, but the approach is different. But to do that I need to send a short python script to the command line to import the target file and call the function. With an interface I can just call the interface directly and main will call the function based on an arguement flag. Neither approach is necessarily better, just different. And I'm calling the python script via a proccess, and getting output from the StandardOutput, so I need the python script to print the result, not return it. So an interface is useful.

calc_test.py Approach: This tests calc.py, and has much more testing than Python_AccessorTests. Note that some tests are testing functionality that the C# UI doesn't need. Because of my initial approach for calc.py I had calc() work on a class, not a string. So calc_test creates instances of that class object and tests calc.py C# sends the python script strings, so I needed some way to convert strings into that class object. I implemented a couple different ways. The C# UI only uses one. But I did test literal_eval(), that seems like it is a decent method for converting strings to python data types.

Python vs Ironpython: This project does not use Ironpython. It's not because I thought cpython was better necessarily for this project. You can host Ironpython in C#, and you have more flexibility when working with Ironpython and C#. It might have made a couple of things easier. But there are some minor differences between cpython and IronPython, so cpython might be a better choice in some cases. And calling cpython scripts seemed a little more complicated than calling IronPython scripts. So I decided calling cpython scripts would be a better demonstration.

Nuget packages: Python_Accessor should automatically create a nuget package on build. The nuget console was throwing a few errors when I tried to install the package in Calculator_UI. So I just added Python_Accessor as a reference. I would still need to look into fixing that. Automatically creating the package works on my local repo. But it doesn't work on the cloned test repo. So something got lost or changed pushing to git.

Improvements: I didn't want to use full paths for the python scripts, portability would have been a problem. So I used relative paths. Because of that the .exe looks for the python scripts in its folder. This means that each C# project needs its own copy of the python scripts. This is bad for development, I would definitely get this fixed. But putting python scripts in the same folder as the .exe isn't such a bad thing once the project would be done.

Automatically creating the nuget package only works on my local repo, not the test on. So this definitely needs to be fixed when I have time.

I would have changed my approach for the calculator part, I would have first tried a stack based approach for evaluation.

The process that calls the python script creates and then suppresses a window. This is annoying, and I'd look into fixing it a little more.

The calculator is really basic. It would be useful with more functionality.