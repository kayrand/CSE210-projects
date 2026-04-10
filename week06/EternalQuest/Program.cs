//Enhancement: I added a level system based on the person's score, when they earn more points, their level increases.

using System;

class Program
{
    static void Main(string[] args)
    {

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}