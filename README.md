# IAW Scan 2

Fork with minor UI tweaks and updated .NET runtime (version 8)

**Current version: 0.87**

# Old readme

## IAW Scan 2

IAW Scan 2 is a succesor of the IAW ECU Scan application.
It is designed to enable easy diagnostics of FIAT OBD-I Engine Control Units.
Application works on any x86/x64 version of Microsoft Windows capable of running .NET 2.0 (namely from Windows 2000 to Windows 7) and uses an inexpensive and widely available ISO-KKL interface (requires additional ODB-2 to FIAT 3-pin adaptor cable). The interface can be either RS-232 or USB (FT232) based.
It supports most of the FIAT cars which use the IAW-6F/8F/16F/18F/18FD Engine Control Units like Cinquecento 900/1100, Seicento 900/1100, Panda 1.0/1.1, Punto 55/60/75/85, Tipo/Tempra 1.6 and also Lancia (Delta/Dedra 1.8, Y 1.2) and Alfa-Romeo (145/146 1.3 BOXER). Since introduction of IAW-04K also some 2.0 engines are supported: FIAT Coupe S 2.0, Tipo 2000, Alfa Romeo 155 2.0 16V, Lancia Delta/Dedra 2.0 16V.

## CHANGE LOG

### Release 0.85 (11.05.2015)
+ German translation thanks to Renè Bayer.

### Release 0.84 (25.03.2015)
* Minor code improvements.
+ List of supported cars for each ECU in ECU selection screen.

### Release 0.83 (27.12.2014)
+ Bosnian/Croatian/Serbian version thanks to Edin Huseinagić.

### Release 0.82 (23.07.2014)
* Corrected splash screen code.
* Improved temperature decoding for IAW-04K.
* Improved communication stability (previously some random errors colud occur for IAW-8F)

### Release 0.81 (12.12.2013)
* Corrected crash after ECU stops responding in Active Diagnostic Mode.
* Corrections in Polish language texts.
- Removed Stepper Motor Test for IAW-16F as it was not funtional.

### Release 0.80 (12.09.2013)
* Corrected Splash Screen code.
* Corrected MAP pressure units in IAW-04K.
* Corrected a bug in error decoding in IAW-04K.
* Code cleanup.

### Release 0.79 (31.07.2013)
+ Portugese version thanks to Artur Soares.
* Reorganized project structure.

### Release 0.78 (25.03.2013)
* Corrected null exception in the FIAT-CODE and IAW-04K modules.

### Release 0.77 (13.03.2013)
* Corrected connection cancelling.
+ Adjustments Tab.
+ IAW-1G7 Palio 1.0.

### Release 0.76 (17.01.2013)
* Corrected Injection Time decoding (corrupted in previous release).

### Release 0.75 (14.01.2013)
* Corrected a bug that caused first test in the list to clear codes instead of executing the actual test.
* Minor polish language corrections.
+ Added FIAT CODE Immobiliser as a separate unit.
+ Added option to toggle fuel trim and idle stepper autocalibration.

### Release 0.74 (11.01.2013)
* Corrected column labelling in CSV log file.
* Corrected decoding of signed parameters.
+ Added graph scrolling.
+ Added Italian language.

### Release 0.73 (25.11.2012)
+ Chceck if COM port is available while openeing.
* Improved timmers accuracy.
* Fixed (hope this time for good) autodetction routine.

### Release 0.72 (06.08.2012)
* Corrected TPS decoding routine in IAW-04K.P8
* Possible autodetection of IAW-04K (but early units do not respond on ISO and CODRIC requests)
+ Added version info to log file

### Release 0.71 (05.07.2012)
* Slightly reduced polling speed in order to gain readouts stability.
* Now 'Compatibility Mode' can work with a single K-Line interface (pins 1 & 3 shorted in the diagnostic socket)

### Release 0.70 (07.06.2012)
* Fixed graph data overrun when single parameter selected, now graph is updated at fixed period of 100ms

### Release 0.69 (19.03.2012)
+ Trimmer & stepper autocalibration reset for IAW-x6F/x8F

### Release 0.68 (02.02.2012)
+ Error decoding for IAW-04K.P8

### Release 0.67 (30.12.2011)
* Minor polish language corrections
* Changed datatype of some (adaptation) parameters
+ Air & water temperature decoding for IAW-04K.P8

### Release 0.66 (31.10.2011)
+ Dutch language added (thanks to Gerrelt)
+ Experimental support for early IAW-8F used in Alfa 33 (thanks to Gerrelt)

### Release 0.65
* Connection lost state detection fixed
* Diagnostic mode initialisation fixed
+ Partial support for IAW-04K.P8 (all but error reading)

### Release 0.64
* Serial port buffer is cleaned before each query
* Errors are queried only when errors panel is visible and parameters are queried only when parameters or graph panel is visible (greatly improves data refresh rate)

### Release 0.63 (02.09.2011)
* Corrected a serious bug in IAW-18F/18FD error decoding routines

### Release 0.62 (29.08.2011)
* Corrected ISO table for car model identification
+ Added some missing strings to Polish translation
+ Added help panel

### Release 0.6 (28.08.2011)
- Removed DEMO-Mode
+ Added Simulation-Mode (for all ECUs, initialized by Ctrl+Connect / Ctrl+F10)
+ Addad option to re-initialize connection after communication lost
* Resolved issue with splash screen causing main form focus lost
* Improved ECU autodetection routine

### Release 0.5 (27.08.2011)
+ Communication Error Handling
* Corrected a bug causing parameter refersh rate was reduced to 1/3
* Compatible mode added (actualy it should be no-delay mode but this became the default mode while compatible mode adds 4ms wait between receiving response and sending next request).

### Release 0.4 (25.08.2011)
* Minor UI improvements
+ Connection initialisation cancelling

### Release 0.3 (24.08.2011)
+ Dynamic log recording to CSV
+ Live Data Graph
+ Lambda Voltage on (some) IAW-18FD

### Release 0.2 (23.08.2011)
+ LOG is now functional

### Release 0.1 (22.08.2011)
* First public release
