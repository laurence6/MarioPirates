﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MarioPirates
{
    internal abstract class GameObject
    {
        private Vector2 location;
        public Vector2 Location
        {
            get => IsLocationAbsolute ? location + Camera.Ins.Offset : location;
            set => location = IsLocationAbsolute ? value - Camera.Ins.Offset : value;
        }
        public bool IsLocationAbsolute { get; set; } = false;

        public Point Size { get; set; }

        public Sprite Sprite { get; set; }

        protected GameObject(float locX, float locY, int sizeX, int sizeY)
        {
            Location = new Vector2(locX, locY);
            Size = new Point(sizeX, sizeY);
        }

        public virtual void Update(float dt)
        {
            Sprite.Update(dt);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, new Rectangle((int)Location.X, (int)Location.Y, Size.X, Size.Y));
        }
    }
}
