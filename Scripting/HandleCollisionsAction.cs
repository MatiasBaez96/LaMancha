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
            Actor _player1 = cast["player"][0];
            Actor _player2 = cast["player2"][0];
            //List<Actor> toRemove = new List<Actor>();
            foreach (Actor platform in platformList)
            {
                Player player1 = (Player)_player1;
                int x = platform.GetX();
                int y = platform.GetY();
                int x_player1 = _player1.GetX();
                int y_player1 = _player1.GetY();
                
                
                if (_physicsService.IsCollision(player1, platform))
                {
                    Console.WriteLine("P1");
                    player1.StopGravity();
                }
            }
            foreach (Actor platform in platformList)
            {
                Player player2 = (Player)_player2;
                int x = platform.GetX();
                int y = platform.GetY();
                int x_player2 = _player2.GetX();
                int y_player2 = _player2.GetY();
                
                if (_physicsService.IsCollision(player2, platform))
                {
                    player2.StopGravity();
                }
            }
        }
    }
}