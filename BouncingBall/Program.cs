using BouncingBall;

var ball = new Ball(15, 1, 1, 1, 5);
var ball2 = new Ball(15, 3, 1, 1, 11);
Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    ball.Show();
    ball2.Show(); 
    ball.AdjustAfterCollision(ball2);
    ball.Move();
    ball2.Move();
    Thread.Sleep(50);
}