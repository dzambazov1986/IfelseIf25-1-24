int timeLap1 = int.Parse(Console.ReadLine());
int timeLap2 =  int.Parse(Console.ReadLine());  
int timeLap3 =  int.Parse(Console.ReadLine());  

int totalSeconds = timeLap1 + timeLap2 + timeLap3;

int timeMinutes = totalSeconds / 60;    
int timeSeconds = totalSeconds % 60;
Console.WriteLine($"{timeMinutes}:{timeSeconds:D2}");