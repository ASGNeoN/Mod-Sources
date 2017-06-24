using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.UI;

namespace Autohammer
{
    public class ExampleUI
    {
        public UIObject obj; //This is the main UIObject, that all of the UI will be added to.
        public Vector2 distanceVector; //You will want to have this on any UI that you want to be able to move around your screen.
        public bool canMove = true; //This too!
        public ExampleUI()
        {
            //This line is used a lot, make sure to change UIParameters.Autohammer to your mod's name, otherwise this won't work!
            Mod mod = ModLoader.GetMod(UIParameters.Autohammer);

            /*

            This is the base UIObject, that all of my other UIObjects' positions will be based off of.

            == UIPanel Constructor Parameters ==

            Vector2 pos: 
             The position of the panel. I tend to use the middle of the screen, to do so, use the code below, where you subtract
             half of the width from the screenWidth divided in two, and the same for the screenHeight.

            Vector2 size:
             This is the width and height of the panel. This should be double what you've just subtracted for the position, if of course
             that is what you are creating :P

            UIObject parent:
             This is the parent object. If you are using this as your background, then you should leave this as null.

            Texture2D fullTexture:
             This is the texture used if you would like to use a full sized texture as your panel's texture. An example of this can be seen
             in Autohammer (look at the screenshots for jExo): http://forums.terraria.org/index.php?threads/neal-boffins-mods.47412/

            */

            UIPanel background = new UIPanel(new Vector2(Main.screenWidth / 2 - 150, Main.screenHeight / 2 - 50), new Vector2(215, 170), null);

            /*

            The first UIObject I am going to add to the background is an Item slot!

            == UIItemSlot Constructor Parameters ==
            
            Vector2 pos: 
             Where it will appear on screen. If you set a parent (in my case, background) then this is where it will 
             appear from the top left of the parent.
             - If you want the UI to appear above an NPC for example, you would need to get the NPCs position:
             npc.position
             - And then subtract Main.screenPosition from it:
             npc.position - Main.screenPosition
             - And have your object there. You should do this for the base object rather than each individual one however. (simpler) 

            UIObject parent: 
             The parent object. As explained before, this is what changes the position. If set to null, then it 
             will simply appear at the position set on the screen.
             
            UIItemSlot.Condition con: 
             This is a delegate bool, that returns true or false depending on whether the item in the mouse
             can be placed into the item slot or not. 
             - To form this, you would type:
                 delegate(Item item) 
                 { 
                     if (item.type == ItemID.IronBroadsword)
                     {
                         return true;
                     }
                     return false;
                 }
             - As you might be able to guess, only Iron Broadswords can be placed into this item slot.
             
            UIItemSlot.DrawInItemSlot db: This is the delegate for drawing the background of the item. Sorry for the bad naming.
             If null, the default inventory background sprite is drawn at a size of 52 x 52.
             - Again, this a delegate formed like so:
             delegate(SpriteBatch spriteBatch, UIItemSlot itemSlot) { //code } *
             
            UIItemSlot.DrawInItemSlot di: This is the delegate for drawing the item. I recommend that you leave this as null.
             If null, it draws the item in the middle of the Item Slot. Hence why I said you may want  to leave it null, for the 
             sake of simplifying your day/night :)
             Form the delegate the same as above! *

            UIItemSlot.DrawInItemSlot pdi: This is the delegate for doing things after the item is drawn. This can be text, textures,
             etc.
             The delegate is again, formed the same as above! *

            bool drawAsNormalItemSlot: This bool decides whether or not the item slot is drawn like the same ones in your inventory.
             This means that if it draws on your screen when not in your inventory, it will scale when you open your inventory. There 
             is no practical fix to this.

            int contextForItemSlot: This int is the context to be used in ItemSlot.Draw. You can explore what each of these contexts
             do in the source code for Terraria, I won't explain them (though the default is for inventory).

             */

            UIItemSlot itemSlot = new UIItemSlot(new Vector2(15, 15), background,
            delegate(Item item)
            {
                return false;
            });
			
			UIItemSlot itemSlot2 = new UIItemSlot(new Vector2(80, 15), background, 
			delegate(Item item)
            {
                return false;
            });
			
			UIItemSlot itemSlot3 = new UIItemSlot(new Vector2(145, 15), background, 
			delegate(Item item)
            {
                return false;
            });
			
			UIItemSlot itemSlot4 = new UIItemSlot(new Vector2(15, 80), background,
            delegate(Item item)
            {
                return false;
            });
			
			UIItemSlot itemSlot5 = new UIItemSlot(new Vector2(80, 80), background, 
			delegate(Item item)
            {
                return false;
            });
			
			UIItemSlot itemSlot6 = new UIItemSlot(new Vector2(145, 80), background, 
			delegate(Item item)
            {
                return false;
            });
			/*
            Next up is the button! This button will simply close the window.

            == UIButton Constructor Parameters ==

            Vector2 pos:
             The same as every other, the position of the button. If parent is not null, then it will be based off 
             of the position of the parent.

            Vector2 size:
             Again, the same as every other, the size of the button.

            Action function:
             This delegate is what happens when the button is pressed.
             - The delegate is formed like so:
             delegate() { //code }

            UIObject parent:
             The parent of the button. The position is based off of the parent object's position.

            Texture2D texture:
             The texture of the button. If the texture is null, then a rectangle with a border of width 1 is drawn.

            */

            UIButton closeButton = new UIButton(new Vector2(195, 5), new Vector2(15, 15), delegate()
            {
                Autohammer.ExampleUIOpen = false;
            }, background);

			UIButton hammerToggle = new UIButton(new Vector2(95, 145), new Vector2(15, 15), delegate()
            {
                Autohammer.ExampleUIOpen = false;
            }, background);
            /*

            The next object is UITextBox! This is one is pretty simple, as everything else is handled in the textbox!
            You can create a button to interact with this textbox too, which is pretty sweet :D

            == UITextBox Constructor Parameters ==

            Vector2 pos:
             Blah blah you know what this is.

            Vector2 size:
             Again, you know what this is. :D

            SpriteFont font:
             The font that is displayed on the textbox.

            UIObject parent:
             Again, you know what this one does if you read all of the above.

            This one is much simpler. :P

            */

            /*

            Finally, the last object to add is a label!
            
            == UILabel Constructor Parameters ==

            Vector2 pos:
             The same as every other. Getting sick of writing this now D:

            SpriteFont font:
             The font to use. You can use the fonts built into Terraria or use your own, though using your own is more complicated.
             I will make a tutorial soon about how to do this (it may already be done, you should check :P).

            Vector2 size:
             The size of the label. The height doesn't really make a difference, but the width does. The text is wrapped to fit the 
             width, sort of like the text formatting "Justified" :)

            Color color: 
             I can't decide how to spell colour. I switch between both color and colour. Forgive me.
             This is the colour of the text. Not to be confused with the borderColour.
            
            Color borderColour:
             This is the colour of the outline around the text. This can be set to transparent if you don't want a border.

            UILabel.GetText updateText:
             This delegate is what decides what the label is. It requires you to return a string.
             - The delegate is formed like so:
             delegate() { //return "string"; }
             You can use if statements etc. to decide what the label is! :D

            UIObject parent:
             Again, the parent of the object. :|

            */

            UILabel labelOn = new UILabel(new Vector2(53, 140), Main.fontMouseText, new Vector2(430, 50), new Color(255, 255, 255), new Color(15, 15, 15), delegate()
            {
                return "On";
                //I recommend that you do labels last, so that you can interact with the rest of your UI elements! :D  
            }, background);
			UILabel labelOff = new UILabel(new Vector2(120, 143), Main.fontMouseText, new Vector2(430, 50), new Color(255, 255, 255), new Color(15, 15, 15), delegate()
            {
                return "Off";
            }, background);

            //Add to the children of the base panel object, in my case, background. In order from top to bottom, the UIObjects will be drawn!
            background.children.Add(itemSlot); //drawn first
			background.children.Add(itemSlot2);
			background.children.Add(itemSlot3);
			background.children.Add(itemSlot4);
			background.children.Add(itemSlot5);
			background.children.Add(itemSlot6);
			background.children.Add(hammerToggle);
            background.children.Add(closeButton);
            background.children.Add(labelOn);
			background.children.Add(labelOff);			//drawn last

            this.obj = background; //The UIPanel we created is now set as this windows main object. This will be used in the drawing.
        }
        public void Draw(SpriteBatch sb)
        {
            this.DoMovement(); //Remove this if you don't want your UI to be able to be moved by the player.
            this.obj.Draw(sb); //This is what draws the object. The way the drawing for any object is simple. It draws the UIObject, then any
            //children the UIObject has. Pretty simple.
        }
        public void DoMovement() //This code simply allows you to drag around the window :)
        {
            if (new Rectangle(UIParameters.lastMouseState.X, UIParameters.lastMouseState.Y, 1, 1).Intersects(this.obj.rectangle) && new Rectangle(UIParameters.mouseState.X, UIParameters.mouseState.Y, 1, 1).Intersects(this.obj.rectangle) && UIParameters.NoChildrenIntersect(this.obj, new Rectangle(UIParameters.mouseState.X, UIParameters.mouseState.Y, 1, 1)))
            {
                if (UIParameters.lastMouseState.LeftButton == ButtonState.Released && UIParameters.mouseState.LeftButton == ButtonState.Pressed)
                {
                    distanceVector = new Vector2(Main.mouseX, Main.mouseY) - this.obj.position;
                    canMove = true;
                }
            }
            if (UIParameters.lastMouseState.LeftButton == ButtonState.Pressed && UIParameters.mouseState.LeftButton == ButtonState.Pressed)
            {
                if (canMove) this.obj.position = new Vector2(Main.mouseX, Main.mouseY) - distanceVector;
            }
            if (UIParameters.mouseState.LeftButton == ButtonState.Released)
            {
                canMove = false;
            }
        }
    }
}
