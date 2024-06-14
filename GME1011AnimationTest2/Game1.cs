using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GME1011AnimationTest2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Goblin _myGoblin1, _myGoblin2, _myGoblin3;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _myGoblin1 = new Goblin(Content.Load<Texture2D>("goblinAttackStrip"), 9, 0, 100);
            _myGoblin2 = new Goblin(Content.Load<Texture2D>("goblinAttackStrip"), 9, 250, 100);
            _myGoblin3 = new Goblin(Content.Load<Texture2D>("goblinAttackStrip"), 9, 500, 100);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _myGoblin1.Draw(_spriteBatch);
            _myGoblin2.Draw(_spriteBatch);
            _myGoblin3.Draw(_spriteBatch);

            base.Draw(gameTime);
        }
    }
}
