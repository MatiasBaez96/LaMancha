using System;
using System.Collections.Generic;
using LaMancha.Services;
using LaMancha.Casting;
using LaMancha.Scripting;
using Raylib_cs;


namespace LaMancha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Bricks
            cast["player"] = new List<Actor>();
            Player player1 = new Player(Constants.PLAYER_HEIGHT, Constants.PLAYER_WIDTH, Constants.PLAYER_X, Constants.PLAYER_Y);
            cast["player"].Add(player1);

            // TODO: Add your bricks here

            // The Ball (or balls if desired)
            cast["player2"] = new List<Actor>();

            // TODO: Add your ball here

            // The paddle
            cast["platfrm"] = new List<Actor>();

            // TODO: Add your paddle here

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService); //conector que recibe un "objeto del tipo OutputSerivice"
            script["output"].Add(drawActorsAction);

            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["update"].Add(controlActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "La Mancha", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
        
    }
}
