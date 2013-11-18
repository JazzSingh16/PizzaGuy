using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RealPacman
{
    enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    class Pacman : Sprite
    {
        public Direction direction = Direction.RIGHT;
        public Vector2 target;
        public float speed = 70f;

        public Pacman(
            Vector2 location,
            Texture2D texture,
            Rectangle initialFrame,
            Vector2 velocity) :

            base(location, texture, initialFrame, velocity)
        {
            target = location + new Vector2(32, 0);
            velocity = new Vector2(speed, 0);
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Right))
            {
                //Rotation = 0;
                //Velocity = new Vector2(200, 0);
                direction = Direction.RIGHT;
            }

            if (keyboard.IsKeyDown(Keys.Down))
            {
                //Rotation = MathHelper.PiOver2;
                //Velocity = new Vector2(0, 200);
                direction = Direction.DOWN;
            }

            if (keyboard.IsKeyDown(Keys.Left))
            {
                //Rotation = MathHelper.Pi;
                //Velocity = new Vector2(-200, 0);
                direction = Direction.LEFT;
            }

            if (keyboard.IsKeyDown(Keys.Up))
            {
                //Rotation = -MathHelper.PiOver2;
                //Velocity = new Vector2(0, -200);
                direction = Direction.UP;
            }

            if (velocity.X > 0 && location.X >= target.X ||
                velocity.X < 0 && location.X <= target.X ||
                velocity.Y > 0 && location.Y >= target.Y ||
                velocity.Y < 0 && location.Y <= target.Y )
            {
                location = target;
                
                //velocity = Vector2.Zero;

                if (direction == Direction.RIGHT)
                {
                    target = location + new Vector2(32, 0);
                    Rotation = 0;
                    Velocity = new Vector2(speed, 0);
                }

                if (direction == Direction.LEFT)
                {
                    target = location + new Vector2(-32, 0);
                    Rotation = MathHelper.Pi;
                    Velocity = new Vector2(speed, 0);
                }

                if (direction == Direction.UP) =
                {
                    target = location + new Vector2(0, -32);
                    Rotation = -MathHelper.PiOver2;
                    Velocity = new Vector2(0, speed);
                }

                if (direction == Direction.UP)
                {
                    target = location + new Vector2(0, 32);
                    
            }

            base.Update(gameTime);
        }

      

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

    }
}