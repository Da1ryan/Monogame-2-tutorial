using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_2_tutorial
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectangleTexture;
        Texture2D circleTexture;
        SpriteFont titleFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 500; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            titleFont = Content.Load<SpriteFont>("Title");
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
            _spriteBatch.Begin();

            
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 0, 3000, 3000), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(500, 20, 300, 300), Color.Gold);
            _spriteBatch.Draw(circleTexture, new Rectangle(100, 20, 300, 300), Color.Blue);
            _spriteBatch.Draw(circleTexture, new Rectangle(550, 75, 100, 100), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(120, 175, 100, 100), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(250, 400, 200, 100), Color.DarkRed);
            _spriteBatch.DrawString(titleFont, "Blurp!?", new Vector2(190, 435), Color.SeaShell);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}