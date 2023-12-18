void setup() {
  Serial.begin(9600);
}

void loop() {
  int humidity = analogRead(A0); // A0 핀에서 습도 값을 읽어옵니다.
  //int light = analogRead(A1);    // A1 핀에서 조도 값을 읽어옵니다.

  // 습도 값을 0~100 범위로 변환합니다.
  int humidityPercent = map(humidity, 1023, 300, 0, 100);

  // 조도 값을 0~100 범위로 변환합니다.
  //int lightPercent = map(light, 0, 1023, 0, 100);

  //Serial.print("습도(%): ");
  Serial.println(humidityPercent);
  //Serial.print(" ");
  //Serial.print("\t조도(%): ");
  //Serial.println(lightPercent);

  delay(1000);
}