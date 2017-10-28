# _Word Counter C#BDD Project October 2017_

#### _ 10.20.17_

#### By _**Victor M. Puentes Jr.,**_

## Description

A website in MVC that uses a method to return how frequently a word appears in a given string. A user will enter both a word and then a string of words. Upon hitting enter, the program will check for full words matches and return the number of times the word appears in the given string.


| Behavior  | Input  | Output  | Explanation |
|---|---|---|---|
|1.User will enter a word, and a one word sentence, and the output will reflect 1. | input word: "Hello", input string: "Hello" | 1 | Here, I'm testing for the simplest possible response, to see that input word is being compared correctly with the input sentence and counted for. |
|2.User will enter a word, as well as a string, and the output will reflect how many times the word appeared in the string.  | input word: "Hi" input string: "Hi, how are you?" | 1 |  Here, I'm testing to see if the application recognizes the user input word, and compares it to the user input string, and is able to identify it accurately.|
|3.User will enter a word, as well as a string, and the output will not count any characters in the string if they are present. | input word: "Hi", input string: "Hi, how @re you??" | 1 | Here, I'm testing to see if the application only recognize the user input word and ignore the non-alpha numeric characters |
|4. User will enter a word, as well as a string with the input word present multiply times, and the output will reflect this accurately. | input word: "am", input string: "I am happy, I am sad, I am lucky, I am glad."| 4 | Here, I'm testing to see if the input word will be counted multiple times. |


## Getting Started

May be deployed using Git hub pages at  https://github.com/vmpuentes/Word_Counter_Oct_17.git.

### Prerequisites

Clone {this repository}(https://github.com/vmpuentes/Word_Counter_Oct_17.git) in your command line.
open project in terminal
Enter in dotnet run in the command line.
Open http://localhost:5000 in your web browser


## Built With

* [C#](https://learnhowtoprogram.com/couses/c#)
* [HTML5](https://developer.mozilla.org/en-US/docs/Web/Guide/HTML/HTML5) - Used to contruct this webpage
* [CSS3](http://html.com/css/) - Used to style
* [Bootstrap](http://getbootstrap.com/) - CSS library used
* MVC
* Razor
* MicrosoftASP.NETCORE version 1.1.2

## Authors

* **Victor M. Puentes Jr.** - *Initial work* - [Github username: vmpuentes](https://github.com/vmpuentes)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Epicodus (https://epicodus.com/)
