namespace SyobonAction.Game
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Audio;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Resources
    {
        protected SpriteFont font;

        protected GraphicDerivitation[][] grap;

        protected Texture2D[] mGrap;

        protected SoundEffectInstance music;

        protected SoundEffect[] sounds;

        public void ChangeMusic(int cue)
        {
            if (this.music != null)
            {
                this.music.Stop();
            }

            this.music = this.sounds[cue].CreateInstance();
        }

        public void Initialize(ContentManager Content)
        {
            int x1, t, i, j;

            this.font = Content.Load<SpriteFont>("System");

            this.sounds = new SoundEffect[22];

            this.sounds[0] = Content.Load<SoundEffect>(@"SE\jump");
            this.sounds[1] = Content.Load<SoundEffect>(@"SE\brockbreak");
            this.sounds[2] = Content.Load<SoundEffect>(@"SE\coin");
            this.sounds[3] = Content.Load<SoundEffect>(@"SE\humi");
            this.sounds[4] = Content.Load<SoundEffect>(@"SE\koura");
            this.sounds[5] = Content.Load<SoundEffect>(@"SE\dokan");
            this.sounds[6] = Content.Load<SoundEffect>(@"SE\brockkinoko");
            this.sounds[7] = Content.Load<SoundEffect>(@"SE\powerup");
            this.sounds[8] = Content.Load<SoundEffect>(@"SE\kirra");
            this.sounds[9] = Content.Load<SoundEffect>(@"SE\goal");
            this.sounds[10] = Content.Load<SoundEffect>(@"SE\death");
            this.sounds[11] = Content.Load<SoundEffect>(@"SE\Pswitch");
            this.sounds[12] = Content.Load<SoundEffect>(@"SE\jumpBlock");
            this.sounds[13] = Content.Load<SoundEffect>(@"SE\hintBlock");
            this.sounds[14] = Content.Load<SoundEffect>(@"SE\4-clear");
            this.sounds[15] = Content.Load<SoundEffect>(@"SE\allclear");
            this.sounds[16] = Content.Load<SoundEffect>(@"SE\tekifire");

            this.sounds[17] = Content.Load<SoundEffect>(@"BGM\titerman");
            this.sounds[18] = Content.Load<SoundEffect>(@"BGM\spelunk");
            this.sounds[19] = Content.Load<SoundEffect>(@"BGM\star4");
            this.sounds[20] = Content.Load<SoundEffect>(@"BGM\makaimura");
            this.sounds[21] = Content.Load<SoundEffect>(@"BGM\puyo");

            this.mGrap = new Texture2D[51];
            this.mGrap[0] = Content.Load<Texture2D>(@"res\player");
            this.mGrap[1] = Content.Load<Texture2D>(@"res\brock");
            this.mGrap[2] = Content.Load<Texture2D>(@"res\item");
            this.mGrap[3] = Content.Load<Texture2D>(@"res\teki");
            this.mGrap[4] = Content.Load<Texture2D>(@"res\haikei");
            this.mGrap[5] = Content.Load<Texture2D>(@"res\brock2");
            this.mGrap[6] = Content.Load<Texture2D>(@"res\omake");
            this.mGrap[7] = Content.Load<Texture2D>(@"res\omake2");
            this.mGrap[30] = Content.Load<Texture2D>(@"res\syobon3");

            this.grap = new GraphicDerivitation[161][];
            for (i = 0; i < 161; i++)
            {
                this.grap[i] = new GraphicDerivitation[8];
                for (j = 0; j < 8; j++)
                {
                    this.grap[i][j] = new GraphicDerivitation();
                }
            }

            this.grap[40][0].setValues(0, 0, 30, 36, 0);
            this.grap[0][0].setValues(31 * 4, 0, 30, 36, 0);
            this.grap[1][0].setValues(31 * 1, 0, 30, 36, 0);
            this.grap[2][0].setValues(31 * 2, 0, 30, 36, 0);
            this.grap[3][0].setValues(31 * 3, 0, 30, 36, 0);
            this.grap[41][0].setValues(50, 0, 51, 73, 6);

            x1 = 1;
            for (t = 0; t <= 6; t++)
            {
                this.grap[t][x1].setValues(33 * t, 0, 30, 30, x1);
                this.grap[t + 30][x1].setValues(33 * t, 33, 30, 30, x1);
                this.grap[t + 60][x1].setValues(33 * t, 66, 30, 30, x1);
            }

            this.grap[8][x1].setValues(33 * 7, 0, 30, 30, x1);
            this.grap[16][x1].setValues(33 * 6, 0, 24, 27, 2);

            x1 = 5;
            for (t = 0; t <= 6; t++)
            {
                this.grap[t][x1].setValues(33 * t, 0, 30, 30, x1);
            }

            this.grap[10][5].setValues(33 * 1, 33, 30, 30, x1);
            this.grap[11][5].setValues(33 * 2, 33, 30, 30, x1);
            this.grap[12][5].setValues(33 * 0, 66, 30, 30, x1);
            this.grap[13][5].setValues(33 * 1, 66, 30, 30, x1);
            this.grap[14][5].setValues(33 * 2, 66, 30, 30, x1);

            x1 = 2;
            for (t = 0; t <= 5; t++)
            {
                this.grap[t][x1].setValues(33 * t, 0, 30, 30, x1);
            }

            x1 = 3;
            this.grap[0][x1].setValues(33 * 0, 0, 30, 30, x1);
            this.grap[1][x1].setValues(33 * 1, 0, 30, 43, x1);
            this.grap[2][x1].setValues(33 * 2, 0, 30, 30, x1);
            this.grap[3][x1].setValues(33 * 3, 0, 30, 44, x1);
            this.grap[4][x1].setValues(33 * 4, 0, 33, 35, x1);
            this.grap[5][x1].setValues(0, 0, 37, 55, 7);
            this.grap[6][x1].setValues(38 * 2, 0, 36, 50, 7);
            this.grap[150][x1].setValues(38 * 2 + 37 * 2, 0, 36, 50, 7);
            this.grap[7][x1].setValues(33 * 6 + 1, 0, 32, 32, x1);
            this.grap[8][x1].setValues(38 * 2 + 37 * 3, 0, 37, 47, 7);
            this.grap[151][x1].setValues(38 * 3 + 37 * 3, 0, 37, 47, 7);
            this.grap[9][x1].setValues(33 * 7 + 1, 0, 26, 30, x1);
            this.grap[10][x1].setValues(214, 0, 46, 16, 6);

            this.grap[30][x1].setValues(0, 56, 30, 36, 7);
            this.grap[155][x1].setValues(31 * 3, 56, 30, 36, 7);
            this.grap[31][x1].setValues(50, 74, 49, 79, 6);

            this.grap[80][x1].setValues(151, 31, 70, 40, 4);
            this.grap[81][x1].setValues(151, 72, 70, 40, 4);
            this.grap[130][x1].setValues(151 + 71, 72, 70, 40, 4);
            this.grap[82][x1].setValues(33 * 1, 0, 30, 30, 5);
            this.grap[83][x1].setValues(0, 0, 49, 48, 6);
            this.grap[84][x1].setValues(33 * 5 + 1, 0, 30, 30, x1);
            this.grap[86][x1].setValues(102, 66, 49, 59, 6);
            this.grap[152][x1].setValues(152, 66, 49, 59, 6);

            this.grap[90][x1].setValues(102, 0, 64, 63, 6);

            this.grap[100][x1].setValues(33 * 1, 0, 30, 30, 2);
            this.grap[101][x1].setValues(33 * 7, 0, 30, 30, 2);
            this.grap[102][x1].setValues(33 * 3, 0, 30, 30, 2);

            this.grap[105][x1].setValues(33 * 5, 0, 30, 30, 2);
            this.grap[110][x1].setValues(33 * 4, 0, 30, 30, 2);

            x1 = 4;
            this.grap[0][x1].setValues(0, 0, 150, 90, x1);
            this.grap[1][x1].setValues(151, 0, 65, 29, x1);
            this.grap[2][x1].setValues(151, 31, 70, 40, x1);
            this.grap[3][x1].setValues(0, 91, 100, 90, x1);
            this.grap[4][x1].setValues(151, 113, 51, 29, x1);
            this.grap[5][x1].setValues(222, 0, 28, 60, x1);
            this.grap[6][x1].setValues(151, 143, 90, 40, x1);

            this.grap[20][x1].setValues(0, 182, 40, 60, x1);

            x1 = 5;
            this.grap[0][x1].setValues(167, 0, 45, 45, 6);
        }

        public void PlaySound(int cue)
        {
            this.sounds[cue].Play();
        }

        public SpriteFont returnFont()
        {
            return this.font;
        }

        public Rectangle returnFrame(int x, int y)
        {
            return this.grap[x][y].rect;
        }

        public Texture2D returnTexture(int x, int y)
        {
            return this.mGrap[this.grap[x][y].textureNumber];
        }

        public Texture2D returnTitle()
        {
            return this.mGrap[30];
        }

        public void StartMusic()
        {
            this.music.Play();
        }

        public void StopMusic()
        {
            this.music.Stop();
        }
    }

    public class GraphicDerivitation
    {
        public Rectangle rect;

        public int textureNumber;

        public void setValues(int x, int y, int width, int height, int TextureNumber)
        {
            this.rect = new Rectangle(x, y, width, height);
            this.textureNumber = TextureNumber;
        }
    }
}