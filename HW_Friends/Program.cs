using System;

class People {
static void Main() {

Console.Clear();

double count, distance, firstFriendSpeed, secondFriendSpeed, 
       dogSpeed, time;

int friend;

count = 0;
distance = 5555; 
firstFriendSpeed = 1;
secondFriendSpeed = 2; 
dogSpeed = 5;
friend = 1;
time = 0;

while (distance > 10) {

    if (friend == 1)
    
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }

    else
    
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

distance = distance-(firstFriendSpeed+secondFriendSpeed)*time;
count++;

}
    
    if (count % 10 == 2 & count != 12 ^ 
        count % 10 == 3 & count != 13 ^
        count % 10 == 4 & count != 14)
    
    {
    Console.Write($"Собака пробежит {count} раза");
    }
    
    else 
    
    {
    Console.Write($"Собака пробежит {count} раз");
    }

  }
}