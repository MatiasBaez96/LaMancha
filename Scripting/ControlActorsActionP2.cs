using System.Collections.Generic;
using LaMancha.Casting;
using LaMancha.Services;

namespace LaMancha.Scripting
{
    /// <summary>
    /// An action to control the horizontal direction of the hero.
    /// </summary>
    public class ControlActorsActionP2 : Action
    {
        InputServiceP2 _inputServiceP2;

        public ControlActorsActionP2(InputServiceP2 inputServiceP2)
        {
            _inputServiceP2 = inputServiceP2;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point directionP2 = _inputServiceP2.GetDirection();
            
            Actor player2 = cast["player2"][0];

            Point velocityP2 = directionP2.Scale(Constants.PLAYER_SPEED);
            
            player2.SetVelocity(velocityP2);
        }
    }
}