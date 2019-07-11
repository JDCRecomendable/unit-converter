# Unit Converter
Improved version of the Avondale College, Auckland project:
https://github.com/JDCRecomendable/unit-converter-old

## Proposed Features
* Ability to manipulate custom units

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

#### Running
Double-click on `WinFormsFrontEnd.exe`.  
(running `UnitConverter.exe` instead will do nothing)
