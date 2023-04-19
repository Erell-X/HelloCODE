Console.Clear();

double count, distance, firstFriendSpeed, secondFriendSpeed, 
       dogSpeed, time;

int friend;

count = 0;
distance = 100; 
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

Console.Write($"Собака пробежит {count} раз");