# IOT 4-DOF ROBOT CONTROL USING ADAFRUIT AND UNITY
# 1. INTRODUCTION OF PROJECT
  Our project will create the Unity application to control the 4-DOF robot postion by controlling the rotation of each motor. We create the GUI to input the angle of motors on Unity, MQTT will read the values and send to AdaFruit. AdaFruit will send those values to ESP8266 through MQTT. Motors can be controlled by PWM signal from ESP8266 module.
# 2. PROGRAM ESP8266 TO CONTROL 4 DOF ROBOT
1. Install Arduino IDE and AdaFruit IO library
2. Use AdaFruit IO library to read data to control the robot
3. Change IO USERNAME, IO KEY of AdaFruit and WIFI in config.h
4. Run the program and should receive the message like this figure in Serial
5.  Wiring the 4 Servo motors to Esp8266 using breadboard
