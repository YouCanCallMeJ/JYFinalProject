﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CastleDefense
{
    public abstract class GameScene : DrawableGameComponent
    {
        public SpriteBatch spriteBatch;
        public Texture2D texture2D;

        public List<GameComponent> SceneComponents { get; set; }

        public virtual void show()
        {
            this.Visible = true;
            this.Enabled = true;
        }
        public virtual void hide()
        {
            this.Visible = false;
            this.Enabled = false;
        }

        public GameScene(Game game) : base(game)
        {
            SceneComponents = new List<GameComponent>();
            hide();
        }
        public override void Draw(GameTime gameTime)
        {
            DrawableGameComponent comp = null;
            foreach (GameComponent item in SceneComponents)
            {
                if (item is DrawableGameComponent)
                {
                    comp = (DrawableGameComponent)item;
                    if (comp.Visible)
                    {
                        comp.Draw(gameTime);
                    }
                }
            }


            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            foreach (GameComponent item in SceneComponents)
            {
                if (item.Enabled)
                {
                    item.Update(gameTime);
                }
            }

            base.Update(gameTime);
        }
    }
}
