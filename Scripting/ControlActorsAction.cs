using System.Collections.Generic;
using LaMancha.Casting;
using LaMancha.Services;

namespace LaMancha.Scripting
{
    /// <summary>
    /// An action to control the horizontal direction of the hero.
    /// </summary>
    public class ControlActorsAction : Action
    {
        InputService _inputService;

        public ControlActorsAction(InputService inputService)
        {
            _inputService = inputService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point direction = _inputService.GetDirection();
            
            Actor player1 = cast["player"][0];

            Point velocity = direction.Scale(Constants.PADDLE_SPEED);
            player1.SetVelocity(velocity);
        }
    }
}