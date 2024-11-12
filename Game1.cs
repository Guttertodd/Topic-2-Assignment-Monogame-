using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_2_Assignment__Monogame_
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circleTexture, rectTexture;
        Rectangle circleRect;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            circleRect = new Rectangle(10,100,100,50);   
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            circleTexture = Content.Load<Texture2D>("circle");
            rectTexture = Content.Load<Texture2D>("rectangle");
            
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
            GraphicsDevice.Clear(Color.WhiteSmoke);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

           
            _spriteBatch.Draw(circleTexture, new Rectangle(200, 75, 375, 375), Color.Yellow);
            _spriteBatch.Draw(rectTexture, new Rectangle(300, 175, 55, 55), Color.Black);
            _spriteBatch.Draw(rectTexture, new Rectangle(425, 175, 55, 55), Color.Black);
            _spriteBatch.Draw(rectTexture, new Rectangle(320, 300, 145, 50), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
