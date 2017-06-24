using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Autohammer
{
    public class Autohammer : Mod
    {
        public static bool ExampleUIOpen = false;
        public static ExampleUI ExampleUI;
        public Autohammer()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        public override void PostDrawInterface(SpriteBatch spriteBatch)
        {
            if (Autohammer.ExampleUIOpen) //If the UI is supposed to be open
            {
                if (!Main.playerInventory) //If the player is not in their inventory
                {
                    Autohammer.ExampleUIOpen = false; //close the UI window.
                }
                else
                {
                    if (Autohammer.ExampleUI == null)
                    {
                        Autohammer.ExampleUI = new ExampleUI(); //This just creates the UI if it is null.
                    }
                    Autohammer.ExampleUI.Draw(spriteBatch); //Draw the UI
                }
            }
            base.PostDrawInterface(spriteBatch);
        }
    }
}
