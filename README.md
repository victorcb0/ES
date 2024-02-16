# ES (Embedded Systems)
Embedded systems are computer systems specialized for specific tasks, integrated in the devices around us. Arduino is an open-source development platform commonly used for rapid prototyping in this field. In the presented labs, you explore Arduino and learn to interact with hardware components and program microcontrollers for various practical applications.

## Laboratory 1
After going through the examples in this lab, create the following assembly and using the Arduino IDE programming environment write the source code. For functionality testing the source code will be uploaded to the Arduino UNO.

Components:
- Arduino UNO
- 2 Temperature sensors
- Button
- 1 LED
- Connecting wires
- 1 LCD

If the user presses the button once, the LED will light up, and if he presses it twice, the value read from the sensors will be displayed on the Serial Monitor.

## Laboratory 2
Using the examples presented in this lab, the following assembly will be created and using the Arduino IDE the source code will be written and uploaded to the Arduino from the simulator to verify functionality.

Components:
- Arduino UNO
- Temperature sensor
- Button
- 3 LEDs
- Connecting wires

When the development board is powered, the red LED will light up, and when the user presses the button the following actions will happen:
- The green LED turns on and the red LED turns off
- The system will measure the temperature
- 4 scenarios will be defined for temperature intervals, for each interval the yellow/blue LED will have a different intensity.
- Temperature will be displayed on Serial Monitor

If the user presses twice, the system will shut down, the red LED will turn on, and the green LED will turn off.

A Word document will be created with the following information:
- The first page will contain the name of the student
- The second and third pages will contain:
  - Exercise requirements
  - A figure made with the Arduino simulator
  - The source code, there will also be comments in the code

---
***Solution:***

The architecture of the created system:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%202/Arhitectura%20Arduino.png)

## Laboratory 3
Components:
- Arduino Uno
- 2 RGB LEDs or 4 LEDs of different colors (for exterior and interior)
- 2 Temperature sensors
- 1 Button

Requirement

Arduino assembly:
- When the system is powered from the USB port and the user will press the button (interrupt will be used), the system will start and the following actions will be performed:
  - Will measure the temperature outside the greenhouse and compare it with the normal values:
    - If the readings are normal then the green color of the outdoor RGB LED will light up
    - If the readings are not normal then the blue color of the outdoor RGB LED will light up if it is too cold or the red color if it is too hot
  - Will measure the temperature inside the greenhouse and compare with normal values:
    - If the readings are normal then the green color of the indoor RGB LED will light up
    - If the readings are not normal then the blue color of the indoor RGB LED will light up if it is too cold or the red color if it is too hot.

## Laboratory 4
Components:
- Arduino Uno
- 2 Leds
- 1 LCD
- 1 Servo motor
- 1 Speaker
- 3 Buttons

Requirement

When power is applied to the system the red LED will light up.

When the first button is pressed the system will do the following:
- The green LED will light up
- A startup message will be displayed on the LCD
- When the second button is pressed, the servo motor will move to the left, and the speaker will play a certain song
- When the third button is pressed, the servomotor will move to the right, and the speaker will play another song

A Word document will be created with the following information:
- The first page will contain the name of the student
- The second and third pages will contain:
  - Exercise requirements
  - A figure made with the Arduino simulator
  - The source code, there will also be comments in the code
  - The link to the system on Tinkercad

---
***Solution:***

The architecture of the created system:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%204/Proiect%20Arduino.jpg)

System architecture created in Tinkercad:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%204/Arhitectura%20sistemului%20-%20Tinkercad.png)

## Laboratory 5
- To implement a traffic light for pedestrians, semaphorePietoni, using the already defined Traffic Light class. The traffic lights will synchronize so that when pedestrians are green, vehicles are red (pay attention to time lags).
- To implement a pedestrian traffic light speaker for blind people. It will emit a sound when the traffic light is red and another sound when the pedestrian traffic light is green.
- To implement a button for the pedestrian traffic lights. Once the button is pressed, the traffic light for cars will turn red, and the traffic light for pedestrians will turn green.

For vehicles the times will be:
- 4 Red seconds;
- 6 Seconds green;
- 2 Seconds yellow;

For pedestrians the times will be:
• 3 Seconds green;
• 9 Seconds red;

The timing diagram of the traffic lights are presented in the following table:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%205/Diagrama%20timpi.png)

## Laboratory 6
Components:
- Arduino Uno
- 2 RGB LEDs or 4 LEDs of different colors (for exterior and interior)
- 2 Temperature sensors
- 1 Button
- 1 Red LED

Requirement

Arduino Assembly:
- When the system is powered from the USB port and the user will press the button (interrupt will be used), the system will start and the following actions will be performed:
  - Will measure the temperature outside the greenhouse and compare it with the normal values:
    - If the readings are normal then the green color of the outdoor RGB LED will light up
    - If the readings are not normal then the blue color of the outdoor RGB LED will light up if it is too cold or the red color if it is too hot
  - Will measure the temperature inside the greenhouse and compare with normal values:
    - If the read values are normal then the red color of the indoor RGB LED will light up
    - If the readings are not normal then the indoor RGB LED will turn blue if it is too cold or red if it is too hot and the speaker will have a different sound for the two situations
  - When the system is started it will be displayed in Serial Monitor:
    - Outside temperature and humidity: value
    - Indoor temperature and humidity: value
  - When the system is turned off, it will be displayed in Serial Monitor: OFF
  - When the button is pressed a second time, the monitoring system will stop and the red LED will light up, and OFF will be displayed in the Serial Monitor.

Report

Team members:

1. Theme statement and real-world utility

2. Assembly components

3. Logical diagram and class diagram

4. Source code in C++ language
- the code will have to contain comments

5. Photos during the laboratory

6. C# application interface and explanations

7. Screenshots of the database tables

8. Graphs/reports

9. Test plan

10. Conclusions

11. Archived Arduino Source Codes and C# Application

---
***Solution:***

Logical scheme and class diagram:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%206/Schema%20logica%20si%20diagrama%20de%20clase.png)

System architecture:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%206/Arhitectura%20sistemului.png)

C# application interface:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%206/Interfata%20din%20aplicatia%20C%23.png)

The tables in the database:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%206/Tabelele%20din%20baza%20de%20date.png)

Graphs/reports:

![picture alt](https://github.com/victorcb0/ES/blob/main/Laborator%206/Grafice%20si%20rapoarte.png)
