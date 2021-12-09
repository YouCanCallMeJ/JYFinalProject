﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace CastleDefense
{
    abstract class Entity
    {
		protected Texture2D image;
		protected Rectangle? srcRectangle = null;
		protected Color color = Color.White;

		public Vector2 Position, Velocity, Origin;
		public float Orientation;
		public float Radius = 20;   // used for circular collision detection
		public bool IsExpired;      // true if the entity was destroyed and should be deleted.

		public Vector2 Size
		{
			get
			{
				return image == null ? Vector2.Zero : new Vector2(image.Width, image.Height);
			}
		}

		public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, Position, srcRectangle, color, Orientation, Size / 2f, 1f, 0, 0);
        }
    }
}
