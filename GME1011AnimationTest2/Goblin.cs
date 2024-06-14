using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GME1011AnimationTest2
{
    internal class Goblin
    {
        private Texture2D _attackStrip;

        private int _currentSpriteFrame;
        private int _numAttackFrames;
        private int _stripHeight, _frameWidth;
        private int _x, _y;
        private Random _rng;

        public Goblin(Texture2D attackStrip, int numFrames, int x, int y)
        { 
            _attackStrip = attackStrip;
            _numAttackFrames = numFrames;

            _stripHeight = _attackStrip.Height;
            _frameWidth = _attackStrip.Width / _numAttackFrames;

            _x = x; 
            _y = y;

            _rng = new Random();
            _currentSpriteFrame = _rng.Next(0, _numAttackFrames);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, null, SamplerState.PointClamp, null, null);
            //spriteBatch.Draw(_attackStrip, new Vector2(10, 10), Color.White);

            //public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)

            spriteBatch.Draw(

                _attackStrip,   //spritesheet or strip
                new Vector2(_x, _y),       //where on the screen
                new Rectangle(_currentSpriteFrame * _frameWidth, 0, _frameWidth, _stripHeight),  //this is the magic!!! what part of the sheet/strip to cut and display
                Color.White,
                0f,
                new Vector2(0, 0),
                3f,
                SpriteEffects.None,
                0);

            _currentSpriteFrame++;
            if(_currentSpriteFrame >= _numAttackFrames)
            {
                _currentSpriteFrame = 0;
            }

            spriteBatch.End();
        }
    }
}
