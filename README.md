# REFrostedViewController for Xamarin.iOS

A Xamarin.iOS Binding for [REFrostedViewController](https://github.com/romaonthego/REFrostedViewController)

iOS 7 style blurred view controller that appears on top of your view controller.

<img src="https://github.com/therealjohn/REFrostedViewController/raw/master/Screenshot.png" alt="REFrostedViewController Screenshot" width="400" height="568" />
<img src="https://github.com/therealjohn/REFrostedViewController/raw/master/Demo.gif" alt="REFrostedViewController Screenshot" width="320" height="568" />

## Requirements
* Xamarin.iOS
* Xcode 5 or higher
* iOS 6.0 or higher

## Demo

Build and run the `REFrostedMenuExample` project in Xamarin Studio to see `REFrostedViewController` in action.

## Installation

### DLLs

I left the built DLL files in the bin directorys of the binding project. If they do not work for you, open the solution and re-build the DLLs and those new files.

Simply reference the REFrostedMenu.Dll in your iOS app project. Add a `using REFrostedMenu;` to get access to the types.

## Example Usage

There is an included sample project that is a direct port of the original "simple" sample. 

## Credits

Inspired by a [Dribbble shot](http://dribbble.com/shots/1173945-Menu-Concept-1), author [Jackie Tran](http://dribbble.com/jackietrananh).

The blur algorithm that is used for static blur comes from WWDC 2013's session 208, "What's New in iOS User Interface Design".

## Original Author

Roman Efimov

- https://github.com/romaonthego
- https://twitter.com/romaonthego
- romefimov@gmail.com

## License

REFrostedViewController is available under the MIT license.

Copyright © 2013 Roman Efimov.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
