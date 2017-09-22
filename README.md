# FlaUIRecorder
UIAutomation test recorder for using with [FlaUI library](https://github.com/Roemer/FlaUI).

This application records all mouse actions and key strokes and generates (C#) code which can be used to automate the ui using [FlaUI](https://github.com/Roemer/FlaUI).

## Code provider
Supporting multiple code generator/provider increases the usability of this application. At the moment only C# code provider is implemented.

## Roadmap
* Support for key strokes
* Add verifications (Adds e.g. `Assert.Equal(uielement.Text, "myvalue")` to the generated code). Required for automated ui tests.
* Nicer project ui

## Credits
This application based on the [FlaUI](https://github.com/Roemer/FlaUI) and some ideas of [FlaUI Inspect](https://github.com/FlauTech/FlaUInspect).
