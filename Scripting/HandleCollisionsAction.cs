using System.Collections.Generic;
using LaMancha.Casting;
using LaMancha.Services;
using System;


namespace LaMancha.Scripting
{
    /// <summary>
    /// An action to manage the collision between the ball and the bricks or paddle.
    /// </summary>
    public class HandleCollisionsAction : Action
    
    {
        PhysicsService _physicsService = new PhysicsService();
        //AudioService _audioService = new AudioService();
        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }   
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> platformList = cast["platform"];
            Actor player1 = cast["player"][0];
            Actor player2 = cast["player2"][0];
            //List<Actor> toRemove = new List<Actor>();
            foreach (Actor actor in platformList)
            {
                int x = actor.GetX();
                int y = actor.GetY();
                int x_player1 = player1.GetX();
                int y_player1 = player1.GetY();
                
                
                if (_physicsService.IsCollision(player1, actor))
                {
                    Console.WriteLine("P1");
                }
            }
            foreach (Actor actor in platformList)
            {
                int x = actor.GetX();
                int y = actor.GetY();
                int x_player2 = player2.GetX();
                int y_player2 = player2.GetY();
                
                if (_physicsService.IsCollision(player2, actor))
                {
                    
                }
            }
        }
    }
}