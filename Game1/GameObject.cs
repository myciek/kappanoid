using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    
    public class GameObject
    {
        protected string textureName = "";
        protected Texture2D texture;
        protected Game game;
        public Vector2 position = Vector2.Zero;

        public GameObject(Game myGame)
        {
            game = myGame;
        }

        public virtual void LoadContent()
        {
            if (textureName != "")
            {
                texture = game.Content.Load <Texture2D> (textureName);
            }
        }

        public virtual void Update(float deltaTime)
        {
        }
    }



}
