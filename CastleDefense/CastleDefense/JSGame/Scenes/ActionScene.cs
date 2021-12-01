﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using CastleDefense;

namespace CastleDefense
{
    public class ActionScene : GameScene
    {
        private SpriteBatch spriteBatch;
        private MouseState oldMouseState;
        private KeyboardState oldKeyboardState;

        private SoundEffect arrowSound;


        public ActionScene(Game game) : base(game)
        {
            Game1 g = (Game1)game;
            spriteBatch = g._spriteBatch;

            arrowSound = g.Content.Load<SoundEffect>("sounds/shoot");

            Castle castle = new Castle(game);
            this.SceneComponents.Add(castle);

            Archer archer = new Archer(game);            
            this.SceneComponents.Add(archer);

            /* Enemy */
            Texture2D texEnemy1 = g.Content.Load<Texture2D>("images/Enemy/01Wolf");
            Enemy e1 = new Enemy(game, texEnemy1);


            Texture2D texEnemy2 = g.Content.Load<Texture2D>("images/Enemy/02RedBat");
            Enemy e2 = new Enemy(game, texEnemy2);
            this.SceneComponents.Add(e2);
            this.SceneComponents.Add(e1);
        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }
    }
}