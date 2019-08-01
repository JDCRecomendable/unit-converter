# Unit Converter
Improved version of the Avondale College, Auckland project:
https://github.com/JDCRecomendable/unit-converter-old

## About
Unit Converter is a cross-platform unit conversion software project that aims
to provide a streamlined interface for unit conversion for students, scientists
and businesses. Included in the program is support for over 370 different
pre-defined units categorised into 16 different physical quantities. In
addition, to support the needs of certain users, the program permits the
addition of custom units.

The program is free/libre and open-source software. The source code is
structured to allow for easy modification by other parties. Specifically,
the core classes are split from the front-end-specific classes. As well,
a definitions file is included that lists pre-defined units and their relative
values to the S.I. unit of their physical quantities.

## License
GNU General Public License Version 3  
The program is provided with ABSOLUTELY NO WARRANTY, EXPRESS OR IMPLIED.

The source code is available on:  
https://github.com/JDCRecomendable/unit-converter

## Caveats
* The Cocoa-based front-end for macOS is not complete.
* The GTK-based front-end for GNU/Linux, though providing the minimum
functionality available in the core project, is not currently on par with the
Windows-Forms based front-end for Windows.
* Custom units at the moment cannot be saved and will have to be manually added
at the next launch.

## Future Directions (possible given more time)
* Bring macOS and GNU/Linux front-ends to be on par with the Windows front-end.
* Allow custom units to be saved by the program and loaded automatically on
start-up without user intervention.
* Allow the automated processing of multiple conversions. E.g. values to be
converted can be stored in a CSV file that can then be loaded, read and
processed by the program.

## Code Structure
* Core
* GTK# Front-End for GNU/Linux
* WinForms for Windows
* [proposed] Cocoa for macOS

## Running the Compiled Binaries
### GNU/Linux
#### Supported Distributions
* Ubuntu 18.04 and later
* Fedora 30 and later

#### Pre-Requisites
* Mono Runtime
  * Ubuntu:
  ```
  apt install mono-runtime
  ```
  * Fedora:
  ```
  dnf install mono-core
  ```
* GTK# 2 Library
  * Ubuntu:
  ```
  apt install libgtk2.0-cil
  ```
  * Fedora:
  ```
  dnf install gtk-sharp2
  ```

#### Running
```
mono GTKSharpFrontEnd.exe
```  
(inputting `UnitConverter.exe` to `mono` instead will do nothing)

### Windows
#### Pre-Requisites
* .NET Framework 4.7

### Running
Double-click on `WinFormsFrontEnd.exe`.  
(running `UnitConverter.exe` instead will do nothing)
