// Задача про собаку
int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

int fullTime = 0;
int fullDistancedog = 0;
int fullDistanceFirstFriend = 0;
int fullDistanceSecondFriend = 0;

while (distance > 10)
{
    if(friend ==1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
    fullTime += time;
}
fullDistancedog = fullTime * dogSpeed;
fullDistanceFirstFriend = fullTime * firstFriendSpeed;
fullDistanceSecondFriend = fullTime *secondFriendSpeed;

Console.WriteLine("Друзья шли навстречу друг другу " + fullTime / 60 + 
" минут, за это время собака сбегала от одного друга к другому " + count + " раз, и пробежала в сумме " +fullDistancedog +
" метров. Первый друг прошел за это время " + fullDistanceFirstFriend + " метров, а второй друг прошел " + fullDistanceSecondFriend + " метров");
