const int button = 2;

void setup() {
  pinMode(2, INPUT);
  pinMode(12, OUTPUT); //Direction of Motor
  pinMode(9, OUTPUT); //Brake of Motor
}

void loop() {
  if (button == HIGH) {
  //forward at full speed
  digitalWrite(12, HIGH); //Direction is set to forward
  digitalWrite(9, LOW); //Brakes are turned off
  analogWrite(3, 255); //Speed is set to maximum
  
  delay(3000); //delay for 3,000 miliseconds(3 seconds)
  
  digitalWrite(9, HIGH) //Turn on brakes for Motor
  
  delay(1,000) //delay for 1,000 miliseconds(1 second) before repeating the loop
  }
  
  else {
  digitalWrite(9, HIGH); //brake if button is not pressed
  }
}
