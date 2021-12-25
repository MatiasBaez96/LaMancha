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
            foreach (Actor platform in platformList)
            {
                Player player1 = (Player)_player1;
                Player player2 = (Player)_player2;     
                if (_physicsService.IsCollision(player1,platform))
                {
                    player1.StopGravity();
                }
                
                if (_physicsService.IsCollision(player2, platform))
                {
                    player2.StopGravity();
                }
                
            }
        }
    }
}