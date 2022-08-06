int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int time = 0;
int count = 0;
int friendNumber = 2;

while (distance > 10)
{
    if (friendNumber == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friendNumber = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friendNumber = 1;
    }
    count++;
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
}
Console.Write("Собака пробежит " + count + " раз.");
