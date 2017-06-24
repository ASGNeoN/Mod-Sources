using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace Autohammer
{
    public class AutohammerPlayer : ModPlayer
    {
        public override void PreUpdate()
        {
            UIParameters.oldState = UIParameters.newState;
            UIParameters.newState = Keyboard.GetState();
            UIParameters.lastMouseState = UIParameters.mouseState;
            UIParameters.mouseState = Mouse.GetState();
        }
    }
}
