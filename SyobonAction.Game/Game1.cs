namespace SyobonAction.Game
{
    using System;
    using System.Collections.Generic;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    /// <summary>
    ///     This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        protected const int fxmax = 48000;

        protected const int fymax = 42000;

        protected Texture2D blank;

        protected Dictionary<string, Texture2D> breakawayBlockTextures = new Dictionary<string, Texture2D>();

        protected Color fontColor = new Color(160, 180, 250);

        protected GraphicsDeviceManager graphics;

        protected int interval;

        protected int mact;
        protected int t2;
        protected int mirror;
        protected int fma;
        protected int fmb;
        protected int mascrollmax;
        protected int kscroll;
        protected int t1;
        protected int emax;
        protected int mmutekion;
        protected int scrolly;
        protected int tmsg;
        protected int tco;
        protected int sco;
        protected int scrollx;
        protected int eco;
        protected int bco;
        protected int tmsgy;
        protected int srmax;
        protected int smax;
        protected int tmsgtm;
        protected int trap;
        protected int sta;
        protected int amax;
        protected int aco;
        protected int mztm;
        protected int t3;
        protected int tt;
        protected int mztype;
        protected int mactp;
        protected int nmax;
        protected int nco;
        protected int tyuukan;
        protected int maintm;
        protected int mzz;
        protected int mmsgtm;
        protected int mmsgtype;
        protected int mxtype;
        protected int blackx;
        protected int blacktm;
        protected int stagerr;
        protected int nokori;
        protected int fast;
        protected int mtm;
        protected int stb;
        protected int maint;
        protected int mmutekitm;
        protected int atktm;
        protected int bmax;
        protected int ending;
        protected int screenX;
        protected int screenY;
        protected int fzx;
        protected int keytm;
        protected int mkasok;
        protected int ma;
        protected int main;
        protected int mainmsgtype;
        protected int mb;
        protected int mc;
        protected int md;
        protected int mjumptm;
        protected int mhp;
        protected int mkeytm;
        protected int mmuki;
        protected int mnobia;
        protected int mnobib;
        protected int mrzimen;
        protected int mzimen;
        protected int mtype;
        protected int over;
        protected int srco;
        protected int stagecolor;
        protected int stageonoff;
        protected int stagepoint;
        protected int stc;
        protected int t;
        protected int tmax;
        protected int tmsgtype;
        protected int zxon;

        protected float pai = (float)Math.PI;

        protected bool paused;

        protected Random random;

        protected Resources resources;

        protected SpriteBatch spriteBatch;

        protected int[] srgtype;
        protected int[] ahp;
        protected int[] item;
        protected int[] nx;
        protected int[] any;
        protected int[] nc;
        protected int[] egtype;
        protected int[] sree;
        protected int[] a2tm;
        protected int[] anotm;
        protected int[] ee;
        protected int[] ef;
        protected int[] axzimen;
        protected int[] srsok;
        protected int[] srmuki;
        protected int[] srmove;
        protected int[] srd;
        protected int[] sr;
        protected int[] sc;
        protected int[] nd;
        protected int[] ne;
        protected int[] nf;
        protected int[] ng;
        protected int[] af;
        protected int[] srmovep;
        protected int[] srf;
        protected int[] td;
        protected int[] tc;
        protected int[] amsgtype;
        protected int[] amsgtm;
        protected int[] anobib;
        protected int[] azimentype;
        protected int[] aa;
        protected int[] ab;
        protected int[] ac;
        protected int[] ad;
        protected int[] ae;
        protected int[] atm;
        protected int[] amuki;
        protected int[] axtype;
        protected int[] anobia;
        protected int[] atype;
        protected int[] aactb;
        protected int[] aacta;
        protected int[] bxtype;
        protected int[] anx;
        protected int[] btm;
        protected int[] bz;
        protected int[] titem;
        protected int[] ec;
        protected int[] ea;
        protected int[] eb;
        protected int[] ed;
        protected int[] etm;
        protected int[] enobib;
        protected int[] enobia;
        protected int[] thp;
        protected int[] stype;
        protected int[] abrocktm;
        protected int[] sxtype;
        protected int[] sd;
        protected int[] sgtype;
        protected int[] sron;
        protected int[] na;
        protected int[] nb;
        protected int[] ntype;
        protected int[] actaon;
        protected int[] ba;
        protected int[] bb;
        protected int[] btype;
        protected int[] enemyX;
        protected int[] enemyY;
        protected int[] sra;
        protected int[] srb;
        protected int[] src;
        protected int[] srtype;
        protected int[] sracttype;
        protected int[] sre;
        protected int[] srsp;
        protected int[] ta;
        protected int[] tb;
        protected int[] ttype;
        protected int[] txtype;
        protected int[] xx;

        protected byte[][] stagedate;

        protected long stime;

        protected double[] xd;

        protected string[] xs;

        public Game1()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.resources = new Resources();
            this.Window.Title = "Syobon Action! - XNA";
            this.Content.RootDirectory = "Content";
            this.random = new Random();
        }

        protected void ayobi(int xa, int xb, int xc, int xd, int xnotm, int xtype, int xxtype)
        {
            int rz = 0;
            for (this.t1 = 0; this.t1 <= 1; this.t1++)
            {
                this.t1 = 2;
                if (this.aa[this.aco] >= -9000 && this.aa[this.aco] <= 30000)
                {
                    this.t1 = 0;
                    rz++;
                }

                if (rz <= this.amax)
                {
                    this.t1 = 3;
                    this.ad[this.aco] = this.xx[1];
                    this.aa[this.aco] = xa;
                    this.ab[this.aco] = xb;
                    this.ac[this.aco] = xc;
                    this.ad[this.aco] = xd;
                    if (xxtype > 100)
                    {
                        this.ac[this.aco] = xxtype;
                    }

                    this.atype[this.aco] = xtype;
                    if (xxtype >= 0 && xxtype <= 99100)
                    {
                        this.axtype[this.aco] = xxtype;
                    }

                    this.anotm[this.aco] = xnotm;
                    if (this.aa[this.aco] - this.screenX <= this.ma + this.mnobia / 2)
                    {
                        this.amuki[this.aco] = 1;
                    }

                    if (this.aa[this.aco] - this.screenX > this.ma + this.mnobia / 2)
                    {
                        this.amuki[this.aco] = 0;
                    }

                    if (this.abrocktm[this.aco] >= 1)
                    {
                        this.amuki[this.aco] = 1;
                    }

                    if (this.abrocktm[this.aco] == 20)
                    {
                        this.amuki[this.aco] = 0;
                    }

                    this.anobia[this.aco] = this.anx[this.atype[this.aco]];
                    this.anobib[this.aco] = this.any[this.atype[this.aco]];
                    if (xtype == 7)
                    {
                        this.resources.PlaySound(8);
                    }

                    if (xtype == 10)
                    {
                        this.resources.PlaySound(16);
                    }

                    this.azimentype[this.aco] = 1;

                    /*
                                        switch (atype[aco])
                                        {
                                        }*/
                    if (xtype == 87)
                    {
                        this.atm[this.aco] = this.random.Next(179) + (-90);
                    }

                    this.aco += 1;
                    if (this.aco >= this.amax - 1)
                    {
                        this.aco = 0;
                    }
                }
            }
        }

        protected void brockbreak(int t)
        {
            if (this.titem[t] == 1)
            {
            }

            if (this.titem[t] >= 2 && this.titem[t] <= 7)
            {
            }

            this.ta[t] = -800000;
        }

        protected override void Draw(GameTime gameTime)
        {
            // graphics.GraphicsDevice.Clear(fontColor);
            base.Draw(gameTime);
        }

        protected void drawarc(int x, int y, int width, int height)
        {
            this.drawrect(x - width, y - height, width * 2, height * 2);
        }

        protected void drawline(int x1, int y1, int x2, int y2)
        {
            Vector2 point1 = new Vector2(x1, y1);
            Vector2 point2 = new Vector2(x2, y2);

            float angle = (float)Math.Atan2(point2.Y - point1.Y, point2.X - point1.X);
            float length = Vector2.Distance(point1, point2);

            this.spriteBatch.Draw(
                this.blank,
                point1,
                null,
                this.fontColor,
                angle,
                Vector2.Zero,
                new Vector2(length, 1.0f),
                SpriteEffects.None,
                0);

            // Old function to draw primitives that is no longer needed

            // VertexPositionColor[] mVtLineList = new VertexPositionColor[2];
            // mVtLineList[0] = new VertexPositionColor(new Vector3(x1, y1, 1), fontColor);
            // mVtLineList[1] = new VertexPositionColor(new Vector3(x2, y2, 1), fontColor);

            // graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColor>(PrimitiveType.LineList, mVtLineList, 0, 1);
        }

        protected void drawrect(int x, int y, int width, int height)
        {
            int h, w;
            h = height;
            w = width;
            Texture2D frect;

            string textureKey = string.Format(
                "w:{0};h:{1};c:{2}",
                width,
                height,
                this.fontColor.PackedValue.ToString());

            if (this.breakawayBlockTextures.ContainsKey(textureKey))
            {
                frect = this.breakawayBlockTextures[textureKey];
            }
            else
            {
                frect = new Texture2D(this.GraphicsDevice, w, h);
                Color transparent = new Color(new Vector4(0, 0, 0, 0));
                uint[] pixel;
                int ii, jj;
                pixel = new uint[(w * h)];
                for (ii = 0; ii < w; ii++)
                {
                    for (jj = 0; jj < h; jj++)
                    {
                        if (ii == 0 || ii == w - 1 || jj == 0 || jj == h - 1)
                        {
                            pixel[(jj * w) + ii] = this.fontColor.PackedValue;
                        }
                        else
                        {
                            pixel[(jj * w) + ii] = transparent.PackedValue;
                        }
                    }
                }

                frect.SetData(pixel);
                this.breakawayBlockTextures.Add(textureKey, frect);
            }

            this.spriteBatch.Draw(frect, new Vector2(x, y), Color.White);
        }

        protected void end()
        {
        }

        protected void eyobi(
            int xa,
            int xb,
            int xc,
            int xd,
            int xe,
            int xf,
            int xnobia,
            int xnobib,
            int xgtype,
            int xtm)
        {
            this.ea[this.eco] = xa;
            this.eb[this.eco] = xb;
            this.ec[this.eco] = xc;
            this.ed[this.eco] = xd;
            this.ee[this.eco] = xe;
            this.ef[this.eco] = xf;
            this.egtype[this.eco] = xgtype;
            this.etm[this.eco] = xtm;
            this.enobia[this.eco] = xnobia;
            this.enobib[this.eco] = xnobib;
            this.eco++;
            if (this.eco >= this.emax)
            {
                this.eco = 0;
            }
        }

        protected void fillarc(int x, int y, int width, int height)
        {
            this.fillrect(x - width, y - height, width * 2, height * 2);
        }

        protected void fillrect(int x, int y, int width, int height)
        {
            int h, w;
            h = height;
            w = width;
            Texture2D frect;
            string textureKey = string.Format("w:{0};h:{1}", width, height);

            if (this.breakawayBlockTextures.ContainsKey(textureKey))
            {
                frect = this.breakawayBlockTextures[textureKey];
            }
            else
            {
                frect = new Texture2D(this.GraphicsDevice, w, h);
                uint[] pixel;
                int ii, jj;
                pixel = new uint[(w * h)];
                for (ii = 0; ii < w; ii++)
                {
                    for (jj = 0; jj < h; jj++)
                    {
                        pixel[(jj * w) + ii] = this.fontColor.PackedValue;
                    }
                }

                frect.SetData(pixel);
                this.breakawayBlockTextures.Add(textureKey, frect);
            }

            this.spriteBatch.Draw(frect, new Vector2(x, y), Color.White);
        }

        protected override void Initialize()
        {
            this.graphics.PreferredBackBufferWidth = fxmax / 100;
            this.graphics.PreferredBackBufferHeight = fymax / 100;
            this.graphics.ApplyChanges();
            this.resources.Initialize(this.Content);
            this.main = 100;
            this.smax = 31;
            this.mascrollmax = 21000;
            this.tmax = 641;
            this.emax = 201;
            this.amax = 24;
            this.bmax = 81;
            this.nmax = 41;
            this.srmax = 21;
            this.blacktm = 1;
            this.blackx = 0;

            this.sta = 1;
            this.stb = 4;
            this.stc = 0;

            this.xd = new double[11];
            this.actaon = new int[7];

            this.any = new int[160];

            this.aa = new int[this.amax];
            this.ab = new int[this.amax];
            this.anobia = new int[this.amax];
            this.anobib = new int[this.amax];
            this.ac = new int[this.amax];
            this.ad = new int[this.amax];
            this.ae = new int[this.amax];
            this.af = new int[this.amax];
            this.abrocktm = new int[this.amax];
            this.aacta = new int[this.amax];
            this.aactb = new int[this.amax];
            this.azimentype = new int[this.amax];
            this.axzimen = new int[this.amax];
            this.atype = new int[this.amax];
            this.axtype = new int[this.amax];
            this.amuki = new int[this.amax];
            this.ahp = new int[this.amax];
            this.anotm = new int[this.amax];
            this.anx = new int[160];
            this.any = new int[160];
            this.atm = new int[this.amax];
            this.a2tm = new int[this.amax];
            this.amsgtm = new int[this.amax];
            this.amsgtype = new int[this.amax];

            this.ea = new int[this.emax];
            this.eb = new int[this.emax];
            this.enobia = new int[this.emax];
            this.enobib = new int[this.emax];
            this.ec = new int[this.emax];
            this.ed = new int[this.emax];
            this.ee = new int[this.emax];
            this.ef = new int[this.emax];
            this.etm = new int[this.emax];
            this.egtype = new int[this.emax];

            this.ba = new int[this.bmax];
            this.bb = new int[this.bmax];
            this.btm = new int[this.bmax];
            this.btype = new int[this.bmax];
            this.bxtype = new int[this.bmax];
            this.bz = new int[this.bmax];

            this.na = new int[this.nmax];
            this.nb = new int[this.nmax];
            this.nc = new int[this.nmax];
            this.nd = new int[this.nmax];
            this.ntype = new int[this.nmax];
            this.ne = new int[this.nmax];
            this.nf = new int[this.nmax];
            this.ng = new int[this.nmax];
            this.nx = new int[this.nmax];

            this.enemyX = new int[this.smax];
            this.enemyY = new int[this.smax];
            this.sc = new int[this.smax];
            this.sd = new int[this.smax];
            this.stype = new int[this.smax];
            this.sxtype = new int[this.smax];
            this.sr = new int[this.smax];
            this.sgtype = new int[this.smax];

            this.ta = new int[this.tmax];
            this.tb = new int[this.tmax];
            this.tc = new int[this.tmax];
            this.td = new int[this.tmax];
            this.thp = new int[this.tmax];
            this.ttype = new int[this.tmax];
            this.item = new int[this.tmax];
            this.txtype = new int[this.tmax];

            this.sra = new int[this.srmax];
            this.srb = new int[this.srmax];
            this.src = new int[this.srmax];
            this.srd = new int[this.srmax];
            this.sre = new int[this.srmax];
            this.srf = new int[this.srmax];
            this.srtype = new int[this.srmax];
            this.srgtype = new int[this.srmax];
            this.sracttype = new int[this.srmax];
            this.srsp = new int[this.srmax];
            this.srmuki = new int[this.srmax];
            this.sron = new int[this.srmax];
            this.sree = new int[this.srmax];
            this.srsok = new int[this.srmax];
            this.srmovep = new int[this.srmax];
            this.srmove = new int[this.srmax];

            this.xx = new int[91];
            this.xs = new string[31];

            this.titem = new int[this.tmax];

            this.stagedate = new byte[17][];
            for (int i = 0; i < 17; i++)
            {
                this.stagedate[i] = new byte[2001];
                for (int j = 0; j < 2001; j++)
                {
                    this.stagedate[i][j] = new byte();
                }
            }

            int x1 = 3;
            for (this.t = 0; this.t <= 140; this.t++)
            {
                this.anx[this.t] = this.resources.returnFrame(this.t, x1).Width;
                this.any[this.t] = this.resources.returnFrame(this.t, x1).Height;
                this.anx[this.t] *= 100;
                this.any[this.t] *= 100;
            }

            this.anx[79] = 120 * 100;
            this.any[79] = 15 * 100;
            this.anx[85] = 25 * 100;
            this.any[85] = 30 * 10 * 100;
            x1 = 4;
            for (this.t = 0; this.t < 40; this.t++)
            {
                this.ne[this.t] = this.resources.returnFrame(this.t, x1).Width;
                this.nf[this.t] = this.resources.returnFrame(this.t, x1).Height;
            }

            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
            this.blank = new Texture2D(this.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            this.blank.SetData(new[] { Color.White });
        }

        protected void MainProgram(GameTime gameTime)
        {
            this.stime = (long)gameTime.TotalGameTime.TotalMilliseconds;
            if (this.ending == 1)
            {
                this.main = 2;
            }

            if (this.main == 1 && this.tmsgtype == 0)
            {
                if (this.zxon == 0)
                {
                    this.zxon = 1;
                    this.mainmsgtype = 0;
                    this.stagecolor = 1;
                    this.ma = 5600;
                    this.mb = 32000;
                    this.mmuki = 1;
                    this.mhp = 1;
                    this.mc = 0;
                    this.md = 0;
                    this.mnobia = 3000;
                    this.mnobib = 3600;
                    this.mtype = 0;
                    this.screenX = 0;
                    this.screenY = 0;
                    this.fzx = 0;
                    this.stageonoff = 0;
                    this.resources.ChangeMusic(17);
                    this.stagecls();
                    this.stage();
                    if (this.over == 1)
                    {
                        for (this.t = 0; this.t < this.tmax; this.t++)
                        {
                            if (this.random.Next(3) <= 1)
                            {
                                this.ta[this.t] = (this.random.Next(500) - 1) * 29 * 100;
                                this.tb[this.t] = this.random.Next(14) * 100 * 29 - 1200;
                                this.ttype[this.t] = this.random.Next(142);
                                if (this.ttype[this.t] >= 9 && this.ttype[this.t] <= 99)
                                {
                                    this.ttype[this.t] = this.random.Next(8);
                                }

                                this.txtype[this.t] = this.random.Next(4);
                            }
                        }

                        for (this.t = 0; this.t < this.bmax; this.t++)
                        {
                            if (this.random.Next(2) <= 1)
                            {
                                this.ba[this.t] = (this.random.Next(500) - 1) * 29 * 100;
                                this.bb[this.t] = this.random.Next(15) * 100 * 29 - 1200 - 3000;
                                if (this.random.Next(6) == 0)
                                {
                                    this.btype[this.t] = this.random.Next(9);
                                }
                            }
                        }

                        this.srco = 0;
                        this.t = this.srco;
                        this.sra[this.t] = this.ma + this.screenX;
                        this.srb[this.t] = (13 * 29 - 12) * 100;
                        this.src[this.t] = 30 * 100;
                        this.srtype[this.t] = 0;
                        this.sracttype[this.t] = 0;
                        this.sre[this.t] = 0;
                        this.srsp[this.t] = 0;
                        this.srco++;
                        if (this.random.Next(4) == 0)
                        {
                            this.stagecolor = this.random.Next(4);
                        }
                    }

                    this.resources.StopMusic();
                    this.resources.StartMusic();
                }

                this.xx[0] = 0;
                this.actaon[2] = 0;
                this.actaon[3] = 0;
                if (this.mkeytm <= 0)
                {
                    if (Keyboard.GetState().IsKeyDown(Keys.Left) && this.keytm <= 0)
                    {
                        this.actaon[0] = -1;
                        this.mmuki = 0;
                        this.actaon[4] = -1;
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.Right) && this.keytm <= 0)
                    {
                        this.actaon[0] = 1;
                        this.mmuki = 1;
                        this.actaon[4] = 1;
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        this.actaon[3] = 1;
                    }
                }

                if (Keyboard.GetState().IsKeyDown(Keys.F1))
                {
                    this.main = 100;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.O))
                {
                    if (this.mhp >= 1)
                    {
                        this.mhp = 0;
                    }

                    if (this.stc >= 5)
                    {
                        this.stc = 0;
                        this.stagepoint = 0;
                    }
                }

                if (this.mkeytm <= 0)
                {
                    if (Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.Z))
                    {
                        if (this.actaon[1] == 10)
                        {
                            this.actaon[1] = 1;
                            this.xx[0] = 1;
                        }

                        this.actaon[2] = 1;
                    }
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.Z))
                {
                    if (this.mjumptm == 8 && this.md >= -900)
                    {
                        this.md = -1300;
                        this.xx[22] = 200;
                        if (this.mc >= this.xx[22] || this.mc <= -this.xx[22])
                        {
                            this.md = -1400;
                        }

                        this.xx[22] = 600;
                        if (this.mc >= this.xx[22] || this.mc <= -this.xx[22])
                        {
                            this.md = -1500;
                        }
                    }

                    if (this.xx[0] == 0)
                    {
                        this.actaon[1] = 10;
                    }
                }

                this.xx[0] = 40;
                this.xx[1] = 700;
                this.xx[8] = 500;
                this.xx[9] = 700;
                this.xx[12] = 1;
                this.xx[13] = 2;
                if (this.mrzimen == 1)
                {
                    this.xx[0] = 20;
                    this.xx[12] = 9;
                    this.xx[13] = 10;
                }

                if (this.actaon[0] == -1)
                {
                    if (!(this.mzimen == 0 && this.mc < -this.xx[8]))
                    {
                        if (this.mc >= -this.xx[9])
                        {
                            this.mc -= this.xx[0];
                            if (this.mc < -this.xx[9])
                            {
                                this.mc = -this.xx[9] - 1;
                            }
                        }

                        if (this.mc < -this.xx[9] && this.atktm <= 0)
                        {
                            this.mc -= this.xx[0] / 10;
                        }
                    }

                    if (this.mrzimen != 1)
                    {
                        if (this.mc > 100 && this.mzimen == 0)
                        {
                            this.mc -= this.xx[0] * 2 / 3;
                        }

                        if (this.mc > 100 && this.mzimen == 1)
                        {
                            this.mc -= this.xx[0];
                            if (this.mzimen == 1)
                            {
                                this.mc -= this.xx[0] * 1 / 2;
                            }
                        }

                        this.actaon[0] = 3;
                        this.mkasok += 1;
                    }
                }

                if (this.actaon[0] == 1)
                {
                    if (!(this.mzimen == 0 && this.mc > this.xx[8]))
                    {
                        if (this.mc <= this.xx[9])
                        {
                            this.mc += this.xx[0];
                            if (this.mc > this.xx[9])
                            {
                                this.mc = this.xx[9] + 1;
                            }
                        }

                        if (this.mc > this.xx[9] && this.atktm <= 0)
                        {
                            this.mc += this.xx[0] / 10;
                        }
                    }

                    if (this.mrzimen != 1)
                    {
                        if (this.mc < -100 && this.mzimen == 0)
                        {
                            this.mc += this.xx[0] * 2 / 3;
                        }

                        if (this.mc < -100 && this.mzimen == 1)
                        {
                            this.mc += this.xx[0];
                            if (this.mzimen == 1)
                            {
                                this.mc += this.xx[0] * 1 / 2;
                            }
                        }

                        this.actaon[0] = 3;
                        this.mkasok += 1;
                    }
                }

                if (this.actaon[0] == 0 && this.mkasok > 0)
                {
                    this.mkasok -= 2;
                }

                if (this.mkasok > 8)
                {
                    this.mkasok = 8;
                }

                if (this.mzimen != 1)
                {
                    this.mrzimen = 0;
                }

                if (this.mjumptm >= 0)
                {
                    this.mjumptm--;
                }

                if (this.actaon[1] == 1 && this.mzimen == 1)
                {
                    this.mb -= 400;
                    this.md = -1200;
                    this.mjumptm = 10;
                    this.resources.PlaySound(0);
                    this.mzimen = 0;
                }

                if (this.actaon[1] <= 9)
                {
                    this.actaon[1] = 0;
                }

                if (this.mmutekitm >= -1)
                {
                    this.mmutekitm--;
                }

                if (this.mhp <= 0 && this.mhp >= -9)
                {
                    this.mkeytm = 12;
                    this.mhp = -20;
                    this.mtype = 200;
                    this.mtm = 0;
                    this.resources.PlaySound(10);
                    this.resources.StopMusic();
                }

                if (this.mtype == 200)
                {
                    if (this.mtm <= 11)
                    {
                        this.mc = 0;
                        this.md = 0;
                    }

                    if (this.mtm == 12)
                    {
                        this.md = -1200;
                    }

                    if (this.mtm >= 12)
                    {
                        this.mc = 0;
                    }

                    if (this.mtm >= 100 || this.fast == 1)
                    {
                        this.zxon = 0;
                        this.main = 10;
                        this.mtm = 0;
                        this.mkeytm = 0;
                        this.nokori--;
                        if (this.fast == 1)
                        {
                            this.mtype = 0;
                        }
                    }
                }

                if (this.mtype == 2)
                {
                    this.mtm++;
                    this.mkeytm = 2;
                    this.md = -1500;
                    if (this.mb <= -6000)
                    {
                        this.blackx = 1;
                        this.blacktm = 20;
                        this.stc += 5;
                        this.stagerr = 0;
                        this.resources.StopMusic();
                        this.mtm = 0;
                        this.mtype = 0;
                        this.mkeytm = -1;
                    }
                }

                if (this.mtype == 3)
                {
                    this.md = -2400;
                    if (this.mb <= -6000)
                    {
                        this.mb = -80000000;
                        this.mhp = 0;
                    }
                }

                if (this.mtype >= 100)
                {
                    this.mtm++;
                    if (this.mtype == 100
                        && (this.mxtype == 1 || this.mxtype == 2 || this.mxtype == 3 || this.mxtype == 5))
                    {
                        this.mc = 0;
                        this.md = 0;
                        if (this.mtm <= 16 && this.mxtype != 3)
                        {
                            this.mb += 240;
                        }

                        if (this.mtm <= 16 && this.mxtype == 3)
                        {
                            this.ma += 240;
                        }

                        if (this.mtm == 19 && this.mxtype == 2)
                        {
                            this.mhp = 0;
                            this.mtype = 2000;
                            this.mtm = 0;
                            this.mmsgtm = 30;
                            this.mmsgtype = 51;
                        }

                        if (this.mtm == 19 && this.mxtype == 5)
                        {
                            this.mhp = 0;
                            this.mtype = 2000;
                            this.mtm = 0;
                            this.mmsgtm = 30;
                            this.mmsgtype = 52;
                        }

                        if (this.mtm == 20)
                        {
                            this.mb = -80000000;
                            this.mxtype = 0;
                            this.blackx = 1;
                            this.blacktm = 20;
                            this.stc++;
                            this.stagerr = 0;
                            this.resources.StopMusic();
                        }
                    }

                    if (this.mtype == 100 && this.mxtype == 0)
                    {
                        this.mc = 0;
                        this.md = 0;
                        this.t = 28;
                        if (this.mtm <= 16)
                        {
                            this.mb += 240;
                            this.mzz = 100;
                        }

                        if (this.mtm == 17)
                        {
                            this.mb = -80000000;
                        }

                        if (this.mtm == 23)
                        {
                            this.enemyX[this.t] -= 100;
                        }

                        if (this.mtm >= 44 && this.mtm <= 60)
                        {
                            if (this.mtm % 2 == 0)
                            {
                                this.enemyX[this.t] += 200;
                            }

                            if (this.mtm % 2 == 1)
                            {
                                this.enemyX[this.t] -= 200;
                            }
                        }

                        if (this.mtm >= 61 && this.mtm <= 77)
                        {
                            if (this.mtm % 2 == 0)
                            {
                                this.enemyX[this.t] += 400;
                            }

                            if (this.mtm % 2 == 1)
                            {
                                this.enemyX[this.t] -= 400;
                            }
                        }

                        if (this.mtm >= 78 && this.mtm <= 78 + 16)
                        {
                            if (this.mtm % 2 == 0)
                            {
                                this.enemyX[this.t] += 600;
                            }

                            if (this.mtm % 2 == 1)
                            {
                                this.enemyX[this.t] -= 600;
                            }
                        }

                        if (this.mtm >= 110)
                        {
                            this.enemyY[this.t] -= this.mzz;
                            this.mzz += 80;
                            if (this.mzz > 1600)
                            {
                                this.mzz = 1600;
                            }
                        }

                        if (this.mtm == 160)
                        {
                            this.mtype = 0;
                            this.mhp--;
                        }
                    }

                    if (this.mtype == 100 && this.mxtype == 10)
                    {
                        this.mc = 0;
                        this.md = 0;
                        if (this.mtm <= 16)
                        {
                            this.ma += 240;
                        }

                        if (this.mtm == 16)
                        {
                            this.mb -= 1100;
                        }

                        if (this.mtm == 20)
                        {
                            this.resources.PlaySound(8);
                        }

                        if (this.mtm >= 24)
                        {
                            this.ma -= 2000;
                            this.mmuki = 0;
                        }

                        if (this.mtm >= 48)
                        {
                            this.mtype = 0;
                            this.mhp--;
                        }
                    }

                    if (this.mtype == 300)
                    {
                        this.mkeytm = 3;
                        if (this.mtm <= 1)
                        {
                            this.mc = 0;
                            this.md = 0;
                        }

                        if (this.mtm >= 2 && this.mtm <= 42)
                        {
                            this.md = 600;
                            this.mmuki = 1;
                        }

                        if (this.mtm > 43 && this.mtm <= 108)
                        {
                            this.mc = 300;
                        }

                        if (this.mtm == 110)
                        {
                            this.mb = -80000000;
                            this.mc = 0;
                        }

                        if (this.mtm == 250)
                        {
                            this.stb++;
                            this.stc = 0;
                            this.zxon = 0;
                            this.tyuukan = 0;
                            this.main = 10;
                            this.maintm = 0;
                        }
                    }

                    if (this.mtype == 301 || this.mtype == 302)
                    {
                        this.mkeytm = 3;
                        if (this.mtm <= 1)
                        {
                            this.mc = 0;
                            this.md = 0;
                        }

                        if (this.mtm >= 2
                            && (this.mtype == 301 && this.mtm <= 102 || this.mtype == 302 && this.mtm <= 60))
                        {
                            this.xx[5] = 500;
                            this.ma -= this.xx[5];
                            this.screenX += this.xx[5];
                            this.fzx += this.xx[5];
                        }

                        if (this.mtype == 301 || this.mtype == 302 && this.mtm >= 2 && this.mtm <= 100)
                        {
                            this.mc = 250;
                            this.mmuki = 1;
                        }

                        if (this.mtm == 200)
                        {
                            this.resources.PlaySound(15);
                            this.na[this.nco] = 157 * 29 * 100 - 1100;
                            this.nb[this.nco] = 4 * 29 * 100;
                            this.ntype[this.nco] = 101;
                            this.nco++;
                            if (this.nco >= this.nmax)
                            {
                                this.nco = 0;
                            }

                            this.na[this.nco] = 155 * 29 * 100 - 1100;
                            this.nb[this.nco] = 6 * 29 * 100;
                            this.ntype[this.nco] = 102;
                            this.nco++;
                            if (this.nco >= this.nmax)
                            {
                                this.nco = 0;
                            }
                        }

                        if (this.mtm == 440)
                        {
                            this.ending = 1;
                        }
                    }
                }

                if (this.mkeytm >= 1)
                {
                    this.mkeytm--;
                }

                this.ma += this.mc;
                this.mb += this.md;
                if (this.mc < 0)
                {
                    this.mactp += (-this.mc);
                }

                if (this.mc >= 0)
                {
                    this.mactp += this.mc;
                }

                if (this.mtype <= 9 || this.mtype == 200 || this.mtype == 300 || this.mtype == 301 || this.mtype == 302)
                {
                    this.md += 100;
                }

                if (this.mtype == 0)
                {
                    this.xx[0] = 800;
                    this.xx[1] = 1600;
                    if (this.mc > this.xx[0] && this.mc < this.xx[0] + 200)
                    {
                        this.mc = this.xx[0];
                    }

                    if (this.mc > this.xx[0] + 200)
                    {
                        this.mc -= 200;
                    }

                    if (this.mc < -this.xx[0] && this.mc > -this.xx[0] - 200)
                    {
                        this.mc = -this.xx[0];
                    }

                    if (this.mc < -this.xx[0] - 200)
                    {
                        this.mc += 200;
                    }

                    if (this.md > this.xx[1])
                    {
                        this.md = this.xx[1];
                    }
                }

                if (this.mzimen == 1 && this.actaon[0] != 3)
                {
                    if ((this.mtype <= 9) || this.mtype == 300 || this.mtype == 301 || this.mtype == 302)
                    {
                        if (this.mrzimen == 0)
                        {
                            this.xx[2] = 30;
                            this.xx[1] = 60;
                            this.xx[3] = 30;
                            if (this.mc >= -this.xx[3] && this.mc <= this.xx[3])
                            {
                                this.mc = 0;
                            }

                            if (this.mc >= this.xx[2])
                            {
                                this.mc -= this.xx[1];
                            }

                            if (this.mc <= -this.xx[2])
                            {
                                this.mc += this.xx[1];
                            }
                        }

                        if (this.mrzimen == 1)
                        {
                            this.xx[2] = 5;
                            this.xx[1] = 10;
                            this.xx[3] = 5;
                            if (this.mc >= -this.xx[3] && this.mc <= this.xx[3])
                            {
                                this.mc = 0;
                            }

                            if (this.mc >= this.xx[2])
                            {
                                this.mc -= this.xx[1];
                            }

                            if (this.mc <= -this.xx[2])
                            {
                                this.mc += this.xx[1];
                            }
                        }
                    }
                }

                this.mzimen = 0;
                if (this.mtype <= 9 && this.mhp >= 1)
                {
                    if (this.ma < 100)
                    {
                        this.ma = 100;
                        this.mc = 0;
                    }

                    if (this.ma + this.mnobia > fxmax)
                    {
                        this.ma = fxmax - this.mnobia;
                        this.mc = 0;
                    }
                }

                if (this.mb >= 38000 && this.mhp >= 0 && this.stagecolor == 4)
                {
                    this.mhp = -2;
                    this.mmsgtm = 30;
                    this.mmsgtype = 55;
                }

                if (this.mb >= 52000 && this.mhp >= 0)
                {
                    this.mhp = -2;
                }

                this.xx[15] = 0;
                for (this.t = 0; this.t < this.tmax; this.t++)
                {
                    this.xx[0] = 200;
                    this.xx[1] = 3000;
                    this.xx[2] = 1000;
                    this.xx[3] = 3000;
                    this.xx[8] = this.ta[this.t] - this.screenX;
                    this.xx[9] = this.tb[this.t] - this.screenY;
                    if (this.ta[this.t] - this.screenX + this.xx[1] >= -10 - this.xx[3]
                        && this.ta[this.t] - this.screenX <= fxmax + 12000 + this.xx[3])
                    {
                        if (this.mtype != 200 && this.mtype != 1 && this.mtype != 2)
                        {
                            if (this.ttype[this.t] < 1000 && this.ttype[this.t] != 800 && this.ttype[this.t] != 140
                                && this.ttype[this.t] != 141)
                            {
                                if (!(this.mztype == 1))
                                {
                                    this.xx[16] = 0;
                                    this.xx[17] = 0;
                                    if (this.ttype[this.t] != 7 && this.ttype[this.t] != 110
                                                                && !(this.ttype[this.t] == 114))
                                    {
                                        if (this.ma + this.mnobia > this.xx[8] + this.xx[0] * 2 + 100
                                            && this.ma < this.xx[8] + this.xx[1] - this.xx[0] * 2 - 100
                                            && this.mb + this.mnobib > this.xx[9]
                                            && this.mb + this.mnobib < this.xx[9] + this.xx[1] && this.md >= -100)
                                        {
                                            if (this.ttype[this.t] != 115 && this.ttype[this.t] != 400
                                                                          && this.ttype[this.t] != 117
                                                                          && this.ttype[this.t] != 118
                                                                          && this.ttype[this.t] != 120)
                                            {
                                                this.mb = this.xx[9] - this.mnobib + 100;
                                                this.md = 0;
                                                this.mzimen = 1;
                                                this.xx[16] = 1;
                                            }
                                            else if (this.ttype[this.t] == 115)
                                            {
                                                this.resources.PlaySound(1);
                                                this.eyobi(
                                                    this.ta[this.t] + 1200,
                                                    this.tb[this.t] + 1200,
                                                    300,
                                                    -1000,
                                                    0,
                                                    160,
                                                    1000,
                                                    1000,
                                                    1,
                                                    120);
                                                this.eyobi(
                                                    this.ta[this.t] + 1200,
                                                    this.tb[this.t] + 1200,
                                                    -300,
                                                    -1000,
                                                    0,
                                                    160,
                                                    1000,
                                                    1000,
                                                    1,
                                                    120);
                                                this.eyobi(
                                                    this.ta[this.t] + 1200,
                                                    this.tb[this.t] + 1200,
                                                    240,
                                                    -1400,
                                                    0,
                                                    160,
                                                    1000,
                                                    1000,
                                                    1,
                                                    120);
                                                this.eyobi(
                                                    this.ta[this.t] + 1200,
                                                    this.tb[this.t] + 1200,
                                                    -240,
                                                    -1400,
                                                    0,
                                                    160,
                                                    1000,
                                                    1000,
                                                    1,
                                                    120);
                                                this.brockbreak(this.t);
                                            }
                                            else if (this.ttype[this.t] == 400)
                                            {
                                                this.md = 0;
                                                this.ta[this.t] = -8000000;
                                                this.resources.PlaySound(11);
                                                for (this.tt = 0; this.tt < this.tmax; this.tt++)
                                                {
                                                    if (this.ttype[this.tt] != 7)
                                                    {
                                                        this.ttype[this.tt] = 800;
                                                    }
                                                }

                                                this.resources.StopMusic();
                                            }
                                            else if (this.ttype[this.t] == 117)
                                            {
                                                this.resources.PlaySound(12);
                                                this.md = -1500;
                                                this.mtype = 2;
                                                this.mtm = 0;
                                                if (this.txtype[this.t] >= 2 && this.mtype == 2)
                                                {
                                                    this.mtype = 0;
                                                    this.md = -1600;
                                                    this.txtype[this.t] = 3;
                                                }

                                                if (this.txtype[this.t] == 0)
                                                {
                                                    this.txtype[this.t] = 1;
                                                }
                                            }
                                            else if (this.ttype[this.t] == 120)
                                            {
                                                this.md = -2400;
                                                this.mtype = 3;
                                                this.mtm = 0;
                                            }
                                        }
                                    }
                                }

                                if (!(this.mztm >= 1 && this.mztype == 1))
                                {
                                    this.xx[21] = 0;
                                    this.xx[22] = 1;
                                    if (this.mzimen == 1 || this.mjumptm >= 10)
                                    {
                                        this.xx[21] = 3;
                                        this.xx[22] = 0;
                                    }

                                    for (this.t3 = 0; this.t3 <= 1; this.t3++)
                                    {
                                        if (this.t3 == this.xx[21] && this.mtype != 100 && this.ttype[this.t] != 117)
                                        {
                                            if (this.ma + this.mnobia > this.xx[8] + this.xx[0] * 2 + 800
                                                && this.ma < this.xx[8] + this.xx[1] - this.xx[0] * 2 - 800
                                                && this.mb > this.xx[9] - this.xx[0] * 2
                                                && this.mb < this.xx[9] + this.xx[1] - this.xx[0] * 2 && this.md <= 0)
                                            {
                                                this.xx[16] = 1;
                                                this.xx[17] = 1;
                                                this.mb = this.xx[9] + this.xx[1] + this.xx[0];
                                                if (this.md < 0)
                                                {
                                                    this.md = -this.md * 2 / 3;
                                                }

                                                if (this.ttype[this.t] == 1 && this.mzimen == 0)
                                                {
                                                    this.resources.PlaySound(1);
                                                    this.eyobi(
                                                        this.ta[this.t] + 1200,
                                                        this.tb[this.t] + 1200,
                                                        300,
                                                        -1000,
                                                        0,
                                                        160,
                                                        1000,
                                                        1000,
                                                        1,
                                                        120);
                                                    this.eyobi(
                                                        this.ta[this.t] + 1200,
                                                        this.tb[this.t] + 1200,
                                                        -300,
                                                        -1000,
                                                        0,
                                                        160,
                                                        1000,
                                                        1000,
                                                        1,
                                                        120);
                                                    this.eyobi(
                                                        this.ta[this.t] + 1200,
                                                        this.tb[this.t] + 1200,
                                                        240,
                                                        -1400,
                                                        0,
                                                        160,
                                                        1000,
                                                        1000,
                                                        1,
                                                        120);
                                                    this.eyobi(
                                                        this.ta[this.t] + 1200,
                                                        this.tb[this.t] + 1200,
                                                        -240,
                                                        -1400,
                                                        0,
                                                        160,
                                                        1000,
                                                        1000,
                                                        1,
                                                        120);
                                                    this.brockbreak(this.t);
                                                }

                                                if (this.ttype[this.t] == 2 && this.mzimen == 0)
                                                {
                                                    this.resources.PlaySound(2);
                                                    this.eyobi(
                                                        this.ta[this.t] + 10,
                                                        this.tb[this.t],
                                                        0,
                                                        -800,
                                                        0,
                                                        40,
                                                        3000,
                                                        3000,
                                                        0,
                                                        16);
                                                    this.ttype[this.t] = 3;
                                                }

                                                if (this.ttype[this.t] == 7)
                                                {
                                                    this.resources.PlaySound(2);
                                                    this.eyobi(
                                                        this.ta[this.t] + 10,
                                                        this.tb[this.t],
                                                        0,
                                                        -800,
                                                        0,
                                                        40,
                                                        3000,
                                                        3000,
                                                        0,
                                                        16);
                                                    this.mb = this.xx[9] + this.xx[1] + this.xx[0];
                                                    this.ttype[this.t] = 3;
                                                    if (this.md < 0)
                                                    {
                                                        this.md = -this.md * 2 / 3;
                                                    }
                                                }
                                            }
                                        }

                                        if (this.t3 == this.xx[22] && this.xx[15] == 0)
                                        {
                                            if (this.ttype[this.t] != 7 && this.ttype[this.t] != 110
                                                                        && this.ttype[this.t] != 117)
                                            {
                                                if (!(this.ttype[this.t] == 114))
                                                {
                                                    if (this.ta[this.t] >= -20000)
                                                    {
                                                        if (this.ma + this.mnobia > this.xx[8]
                                                            && this.ma < this.xx[8] + this.xx[2]
                                                            && this.mb + this.mnobib
                                                            > this.xx[9] + this.xx[1] / 2 - this.xx[0]
                                                            && this.mb < this.xx[9] + this.xx[2] && this.mc >= 0)
                                                        {
                                                            this.ma = this.xx[8] - this.mnobia;
                                                            this.mc = 0;
                                                            this.xx[16] = 1;
                                                        }

                                                        if (this.ma + this.mnobia > this.xx[8] + this.xx[2]
                                                            && this.ma < this.xx[8] + this.xx[1]
                                                            && this.mb + this.mnobib
                                                            > this.xx[9] + this.xx[1] / 2 - this.xx[0]
                                                            && this.mb < this.xx[9] + this.xx[2] && this.mc <= 0)
                                                        {
                                                            this.ma = this.xx[8] + this.xx[1];
                                                            this.mc = 0;
                                                            this.xx[16] = 1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            if (this.ttype[this.t] == 800)
                            {
                                if (this.mb > this.xx[9] - this.xx[0] * 2 - 2000
                                    && this.mb < this.xx[9] + this.xx[1] - this.xx[0] * 2 + 2000
                                    && this.ma + this.mnobia > this.xx[8] - 400 && this.ma < this.xx[8] + this.xx[1])
                                {
                                    this.ta[this.t] = -800000;
                                    this.resources.PlaySound(2);
                                }
                            }

                            if (this.ttype[this.t] == 140)
                            {
                                if (this.mb > this.xx[9] - this.xx[0] * 2 - 2000
                                    && this.mb < this.xx[9] + this.xx[1] - this.xx[0] * 2 + 2000
                                    && this.ma + this.mnobia > this.xx[8] - 400 && this.ma < this.xx[8] + this.xx[1])
                                {
                                    this.ta[this.t] = -800000;
                                    this.sracttype[20] = 1;
                                    this.sron[20] = 1;
                                    this.resources.StopMusic();
                                    this.mtype = 301;
                                    this.mtm = 0;
                                    this.resources.PlaySound(14);
                                }
                            }

                            if (this.ttype[this.t] == 100)
                            {
                                if (this.mb > this.xx[9] - this.xx[0] * 2 - 2000
                                    && this.mb < this.xx[9] + this.xx[1] - this.xx[0] * 2 + 2000
                                    && this.ma + this.mnobia > this.xx[8] - 400 && this.ma < this.xx[8] + this.xx[1]
                                    && this.md <= 0)
                                {
                                    if (this.txtype[this.t] == 0)
                                    {
                                        this.tb[this.t] = this.mb + this.screenY - 1200 - this.xx[1];
                                    }
                                }

                                if (this.txtype[this.t] == 1)
                                {
                                    if (this.xx[17] == 1)
                                    {
                                        if (this.ma + this.mnobia > this.xx[8] - 400
                                            && this.ma < this.xx[8] + this.xx[1] / 2 - 1500)
                                        {
                                            this.ta[this.t] += 3000;
                                        }
                                        else if (this.ma + this.mnobia >= this.xx[8] + this.xx[1] / 2 - 1500
                                                 && this.ma < this.xx[8] + this.xx[1])
                                        {
                                            this.ta[this.t] -= 3000;
                                        }
                                    }
                                }

                                if (this.xx[17] == 1 && this.txtype[this.t] == 0)
                                {
                                    this.resources.PlaySound(2);
                                    this.eyobi(
                                        this.ta[this.t] + 10,
                                        this.tb[this.t],
                                        0,
                                        -800,
                                        0,
                                        40,
                                        3000,
                                        3000,
                                        0,
                                        16);
                                    this.ttype[this.t] = 3;
                                }
                            }

                            if (this.ttype[this.t] == 101)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.resources.PlaySound(6);
                                    this.ttype[this.t] = 3;
                                    this.abrocktm[this.aco] = 16;
                                    if (this.txtype[this.t] == 0)
                                    {
                                        this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 0, 0);
                                    }

                                    if (this.txtype[this.t] == 1)
                                    {
                                        this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 4, 0);
                                    }

                                    if (this.txtype[this.t] == 3)
                                    {
                                        this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 101, 0);
                                    }

                                    if (this.txtype[this.t] == 4)
                                    {
                                        this.abrocktm[this.aco] = 20;
                                        this.ayobi(this.ta[this.t] - 400, this.tb[this.t] - 1600, 0, 0, 0, 6, 0);
                                    }
                                }
                            }

                            if (this.ttype[this.t] == 102)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.resources.PlaySound(6);
                                    this.ttype[this.t] = 3;
                                    this.abrocktm[this.aco] = 16;
                                    if (this.txtype[this.t] == 0)
                                    {
                                        this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 100, 0);
                                    }

                                    if (this.txtype[this.t] == 2)
                                    {
                                        this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 100, 2);
                                    }

                                    if (this.txtype[this.t] == 3)
                                    {
                                        this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 102, 1);
                                    }
                                }
                            }

                            if (this.ttype[this.t] == 103)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.resources.PlaySound(6);
                                    this.ttype[this.t] = 3;
                                    this.abrocktm[this.aco] = 16;
                                    this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 100, 1);
                                }
                            }

                            if (this.ttype[this.t] == 104)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.resources.PlaySound(6);
                                    this.ttype[this.t] = 3;
                                    this.abrocktm[this.aco] = 16;
                                    this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 110, 0);
                                }
                            }

                            if (this.ttype[this.t] == 110)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.ttype[this.t] = 111;
                                    this.thp[this.t] = 999;
                                }
                            }

                            if (this.ttype[this.t] == 111 && this.ta[this.t] - this.screenX >= 0)
                            {
                                this.thp[this.t]++;
                                if (this.thp[this.t] >= 16)
                                {
                                    this.thp[this.t] = 0;
                                    this.resources.PlaySound(6);
                                    this.abrocktm[this.aco] = 16;
                                    this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 102, 1);
                                }
                            }

                            if (this.ttype[this.t] == 112)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.ttype[this.t] = 113;
                                    this.thp[this.t] = 999;
                                    this.titem[this.t] = 0;
                                }
                            }

                            if (this.ttype[this.t] == 113 && this.ta[this.t] - this.screenX >= 0)
                            {
                                if (this.titem[this.t] <= 19)
                                {
                                    this.thp[this.t]++;
                                }

                                if (this.thp[this.t] >= 3)
                                {
                                    this.thp[this.t] = 0;
                                    this.titem[this.t]++;
                                    this.resources.PlaySound(2);
                                    this.eyobi(
                                        this.ta[this.t] + 10,
                                        this.tb[this.t],
                                        0,
                                        -800,
                                        0,
                                        40,
                                        3000,
                                        3000,
                                        0,
                                        16);
                                }
                            }

                            if (this.ttype[this.t] == 114)
                            {
                                if (this.xx[17] == 1)
                                {
                                    if (this.txtype[this.t] == 0)
                                    {
                                        this.resources.PlaySound(6);
                                        this.ttype[this.t] = 3;
                                        this.abrocktm[this.aco] = 16;
                                        this.ayobi(this.ta[this.t], this.tb[this.t], 0, 0, 0, 102, 1);
                                    }

                                    if (this.txtype[this.t] == 2)
                                    {
                                        this.resources.PlaySound(2);
                                        this.eyobi(
                                            this.ta[this.t] + 10,
                                            this.tb[this.t],
                                            0,
                                            -800,
                                            0,
                                            40,
                                            3000,
                                            3000,
                                            0,
                                            16);
                                        this.ttype[this.t] = 115;
                                        this.txtype[this.t] = 0;
                                    }

                                    if (this.txtype[this.t] == 10)
                                    {
                                        if (this.stageonoff == 1)
                                        {
                                            this.ttype[this.t] = 130;
                                            this.stageonoff = 0;
                                            this.resources.PlaySound(11);
                                            this.txtype[this.t] = 2;
                                            for (this.t = 0; this.t < this.amax; this.t++)
                                            {
                                                if (this.atype[this.t] == 87)
                                                {
                                                    if (this.axtype[this.t] == 105)
                                                    {
                                                        this.axtype[this.t] = 110;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            this.resources.PlaySound(2);
                                            this.eyobi(
                                                this.ta[this.t] + 10,
                                                this.tb[this.t],
                                                0,
                                                -800,
                                                0,
                                                40,
                                                3000,
                                                3000,
                                                0,
                                                16);
                                            this.ttype[this.t] = 3;
                                        }
                                    }
                                }
                            }

                            if (this.ttype[this.t] == 115)
                            {
                            }

                            if (this.ttype[this.t] == 116)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.resources.PlaySound(6);
                                    this.ttype[this.t] = 3;
                                    this.tyobi(this.ta[this.t] / 100, (this.tb[this.t] / 100) - 29, 400);
                                }
                            }

                            if (this.ttype[this.t] == 124)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.resources.PlaySound(11);
                                    for (this.t = 0; this.t < this.amax; this.t++)
                                    {
                                        if (this.atype[this.t] == 87)
                                        {
                                            if (this.axtype[this.t] == 101)
                                            {
                                                this.axtype[this.t] = 120;
                                            }
                                        }
                                    }

                                    this.ttype[this.t] = 3;
                                }
                            }

                            if (this.ttype[this.t] == 130)
                            {
                                if (this.xx[17] == 1)
                                {
                                    if (this.txtype[this.t] != 1)
                                    {
                                        this.stageonoff = 0;
                                        this.resources.PlaySound(11);
                                    }
                                }
                            }
                            else if (this.ttype[this.t] == 131)
                            {
                                if (this.xx[17] == 1 && this.txtype[this.t] != 2)
                                {
                                    this.stageonoff = 1;
                                    this.resources.PlaySound(11);
                                    if (this.txtype[this.t] == 1)
                                    {
                                        for (this.t = 0; this.t < this.amax; this.t++)
                                        {
                                            if (this.atype[this.t] == 87)
                                            {
                                                if (this.axtype[this.t] == 105)
                                                {
                                                    this.axtype[this.t] = 110;
                                                }
                                            }
                                        }

                                        this.bxtype[3] = 105;
                                    }
                                }
                            }

                            if (this.ttype[this.t] == 300)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.resources.PlaySound(13);
                                    if (this.txtype[this.t] <= 100)
                                    {
                                        this.tmsgtype = 1;
                                        this.tmsgtm = 15;
                                        this.tmsgy = 300 + (this.txtype[this.t] - 1);
                                        this.tmsg = (this.txtype[this.t]);
                                    }

                                    if (this.txtype[this.t] == 540)
                                    {
                                        this.tmsgtype = 1;
                                        this.tmsgtm = 15;
                                        this.tmsgy = 400;
                                        this.tmsg = 100;
                                        this.txtype[this.t] = 541;
                                    }
                                }
                            }

                            if (this.ttype[this.t] == 301)
                            {
                                if (this.xx[17] == 1)
                                {
                                    this.resources.PlaySound(1);
                                    this.eyobi(
                                        this.ta[this.t] + 1200,
                                        this.tb[this.t] + 1200,
                                        300,
                                        -1000,
                                        0,
                                        160,
                                        1000,
                                        1000,
                                        1,
                                        120);
                                    this.eyobi(
                                        this.ta[this.t] + 1200,
                                        this.tb[this.t] + 1200,
                                        -300,
                                        -1000,
                                        0,
                                        160,
                                        1000,
                                        1000,
                                        1,
                                        120);
                                    this.eyobi(
                                        this.ta[this.t] + 1200,
                                        this.tb[this.t] + 1200,
                                        240,
                                        -1400,
                                        0,
                                        160,
                                        1000,
                                        1000,
                                        1,
                                        120);
                                    this.eyobi(
                                        this.ta[this.t] + 1200,
                                        this.tb[this.t] + 1200,
                                        -240,
                                        -1400,
                                        0,
                                        160,
                                        1000,
                                        1000,
                                        1,
                                        120);
                                    this.brockbreak(this.t);
                                }
                            }
                        }
                        else if (this.mtype == 1)
                        {
                            if (this.ma + this.mnobia > this.xx[8] && this.ma < this.xx[8] + this.xx[1]
                                                                   && this.mb + this.mnobib > this.xx[9]
                                                                   && this.mb < this.xx[9] + this.xx[1])
                            {
                                this.resources.PlaySound(1);
                                this.eyobi(
                                    this.ta[this.t] + 1200,
                                    this.tb[this.t] + 1200,
                                    300,
                                    -1000,
                                    0,
                                    160,
                                    1000,
                                    1000,
                                    1,
                                    120);
                                this.eyobi(
                                    this.ta[this.t] + 1200,
                                    this.tb[this.t] + 1200,
                                    -300,
                                    -1000,
                                    0,
                                    160,
                                    1000,
                                    1000,
                                    1,
                                    120);
                                this.eyobi(
                                    this.ta[this.t] + 1200,
                                    this.tb[this.t] + 1200,
                                    240,
                                    -1400,
                                    0,
                                    160,
                                    1000,
                                    1000,
                                    1,
                                    120);
                                this.eyobi(
                                    this.ta[this.t] + 1200,
                                    this.tb[this.t] + 1200,
                                    -240,
                                    -1400,
                                    0,
                                    160,
                                    1000,
                                    1000,
                                    1,
                                    120);
                                this.brockbreak(this.t);
                            }
                        }

                        if (this.ttype[this.t] == 130 && this.stageonoff == 0)
                        {
                            this.ttype[this.t] = 131;
                        }

                        if (this.ttype[this.t] == 131 && this.stageonoff == 1)
                        {
                            this.ttype[this.t] = 130;
                        }

                        if (this.ttype[this.t] == 300)
                        {
                            if (this.txtype[this.t] >= 500 && this.ta[this.t] >= -6000)
                            {
                                if (this.txtype[this.t] <= 539)
                                {
                                    this.txtype[this.t]++;
                                }

                                if (this.txtype[this.t] >= 540)
                                {
                                    this.ta[this.t] -= 500;
                                }
                            }
                        }
                    }
                }

                for (this.t = 0; this.t < this.smax; this.t++)
                {
                    if (this.enemyX[this.t] - this.screenX + this.sc[this.t] >= -12000
                        && this.enemyX[this.t] - this.screenX <= fxmax)
                    {
                        this.xx[0] = 200;
                        this.xx[1] = 2400;
                        this.xx[2] = 1000;
                        this.xx[7] = 0;
                        this.xx[8] = this.enemyX[this.t] - this.screenX;
                        this.xx[9] = this.enemyY[this.t] - this.screenY;
                        if ((this.stype[this.t] <= 99 || this.stype[this.t] == 200) && this.mtype < 10)
                        {
                            if (this.stype[this.t] == 51)
                            {
                                if (this.ma + this.mnobia > this.xx[8] + this.xx[0] + 3000
                                    && this.ma < this.xx[8] + this.sc[this.t] - this.xx[0]
                                    && this.mb + this.mnobib > this.xx[9] + 3000 && this.sgtype[this.t] == 0)
                                {
                                    if (this.sxtype[this.t] == 0)
                                    {
                                        this.sgtype[this.t] = 1;
                                        this.sr[this.t] = 0;
                                    }
                                }

                                if (this.ma + this.mnobia > this.xx[8] + this.xx[0] + 1000
                                    && this.ma < this.xx[8] + this.sc[this.t] - this.xx[0]
                                    && this.mb + this.mnobib > this.xx[9] + 3000 && this.sgtype[this.t] == 0)
                                {
                                    if ((this.sxtype[this.t] == 10) && this.sgtype[this.t] == 0)
                                    {
                                        this.sgtype[this.t] = 1;
                                        this.sr[this.t] = 0;
                                    }
                                }

                                if ((this.sxtype[this.t] == 1) && this.enemyY[27] >= 25000
                                                               && this.enemyX[27] > this.ma + this.mnobia
                                                               && this.t != 27 && this.sgtype[this.t] == 0)
                                {
                                    this.sgtype[this.t] = 1;
                                    this.sr[this.t] = 0;
                                }

                                if (this.sxtype[this.t] == 2 && this.enemyY[28] >= 48000 && this.t != 28
                                    && this.sgtype[this.t] == 0 && this.mhp >= 1)
                                {
                                    this.sgtype[this.t] = 1;
                                    this.sr[this.t] = 0;
                                }

                                if ((this.sxtype[this.t] == 3 && this.mb >= 30000
                                     || this.sxtype[this.t] == 4 && this.mb >= 25000) && this.sgtype[this.t] == 0
                                                                                      && this.mhp >= 1
                                                                                      && this.ma + this.mnobia
                                                                                      > this.xx[8] + this.xx[0] + 3000
                                                                                      - 300 && this.ma
                                                                                      < this.xx[8] + this.sc[this.t]
                                                                                      - this.xx[0])
                                {
                                    this.sgtype[this.t] = 1;
                                    this.sr[this.t] = 0;
                                    if (this.sxtype[this.t] == 4)
                                    {
                                        this.sr[this.t] = 100;
                                    }
                                }

                                if (this.sgtype[this.t] == 1 && this.enemyY[this.t] <= fymax + 18000)
                                {
                                    this.sr[this.t] += 120;
                                    if (this.sr[this.t] >= 1600)
                                    {
                                        this.sr[this.t] = 1600;
                                    }

                                    this.enemyY[this.t] += this.sr[this.t];
                                    if (this.ma + this.mnobia > this.xx[8] + this.xx[0]
                                        && this.ma < this.xx[8] + this.sc[this.t] - this.xx[0]
                                        && this.mb + this.mnobib > this.xx[9]
                                        && this.mb < this.xx[9] + this.sd[this.t] + this.xx[0])
                                    {
                                        this.mhp--;
                                        this.xx[7] = 1;
                                    }
                                }
                            }

                            if (this.stype[this.t] == 52)
                            {
                                if (this.sgtype[this.t] == 0 && this.ma + this.mnobia > this.xx[8] + this.xx[0] + 2000
                                                             && this.ma < this.xx[8] + this.sc[this.t] - this.xx[0]
                                                                                                       - 2500 && this.mb
                                                             + this.mnobib > this.xx[9] - 3000)
                                {
                                    this.sgtype[this.t] = 1;
                                    this.sr[this.t] = 0;
                                }

                                if (this.sgtype[this.t] == 1)
                                {
                                    this.sr[this.t] += 120;
                                    if (this.sr[this.t] >= 1600)
                                    {
                                        this.sr[this.t] = 1600;
                                    }

                                    this.enemyY[this.t] += this.sr[this.t];
                                }
                            }

                            if (this.xx[7] == 0)
                            {
                                if (this.ma + this.mnobia > this.xx[8] + this.xx[0]
                                    && this.ma < this.xx[8] + this.sc[this.t] - this.xx[0]
                                    && this.mb + this.mnobib > this.xx[9]
                                    && this.mb + this.mnobib < this.xx[9] + this.xx[1] && this.md >= -100)
                                {
                                    this.mb = this.enemyY[this.t] - this.screenY - this.mnobib + 100;
                                    this.md = 0;
                                    this.mzimen = 1;
                                }

                                if (this.ma + this.mnobia > this.xx[8] - this.xx[0] && this.ma < this.xx[8] + this.xx[2]
                                                                                    && this.mb + this.mnobib
                                                                                    > this.xx[9] + this.xx[1] * 3 / 4
                                                                                    && this.mb < this.xx[9]
                                                                                    + this.sd[this.t] - this.xx[2])
                                {
                                    this.ma = this.xx[8] - this.xx[0] - this.mnobia;
                                    this.mc = 0;
                                }

                                if (this.ma + this.mnobia > this.xx[8] + this.sc[this.t] - this.xx[0]
                                    && this.ma < this.xx[8] + this.sc[this.t] + this.xx[0]
                                    && this.mb + this.mnobib > this.xx[9] + this.xx[1] * 3 / 4
                                    && this.mb < this.xx[9] + this.sd[this.t] - this.xx[2])
                                {
                                    this.ma = this.xx[8] + this.sc[this.t] + this.xx[0];
                                    this.mc = 0;
                                }

                                if (this.ma + this.mnobia > this.xx[8] + this.xx[0] * 2
                                    && this.ma < this.xx[8] + this.sc[this.t] - this.xx[0] * 2
                                    && this.mb > this.xx[9] + this.sd[this.t] - this.xx[1]
                                    && this.mb < this.xx[9] + this.sd[this.t] + this.xx[0])
                                {
                                    this.mb = this.xx[9] + this.sd[this.t] + this.xx[0];
                                    if (this.md < 0)
                                    {
                                        this.md = -this.md * 2 / 3;
                                    }
                                }
                            }

                            if (this.stype[this.t] == 50)
                            {
                                if (this.ma + this.mnobia > this.xx[8] + 2800
                                    && this.ma < this.xx[8] + this.sc[this.t] - 3000
                                    && this.mb + this.mnobib > this.xx[9] - 1000
                                    && this.mb + this.mnobib < this.xx[9] + this.xx[1] + 3000 && this.mzimen == 1
                                    && this.actaon[3] == 1 && this.mtype == 0)
                                {
                                    if (this.sxtype[this.t] == 0)
                                    {
                                        this.mtype = 100;
                                        this.mtm = 0;
                                        this.resources.PlaySound(5);
                                        this.mxtype = 0;
                                    }

                                    if (this.sxtype[this.t] == 1)
                                    {
                                        this.mtype = 100;
                                        this.mtm = 0;
                                        this.resources.PlaySound(5);
                                        this.mxtype = 1;
                                    }

                                    if (this.sxtype[this.t] == 2)
                                    {
                                        this.mtype = 100;
                                        this.mtm = 0;
                                        this.resources.PlaySound(5);
                                        this.mxtype = 2;
                                    }

                                    if (this.sxtype[this.t] == 5)
                                    {
                                        this.mtype = 100;
                                        this.mtm = 0;
                                        this.resources.PlaySound(5);
                                        this.mxtype = 5;
                                    }
                                }
                            }

                            if (this.stype[this.t] == 40)
                            {
                                if (this.ma + this.mnobia > this.xx[8] - 300
                                    && this.ma < this.xx[8] + this.sc[this.t] - 1000 && this.mb > this.xx[9] + 1000
                                    && this.mb + this.mnobib < this.xx[9] + this.xx[1] + 4000 && this.mzimen == 1
                                    && this.actaon[4] == 1 && this.mtype == 0)
                                {
                                    if (this.sxtype[this.t] == 0)
                                    {
                                        this.mtype = 500;
                                        this.mtm = 0;
                                        this.resources.PlaySound(5);
                                        this.mtype = 100;
                                        this.mxtype = 10;
                                    }

                                    if (this.sxtype[this.t] == 2)
                                    {
                                        this.mxtype = 3;
                                        this.mtm = 0;
                                        this.resources.PlaySound(5);
                                        this.mtype = 100;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (this.ma + this.mnobia > this.xx[8] + this.xx[0]
                                && this.ma < this.xx[8] + this.sc[this.t] - this.xx[0]
                                && this.mb + this.mnobib > this.xx[9]
                                && this.mb < this.xx[9] + this.sd[this.t] + this.xx[0])
                            {
                                if (this.stype[this.t] == 100)
                                {
                                    if (this.sxtype[this.t] == 0 || this.sxtype[this.t] == 1 && this.ttype[1] != 3)
                                    {
                                        this.ayobi(this.enemyX[this.t] + 1000, 32000, 0, 0, 0, 3, 0);
                                        this.enemyX[this.t] = -800000000;
                                        this.resources.PlaySound(8);
                                    }
                                }

                                if (this.stype[this.t] == 101)
                                {
                                    this.ayobi(this.enemyX[this.t] + 6000, -4000, 0, 0, 0, 3, 1);
                                    this.enemyX[this.t] = -800000000;
                                    this.resources.PlaySound(8);
                                }

                                if (this.stype[this.t] == 102)
                                {
                                    if (this.sxtype[this.t] == 0)
                                    {
                                        for (this.t3 = 0; this.t3 <= 3; this.t3++)
                                        {
                                            this.ayobi(this.enemyX[this.t] + this.t3 * 3000, -3000, 0, 0, 0, 0, 0);
                                        }
                                    }

                                    if (this.sxtype[this.t] == 1 && this.mb >= 16000)
                                    {
                                        this.ayobi(this.enemyX[this.t] + 1500, 44000, 0, -2000, 0, 4, 0);
                                    }
                                    else if (this.sxtype[this.t] == 2)
                                    {
                                        this.ayobi(this.enemyX[this.t] + 4500, 30000, 0, -1600, 0, 5, 0);
                                        this.resources.PlaySound(8);
                                        this.sxtype[this.t] = 3;
                                        this.enemyX[this.t] -= 12000;
                                    }
                                    else if (this.sxtype[this.t] == 3)
                                    {
                                        this.enemyX[this.t] += 12000;
                                        this.sxtype[this.t] = 4;
                                    }
                                    else if (this.sxtype[this.t] == 4)
                                    {
                                        this.ayobi(this.enemyX[this.t] + 4500, 30000, 0, -1600, 0, 5, 0);
                                        this.resources.PlaySound(8);
                                        this.sxtype[this.t] = 5;
                                        this.sxtype[this.t] = 0;
                                    }
                                    else if (this.sxtype[this.t] == 7)
                                    {
                                        this.mainmsgtype = 1;
                                    }
                                    else if (this.sxtype[this.t] == 8)
                                    {
                                        this.ayobi(this.enemyX[this.t] - 5000 - 3000 * 1, 26000, 0, -1600, 0, 5, 0);
                                        this.resources.PlaySound(8);
                                    }
                                    else if (this.sxtype[this.t] == 9)
                                    {
                                        for (this.t3 = 0; this.t3 <= 2; this.t3++)
                                        {
                                            this.ayobi(
                                                this.enemyX[this.t] + this.t3 * 3000 + 3000,
                                                48000,
                                                0,
                                                -6000,
                                                0,
                                                3,
                                                0);
                                        }
                                    }

                                    if (this.sxtype[this.t] == 10)
                                    {
                                        this.enemyX[this.t] -= 5 * 30 * 100;
                                        this.stype[this.t] = 101;
                                    }

                                    if (this.sxtype[this.t] == 12)
                                    {
                                        for (this.t3 = 1; this.t3 <= 3; this.t3++)
                                        {
                                            this.ayobi(
                                                this.enemyX[this.t] + this.t3 * 3000 - 1000,
                                                40000,
                                                0,
                                                -2600,
                                                0,
                                                9,
                                                0);
                                        }
                                    }

                                    if (this.sxtype[this.t] == 20)
                                    {
                                        this.scrollx = 0;
                                    }

                                    if (this.sxtype[this.t] == 30)
                                    {
                                        this.enemyX[this.t] = -80000000;
                                        this.md = 0;
                                        this.resources.StopMusic();
                                        this.mtype = 302;
                                        this.mtm = 0;
                                        this.resources.PlaySound(14);
                                    }

                                    if (this.sxtype[this.t] != 3 && this.sxtype[this.t] != 4
                                                                 && this.sxtype[this.t] != 10)
                                    {
                                        this.enemyX[this.t] = -800000000;
                                    }
                                }

                                if (this.stype[this.t] == 103)
                                {
                                    if (this.sxtype[this.t] == 0)
                                    {
                                        this.amsgtm[this.aco] = 10;
                                        this.amsgtype[this.aco] = 50;
                                        this.ayobi(
                                            this.enemyX[this.t] + 9000,
                                            this.enemyY[this.t] + 2000,
                                            0,
                                            0,
                                            0,
                                            79,
                                            0);
                                        this.enemyX[this.t] = -800000000;
                                    }

                                    if (this.sxtype[this.t] == 1 && this.ttype[6] <= 6)
                                    {
                                        this.amsgtm[this.aco] = 10;
                                        this.amsgtype[this.aco] = 50;
                                        this.ayobi(
                                            this.enemyX[this.t] - 12000,
                                            this.enemyY[this.t] + 2000,
                                            0,
                                            0,
                                            0,
                                            79,
                                            0);
                                        this.enemyX[this.t] = -800000000;
                                        this.txtype[9] = 500;
                                    }
                                }

                                if (this.stype[this.t] == 104)
                                {
                                    if (this.sxtype[this.t] == 0)
                                    {
                                        this.ayobi(
                                            this.enemyX[this.t] + 12000,
                                            this.enemyY[this.t] + 2000 + 3000,
                                            0,
                                            0,
                                            0,
                                            79,
                                            0);
                                        this.ayobi(
                                            this.enemyX[this.t] + 12000,
                                            this.enemyY[this.t] + 2000 + 3000,
                                            0,
                                            0,
                                            0,
                                            79,
                                            1);
                                        this.ayobi(
                                            this.enemyX[this.t] + 12000,
                                            this.enemyY[this.t] + 2000 + 3000,
                                            0,
                                            0,
                                            0,
                                            79,
                                            2);
                                        this.ayobi(
                                            this.enemyX[this.t] + 12000,
                                            this.enemyY[this.t] + 2000 + 3000,
                                            0,
                                            0,
                                            0,
                                            79,
                                            3);
                                        this.ayobi(
                                            this.enemyX[this.t] + 12000,
                                            this.enemyY[this.t] + 2000 + 3000,
                                            0,
                                            0,
                                            0,
                                            79,
                                            4);
                                        this.enemyX[this.t] = -800000000;
                                    }
                                }

                                if (this.stype[this.t] == 105 && this.mzimen == 0 && this.md >= 0)
                                {
                                    this.ta[1] -= 1000;
                                    this.ta[2] += 1000;
                                    this.sxtype[this.t]++;
                                    if (this.sxtype[this.t] >= 3)
                                    {
                                        this.enemyX[this.t] = -8000000;
                                    }
                                }

                                if (this.stype[this.t] == 300 && this.mtype == 0
                                                              && this.mb < this.xx[9] + this.sd[this.t] + this.xx[0]
                                                              - 3000 && this.mhp >= 1)
                                {
                                    this.resources.StopMusic();
                                    this.mtype = 300;
                                    this.mtm = 0;
                                    this.ma = this.enemyX[this.t] - this.screenX - 2000;
                                    this.resources.PlaySound(9);
                                }

                                if (this.stype[this.t] == 500 && this.mtype == 0 && this.mhp >= 1)
                                {
                                    this.tyuukan += 1;
                                    this.enemyX[this.t] = -80000000;
                                }
                            }

                            if (this.stype[this.t] == 180)
                            {
                                this.sr[this.t]++;
                                if (this.sr[this.t] >= this.sgtype[this.t])
                                {
                                    this.sr[this.t] = 0;
                                    this.ayobi(
                                        this.enemyX[this.t],
                                        30000,
                                        this.random.Next(600) - 300,
                                        -1600 - this.random.Next(900),
                                        0,
                                        84,
                                        0);
                                }
                            }
                        }
                    }
                }

                this.actaon[0] = 0;
                this.actaon[4] = 0;
                for (this.t = 0; this.t < this.srmax; this.t++)
                {
                    this.xx[10] = this.sra[this.t];
                    this.xx[11] = this.srb[this.t];
                    this.xx[12] = this.src[this.t];
                    this.xx[13] = this.srd[this.t];
                    this.xx[8] = this.xx[10] - this.screenX;
                    this.xx[9] = this.xx[11] - this.screenY;
                    if (this.xx[8] + this.xx[12] >= -10 - 12000 && this.xx[8] <= fxmax + 12100)
                    {
                        this.xx[0] = 500;
                        this.xx[1] = 1200;
                        this.xx[2] = 1000;
                        this.xx[7] = 2000;
                        if (this.md >= 100)
                        {
                            this.xx[1] = 900 + this.md;
                        }

                        if (this.md > this.xx[1])
                        {
                            this.xx[1] = this.md + 100;
                        }

                        this.srb[this.t] += this.sre[this.t];
                        this.sre[this.t] += this.srf[this.t];
                        switch (this.sracttype[this.t])
                        {
                            case 1:
                                if (this.sron[this.t] == 1)
                                {
                                    this.srf[this.t] = 60;
                                }

                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 5:
                                if (this.srmove[this.t] == 0)
                                {
                                    this.srmuki[this.t] = 0;
                                }
                                else
                                {
                                    this.srmuki[this.t] = 1;
                                }

                                if (this.srb[this.t] - this.screenY < -2100)
                                {
                                    this.srb[this.t] = fymax + this.screenY + this.scrolly + 2000;
                                }

                                if (this.srb[this.t] - this.screenY > fymax + this.scrolly + 2000)
                                {
                                    this.srb[this.t] = -2100 + this.screenY;
                                }

                                break;
                            case 6:
                                if (this.sron[this.t] == 1)
                                {
                                    this.srf[this.t] = 40;
                                }

                                break;
                            case 7:
                                break;
                        }

                        if (!(this.mztm >= 1 && this.mztype == 1 && this.actaon[3] == 1) && this.mhp >= 1)
                        {
                            if (this.ma + this.mnobia > this.xx[8] + this.xx[0]
                                && this.ma < this.xx[8] + this.xx[12] - this.xx[0] && this.mb + this.mnobib > this.xx[9]
                                && this.mb + this.mnobib < this.xx[9] + this.xx[1] && this.md >= -100)
                            {
                                this.mb = this.xx[9] - this.mnobib + 100;
                                if (this.srtype[this.t] == 1)
                                {
                                    this.sre[10] = 900;
                                    this.sre[11] = 900;
                                }

                                if (this.srsp[this.t] != 12)
                                {
                                    this.mzimen = 1;
                                    this.md = 0;
                                }
                                else
                                {
                                    this.md = -800;
                                }

                                if ((this.sracttype[this.t] == 1) && this.sron[this.t] == 0)
                                {
                                    this.sron[this.t] = 1;
                                }

                                if (this.sracttype[this.t] == 1 && this.sron[this.t] == 1 || this.sracttype[this.t] == 3
                                                                                          || this.sracttype[this.t]
                                                                                          == 5)
                                {
                                    this.mb += this.sre[this.t];
                                }

                                if (this.sracttype[this.t] == 7)
                                {
                                    if (this.actaon[2] != 1)
                                    {
                                        this.md = -600;
                                        this.mb -= 810;
                                    }

                                    if (this.actaon[2] == 1)
                                    {
                                        this.mb -= 400;
                                        this.md = -1400;
                                        this.mjumptm = 10;
                                    }
                                }

                                if (this.srsp[this.t] == 1)
                                {
                                    this.resources.PlaySound(1);
                                    this.eyobi(
                                        this.sra[this.t] + 200,
                                        this.srb[this.t] - 1000,
                                        -240,
                                        -1400,
                                        0,
                                        160,
                                        4500,
                                        4500,
                                        2,
                                        120);
                                    this.eyobi(
                                        this.sra[this.t] + 4500 - 200,
                                        this.srb[this.t] - 1000,
                                        240,
                                        -1400,
                                        0,
                                        160,
                                        4500,
                                        4500,
                                        3,
                                        120);
                                    this.sra[this.t] = -70000000;
                                }

                                if (this.srsp[this.t] == 2)
                                {
                                    this.mc = -2400;
                                    this.srmove[this.t] += 1;
                                    if (this.srmove[this.t] >= 100)
                                    {
                                        this.mhp = 0;
                                        this.mmsgtype = 53;
                                        this.mmsgtm = 30;
                                        this.srmove[this.t] = -5000;
                                    }
                                }
                            }

                            if (this.srsp[this.t] == 2 && this.mc != -2400 && this.srmove[this.t] > 0)
                            {
                                this.srmove[this.t]--;
                            }

                            if (this.srsp[this.t] == 11)
                            {
                                if (this.ma + this.mnobia > this.xx[8] + this.xx[0] - 2000
                                    && this.ma < this.xx[8] + this.xx[12] - this.xx[0])
                                {
                                    this.sron[this.t] = 1;
                                }

                                if (this.sron[this.t] == 1)
                                {
                                    this.srf[this.t] = 60;
                                    this.srb[this.t] += this.sre[this.t];
                                }
                            }

                            if (this.ma + this.mnobia > this.xx[8] + this.xx[0]
                                && this.ma < this.xx[8] + this.xx[12] - this.xx[0]
                                && this.mb > this.xx[9] - this.xx[1] / 2 && this.mb < this.xx[9] + this.xx[1] / 2)
                            {
                                if (this.srtype[this.t] == 2)
                                {
                                    if (this.md < 0)
                                    {
                                        this.md = -this.md;
                                    }

                                    this.mb += 110;
                                    if (this.mmutekitm <= 0)
                                    {
                                        this.mhp -= 1;
                                    }

                                    if (this.mmutekion != 1)
                                    {
                                        this.mmutekitm = 40;
                                    }
                                }
                            }

                            if (this.sracttype[this.t] == 6)
                            {
                                if (this.ma + this.mnobia > this.xx[8] + this.xx[0]
                                    && this.ma < this.xx[8] + this.xx[12] - this.xx[0])
                                {
                                    this.sron[this.t] = 1;
                                }
                            }
                        }

                        if (this.sracttype[this.t] == 2 || this.sracttype[this.t] == 4)
                        {
                            if (this.srmuki[this.t] == 0)
                            {
                                this.sra[this.t] -= this.srsok[this.t];
                            }

                            if (this.srmuki[this.t] == 1)
                            {
                                this.sra[this.t] += this.srsok[this.t];
                            }
                        }

                        if (this.sracttype[this.t] == 3 || this.sracttype[this.t] == 5)
                        {
                            if (this.srmuki[this.t] == 0)
                            {
                                this.srb[this.t] -= this.srsok[this.t];
                            }

                            if (this.srmuki[this.t] == 1)
                            {
                                this.srb[this.t] += this.srsok[this.t];
                            }
                        }

                        for (this.tt = 0; this.tt < this.amax; this.tt++)
                        {
                            if (this.azimentype[this.tt] == 1)
                            {
                                if (this.aa[this.tt] + this.anobia[this.tt] - this.screenX > this.xx[8] + this.xx[0]
                                    && this.aa[this.tt] - this.screenX < this.xx[8] + this.xx[12] - this.xx[0]
                                    && this.ab[this.tt] + this.anobib[this.tt] > this.xx[11] - 100
                                    && this.ab[this.tt] + this.anobib[this.tt] < this.xx[11] + this.xx[1] + 500
                                    && this.ad[this.tt] >= -100)
                                {
                                    this.ab[this.tt] = this.xx[9] - this.anobib[this.tt] + 100;
                                    this.ad[this.tt] = 0;
                                    this.axzimen[this.tt] = 1;
                                }
                            }
                        }
                    }
                }

                for (this.t = 0; this.t < this.emax; this.t++)
                {
                    this.xx[0] = this.ea[this.t] - this.screenX;
                    this.xx[1] = this.eb[this.t] - this.screenY;
                    this.xx[2] = this.enobia[this.t] / 100;
                    this.xx[3] = this.enobib[this.t] / 100;
                    if (this.etm[this.t] >= 0)
                    {
                        this.etm[this.t]--;
                    }

                    if (this.xx[0] + this.xx[2] * 100 >= -10 && this.xx[1] <= fxmax
                                                             && this.xx[1] + this.xx[3] * 100 >= -10 - 8000
                                                             && this.xx[3] <= fymax && this.etm[this.t] >= 0)
                    {
                        this.ea[this.t] += this.ec[this.t];
                        this.eb[this.t] += this.ed[this.t];
                        this.ec[this.t] += this.ee[this.t];
                        this.ed[this.t] += this.ef[this.t];
                    }
                    else
                    {
                        this.ea[this.t] = -9000000;
                    }
                }

                for (this.t = 0; this.t < this.bmax; this.t++)
                {
                    if (this.ba[this.t] >= -80000)
                    {
                        if (this.btm[this.t] >= 0)
                        {
                            this.btm[this.t] = this.btm[this.t] - 1;
                        }

                        for (this.tt = 0; this.tt <= 1; this.tt++)
                        {
                            this.xx[0] = 0;
                            this.xx[1] = 0;
                            if (this.bz[this.t] == 0 && this.btm[this.t] < 0
                                                     && this.ba[this.t] - this.screenX >= fxmax + 2000
                                                     && this.ba[this.t] - this.screenX < fxmax + 2000 + this.mc
                                                     && this.tt == 0)
                            {
                                this.xx[0] = 1;
                                this.amuki[this.aco] = 0;
                            }

                            if (this.bz[this.t] == 0 && this.btm[this.t] < 0
                                                     && this.ba[this.t] - this.screenX
                                                     >= -400 - this.anx[this.btype[this.t]] + this.mc
                                                     && this.ba[this.t] - this.screenX
                                                     < -400 - this.anx[this.btype[this.t]] && this.tt == 1)
                            {
                                this.xx[0] = 1;
                                this.xx[1] = 1;
                                this.amuki[this.aco] = 1;
                            }

                            if (this.bz[this.t] == 1
                                && this.ba[this.t] - this.screenX >= 0 - this.anx[this.btype[this.t]]
                                && this.ba[this.t] - this.screenX <= fxmax + 4000
                                && this.bb[this.t] - this.screenY >= -9000
                                && this.bb[this.t] - this.screenY <= fymax + 4000 && this.btm[this.t] < 0)
                            {
                                this.xx[0] = 1;
                                this.bz[this.t] = 0;
                            }

                            if (this.xx[0] == 1)
                            {
                                this.btm[this.t] = 401;
                                this.xx[0] = 0;
                                if (this.btype[this.t] >= 10)
                                {
                                    this.btm[this.t] = 9999999;
                                }

                                this.ayobi(
                                    this.ba[this.t],
                                    this.bb[this.t],
                                    0,
                                    0,
                                    0,
                                    this.btype[this.t],
                                    this.bxtype[this.t]);
                            }
                        }
                    }
                }

                for (this.t = 0; this.t < this.amax; this.t++)
                {
                    this.xx[0] = this.aa[this.t] - this.screenX;
                    this.xx[1] = this.ab[this.t] - this.screenY;
                    this.xx[2] = this.anobia[this.t];
                    this.xx[3] = this.anobib[this.t];
                    this.xx[14] = 12000 * 1;
                    if (this.anotm[this.t] >= 0)
                    {
                        this.anotm[this.t]--;
                    }

                    if (this.xx[0] + this.xx[2] >= -this.xx[14] && this.xx[0] <= fxmax + this.xx[14]
                                                                && this.xx[1] + this.xx[3] >= -10 - 9000
                                                                && this.xx[1] <= fymax + 20000)
                    {
                        this.aacta[this.t] = 0;
                        this.aactb[this.t] = 0;
                        this.xx[10] = 0;
                        switch (this.atype[this.t])
                        {
                            case 0:
                                this.xx[10] = 100;
                                break;
                            case 1:
                                this.xx[10] = 100;
                                break;
                            case 2:
                                this.xx[10] = 0;
                                this.xx[17] = 800;
                                if (this.axtype[this.t] >= 1)
                                {
                                    this.xx[10] = this.xx[17];
                                }

                                if (this.axtype[this.t] >= 1)
                                {
                                    for (this.tt = 0; this.tt < this.amax; this.tt++)
                                    {
                                        this.xx[0] = 250;
                                        this.xx[5] = -800;
                                        this.xx[12] = 0;
                                        this.xx[1] = 1600;
                                        this.xx[8] = this.aa[this.tt] - this.screenX;
                                        this.xx[9] = this.ab[this.tt] - this.screenY;
                                        if (this.t != this.tt)
                                        {
                                            if (this.aa[this.t] + this.anobia[this.t] - this.screenX
                                                > this.xx[8] + this.xx[0] * 2
                                                && this.aa[this.t] - this.screenX
                                                < this.xx[8] + this.anobia[this.tt] - this.xx[0] * 2
                                                && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                                > this.xx[9] + this.xx[5]
                                                && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                                < this.xx[9] + this.xx[1] * 3 + this.xx[12] + 1500)
                                            {
                                                this.aa[this.tt] = -800000;
                                                this.resources.PlaySound(4);
                                            }
                                        }
                                    }
                                }

                                break;
                            case 3:
                                this.azimentype[this.t] = 0;
                                if (this.axtype[this.t] == 0)
                                {
                                    this.ab[this.t] -= 800;
                                }

                                if (this.axtype[this.t] == 1)
                                {
                                    this.ab[this.t] += 1200;
                                }

                                break;
                            case 4:
                                this.xx[10] = 120;
                                this.xx[0] = 250;
                                this.xx[8] = this.aa[this.t] - this.screenX;
                                this.xx[9] = this.ab[this.t] - this.screenY;
                                if (this.atm[this.t] >= 0)
                                {
                                    this.atm[this.t]--;
                                }

                                if (this.ma + this.mnobia > this.xx[8] + this.xx[0] * 2 - 3000
                                    && this.ma < this.xx[8] + this.anobia[this.t] - this.xx[0] * 2 + 3000
                                    && this.md <= -600 && this.atm[this.t] <= 0)
                                {
                                    if (this.axtype[this.t] == 1 && this.mzimen == 0 && this.axzimen[this.t] == 1)
                                    {
                                        this.ad[this.t] = -1600;
                                        this.atm[this.t] = 40;
                                        this.ab[this.t] -= 1000;
                                    }
                                }

                                break;
                            case 5:
                                this.xx[10] = 160;
                                break;
                            case 6:
                                if (this.azimentype[this.t] == 30)
                                {
                                    this.ad[this.t] = -1600;
                                    this.ab[this.t] += this.ad[this.t];
                                }

                                this.xx[10] = 120;
                                if (this.atm[this.t] >= 10)
                                {
                                    this.atm[this.t]++;
                                    if (this.mhp >= 1)
                                    {
                                        if (this.atm[this.t] <= 19)
                                        {
                                            this.ma = this.xx[0];
                                            this.mb = this.xx[1] - 3000;
                                            this.mtype = 0;
                                        }

                                        this.xx[10] = 0;
                                        if (this.atm[this.t] == 20)
                                        {
                                            this.mc = 700;
                                            this.mkeytm = 24;
                                            this.md = -1200;
                                            this.mb = this.xx[1] - 1000 - 3000;
                                            this.amuki[this.t] = 1;
                                            if (this.axtype[this.t] == 1)
                                            {
                                                this.mc = 840;
                                                this.axtype[this.t] = 0;
                                            }
                                        }

                                        if (this.atm[this.t] == 40)
                                        {
                                            this.amuki[this.t] = 0;
                                            this.atm[this.t] = 0;
                                        }
                                    }
                                }

                                if (this.axtype[this.t] == 1)
                                {
                                    for (this.tt = 0; this.tt < this.smax; this.tt++)
                                    {
                                        if (this.stype[this.tt] == 300)
                                        {
                                            if (this.aa[this.t] - this.screenX >= -8000
                                                && this.aa[this.t] >= this.enemyX[this.tt] + 2000
                                                && this.aa[this.t] <= this.enemyX[this.tt] + 3600
                                                && this.axzimen[this.t] == 1)
                                            {
                                                this.enemyX[this.tt] = -800000;
                                                this.atm[this.t] = 100;
                                            }
                                        }
                                    }

                                    if (this.atm[this.t] == 100)
                                    {
                                        this.eyobi(
                                            this.aa[this.t] + 1200 - 1200,
                                            this.ab[this.t] + 3000 - 10 * 3000 - 1500,
                                            0,
                                            0,
                                            0,
                                            0,
                                            1000,
                                            10 * 3000 - 1200,
                                            4,
                                            20);
                                        if (this.mtype == 300)
                                        {
                                            this.mtype = 0;
                                            this.resources.StopMusic();
                                            this.resources.ChangeMusic(17);
                                            this.resources.StartMusic();
                                        }

                                        for (this.t1 = 0; this.t1 < this.smax; this.t1++)
                                        {
                                            if (this.stype[this.t1] == 104)
                                            {
                                                this.enemyX[this.t1] = -80000000;
                                            }
                                        }
                                    }

                                    if (this.atm[this.t] == 120)
                                    {
                                        this.eyobi(
                                            this.aa[this.t] + 1200 - 1200,
                                            this.ab[this.t] + 3000 - 10 * 3000 - 1500,
                                            600,
                                            -1200,
                                            0,
                                            160,
                                            1000,
                                            10 * 3000 - 1200,
                                            4,
                                            240);
                                        this.amuki[this.t] = 1;
                                    }

                                    if (this.atm[this.t] == 140)
                                    {
                                        this.amuki[this.t] = 0;
                                        this.atm[this.t] = 0;
                                    }
                                }

                                if (this.atm[this.t] >= 220)
                                {
                                    this.atm[this.t] = 0;
                                    this.amuki[this.t] = 0;
                                }

                                for (this.tt = 0; this.tt < this.amax; this.tt++)
                                {
                                    this.xx[0] = 250;
                                    this.xx[5] = -800;
                                    this.xx[12] = 0;
                                    this.xx[1] = 1600;
                                    this.xx[8] = this.aa[this.tt] - this.screenX;
                                    this.xx[9] = this.ab[this.tt] - this.screenY;
                                    if (this.t != this.tt && this.atype[this.tt] >= 100)
                                    {
                                        if (this.aa[this.t] + this.anobia[this.t] - this.screenX
                                            > this.xx[8] + this.xx[0] * 2
                                            && this.aa[this.t] - this.screenX
                                            < this.xx[8] + this.anobia[this.tt] - this.xx[0] * 2
                                            && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                            > this.xx[9] + this.xx[5]
                                            && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                            < this.xx[9] + this.xx[1] * 3 + this.xx[12] + 1500)
                                        {
                                            this.amuki[this.tt] = 1;
                                            this.aa[this.tt] = this.aa[this.t] + 300;
                                            this.ab[this.tt] = this.ab[this.t] - 3000;
                                            this.abrocktm[this.tt] = 120;
                                            this.atm[this.t] = 200;
                                            this.amuki[this.t] = 1;
                                        }
                                    }
                                }

                                break;
                            case 7:
                                this.azimentype[this.t] = 0;
                                this.xx[10] = 0;
                                this.xx[11] = 400;
                                if (this.axtype[this.t] == 0)
                                {
                                    this.xx[10] = this.xx[11];
                                }

                                if (this.axtype[this.t] == 1)
                                {
                                    this.xx[10] = -this.xx[11];
                                }

                                if (this.axtype[this.t] == 2)
                                {
                                    this.ab[this.t] -= this.xx[11];
                                }

                                if (this.axtype[this.t] == 3)
                                {
                                    this.ab[this.t] += this.xx[11];
                                }

                                break;
                            case 8:
                                this.azimentype[this.t] = 0;
                                this.xx[22] = 20;
                                if (this.atm[this.t] == 0)
                                {
                                    this.af[this.t] += this.xx[22];
                                    this.ad[this.t] += this.xx[22];
                                }

                                if (this.atm[this.t] == 1)
                                {
                                    this.af[this.t] -= this.xx[22];
                                    this.ad[this.t] -= this.xx[22];
                                }

                                if (this.ad[this.t] > 300)
                                {
                                    this.ad[this.t] = 300;
                                }

                                if (this.ad[this.t] < -300)
                                {
                                    this.ad[this.t] = -300;
                                }

                                if (this.af[this.t] >= 1200)
                                {
                                    this.atm[this.t] = 1;
                                }

                                if (this.af[this.t] < -0)
                                {
                                    this.atm[this.t] = 0;
                                }

                                this.ab[this.t] += this.ad[this.t];
                                break;
                            case 151:
                                this.azimentype[this.t] = 2;
                                break;
                            case 9:
                                this.azimentype[this.t] = 5;
                                this.ab[this.t] += this.ad[this.t];
                                this.ad[this.t] += 100;
                                if (this.ab[this.t] >= fymax + 1000)
                                {
                                    this.ad[this.t] = 900;
                                }

                                if (this.ab[this.t] >= fymax + 12000)
                                {
                                    this.ab[this.t] = fymax;
                                    this.ad[this.t] = -2600;
                                }

                                break;
                            case 10:
                                this.azimentype[this.t] = 0;
                                this.xx[10] = 0;
                                this.xx[11] = 400;
                                if (this.axtype[this.t] == 0)
                                {
                                    this.xx[10] = this.xx[11];
                                }

                                if (this.axtype[this.t] == 1)
                                {
                                    this.xx[10] = -this.xx[11];
                                }

                                break;
                            case 30:
                                this.atm[this.t] += 1;
                                if (this.axtype[this.t] == 0)
                                {
                                    if (this.atm[this.t] == 50 && this.mb >= 6000)
                                    {
                                        this.ac[this.t] = 300;
                                        this.ad[this.t] -= 1600;
                                        this.ab[this.t] -= 1000;
                                    }

                                    for (this.tt = 0; this.tt < this.amax; this.tt++)
                                    {
                                        this.xx[0] = 250;
                                        this.xx[5] = -800;
                                        this.xx[12] = 0;
                                        this.xx[1] = 1600;
                                        this.xx[8] = this.aa[this.tt] - this.screenX;
                                        this.xx[9] = this.ab[this.tt] - this.screenY;
                                        if (this.t != this.tt && this.atype[this.tt] == 102)
                                        {
                                            if (this.aa[this.t] + this.anobia[this.t] - this.screenX
                                                > this.xx[8] + this.xx[0] * 2
                                                && this.aa[this.t] - this.screenX
                                                < this.xx[8] + this.anobia[this.tt] - this.xx[0] * 2
                                                && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                                > this.xx[9] + this.xx[5]
                                                && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                                < this.xx[9] + this.xx[1] * 3 + this.xx[12] + 1500)
                                            {
                                                this.aa[this.tt] = -800000;
                                                this.axtype[this.t] = 1;
                                                this.ad[this.t] = -1600;
                                                this.amsgtm[this.t] = 30;
                                                this.amsgtype[this.t] = 25;
                                            }
                                        }
                                    }
                                }

                                if (this.axtype[this.t] == 1)
                                {
                                    this.azimentype[this.t] = 0;
                                    this.ab[this.t] += this.ad[this.t];
                                    this.ad[this.t] += 120;
                                }

                                break;
                            case 79:
                                this.azimentype[this.t] = 0;
                                this.xx[10] = 1600;
                                if (this.axtype[this.t] == 1)
                                {
                                    this.xx[10] = 1200;
                                    this.ab[this.t] -= 200;
                                }

                                if (this.axtype[this.t] == 2)
                                {
                                    this.xx[10] = 1200;
                                    this.ab[this.t] += 200;
                                }

                                if (this.axtype[this.t] == 3)
                                {
                                    this.xx[10] = 900;
                                    this.ab[this.t] -= 600;
                                }

                                if (this.axtype[this.t] == 4)
                                {
                                    this.xx[10] = 900;
                                    this.ab[this.t] += 600;
                                }

                                break;
                            case 80:
                                this.azimentype[this.t] = 0;
                                break;
                            case 81:
                                this.azimentype[this.t] = 0;
                                break;
                            case 82:
                                this.azimentype[this.t] = 0;
                                break;
                            case 83:
                                this.azimentype[this.t] = 0;
                                break;
                            case 84:
                                this.azimentype[this.t] = 2;
                                break;
                            case 85:
                                this.xx[23] = 400;
                                if (this.axtype[this.t] == 0)
                                {
                                    this.axtype[this.t] = 1;
                                    this.amuki[this.t] = 1;
                                }

                                if (this.mb >= 30000 && this.ma >= this.aa[this.t] - 3000 * 5 - this.screenX
                                                     && this.ma <= this.aa[this.t] - this.screenX
                                                     && this.axtype[this.t] == 1)
                                {
                                    this.axtype[this.t] = 5;
                                    this.amuki[this.t] = 0;
                                }

                                if (this.mb >= 24000 && this.ma <= this.aa[this.t] + 3000 * 8 - this.screenX
                                                     && this.ma >= this.aa[this.t] - this.screenX
                                                     && this.axtype[this.t] == 1)
                                {
                                    this.axtype[this.t] = 5;
                                    this.amuki[this.t] = 1;
                                }

                                if (this.axtype[this.t] == 5)
                                {
                                    this.xx[10] = this.xx[23];
                                }

                                break;
                            case 86:
                                this.azimentype[this.t] = 4;
                                this.xx[23] = 1000;
                                if (this.ma >= this.aa[this.t] - this.screenX - this.mnobia - this.xx[26]
                                    && this.ma <= this.aa[this.t] - this.screenX + this.anobia[this.t] + this.xx[26])
                                {
                                    this.atm[this.t] = 1;
                                }

                                if (this.atm[this.t] == 1)
                                {
                                    this.ab[this.t] += 1200;
                                }

                                break;
                            case 87:
                                this.azimentype[this.t] = 0;
                                if (this.aa[this.t] % 10 != 1)
                                {
                                    this.atm[this.t] += 6;
                                }
                                else
                                {
                                    this.atm[this.t] -= 6;
                                }

                                this.xx[25] = 2;
                                if (this.atm[this.t] > 360 * this.xx[25])
                                {
                                    this.atm[this.t] -= 360 * this.xx[25];
                                }

                                if (this.atm[this.t] < 0)
                                {
                                    this.atm[this.t] += 360 * this.xx[25];
                                }

                                for (this.tt = 0; this.tt <= this.axtype[this.t] % 100; this.tt++)
                                {
                                    this.xx[26] = 18;
                                    this.xd[4] = this.tt * this.xx[26]
                                                         * Math.Cos(this.atm[this.t] * this.pai / 180 / 2);
                                    this.xd[5] = this.tt * this.xx[26]
                                                         * Math.Sin(this.atm[this.t] * this.pai / 180 / 2);
                                    this.xx[4] = 1800;
                                    this.xx[5] = 800;
                                    this.xx[8] = this.aa[this.t] - this.screenX + ((int)this.xd[4]) * 100
                                                 - this.xx[4] / 2;
                                    this.xx[9] = this.ab[this.t] - this.screenY + ((int)this.xd[5]) * 100
                                                 - this.xx[4] / 2;
                                    if (this.ma + this.mnobia > this.xx[8] + this.xx[5]
                                        && this.ma < this.xx[8] + this.xx[4] - this.xx[5]
                                        && this.mb + this.mnobib > this.xx[9] + this.xx[5]
                                        && this.mb < this.xx[9] + this.xx[4] - this.xx[5])
                                    {
                                        this.mhp -= 1;
                                        this.mmsgtype = 51;
                                        this.mmsgtm = 30;
                                    }
                                }

                                break;
                            case 90:
                                this.xx[10] = 160;
                                break;
                            case 100:
                                this.azimentype[this.t] = 1;
                                this.xx[10] = 100;
                                if (this.axtype[this.t] == 2)
                                {
                                    for (this.tt = 0; this.tt < this.amax; this.tt++)
                                    {
                                        this.xx[0] = 250;
                                        this.xx[5] = -800;
                                        this.xx[12] = 0;
                                        this.xx[1] = 1600;
                                        this.xx[8] = this.aa[this.tt] - this.screenX;
                                        this.xx[9] = this.ab[this.tt] - this.screenY;
                                        if (this.t != this.tt)
                                        {
                                            if (this.aa[this.t] + this.anobia[this.t] - this.screenX
                                                > this.xx[8] + this.xx[0] * 2
                                                && this.aa[this.t] - this.screenX
                                                < this.xx[8] + this.anobia[this.tt] - this.xx[0] * 2
                                                && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                                > this.xx[9] + this.xx[5]
                                                && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                                < this.xx[9] + this.xx[1] * 3 + this.xx[12])
                                            {
                                                if (this.atype[this.tt] == 0 || this.atype[this.tt] == 4)
                                                {
                                                    this.atype[this.tt] = 90;
                                                    this.anobia[this.tt] = 6400;
                                                    this.anobib[this.tt] = 6300;
                                                    this.axtype[this.tt] = 0;
                                                    this.aa[this.tt] -= 1050;
                                                    this.ab[this.tt] -= 1050;
                                                    this.resources.PlaySound(7);
                                                    this.aa[this.t] = -80000000;
                                                }
                                            }
                                        }
                                    }
                                }

                                break;
                            case 102:
                                this.azimentype[this.t] = 1;
                                this.xx[10] = 100;
                                if (this.axtype[this.t] == 1)
                                {
                                    this.xx[10] = 200;
                                }

                                break;
                            case 110:
                                this.azimentype[this.t] = 1;
                                this.xx[10] = 200;
                                if (this.axzimen[this.t] == 1)
                                {
                                    this.ab[this.t] -= 1200;
                                    this.ad[this.t] = -1400;
                                }

                                break;
                            case 200:
                                this.azimentype[this.t] = 1;
                                this.xx[10] = 100;
                                break;
                        }

                        if (this.abrocktm[this.t] >= 1)
                        {
                            this.xx[10] = 0;
                        }

                        if (this.amuki[this.t] == 0)
                        {
                            this.aacta[this.t] -= this.xx[10];
                        }

                        if (this.amuki[this.t] == 1)
                        {
                            this.aacta[this.t] += this.xx[10];
                        }

                        this.xx[0] = 850;
                        this.xx[1] = 1200;
                        if (this.ad[this.t] > this.xx[1] && this.azimentype[this.t] != 5)
                        {
                            this.ad[this.t] = this.xx[1];
                        }

                        this.aa[this.t] += this.aacta[this.t];
                        if ((this.azimentype[this.t] >= 1 || this.azimentype[this.t] == -1)
                            && this.abrocktm[this.t] <= 0)
                        {
                            this.aa[this.t] += this.ac[this.t];
                            if (this.azimentype[this.t] >= 1 && this.azimentype[this.t] <= 3)
                            {
                                this.ab[this.t] += this.ad[this.t];
                                this.ad[this.t] += 120;
                            }

                            if (this.axzimen[this.t] == 1)
                            {
                                this.xx[0] = 100;
                                if (this.ac[this.t] >= 200)
                                {
                                    this.ac[this.t] -= this.xx[0];
                                }
                                else if (this.ac[this.t] <= -200)
                                {
                                    this.ac[this.t] += this.xx[0];
                                }
                                else
                                {
                                    this.ac[this.t] = 0;
                                }
                            }

                            this.axzimen[this.t] = 0;
                            if (this.azimentype[this.t] != 2)
                            {
                                this.tekizimen();
                            }
                        }

                        if (this.abrocktm[this.t] > 0)
                        {
                            this.abrocktm[this.t]--;
                            if (this.abrocktm[this.t] < 100)
                            {
                                this.ab[this.t] -= 180;
                            }

                            if (this.abrocktm[this.t] > 100)
                            {
                            }

                            if (this.abrocktm[this.t] == 100)
                            {
                                this.ab[this.t] -= 800;
                                this.ad[this.t] = -1200;
                                this.ac[this.t] = 700;
                                this.abrocktm[this.t] = 0;
                            }
                        }

                        this.xx[0] = 250;
                        this.xx[1] = 1600;
                        this.xx[2] = 1000;
                        this.xx[4] = 500;
                        this.xx[5] = -800;
                        this.xx[8] = this.aa[this.t] - this.screenX;
                        this.xx[9] = this.ab[this.t] - this.screenY;
                        this.xx[12] = 0;
                        if (this.md >= 100)
                        {
                            this.xx[12] = this.md;
                        }

                        this.xx[25] = 0;
                        if (this.ma + this.mnobia > this.xx[8] + this.xx[0] * 2
                            && this.ma < this.xx[8] + this.anobia[this.t] - this.xx[0] * 2
                            && this.mb + this.mnobib > this.xx[9] - this.xx[5]
                            && this.mb + this.mnobib < this.xx[9] + this.xx[1] + this.xx[12]
                            && (this.mmutekitm <= 0 || this.md >= 100) && this.abrocktm[this.t] <= 0)
                        {
                            if (this.atype[this.t] != 4 && this.atype[this.t] != 9 && this.atype[this.t] != 10
                                && (this.atype[this.t] <= 78 || this.atype[this.t] == 85) && this.mzimen != 1
                                && this.mtype != 200)
                            {
                                if (this.atype[this.t] == 0)
                                {
                                    if (this.axtype[this.t] == 0)
                                    {
                                        this.aa[this.t] = -900000;
                                    }

                                    if (this.axtype[this.t] == 1)
                                    {
                                        this.resources.PlaySound(3);
                                        this.mb = this.xx[9] - 900 - this.anobib[this.t];
                                        this.md = -2100;
                                        this.xx[25] = 1;
                                        this.actaon[2] = 0;
                                    }
                                }

                                if (this.atype[this.t] == 1)
                                {
                                    this.atype[this.t] = 2;
                                    this.anobib[this.t] = 3000;
                                    this.axtype[this.t] = 0;
                                }
                                else if (this.atype[this.t] == 2 && this.md >= 0)
                                {
                                    if (this.axtype[this.t] == 1 || this.axtype[this.t] == 2)
                                    {
                                        this.axtype[this.t] = 0;
                                    }
                                    else if (this.axtype[this.t] == 0)
                                    {
                                        if (this.ma + this.mnobia > this.xx[8] + this.xx[0] * 2
                                            && this.ma < this.xx[8] + this.anobia[this.t] / 2 - this.xx[0] * 4)
                                        {
                                            this.axtype[this.t] = 1;
                                            this.amuki[this.t] = 1;
                                        }
                                        else
                                        {
                                            this.axtype[this.t] = 1;
                                            this.amuki[this.t] = 0;
                                        }
                                    }
                                }

                                if (this.atype[this.t] == 3)
                                {
                                    this.xx[25] = 1;
                                }

                                if (this.atype[this.t] == 6)
                                {
                                    this.atm[this.t] = 10;
                                    this.md = 0;
                                    this.actaon[2] = 0;
                                }

                                if (this.atype[this.t] == 7)
                                {
                                    this.aa[this.t] = -900000;
                                }

                                if (this.atype[this.t] == 8)
                                {
                                    this.atype[this.t] = 151;
                                    this.ad[this.t] = 0;
                                }

                                if (this.atype[this.t] != 85)
                                {
                                    if (this.xx[25] == 0)
                                    {
                                        this.resources.PlaySound(3);
                                        this.mb = this.xx[9] - 1000 - this.anobib[this.t];
                                        this.md = -1000;
                                    }
                                }

                                if (this.atype[this.t] == 85)
                                {
                                    if (this.xx[25] == 0)
                                    {
                                        this.resources.PlaySound(3);
                                        this.mb = this.xx[9] - 4000;
                                        this.md = -1000;
                                        this.axtype[this.t] = 5;
                                    }
                                }

                                if (this.actaon[2] == 1)
                                {
                                    this.md = -1600;
                                    this.actaon[2] = 0;
                                }
                            }
                        }

                        this.xx[15] = -500;
                        this.xx[16] = 0;
                        if (this.atype[this.t] == 4 || this.atype[this.t] == 9 || this.atype[this.t] == 10)
                        {
                            this.xx[16] = -3000;
                        }

                        if (this.atype[this.t] == 82 || this.atype[this.t] == 83 || this.atype[this.t] == 84)
                        {
                            this.xx[16] = -3200;
                        }

                        if (this.atype[this.t] == 85)
                        {
                            this.xx[16] = -this.anobib[this.t] + 6000;
                        }

                        if (this.ma + this.mnobia > this.xx[8] + this.xx[4]
                            && this.ma < this.xx[8] + this.anobia[this.t] - this.xx[4]
                            && this.mb < this.xx[9] + this.anobib[this.t] + this.xx[15]
                            && this.mb + this.mnobib > this.xx[9] + this.anobib[this.t] - this.xx[0] + this.xx[16]
                            && this.anotm[this.t] <= 0 && this.abrocktm[this.t] <= 0)
                        {
                            if (this.mmutekion == 1)
                            {
                                this.aa[this.t] = -9000000;
                            }

                            if (this.mmutekitm <= 0 && (this.atype[this.t] <= 99 || this.atype[this.t] >= 200))
                            {
                                if (this.mmutekion != 1 && this.mtype != 200)
                                {
                                    if ((this.atype[this.t] != 2 || this.axtype[this.t] != 0) && this.mhp >= 1)
                                    {
                                        if (this.atype[this.t] != 6)
                                        {
                                            this.mhp -= 1;
                                        }
                                    }

                                    if (this.atype[this.t] == 6)
                                    {
                                        this.atm[this.t] = 10;
                                    }

                                    if (this.mhp == 0)
                                    {
                                        if (this.atype[this.t] == 0 || this.atype[this.t] == 7)
                                        {
                                            this.amsgtm[this.t] = 60;
                                            this.amsgtype[this.t] =
                                                this.random.Next(7) + 1 + 1000 + (this.stb - 1) * 10;
                                        }

                                        if (this.atype[this.t] == 1)
                                        {
                                            this.amsgtm[this.t] = 60;
                                            this.amsgtype[this.t] = 15;
                                        }

                                        if (this.atype[this.t] == 2 && this.axtype[this.t] >= 1 && this.mmutekitm <= 0)
                                        {
                                            this.amsgtm[this.t] = 60;
                                            this.amsgtype[this.t] = 18;
                                        }

                                        if (this.atype[this.t] == 3)
                                        {
                                            this.amsgtm[this.t] = 60;
                                            this.amsgtype[this.t] = 20;
                                        }

                                        if (this.atype[this.t] == 4)
                                        {
                                            this.amsgtm[this.t] = 60;
                                            this.amsgtype[this.t] =
                                                this.random.Next(7) + 1 + 1000 + (this.stb - 1) * 10;
                                        }

                                        if (this.atype[this.t] == 5)
                                        {
                                            this.amsgtm[this.t] = 60;
                                            this.amsgtype[this.t] = 21;
                                        }

                                        if (this.atype[this.t] == 9 || this.atype[this.t] == 10)
                                        {
                                            this.mmsgtm = 30;
                                            this.mmsgtype = 54;
                                        }

                                        if (this.atype[this.t] == 31)
                                        {
                                            this.amsgtm[this.t] = 30;
                                            this.amsgtype[this.t] = 24;
                                        }

                                        if (this.atype[this.t] == 80 || this.atype[this.t] == 81)
                                        {
                                            this.amsgtm[this.t] = 60;
                                            this.amsgtype[this.t] = 30;
                                        }

                                        if (this.atype[this.t] == 82)
                                        {
                                            this.amsgtm[this.t] = 20;
                                            this.amsgtype[this.t] = 31;
                                            this.xx[24] = 900;
                                            this.atype[this.t] = 83;
                                            this.aa[this.t] -= this.xx[24] + 100;
                                            this.ab[this.t] -= this.xx[24] - 100 * 0;
                                        }

                                        if (this.atype[this.t] == 84)
                                        {
                                            this.mmsgtm = 30;
                                            this.mmsgtype = 50;
                                        }

                                        if (this.atype[this.t] == 85)
                                        {
                                            this.amsgtm[this.t] = 60;
                                            this.amsgtype[this.t] = 85;
                                        }

                                        if (this.atype[this.t] == 80)
                                        {
                                            this.atype[this.t] = 81;
                                        }
                                    }

                                    if (this.atype[this.t] == 2)
                                    {
                                        if (this.axtype[this.t] == 0)
                                        {
                                            if (this.ma + this.mnobia > this.xx[8] + this.xx[0] * 2
                                                && this.ma < this.xx[8] + this.anobia[this.t] / 2 - this.xx[0] * 4)
                                            {
                                                this.axtype[this.t] = 1;
                                                this.amuki[this.t] = 1;
                                                this.aa[this.t] = this.ma + this.mnobia + this.screenX + this.mc;
                                                this.mmutekitm = 5;
                                            }
                                            else
                                            {
                                                this.axtype[this.t] = 1;
                                                this.amuki[this.t] = 0;
                                                this.aa[this.t] =
                                                    this.ma - this.anobia[this.t] + this.screenX - this.mc;
                                                this.mmutekitm = 5;
                                            }
                                        }
                                        else
                                        {
                                            this.mhp -= 1;
                                        }
                                    }
                                }
                            }

                            if (this.atype[this.t] >= 100 && this.atype[this.t] <= 199)
                            {
                                if (this.atype[this.t] == 100 && this.axtype[this.t] == 0)
                                {
                                    this.mmsgtm = 30;
                                    this.mmsgtype = 1;
                                    this.resources.PlaySound(7);
                                }

                                if (this.atype[this.t] == 100 && this.axtype[this.t] == 1)
                                {
                                    this.mmsgtm = 30;
                                    this.mmsgtype = 2;
                                    this.resources.PlaySound(7);
                                }

                                if (this.atype[this.t] == 100 && this.axtype[this.t] == 2)
                                {
                                    this.mnobia = 5200;
                                    this.mnobib = 7300;
                                    this.resources.PlaySound(7);
                                    this.ma -= 1100;
                                    this.mb -= 4000;
                                    this.mtype = 1;
                                    this.mhp = 50000000;
                                }

                                if (this.atype[this.t] == 101)
                                {
                                    this.mhp -= 1;
                                    this.mmsgtm = 30;
                                    this.mmsgtype = 11;
                                }

                                if (this.atype[this.t] == 102)
                                {
                                    this.mhp -= 1;
                                    this.mmsgtm = 30;
                                    this.mmsgtype = 10;
                                }

                                if (this.atype[this.t] == 105)
                                {
                                    if (this.axtype[this.t] == 0)
                                    {
                                        this.resources.PlaySound(2);
                                        this.sgtype[26] = 6;
                                    }

                                    if (this.axtype[this.t] == 1)
                                    {
                                        this.txtype[7] = 80;
                                        this.resources.PlaySound(2);
                                        this.ayobi(this.aa[this.t] - 8 * 3000 - 1000, -4 * 3000, 0, 0, 0, 110, 0);
                                        this.ayobi(this.aa[this.t] - 10 * 3000 + 1000, -1 * 3000, 0, 0, 0, 110, 0);
                                        this.ayobi(this.aa[this.t] + 4 * 3000 + 1000, -2 * 3000, 0, 0, 0, 110, 0);
                                        this.ayobi(this.aa[this.t] + 5 * 3000 - 1000, -3 * 3000, 0, 0, 0, 110, 0);
                                        this.ayobi(this.aa[this.t] + 6 * 3000 + 1000, -4 * 3000, 0, 0, 0, 110, 0);
                                        this.ayobi(this.aa[this.t] + 7 * 3000 - 1000, -2 * 3000, 0, 0, 0, 110, 0);
                                        this.ayobi(
                                            this.aa[this.t] + 8 * 3000 + 1000,
                                            -2 * 3000 - 1000,
                                            0,
                                            0,
                                            0,
                                            110,
                                            0);
                                        this.tb[0] += 3000 * 3;
                                    }
                                }

                                if (this.atype[this.t] == 110)
                                {
                                    this.mhp -= 1;
                                    this.mmsgtm = 30;
                                    this.mmsgtype = 3;
                                }

                                this.aa[this.t] = -90000000;
                            }
                        }
                    }
                    else
                    {
                        this.aa[this.t] = -9000000;
                    }
                }

                if (this.kscroll != 1 && this.kscroll != 2)
                {
                    this.xx[2] = this.mascrollmax;
                    this.xx[3] = 0;
                    this.xx[1] = this.xx[2];
                    if (this.ma > this.xx[1] && this.fzx < this.scrollx)
                    {
                        this.xx[5] = this.ma - this.xx[1];
                        this.ma = this.xx[1];
                        this.screenX += this.xx[5];
                        this.fzx += this.xx[5];
                        if (this.xx[1] <= 5000)
                        {
                            this.xx[3] = 1;
                        }
                    }
                }
            }

            if (this.main == 2)
            {
                this.maintm++;
                this.xx[7] = 46;
                if (Keyboard.GetState().IsKeyDown(Keys.D1))
                {
                    this.end();
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Space))
                {
                    for (this.t = 0; this.t <= this.xx[7]; this.t += 1)
                    {
                        this.xx[12 + this.t] -= 300;
                    }
                }

                if (this.maintm <= 1)
                {
                    this.maintm = 2;
                    this.resources.ChangeMusic(21);
                    this.resources.StartMusic();
                    this.xx[10] = 0;
                    for (this.t = 0; this.t <= this.xx[7]; this.t += 1)
                    {
                        this.xx[12 + this.t] = 980000;
                    }

                    this.xx[12] = 460;
                    this.xx[13] = 540;
                    this.xx[14] = 590;
                    this.xx[15] = 650;
                    this.xx[16] = 700;
                    this.xx[17] = 760;
                    this.xx[18] = 810;
                    this.xx[19] = 870;
                    this.xx[20] = 920;
                    this.xx[21] = 1000;
                    this.xx[22] = 1050;
                    this.xx[23] = 1100;
                    this.xx[24] = 1180;
                    this.xx[25] = 1230;
                    this.xx[26] = 1360;
                    this.xx[27] = 1410;
                    this.xx[28] = 1540;
                    this.xx[29] = 1590;
                    this.xx[30] = 1800;
                    for (this.t = 0; this.t <= this.xx[7]; this.t += 1)
                    {
                        this.xx[12 + this.t] *= 100;
                    }
                }

                this.xx[10] += 1;
                for (this.t = 0; this.t <= this.xx[7]; this.t += 1)
                {
                    this.xx[12 + this.t] -= 100;
                }

                if (this.xx[30] == -200)
                {
                    this.resources.ChangeMusic(21);
                }

                if (this.xx[30] <= -400)
                {
                    this.main = 100;
                    this.nokori = 2;
                    this.maintm = 0;
                    this.ending = 0;
                }
            }

            if (this.main == 10)
            {
                this.maintm++;
                if (this.fast == 1)
                {
                    this.maintm += 2;
                }

                if (this.maintm >= 30)
                {
                    this.maintm = 0;
                    this.main = 1;
                    this.zxon = 0;
                }
            }

            if (this.main == 100)
            {
                this.maintm++;
                this.xx[0] = 0;
                if (this.maintm <= 10)
                {
                    this.maintm = 11;
                    this.sta = 1;
                    this.stb = 1;
                    this.stc = 0;
                    this.over = 0;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D1))
                {
                    this.sta = 1;
                    this.stb = 1;
                    this.stc = 0;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D2))
                {
                    this.sta = 1;
                    this.stb = 2;
                    this.stc = 0;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D3))
                {
                    this.sta = 1;
                    this.stb = 3;
                    this.stc = 0;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D4))
                {
                    this.sta = 1;
                    this.stb = 4;
                    this.stc = 0;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D0))
                {
                    this.xx[0] = 1;
                    this.over = 1;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Enter))
                {
                    this.xx[0] = 1;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Z))
                {
                    this.xx[0] = 1;
                }

                if (this.xx[0] == 1)
                {
                    this.main = 10;
                    this.zxon = 0;
                    this.maintm = 0;
                    this.nokori = 2;
                    this.fast = 0;
                    this.trap = 0;
                    this.tyuukan = 0;
                }
            }

            this.spriteBatch.Begin();
            this.rpaint();
            this.spriteBatch.End();
            this.xx[0] = 30;
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                this.xx[0] = 60;
            }

            // wait2(stime,(long)gameTime.TotalGameTime.TotalMilliseconds,1000/xx[0]);
        }

        protected void rpaint()
        {
            this.graphics.GraphicsDevice.Clear(new Color(160, 180, 250));
            if (this.stagecolor == 1)
            {
                this.graphics.GraphicsDevice.Clear(new Color(160, 180, 250));
            }

            if (this.stagecolor == 2)
            {
                this.graphics.GraphicsDevice.Clear(new Color(10, 10, 10));
            }

            if (this.stagecolor == 3)
            {
                this.graphics.GraphicsDevice.Clear(new Color(160, 180, 250));
            }

            if (this.stagecolor == 4)
            {
                this.graphics.GraphicsDevice.Clear(new Color(10, 10, 10));
            }

            if (this.main == 1 && this.zxon >= 1)
            {
                for (this.t = 0; this.t < this.nmax; this.t++)
                {
                    this.xx[0] = this.na[this.t] - this.screenX;
                    this.xx[1] = this.nb[this.t] - this.screenY;
                    this.xx[2] = this.ne[this.ntype[this.t]] * 100;
                    this.xx[3] = this.nf[this.ntype[this.t]] * 100;
                    this.xx[2] = 16000;
                    this.xx[3] = 16000;
                    if (this.xx[0] + this.xx[2] >= -10 && this.xx[0] <= fxmax && this.xx[1] + this.xx[3] >= -10
                        && this.xx[3] <= fymax)
                    {
                        if (this.ntype[this.t] != 3)
                        {
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.ntype[this.t], 4),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(this.ntype[this.t], 4),
                                Color.White);

                            // drawimage(grap[ntype[t]][4],xx[0]/100,xx[1]/100);
                        }

                        if (this.ntype[this.t] == 3)
                        {
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.ntype[this.t], 4),
                                new Vector2(this.xx[0] / 100 - 5, this.xx[1] / 100),
                                this.resources.returnFrame(this.ntype[this.t], 4),
                                Color.White);

                            // drawimage(grap[ntype[t]][4],xx[0]/100-5,xx[1]/100);
                        }

                        if (this.ntype[this.t] == 100)
                        {
                            this.spriteBatch.DrawString(
                                this.resources.returnFont(),
                                "51",
                                new Vector2(this.xx[0] / 100 + this.fma, this.xx[1] / 100 + this.fmb),
                                Color.White);

                            // DrawFormatString(xx[0]/100+fma,xx[1]/100+fmb,GetColor(255,255,255),"51");
                        }

                        if (this.ntype[this.t] == 101)
                        {
                            this.spriteBatch.DrawString(
                                this.resources.returnFont(),
                                "Message 1",
                                new Vector2(this.xx[0] / 100 + this.fma, this.xx[1] / 100 + this.fmb),
                                Color.White);

                            // DrawFormatString(xx[0]/100+fma,xx[1]/100+fmb,GetColor(255,255,255),"ƒQ[ƒ€ƒNƒŠƒA[");
                        }

                        if (this.ntype[this.t] == 102)
                        {
                            this.spriteBatch.DrawString(
                                this.resources.returnFont(),
                                "Message 2",
                                new Vector2(this.xx[0] / 100 + this.fma, this.xx[1] / 100 + this.fmb),
                                Color.White);

                            // DrawFormatString(xx[0]/100+fma,xx[1]/100+fmb,GetColor(255,255,255),"ƒvƒŒƒC‚µ‚Ä‚­‚ê‚Ä‚ ‚è‚ª‚Æ[");
                        }
                    }
                }

                for (this.t = 0; this.t < this.emax; this.t++)
                {
                    this.xx[0] = this.ea[this.t] - this.screenX;
                    this.xx[1] = this.eb[this.t] - this.screenY;
                    this.xx[2] = this.enobia[this.t] / 100;
                    this.xx[3] = this.enobib[this.t] / 100;
                    if (this.xx[0] + this.xx[2] * 100 >= -10 && this.xx[1] <= fxmax
                                                             && this.xx[1] + this.xx[3] * 100 >= -10 - 8000
                                                             && this.xx[3] <= fymax)
                    {
                        if (this.egtype[this.t] == 0)
                        {
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(0, 2),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(0, 2),
                                Color.White);

                            // drawimage(grap[0][2],xx[0]/100,xx[1]/100);
                        }

                        if (this.egtype[this.t] == 1)
                        {
                            if (this.stagecolor <= 1 || this.stagecolor == 3) this.setcolor(9 * 16, 6 * 16, 3 * 16);
                            if (this.stagecolor == 2) this.setcolor(0, 120, 160);
                            if (this.stagecolor == 4) this.setcolor(192, 192, 192);
                            this.fillarc(this.xx[0] / 100, this.xx[1] / 100, 7, 7);
                            this.setcolor(0, 0, 0);
                            this.drawarc(this.xx[0] / 100, this.xx[1] / 100, 7, 7);
                        }

                        if (this.egtype[this.t] == 2 || this.egtype[this.t] == 3)
                        {
                            if (this.egtype[this.t] == 3)
                            {
                                this.mirror = 1;
                            }

                            this.spriteBatch.Draw(
                                this.resources.returnTexture(0, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(0, 5),
                                Color.White);

                            // drawimage(grap[0][5], xx[0] / 100, xx[1] / 100);
                            this.mirror = 0;
                        }

                        if (this.egtype[this.t] == 4)
                        {
                            this.setc1();
                            this.fillrect((this.xx[0]) / 100 + 10, (this.xx[1]) / 100, 10, this.xx[3]);
                            this.setc0();
                            this.drawrect((this.xx[0]) / 100 + 10, (this.xx[1]) / 100, 10, this.xx[3]);
                            this.setcolor(250, 250, 0);
                            this.fillarc((this.xx[0]) / 100 + 15 - 1, (this.xx[1]) / 100, 10, 10);
                            this.setc0();
                            this.drawarc((this.xx[0]) / 100 + 15 - 1, (this.xx[1]) / 100, 10, 10);
                        }
                    }
                }

                for (this.t = 0; this.t < this.srmax; this.t++)
                {
                    this.xx[0] = this.sra[this.t] - this.screenX;
                    this.xx[1] = this.srb[this.t] - this.screenY;
                    if (this.xx[0] + this.src[this.t] >= -10 && this.xx[1] <= fxmax + 12100
                                                             && this.src[this.t] / 100 >= 1)
                    {
                        this.xx[2] = 14;
                        if (this.srsp[this.t] == 1)
                        {
                            this.xx[2] = 12;
                        }

                        if (this.srsp[this.t] <= 9 || this.srsp[this.t] >= 20)
                        {
                            this.setcolor(220, 220, 0);
                            if (this.srsp[this.t] == 2)
                            {
                                this.setcolor(0, 220, 0);
                            }

                            if (this.srsp[this.t] == 21)
                            {
                                this.setcolor(180, 180, 180);
                            }

                            this.fillrect(
                                (this.sra[this.t] - this.screenX) / 100,
                                (this.srb[this.t] - this.screenY) / 100,
                                this.src[this.t] / 100,
                                this.xx[2]);
                            this.setcolor(180, 180, 0);
                            if (this.srsp[this.t] == 2)
                            {
                                this.setcolor(0, 180, 0);
                            }

                            if (this.srsp[this.t] == 21)
                            {
                                this.setcolor(150, 150, 150);
                            }

                            this.drawrect(
                                (this.sra[this.t] - this.screenX) / 100,
                                (this.srb[this.t] - this.screenY) / 100,
                                this.src[this.t] / 100,
                                this.xx[2]);
                        }
                        else if (this.srsp[this.t] <= 14)
                        {
                            if (this.src[this.t] >= 5000)
                            {
                                this.setcolor(0, 200, 0);
                                this.fillrect(
                                    (this.sra[this.t] - this.screenX) / 100,
                                    (this.srb[this.t] - this.screenY) / 100,
                                    this.src[this.t] / 100,
                                    30);
                                this.setcolor(0, 160, 0);
                                this.drawrect(
                                    (this.sra[this.t] - this.screenX) / 100,
                                    (this.srb[this.t] - this.screenY) / 100,
                                    this.src[this.t] / 100,
                                    30);
                                this.setcolor(180, 120, 60);
                                this.fillrect(
                                    (this.sra[this.t] - this.screenX) / 100 + 20,
                                    (this.srb[this.t] - this.screenY) / 100 + 30,
                                    this.src[this.t] / 100 - 40,
                                    480);
                                this.setcolor(100, 80, 20);
                                this.drawrect(
                                    (this.sra[this.t] - this.screenX) / 100 + 20,
                                    (this.srb[this.t] - this.screenY) / 100 + 30,
                                    this.src[this.t] / 100 - 40,
                                    480);
                            }
                        }

                        if (this.srsp[this.t] == 15)
                        {
                            for (this.t2 = 0; this.t2 <= 2; this.t2++)
                            {
                                this.xx[6] = 1 + 0;

                                // drawimage(grap[xx[6]][1],(sra[t]-fx)/100+t2*29,(srb[t]-fy)/100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(this.xx[6], 1),
                                    new Vector2(
                                        (this.sra[this.t] - this.screenX) / 100 + this.t2 * 29,
                                        (this.srb[this.t] - this.screenY) / 100),
                                    this.resources.returnFrame(this.xx[6], 1),
                                    Color.White);
                            }
                        }
                    }
                }

                this.setcolor(0, 0, 255);
                if (this.mactp >= 2000)
                {
                    this.mactp -= 2000;
                    if (this.mact == 0)
                    {
                        this.mact = 1;
                    }
                    else
                    {
                        this.mact = 0;
                    }
                }

                if (this.mmuki == 0)
                {
                    this.mirror = 1;
                }

                if (this.mtype != 200 && this.mtype != 1)
                {
                    if (this.mzimen == 1)
                    {
                        if (this.mact == 0)
                        {
                            // drawimage(grap[0][0], ma / 100, mb / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(0, 0),
                                new Vector2(this.ma / 100, this.mb / 100),
                                this.resources.returnFrame(0, 0),
                                Color.White);
                        }

                        if (this.mact == 1)
                        {
                            // drawimage(grap[1][0], ma / 100, mb / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(1, 0),
                                new Vector2(this.ma / 100, this.mb / 100),
                                this.resources.returnFrame(1, 0),
                                Color.White);
                        }
                    }

                    if (this.mzimen == 0)
                    {
                        // drawimage(grap[2][0], ma / 100, mb / 100);
                        this.spriteBatch.Draw(
                            this.resources.returnTexture(2, 0),
                            new Vector2(this.ma / 100, this.mb / 100),
                            this.resources.returnFrame(2, 0),
                            Color.White);
                    }
                }
                else if (this.mtype == 1)
                {
                    // drawimage(grap[41][0], ma / 100, mb / 100);
                    this.spriteBatch.Draw(
                        this.resources.returnTexture(41, 0),
                        new Vector2(this.ma / 100, this.mb / 100),
                        this.resources.returnFrame(41, 0),
                        Color.White);
                }
                else if (this.mtype == 200)
                {
                    // drawimage(grap[3][0], ma / 100, mb / 100);
                    this.spriteBatch.Draw(
                        this.resources.returnTexture(3, 0),
                        new Vector2(this.ma / 100, this.mb / 100),
                        this.resources.returnFrame(3, 0),
                        Color.White);
                }

                this.mirror = 0;
                for (this.t = 0; this.t < this.amax; this.t++)
                {
                    this.xx[0] = this.aa[this.t] - this.screenX;
                    this.xx[1] = this.ab[this.t] - this.screenY;
                    this.xx[2] = this.anobia[this.t] / 100;
                    this.xx[3] = this.anobib[this.t] / 100;
                    this.xx[14] = 3000;
                    this.xx[16] = 0;
                    if (this.xx[0] + this.xx[2] * 100 >= -10 - this.xx[14] && this.xx[1] <= fxmax + this.xx[14]
                                                                           && this.xx[1] + this.xx[3] * 100 >= -10
                                                                           && this.xx[3] <= fymax)
                    {
                        if (this.amuki[this.t] == 1)
                        {
                            this.mirror = 1;
                        }

                        if (this.atype[this.t] == 3 && this.axtype[this.t] == 1)
                        {
                            // DrawRotaGraph(xx[0] / 100 + 13, xx[1] / 100 + 15, 1.0f, pai / 1, grap[atype[t]][3], TRUE);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.atype[this.t], 3),
                                new Vector2(this.xx[0] / 100 + 13, this.xx[1] / 100 + 15),
                                this.resources.returnFrame(this.atype[this.t], 3),
                                Color.White,
                                this.pai / 1,
                                Vector2.One,
                                1.0f,
                                SpriteEffects.None,
                                0);
                            this.xx[16] = 1;
                        }

                        if (this.atype[this.t] == 9 && this.ad[this.t] >= 1)
                        {
                            // DrawRotaGraph(xx[0] / 100 + 13, xx[1] / 100 + 15, 1.0f, pai / 1, grap[atype[t]][3], TRUE);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.atype[this.t], 3),
                                new Vector2(this.xx[0] / 100 + 13, this.xx[1] / 100 + 15),
                                this.resources.returnFrame(this.atype[this.t], 3),
                                Color.White,
                                this.pai / 1,
                                Vector2.One,
                                1.0f,
                                SpriteEffects.None,
                                0);
                            this.xx[16] = 1;
                        }

                        if (this.atype[this.t] >= 100 && this.amuki[this.t] == 1)
                        {
                            this.mirror = 0;
                        }

                        if (this.atype[this.t] < 200 && this.xx[16] == 0 && this.atype[this.t] != 6
                            && this.atype[this.t] != 79 && this.atype[this.t] != 86 && this.atype[this.t] != 30)
                        {
                            if (!((this.atype[this.t] == 80 || this.atype[this.t] == 81) && this.axtype[this.t] == 1))
                            {
                                // drawimage(grap[atype[t]][3], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(this.atype[this.t], 3),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(this.atype[this.t], 3),
                                    Color.White);
                            }
                        }

                        if (this.atype[this.t] == 6)
                        {
                            if (this.atm[this.t] >= 10 && this.atm[this.t] <= 19
                                || this.atm[this.t] >= 100 && this.atm[this.t] <= 119 || this.atm[this.t] >= 200)
                            {
                                // drawimage(grap[150][3], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(150, 3),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(150, 3),
                                    Color.White);
                            }
                            else
                            {
                                // drawimage(grap[6][3], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(6, 3),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(6, 3),
                                    Color.White);
                            }
                        }

                        if (this.atype[this.t] == 30)
                        {
                            if (this.axtype[this.t] == 0)
                            {
                                // drawimage(grap[30][3], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(30, 3),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(30, 3),
                                    Color.White);
                            }

                            if (this.axtype[this.t] == 1)
                            {
                                // drawimage(grap[155][3], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(155, 3),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(155, 3),
                                    Color.White);
                            }
                        }

                        if ((this.atype[this.t] == 81) && this.axtype[this.t] == 1)
                        {
                            // drawimage(grap[130][3], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(130, 3),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(130, 3),
                                Color.White);
                        }

                        if (this.atype[this.t] == 79)
                        {
                            this.setcolor(250, 250, 0);
                            this.fillrect(this.xx[0] / 100, this.xx[1] / 100, this.xx[2], this.xx[3]);
                            this.setc0();
                            this.drawrect(this.xx[0] / 100, this.xx[1] / 100, this.xx[2], this.xx[3]);
                        }

                        if (this.atype[this.t] == 82)
                        {
                            if (this.axtype[this.t] == 1)
                            {
                                this.xx[9] = 0;
                                if (this.stagecolor == 2)
                                {
                                    this.xx[9] = 30;
                                }

                                if (this.stagecolor == 4)
                                {
                                    this.xx[9] = 60;
                                }

                                this.xx[6] = 4 + this.xx[9];

                                // drawimage(grap[xx[6]][1], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(this.xx[6], 1),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(this.xx[6], 1),
                                    Color.White);
                            }

                            if (this.axtype[this.t] == 2)
                            {
                                // drawimage(grap[1][5], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(1, 5),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(1, 5),
                                    Color.White);
                            }
                        }

                        if (this.atype[this.t] == 83)
                        {
                            if (this.axtype[this.t] == 1)
                            {
                                this.xx[9] = 0;
                                if (this.stagecolor == 2)
                                {
                                    this.xx[9] = 30;
                                }

                                if (this.stagecolor == 4)
                                {
                                    this.xx[9] = 60;
                                }

                                this.xx[6] = 4 + this.xx[9];

                                // drawimage(grap[xx[6]][1], xx[0] / 100 + 10, xx[1] / 100 + 9);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(this.xx[6], 1),
                                    new Vector2(this.xx[0] / 100 + 10, this.xx[1] / 100 + 9),
                                    this.resources.returnFrame(this.xx[6], 1),
                                    Color.White);
                            }
                        }

                        if (this.atype[this.t] == 85)
                        {
                            this.setc1();
                            this.fillrect((this.xx[0]) / 100 + 10, (this.xx[1]) / 100, 10, this.xx[3]);
                            this.setc0();
                            this.drawrect((this.xx[0]) / 100 + 10, (this.xx[1]) / 100, 10, this.xx[3]);
                            this.setcolor(0, 250, 200);
                            this.fillarc((this.xx[0]) / 100 + 15 - 1, (this.xx[1]) / 100, 10, 10);
                            this.setc0();
                            this.drawarc((this.xx[0]) / 100 + 15 - 1, (this.xx[1]) / 100, 10, 10);
                        }

                        if (this.atype[this.t] == 86)
                        {
                            if (this.ma >= this.aa[this.t] - this.screenX - this.mnobia - 4000
                                && this.ma <= this.aa[this.t] - this.screenX + this.anobia[this.t] + 4000)
                            {
                                // drawimage(grap[152][3], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(152, 3),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(152, 3),
                                    Color.White);
                            }
                            else
                            {
                                // drawimage(grap[86][3], xx[0] / 100, xx[1] / 100);
                                this.spriteBatch.Draw(
                                    this.resources.returnTexture(86, 3),
                                    new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                    this.resources.returnFrame(86, 3),
                                    Color.White);
                            }
                        }

                        if (this.atype[this.t] == 200)
                        {
                            // drawimage(grap[0][3], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(0, 3),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(0, 3),
                                Color.White);
                        }

                        this.mirror = 0;
                    }
                }

                for (this.t = 0; this.t < this.tmax; this.t++)
                {
                    this.xx[0] = this.ta[this.t] - this.screenX;
                    this.xx[1] = this.tb[this.t] - this.screenY;
                    this.xx[2] = 32;
                    this.xx[3] = this.xx[2];
                    if (this.xx[0] + this.xx[2] * 100 >= -10 && this.xx[1] <= fxmax)
                    {
                        this.xx[9] = 0;
                        if (this.stagecolor == 2)
                        {
                            this.xx[9] = 30;
                        }

                        if (this.stagecolor == 4)
                        {
                            this.xx[9] = 60;
                        }

                        if (this.ttype[this.t] < 100)
                        {
                            this.xx[6] = this.ttype[this.t] + this.xx[9];

                            // drawimage(grap[xx[6]][1], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.xx[6], 1),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(this.xx[6], 1),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 100 || this.ttype[this.t] == 101 || this.ttype[this.t] == 102
                            || this.ttype[this.t] == 103 || this.ttype[this.t] == 104 && this.txtype[this.t] == 1
                            || this.ttype[this.t] == 114 && this.txtype[this.t] == 1 || this.ttype[this.t] == 116)
                        {
                            this.xx[6] = 2 + this.xx[9];

                            // drawimage(grap[xx[6]][1], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.xx[6], 1),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(this.xx[6], 1),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 112 || this.ttype[this.t] == 104 && this.txtype[this.t] == 0
                                                      || this.ttype[this.t] == 115 && this.txtype[this.t] == 1)
                        {
                            this.xx[6] = 1 + this.xx[9];

                            // drawimage(grap[xx[6]][1], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.xx[6], 1),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(this.xx[6], 1),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 111 || this.ttype[this.t] == 113
                                                      || this.ttype[this.t] == 115 && this.txtype[this.t] == 0
                                                      || this.ttype[this.t] == 124)
                        {
                            this.xx[6] = 3 + this.xx[9];

                            // drawimage(grap[xx[6]][1], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.xx[6], 1),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(this.xx[6], 1),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 117 && this.txtype[this.t] == 1)
                        {
                            // drawimage(grap[4][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(4, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(4, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 117 && this.txtype[this.t] >= 3)
                        {
                            // drawimage(grap[3][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(3, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(3, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 115 && this.txtype[this.t] == 3)
                        {
                            this.xx[6] = 1 + this.xx[9];

                            // drawimage(grap[xx[6]][1], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(this.xx[6], 1),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(this.xx[6], 1),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 120 && this.txtype[this.t] != 1)
                        {
                            // drawimage(grap[16][1], xx[0] / 100 + 3, xx[1] / 100 + 2);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(16, 1),
                                new Vector2(this.xx[0] / 100 + 3, this.xx[1] / 100 + 2),
                                this.resources.returnFrame(16, 1),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 130)
                        {
                            // drawimage(grap[10][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(10, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(10, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 131)
                        {
                            // drawimage(grap[11][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(11, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(11, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 140)
                        {
                            // drawimage(grap[12][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(12, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(12, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 141)
                        {
                            // drawimage(grap[13][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(13, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(13, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 142)
                        {
                            // drawimage(grap[14][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(14, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(14, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 300 || this.ttype[this.t] == 301)
                        {
                            // drawimage(grap[1][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(1, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(1, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 400)
                        {
                            // drawimage(grap[2][5], xx[0] / 100, xx[1] / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(2, 5),
                                new Vector2(this.xx[0] / 100, this.xx[1] / 100),
                                this.resources.returnFrame(2, 5),
                                Color.White);
                        }

                        if (this.ttype[this.t] == 800)
                        {
                            // drawimage(grap[0][2], xx[0] / 100 + 2, xx[1] / 100 + 1);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(0, 2),
                                new Vector2(this.xx[0] / 100 + 2, this.xx[1] / 100 + 1),
                                this.resources.returnFrame(0, 2),
                                Color.White);
                        }
                    }
                }

                for (this.t = 0; this.t < this.smax; this.t++)
                {
                    if (this.enemyX[this.t] - this.screenX + this.sc[this.t] >= -10
                        && this.enemyX[this.t] - this.screenX <= fxmax + 1100)
                    {
                        if (this.stype[this.t] == 0)
                        {
                            this.setcolor(40, 200, 40);
                            this.fillrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb,
                                this.sc[this.t] / 100,
                                this.sd[this.t] / 100);
                            this.drawrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb,
                                this.sc[this.t] / 100,
                                this.sd[this.t] / 100);
                        }

                        if (this.stype[this.t] == 1)
                        {
                            this.setcolor(0, 230, 0);
                            this.fillrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb,
                                this.sc[this.t] / 100,
                                this.sd[this.t] / 100);
                            this.setc0();
                            this.drawrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb,
                                this.sc[this.t] / 100,
                                this.sd[this.t] / 100);
                        }

                        if (this.stype[this.t] == 2)
                        {
                            this.setcolor(0, 230, 0);
                            this.fillrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 1,
                                this.sc[this.t] / 100,
                                this.sd[this.t] / 100);
                            this.setc0();
                            this.drawline(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb,
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + this.sd[this.t] / 100);
                            this.drawline(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + this.sc[this.t] / 100 + 1,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb,
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + this.sc[this.t] / 100 + 1,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + this.sd[this.t] / 100);
                        }

                        if (this.stype[this.t] == 5)
                        {
                            this.setcolor(0, 230, 0);
                            this.fillrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 1,
                                this.sc[this.t] / 100,
                                this.sd[this.t] / 100);
                            this.setc0();
                            this.drawline(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb,
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + this.sc[this.t] / 100,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb);
                            this.drawline(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 1,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + this.sd[this.t] / 100,
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + this.sc[this.t] / 100 + 1,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + this.sd[this.t] / 100);
                        }

                        if (this.stype[this.t] == 51)
                        {
                            if (this.sxtype[this.t] == 0)
                            {
                                for (this.t3 = 0; this.t3 <= this.sc[this.t] / 3000; this.t3++)
                                {
                                    // drawimage(grap[1][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + fmb);
                                    this.spriteBatch.Draw(
                                        this.resources.returnTexture(1, 1),
                                        new Vector2(
                                            (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                            (this.enemyY[this.t] - this.screenY) / 100 + this.fmb),
                                        this.resources.returnFrame(1, 1),
                                        Color.White);
                                }
                            }

                            if (this.sxtype[this.t] == 1 || this.sxtype[this.t] == 2)
                            {
                                for (this.t3 = 0; this.t3 <= this.sc[this.t] / 3000; this.t3++)
                                {
                                    // drawimage(grap[31][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + fmb);
                                    this.spriteBatch.Draw(
                                        this.resources.returnTexture(31, 1),
                                        new Vector2(
                                            (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                            (this.enemyY[this.t] - this.screenY) / 100 + this.fmb),
                                        this.resources.returnFrame(31, 1),
                                        Color.White);
                                }
                            }

                            if (this.sxtype[this.t] == 3 || this.sxtype[this.t] == 4)
                            {
                                for (this.t3 = 0; this.t3 <= this.sc[this.t] / 3000; this.t3++)
                                {
                                    for (this.t2 = 0; this.t2 <= this.sd[this.t] / 3000; this.t2++)
                                    {
                                        // drawimage(grap[65][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + 29 * t2 + fmb);
                                        this.spriteBatch.Draw(
                                            this.resources.returnTexture(65, 1),
                                            new Vector2(
                                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                                (this.enemyY[this.t] - this.screenY) / 100 + 29 * this.t2 + this.fmb),
                                            this.resources.returnFrame(65, 1),
                                            Color.White);
                                    }
                                }
                            }

                            if (this.sxtype[this.t] == 10)
                            {
                                for (this.t3 = 0; this.t3 <= this.sc[this.t] / 3000; this.t3++)
                                {
                                    // drawimage(grap[65][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + fmb);
                                    this.spriteBatch.Draw(
                                        this.resources.returnTexture(65, 1),
                                        new Vector2(
                                            (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                            (this.enemyY[this.t] - this.screenY) / 100 + this.fmb),
                                        this.resources.returnFrame(65, 1),
                                        Color.White);
                                }
                            }
                        }

                        if (this.stype[this.t] == 52)
                        {
                            this.xx[29] = 0;
                            if (this.stagecolor == 2)
                            {
                                this.xx[29] = 30;
                            }

                            if (this.stagecolor == 4)
                            {
                                this.xx[29] = 60;
                            }

                            for (this.t3 = 0; this.t3 <= this.sc[this.t] / 3000; this.t3++)
                            {
                                if (this.sxtype[this.t] == 0)
                                {
                                    // drawimage(grap[5 + xx[29]][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + fmb);
                                    this.spriteBatch.Draw(
                                        this.resources.returnTexture(5 + this.xx[29], 1),
                                        new Vector2(
                                            (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                            (this.enemyY[this.t] - this.screenY) / 100 + this.fmb),
                                        this.resources.returnFrame(5 + this.xx[29], 1),
                                        Color.White);
                                    if (this.stagecolor != 4)
                                    {
                                        // drawimage(grap[6 + xx[29]][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + fmb + 29);
                                        this.spriteBatch.Draw(
                                            this.resources.returnTexture(6 + this.xx[29], 1),
                                            new Vector2(
                                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 29),
                                            this.resources.returnFrame(6 + this.xx[29], 1),
                                            Color.White);
                                    }
                                    else
                                    {
                                        // drawimage(grap[5 + xx[29]][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + fmb + 29);
                                        this.spriteBatch.Draw(
                                            this.resources.returnTexture(5 + this.xx[29], 1),
                                            new Vector2(
                                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 29),
                                            this.resources.returnFrame(5 + this.xx[29], 1),
                                            Color.White);
                                    }
                                }

                                if (this.sxtype[this.t] == 1)
                                {
                                    for (this.t2 = 0; this.t2 <= this.sd[this.t] / 3000; this.t2++)
                                    {
                                        // drawimage(grap[1 + xx[29]][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + fmb + 29 * t2);
                                        this.spriteBatch.Draw(
                                            this.resources.returnTexture(1 + this.xx[29], 1),
                                            new Vector2(
                                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 29 * this.t2),
                                            this.resources.returnFrame(1 + this.xx[29], 1),
                                            Color.White);
                                    }
                                }
                            }
                        }

                        if (this.trap == 1)
                        {
                            if (this.stype[this.t] >= 100 && this.stype[this.t] <= 299)
                            {
                                if (this.stagecolor <= 1 || this.stagecolor == 3)
                                {
                                    this.setc0();
                                }

                                if (this.stagecolor == 2 || this.stagecolor == 4)
                                {
                                    this.setc1();
                                }

                                this.drawrect(
                                    (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                    (this.enemyY[this.t] - this.screenY) / 100 + this.fmb,
                                    this.sc[this.t] / 100,
                                    this.sd[this.t] / 100);
                            }
                        }

                        if (this.stype[this.t] == 300)
                        {
                            this.setc1();
                            this.fillrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + 10,
                                (this.enemyY[this.t] - this.screenY) / 100,
                                10,
                                this.sd[this.t] / 100 - 8);
                            this.setc0();
                            this.drawrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + 10,
                                (this.enemyY[this.t] - this.screenY) / 100,
                                10,
                                this.sd[this.t] / 100 - 8);
                            this.setcolor(250, 250, 0);
                            this.fillarc(
                                (this.enemyX[this.t] - this.screenX) / 100 + 15 - 1,
                                (this.enemyY[this.t] - this.screenY) / 100,
                                10,
                                10);
                            this.setc0();
                            this.drawarc(
                                (this.enemyX[this.t] - this.screenX) / 100 + 15 - 1,
                                (this.enemyY[this.t] - this.screenY) / 100,
                                10,
                                10);
                        }

                        if (this.stype[this.t] == 500)
                        {
                            // drawimage(grap[20][4], (sa[t] - fx) / 100, (sb[t] - fy) / 100);
                            this.spriteBatch.Draw(
                                this.resources.returnTexture(20, 4),
                                new Vector2(
                                    (this.enemyX[this.t] - this.screenX) / 100,
                                    (this.enemyY[this.t] - this.screenY) / 100),
                                this.resources.returnFrame(20, 4),
                                Color.White);
                        }
                    }
                }

                for (this.t = 0; this.t < this.smax; this.t++)
                {
                    if (this.enemyX[this.t] - this.screenX + this.sc[this.t] >= -10
                        && this.enemyX[this.t] - this.screenX <= fxmax + 1100)
                    {
                        if (this.stype[this.t] == 40)
                        {
                            this.setcolor(0, 230, 0);
                            this.fillrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 1,
                                this.sc[this.t] / 100,
                                this.sd[this.t] / 100);
                            this.setc0();
                            this.drawrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 1,
                                this.sc[this.t] / 100,
                                this.sd[this.t] / 100);
                        }

                        if (this.stype[this.t] == 50)
                        {
                            this.setcolor(0, 230, 0);
                            this.fillrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 5,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 30,
                                50,
                                this.sd[this.t] / 100 - 30);
                            this.setc0();
                            this.drawline(
                                (this.enemyX[this.t] - this.screenX) / 100 + 5 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 30,
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 5,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + this.sd[this.t] / 100);
                            this.drawline(
                                (this.enemyX[this.t] - this.screenX) / 100 + 5 + this.fma + 50 + 1,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 30,
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 50 + 5 + 1,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + this.sd[this.t] / 100);
                            this.setcolor(0, 230, 0);
                            this.fillrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 1,
                                60,
                                30);
                            this.setc0();
                            this.drawrect(
                                (this.enemyX[this.t] - this.screenX) / 100 + this.fma,
                                (this.enemyY[this.t] - this.screenY) / 100 + this.fmb + 1,
                                60,
                                30);
                        }

                        if (this.stype[this.t] == 200)
                        {
                            for (this.t3 = 0; this.t3 <= this.sc[this.t] / 3000; this.t3++)
                            {
                                for (this.t2 = 0; this.t2 <= this.sd[this.t] / 3000; this.t2++)
                                {
                                    // drawimage(grap[65][1], (sa[t] - fx) / 100 + fma + 29 * t3, (sb[t] - fy) / 100 + 29 * t2 + fmb);
                                    this.spriteBatch.Draw(
                                        this.resources.returnTexture(65, 1),
                                        new Vector2(
                                            (this.enemyX[this.t] - this.screenX) / 100 + this.fma + 29 * this.t3,
                                            (this.enemyY[this.t] - this.screenY) / 100 + 29 * this.t2 + this.fmb),
                                        this.resources.returnFrame(65, 1),
                                        Color.White);
                                }
                            }
                        }
                    }
                }

                for (this.t = 0; this.t < this.amax; this.t++)
                {
                    this.xx[0] = this.aa[this.t] - this.screenX;
                    this.xx[1] = this.ab[this.t] - this.screenY;
                    this.xx[14] = 12000;
                    this.xx[16] = 0;
                    if (this.atype[this.t] == 87)
                    {
                        if (this.xx[0] + this.xx[2] * 100 >= -10 - this.xx[14] && this.xx[1] <= fxmax + this.xx[14]
                                                                               && this.xx[1] + this.xx[3] * 100 >= -10
                                                                               && this.xx[3] <= fymax)
                        {
                            for (this.tt = 0; this.tt <= this.axtype[this.t] % 100; this.tt++)
                            {
                                this.xx[26] = 18;
                                this.xd[4] = this.tt * this.xx[26] * Math.Cos(this.atm[this.t] * this.pai / 180 / 2);
                                this.xd[5] = this.tt * this.xx[26] * Math.Sin(this.atm[this.t] * this.pai / 180 / 2);
                                this.xx[24] = ((int)this.xd[4]);
                                this.xx[25] = ((int)this.xd[5]);
                                this.setcolor(230, 120, 0);
                                this.xx[23] = 8;
                                this.fillarc(
                                    this.xx[0] / 100 + this.xx[24],
                                    this.xx[1] / 100 + this.xx[25],
                                    this.xx[23],
                                    this.xx[23]);
                                this.setcolor(0, 0, 0);
                                this.drawarc(
                                    this.xx[0] / 100 + this.xx[24],
                                    this.xx[1] / 100 + this.xx[25],
                                    this.xx[23],
                                    this.xx[23]);
                            }
                        }
                    }
                }

                this.setc0();
                if (this.mmsgtm >= 1)
                {
                    this.mmsgtm--;
                    this.xs[0] = string.Empty;
                    if (this.mmsgtype == 1) this.xs[0] = "Message 3";
                    if (this.mmsgtype == 2) this.xs[0] = "Message 4";
                    if (this.mmsgtype == 3) this.xs[0] = "Message 5";
                    if (this.mmsgtype == 10) this.xs[0] = "Message 6";
                    if (this.mmsgtype == 11) this.xs[0] = "Message 7";
                    if (this.mmsgtype == 50) this.xs[0] = "Message 8";
                    if (this.mmsgtype == 51) this.xs[0] = "Message 9";
                    if (this.mmsgtype == 52) this.xs[0] = "Message 10";
                    if (this.mmsgtype == 53) this.xs[0] = "Message 11";
                    if (this.mmsgtype == 54) this.xs[0] = "Message 12";
                    if (this.mmsgtype == 55) this.xs[0] = "Message 13";
                    this.setc0();
                    this.str(this.xs[0], (this.ma + this.mnobia + 300) / 100 - 1, this.mb / 100 - 1);
                    this.str(this.xs[0], (this.ma + this.mnobia + 300) / 100 + 1, this.mb / 100 + 1);
                    this.setc1();
                    this.str(this.xs[0], (this.ma + this.mnobia + 300) / 100, this.mb / 100);
                }

                this.setc0();
                for (this.t = 0; this.t < this.amax; this.t++)
                {
                    if (this.amsgtm[this.t] >= 1)
                    {
                        this.amsgtm[this.t]--;
                        this.xs[0] = string.Empty;

                        if (this.amsgtype[this.t] == 1001) this.xs[0] = "Message 14";
                        if (this.amsgtype[this.t] == 1002) this.xs[0] = "Message 15";
                        if (this.amsgtype[this.t] == 1003) this.xs[0] = "Message 16";
                        if (this.amsgtype[this.t] == 1004) this.xs[0] = "Message 17";
                        if (this.amsgtype[this.t] == 1005) this.xs[0] = "Message 18";
                        if (this.amsgtype[this.t] == 1006) this.xs[0] = "Message 19";
                        if (this.amsgtype[this.t] == 1007) this.xs[0] = "Message 20";
                        if (this.amsgtype[this.t] == 1008) this.xs[0] = "Message 21";

                        if (this.amsgtype[this.t] == 1011) this.xs[0] = "Message 22";
                        if (this.amsgtype[this.t] == 1012) this.xs[0] = "Message 23";
                        if (this.amsgtype[this.t] == 1013) this.xs[0] = "Message 24";
                        if (this.amsgtype[this.t] == 1014) this.xs[0] = "Message 25";
                        if (this.amsgtype[this.t] == 1015) this.xs[0] = "Message 26";
                        if (this.amsgtype[this.t] == 1016) this.xs[0] = "Message 27";
                        if (this.amsgtype[this.t] == 1017) this.xs[0] = "Message 28";
                        if (this.amsgtype[this.t] == 1018) this.xs[0] = "Message 29";

                        if (this.amsgtype[this.t] == 1021) this.xs[0] = "Message 30";
                        if (this.amsgtype[this.t] == 1022) this.xs[0] = "Message 31";
                        if (this.amsgtype[this.t] == 1023) this.xs[0] = "Message 32";
                        if (this.amsgtype[this.t] == 1024) this.xs[0] = "Message 33";
                        if (this.amsgtype[this.t] == 1025) this.xs[0] = "Message 34";
                        if (this.amsgtype[this.t] == 1026) this.xs[0] = "Message 35";
                        if (this.amsgtype[this.t] == 1027) this.xs[0] = "Message 36";
                        if (this.amsgtype[this.t] == 1028) this.xs[0] = "Message 37";

                        if (this.amsgtype[this.t] == 15) this.xs[0] = "Message 38";
                        if (this.amsgtype[this.t] == 18) this.xs[0] = "Message 39";
                        if (this.amsgtype[this.t] == 20) this.xs[0] = "Message 40";
                        if (this.amsgtype[this.t] == 21) this.xs[0] = "Message 41";
                        if (this.amsgtype[this.t] == 24) this.xs[0] = "Message 42";
                        if (this.amsgtype[this.t] == 25) this.xs[0] = "Message 43";
                        if (this.amsgtype[this.t] == 30) this.xs[0] = "Message 44";
                        if (this.amsgtype[this.t] == 31) this.xs[0] = "Message 45";

                        if (this.amsgtype[this.t] == 50) this.xs[0] = "Message 46";
                        if (this.amsgtype[this.t] == 85) this.xs[0] = "Message 47";
                        if (this.amsgtype[this.t] != 31)
                        {
                            this.xx[5] = (this.aa[this.t] + this.anobia[this.t] + 300 - this.screenX) / 100;
                            this.xx[6] = (this.ab[this.t] - this.screenY) / 100;
                        }
                        else
                        {
                            this.xx[5] = (this.aa[this.t] + this.anobia[this.t] + 300 - this.screenX) / 100;
                            this.xx[6] = (this.ab[this.t] - this.screenY - 800) / 100;
                        }

                        this.setc0();
                        this.str(this.xs[0], this.xx[5] - 1, this.xx[6] - 1);
                        this.str(this.xs[0], this.xx[5] + 1, this.xx[6] + 1);
                        this.setc1();
                        this.str(this.xs[0], this.xx[5], this.xx[6]);
                    }
                }

                if (this.tmsgtm > 0)
                {
                    this.ttmsg();
                    if (this.tmsgtype == 1)
                    {
                        this.xx[0] = 1200;
                        this.tmsgy += this.xx[0];
                        if (this.tmsgtm == 1)
                        {
                            this.tmsgtm = 80000000;
                            this.tmsgtype = 2;
                        }
                    }
                    else if (this.tmsgtype == 2)
                    {
                        this.tmsgy = 0;
                        this.tmsgtype = 3;
                        this.tmsgtm = 15 + 1;
                    }
                    else if (this.tmsgtype == 3)
                    {
                        this.xx[0] = 1200;
                        this.tmsgy += this.xx[0];
                        if (this.tmsgtm == 15)
                        {
                            this.WaitKey();
                        }

                        if (this.tmsgtm == 1)
                        {
                            this.tmsgtm = 0;
                            this.tmsgtype = 0;
                            this.tmsgy = 0;
                        }
                    }

                    this.tmsgtm--;
                }

                if (this.mainmsgtype >= 1)
                {
                    // setfont(20, 4);
                    if (this.mainmsgtype == 1)
                    {
                        // DrawFormatString(126, 100, GetColor(255, 255, 255), "WELCOME TO OWATA ZONE");
                    }

                    if (this.mainmsgtype == 1)
                    {
                        for (this.t2 = 0; this.t2 <= 2; this.t2++)
                        {
                            // DrawFormatString(88 + t2 * 143, 210, GetColor(255, 255, 255), "1");
                        }
                    }

                    // setfont(20, 5);
                }

                if (this.blacktm > 0)
                {
                    this.blacktm--;
                    this.fillrect(0, 0, fxmax / 100, fymax / 100);
                    if (this.blacktm == 0)
                    {
                        if (this.blackx == 1)
                        {
                            this.zxon = 0;
                        }
                    }
                }
            }

            if (this.main == 2)
            {
                this.setcolor(255, 255, 255);
                this.setc1();
                this.str("Message 48", 240 - 13 * 20 / 2, this.xx[12] / 100);
                this.str("Message 49", 240 - 9 * 20 / 2, this.xx[13] / 100);
                this.str("Message 50", 240 - 6 * 20 / 2, this.xx[14] / 100);
                this.str("Message 51", 240 - 9 * 20 / 2, this.xx[15] / 100);
                this.str("Message 52", 240 - 8 * 20 / 2, this.xx[16] / 100);
                this.str("Message 53", 240 - 9 * 20 / 2, this.xx[17] / 100);
                this.str("Message 54", 240 - 8 * 20 / 2, this.xx[18] / 100);
                this.str("Message 55", 240 - 9 * 20 / 2, this.xx[19] / 100);
                this.str("Message 56", 240 - 6 * 20 / 2, this.xx[20] / 100);
                this.str("Message 57", 240 - 3 * 20 / 2, this.xx[21] / 100);
                this.str("Message 58", 240 - 3 * 20 / 2, this.xx[22] / 100);
                this.str("Message 59", 240 - 3 * 20 / 2, this.xx[23] / 100);
                this.str("Message 60", 240 - 6 * 20 / 2, this.xx[24] / 100);
                this.str("Message 61", 240 - 3 * 20 / 2, this.xx[25] / 100);
                this.str("Message 62", 240 - 16 * 20 / 2, this.xx[26] / 100);
                this.str("Message 63", 240 - 5 * 20 / 2, this.xx[27] / 100);
                this.str("Message 64", 240 - 16 * 20 / 2, this.xx[28] / 100);
                this.str("Message 65", 240 - 2 * 20 / 2, this.xx[29] / 100);
                this.str("Message 66", 240 - 22 * 20 / 2, this.xx[30] / 100);
            }

            if (this.main == 10)
            {
                this.setc0();
                this.fillrect(0, 0, fxmax / 100, fymax / 100);

                // SetFontSize(20);
                // SetFontThickness(6);
                // drawimage(grap[0][0], 190, 190);
                this.spriteBatch.Draw(
                    this.resources.returnTexture(0, 0),
                    new Vector2(190, 190),
                    this.resources.returnFrame(0, 0),
                    Color.White);

                // DrawFormatString(230, 200, GetColor(255, 255, 255), " ~ %d", nokori);
                this.setc1();
                this.str("  X " + this.nokori, 230, 200);
                this.setc0();
            }

            if (this.main == 100)
            {
                this.setcolor(160, 180, 250);
                this.fillrect(0, 0, fxmax / 100, fymax / 100);

                // drawimage(mgrap[30], 240 - 380 / 2, 60);
                this.spriteBatch.Draw(this.resources.returnTitle(), new Vector2(240 - 380 / 2, 60), Color.White);

                // drawimage(grap[0][4], 12 * 30, 10 * 29 - 12);
                this.spriteBatch.Draw(
                    this.resources.returnTexture(0, 4),
                    new Vector2(12 * 30, 10 * 29 - 12),
                    this.resources.returnFrame(0, 4),
                    Color.White);

                // drawimage(grap[1][4], 6 * 30, 12 * 29 - 12);
                this.spriteBatch.Draw(
                    this.resources.returnTexture(1, 4),
                    new Vector2(6 * 30, 12 * 29 - 12),
                    this.resources.returnFrame(1, 4),
                    Color.White);

                // drawimage(grap[0][0], 2 * 30, 12 * 29 - 12 - 6);
                this.spriteBatch.Draw(
                    this.resources.returnTexture(0, 0),
                    new Vector2(2 * 30, 12 * 29 - 12 - 6),
                    this.resources.returnFrame(0, 0),
                    Color.White);
                for (this.t = 0; this.t <= 16; this.t++)
                {
                    // drawimage(grap[5][1], 29 * t, 13 * 29 - 12);
                    this.spriteBatch.Draw(
                        this.resources.returnTexture(5, 1),
                        new Vector2(29 * this.t, 13 * 29 - 12),
                        this.resources.returnFrame(5, 1),
                        Color.White);

                    // drawimage(grap[6][1], 29 * t, 14 * 29 - 12);
                    this.spriteBatch.Draw(
                        this.resources.returnTexture(6, 1),
                        new Vector2(29 * this.t, 14 * 29 - 12),
                        this.resources.returnFrame(6, 1),
                        Color.White);
                }

                this.setcolor(0, 0, 0);
                this.str("Prece Enter Key ", 240 - 8 * 20 / 2, 250);
            }
        }

        protected void setc0()
        {
            this.fontColor = Color.Black;
        }

        protected void setc1()
        {
            this.fontColor = Color.White;
        }

        protected void setcolor(int r, int g, int b)
        {
            this.fontColor = new Color(new Vector3((float)r / 255, (float)g / 255, (float)b / 255));
        }

        protected void stagecls()
        {
            for (this.t = 0; this.t < this.smax; this.t++)
            {
                this.enemyX[this.t] = -9000000;
                this.enemyY[this.t] = 1;
                this.sc[this.t] = 1;
                this.sd[this.t] = 1;
                this.sgtype[this.t] = 0;
                this.stype[this.t] = 0;
                this.sxtype[this.t] = 0;
            }

            for (this.t = 0; this.t < this.tmax; this.t++)
            {
                this.ta[this.t] = -9000000;
                this.tb[this.t] = 1;
                this.tc[this.t] = 1;
                this.td[this.t] = 1;
                this.titem[this.t] = 0;
                this.txtype[this.t] = 0;
            }

            for (this.t = 0; this.t < this.srmax; this.t++)
            {
                this.sra[this.t] = -9000000;
                this.srb[this.t] = 1;
                this.src[this.t] = 1;
                this.srd[this.t] = 1;
                this.sre[this.t] = 0;
                this.srf[this.t] = 0;
                this.srmuki[this.t] = 0;
                this.sron[this.t] = 0;
                this.sree[this.t] = 0;
                this.srsok[this.t] = 0;
                this.srmove[this.t] = 0;
                this.srmovep[this.t] = 0;
                this.srsp[this.t] = 0;
            }

            for (this.t = 0; this.t < this.amax; this.t++)
            {
                this.aa[this.t] = -9000000;
                this.ab[this.t] = 1;
                this.ac[this.t] = 0;
                this.ad[this.t] = 1;
                this.azimentype[this.t] = 0;
                this.atype[this.t] = 0;
                this.axtype[this.t] = 0;
                this.ae[this.t] = 0;
                this.af[this.t] = 0;
                this.atm[this.t] = 0;
                this.a2tm[this.t] = 0;
                this.abrocktm[this.t] = 0;
                this.amsgtm[this.t] = 0;
            }

            for (this.t = 0; this.t < this.bmax; this.t++)
            {
                this.ba[this.t] = -9000000;
                this.bb[this.t] = 1;
                this.bz[this.t] = 1;
                this.btm[this.t] = 0;
                this.bxtype[this.t] = 0;
            }

            for (this.t = 0; this.t < this.emax; this.t++)
            {
                this.ea[this.t] = -9000000;
                this.eb[this.t] = 1;
                this.ec[this.t] = 1;
                this.ed[this.t] = 1;
                this.egtype[this.t] = 0;
            }

            for (this.t = 0; this.t < this.nmax; this.t++)
            {
                this.na[this.t] = -9000000;
                this.nb[this.t] = 1;
                this.nc[this.t] = 1;
                this.nd[this.t] = 1;
                this.ne[this.t] = 1;
                this.nf[this.t] = 1;
                this.ng[this.t] = 0;
                this.ntype[this.t] = 0;
            }

            this.sco = 0;
            this.tco = 0;
            this.aco = 0;
            this.bco = 0;
            this.eco = 0;
            this.nco = 0;
        }

        protected void stagep()
        {
            this.scrollx = 3600 * 100;
            if (this.sta == 1 && this.stb == 1 && this.stc == 0)
            {
                byte[][] stagedatex;
                stagedatex = new byte[17][];
                stagedatex[0] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[1] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[2] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 82, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 99, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[3] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0
                                    };
                stagedatex[4] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[5] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 98, 98, 98,
                                        1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 98, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0
                                    };
                stagedatex[6] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[7] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 50, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[8] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[9] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 98, 0, 0, 0, 1, 98, 1, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 1, 98, 1, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 98, 0, 0, 0, 0, 0, 0, 1, 98, 0, 0, 0, 2, 0, 0, 2, 0, 0, 2,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 1, 0, 0,
                                        0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0
                                    };
                stagedatex[10] = new byte[]
                                     {
                                         0, 80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 40, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 4, 0, 7, 7, 7, 7, 7, 40, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 83, 0,
                                         0, 0, 0, 0
                                     };
                stagedatex[11] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 41, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 41, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 40, 0, 0, 4, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0
                                     };
                stagedatex[12] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 50, 0, 0, 0, 0, 0, 50, 0, 0, 81, 41, 0, 0, 0, 0,
                                         0, 81, 98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 81, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 50, 0, 50, 0, 0, 51, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 81, 0, 0, 0, 4, 4, 4, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 41, 0, 0, 0, 0, 0,
                                         50, 0, 50, 0, 0, 41, 0, 4, 4, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 4, 81, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[13] = new byte[]
                                     {
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 5,
                                         5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 0, 5, 5, 5, 5, 5, 5, 5
                                     };
                stagedatex[14] = new byte[]
                                     {
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 6,
                                         6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 0, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0
                                     };
                stagedatex[15] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                this.tyobi(8 * 29, 9 * 29 - 12, 100);
                this.tyobi(13 * 29, 9 * 29 - 12, 102);
                this.tyobi(14 * 29, 5 * 29 - 12, 101);
                this.tyobi(35 * 29, 8 * 29 - 12, 110);
                this.tyobi(47 * 29, 9 * 29 - 12, 103);
                this.tyobi(59 * 29, 9 * 29 - 12, 112);
                this.tyobi(67 * 29, 9 * 29 - 12, 104);
                this.sco = 0;
                this.t = this.sco;
                this.enemyX[this.t] = 20 * 29 * 100 + 500;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 5000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 100;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 54 * 29 * 100 - 500;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 7000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 101;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 112 * 29 * 100 + 1000;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 3000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 102;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 117 * 29 * 100;
                this.enemyY[this.t] = (2 * 29 - 12) * 100 - 1500;
                this.sc[this.t] = 15000;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 103;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 125 * 29 * 100;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 9000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 101;
                this.sco++;
                this.t = 28;
                this.enemyX[this.t] = 29 * 29 * 100 + 500;
                this.enemyY[this.t] = (9 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 12000 - 200;
                this.stype[this.t] = 50;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 49 * 29 * 100;
                this.enemyY[this.t] = (5 * 29 - 12) * 100;
                this.sc[this.t] = 9000 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 51;
                this.sgtype[this.t] = 0;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 72 * 29 * 100;
                this.enemyY[this.t] = (13 * 29 - 12) * 100;
                this.sc[this.t] = 3000 * 5 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 52;
                this.sco++;
                this.bco = 0;
                this.t = this.bco;
                this.ba[this.t] = 27 * 29 * 100;
                this.bb[this.t] = (9 * 29 - 12) * 100;
                this.btype[this.t] = 0;
                this.bxtype[this.t] = 1;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 103 * 29 * 100;
                this.bb[this.t] = (5 * 29 - 12 + 10) * 100;
                this.btype[this.t] = 80;
                this.bxtype[this.t] = 0;
                this.bco++;

                this.t = 0;
                for (this.t = 0; this.t < stagedatex.Length - 1; this.t++)
                {
                    for (this.tt = 0; this.tt < stagedatex[this.t].Length - 1; this.tt++)
                    {
                        this.stagedate[this.t][this.tt] = 0;
                        this.stagedate[this.t][this.tt] = stagedatex[this.t][this.tt];
                    }
                }
            }

            if (this.sta == 1 && this.stb == 2 && this.stc == 0)
            {
                this.resources.ChangeMusic(17);
                this.scrollx = 0 * 100;
                byte[][] stagedatex;
                stagedatex = new byte[17][];
                stagedatex[0] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[1] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[2] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[3] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[4] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[5] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[6] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[7] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[8] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 7 };
                stagedatex[9] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[10] = new byte[] { 0, 83, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[11] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 44, 0 };
                stagedatex[12] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[13] = new byte[]
                                     {
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 5,
                                         5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 0, 5, 5, 5, 5, 5, 5, 5
                                     };
                stagedatex[14] = new byte[]
                                     {
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 6,
                                         6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 0, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0
                                     };
                stagedatex[15] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                this.tco = 0;
                this.txtype[this.tco] = 1;
                this.tyobi(4 * 29, 9 * 29 - 12, 300);
                this.tyobi(13 * 29, 8 * 29 - 12, 114);
                this.sco = 0;
                this.t = this.sco;
                this.enemyX[this.t] = 14 * 29 * 100 + 500;
                this.enemyY[this.t] = (9 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 12000 - 200;
                this.stype[this.t] = 50;
                this.sxtype[this.t] = 1;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 12 * 29 * 100;
                this.enemyY[this.t] = (11 * 29 - 12) * 100;
                this.sc[this.t] = 3000;
                this.sd[this.t] = 6000 - 200;
                this.stype[this.t] = 40;
                this.sxtype[this.t] = 0;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 14 * 29 * 100 + 1000;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 5000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 100;
                this.sxtype[this.t] = 1;
                this.sco++;
                for (this.t = 0; this.t < stagedatex.Length - 1; this.t++)
                {
                    for (this.tt = 0; this.tt < stagedatex[this.t].Length - 1; this.tt++)
                    {
                        this.stagedate[this.t][this.tt] = 0;
                        this.stagedate[this.t][this.tt] = stagedatex[this.t][this.tt];
                    }
                }
            }

            if (this.sta == 1 && this.stb == 2 && this.stc == 1)
            {
                this.resources.ChangeMusic(18);
                this.scrollx = 4080 * 100;
                this.ma = 6000;
                this.mb = 3000;
                this.stagecolor = 2;
                byte[][] stagedatex;
                stagedatex = new byte[17][];
                stagedatex[0] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 97, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[1] = new byte[]
                                    {
                                        1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                        1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 4, 4, 4, 4, 4,
                                        4, 4, 4, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 98, 0, 1,
                                        1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0
                                    };
                stagedatex[2] = new byte[]
                                    {
                                        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
                                        1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0
                                    };
                stagedatex[3] = new byte[]
                                    {
                                        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
                                        1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0
                                    };
                stagedatex[4] = new byte[]
                                    {
                                        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
                                        1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0
                                    };
                stagedatex[5] = new byte[]
                                    {
                                        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0,
                                        0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
                                        1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0
                                    };
                stagedatex[6] = new byte[]
                                    {
                                        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
                                        1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0
                                    };
                stagedatex[7] = new byte[]
                                    {
                                        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 97, 44, 0, 0, 1,
                                        1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0
                                    };
                stagedatex[8] = new byte[]
                                    {
                                        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        1, 0, 0, 54, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 97, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0,
                                        1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0
                                    };
                stagedatex[9] = new byte[]
                                    {
                                        1, 0, 0, 0, 0, 0, 0, 98, 2, 2, 98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 7, 7, 7, 7, 4,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 98, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 1, 4, 4, 4, 4, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1,
                                        1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0
                                    };
                stagedatex[10] = new byte[]
                                     {
                                         1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 4,
                                         0, 4, 0, 51, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0,
                                         0, 0, 1, 1, 4, 4, 4, 4, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1,
                                         1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 1, 0
                                     };
                stagedatex[11] = new byte[]
                                     {
                                         1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 4, 0, 4, 0, 0, 0, 0, 4,
                                         0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 40, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 1, 1, 1, 4, 4, 4, 4, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1,
                                         1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 1, 0
                                     };
                stagedatex[12] = new byte[]
                                     {
                                         1, 0, 7, 0, 0, 0, 0, 0, 0, 0, 50, 0, 50, 0, 4, 0, 4, 0, 4, 0, 4, 0, 50, 0, 0,
                                         4, 0, 4, 0, 4, 0, 4, 0, 0, 0, 0, 50, 50, 50, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 41, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 1, 1, 1, 1, 4, 4, 4, 4, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0,
                                         0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0,
                                         1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 1, 0
                                     };
                stagedatex[13] = new byte[]
                                     {
                                         5, 5, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 0, 0, 0,
                                         5, 5, 5, 5, 5, 5, 0, 0, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1,
                                         1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 0
                                     };
                stagedatex[14] = new byte[]
                                     {
                                         6, 6, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 6,
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 0, 0, 0,
                                         6, 6, 6, 6, 6, 6, 0, 0, 6, 6, 0, 0, 0, 0, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1,
                                         1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[15] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0
                                     };
                this.tco = 0;
                this.txtype[this.tco] = 2;
                this.tyobi(7 * 29, 9 * 29 - 12, 102);
                this.tyobi(10 * 29, 9 * 29 - 12, 101);
                this.txtype[this.tco] = 2;
                this.tyobi(49 * 29, 9 * 29 - 12, 114);
                for (this.t = 0; this.t >= -7; this.t--)
                {
                    this.tyobi(53 * 29, this.t * 29 - 12, 1);
                }

                this.txtype[this.tco] = 1;
                this.tyobi(80 * 29, 5 * 29 - 12, 104);
                this.txtype[this.tco] = 2;
                this.tyobi(78 * 29, 5 * 29 - 12, 102);
                this.sco = 0;
                this.t = this.sco;
                this.enemyX[this.t] = 2 * 29 * 100;
                this.enemyY[this.t] = (13 * 29 - 12) * 100;
                this.sc[this.t] = 3000 * 1 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 52;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 24 * 29 * 100;
                this.enemyY[this.t] = (13 * 29 - 12) * 100;
                this.sc[this.t] = 3000 * 1 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 52;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 43 * 29 * 100 + 500;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 3000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 102;
                this.sxtype[this.t] = 1;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 53 * 29 * 100 + 500;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 3000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 102;
                this.sxtype[this.t] = 2;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 129 * 29 * 100;
                this.enemyY[this.t] = (7 * 29 - 12) * 100;
                this.sc[this.t] = 3000;
                this.sd[this.t] = 6000 - 200;
                this.stype[this.t] = 40;
                this.sxtype[this.t] = 2;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 154 * 29 * 100;
                this.enemyY[this.t] = 3000;
                this.sc[this.t] = 9000;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 102;
                this.sxtype[this.t] = 7;
                this.sco++;
                this.t = 27;
                this.enemyX[this.t] = 69 * 29 * 100;
                this.enemyY[this.t] = (1 * 29 - 12) * 100;
                this.sc[this.t] = 9000 * 2 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 51;
                this.sxtype[this.t] = 0;
                this.sgtype[this.t] = 0;
                this.sco++;
                this.t = 28;
                this.enemyX[this.t] = 66 * 29 * 100;
                this.enemyY[this.t] = (1 * 29 - 12) * 100;
                this.sc[this.t] = 9000 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 51;
                this.sxtype[this.t] = 1;
                this.sgtype[this.t] = 0;
                this.sco++;
                this.t = 29;
                this.enemyX[this.t] = 66 * 29 * 100;
                this.enemyY[this.t] = (-2 * 29 - 12) * 100;
                this.sc[this.t] = 9000 * 3 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 51;
                this.sxtype[this.t] = 2;
                this.sgtype[this.t] = 0;
                this.sco++;
                this.t = 26;
                this.enemyX[this.t] = 103 * 29 * 100 - 1500;
                this.enemyY[this.t] = (9 * 29 - 12) * 100 - 2000;
                this.sc[this.t] = 3000;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 180;
                this.sxtype[this.t] = 0;
                this.sr[this.t] = 0;
                this.sgtype[this.t] = 48;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 102 * 29 * 100;
                this.enemyY[this.t] = (9 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 12000 - 200;
                this.stype[this.t] = 50;
                this.sxtype[this.t] = 2;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 123 * 29 * 100;
                this.enemyY[this.t] = (9 * 29 - 12) * 100;
                this.sc[this.t] = 3000 * 5 - 1;
                this.sd[this.t] = 3000 * 5;
                this.stype[this.t] = 52;
                this.sxtype[this.t] = 1;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 131 * 29 * 100 + 1100;
                this.enemyY[this.t] = (1 * 29 - 12) * 100;
                this.sc[this.t] = 4700;
                this.sd[this.t] = 3000 * 8 - 700;
                this.stype[this.t] = 1;
                this.sxtype[this.t] = 0;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 143 * 29 * 100;
                this.enemyY[this.t] = (9 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 12000 - 200;
                this.stype[this.t] = 50;
                this.sxtype[this.t] = 5;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 148 * 29 * 100;
                this.enemyY[this.t] = (9 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 12000 - 200;
                this.stype[this.t] = 50;
                this.sxtype[this.t] = 5;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 153 * 29 * 100;
                this.enemyY[this.t] = (9 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 12000 - 200;
                this.stype[this.t] = 50;
                this.sxtype[this.t] = 5;
                this.sco++;
                this.bco = 0;
                this.t = this.bco;
                this.ba[this.t] = 18 * 29 * 100;
                this.bb[this.t] = (10 * 29 - 12) * 100;
                this.btype[this.t] = 82;
                this.bxtype[this.t] = 1;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 51 * 29 * 100 + 1000;
                this.bb[this.t] = (2 * 29 - 12 + 10) * 100;
                this.btype[this.t] = 80;
                this.bxtype[this.t] = 1;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 96 * 29 * 100 + 100;
                this.bb[this.t] = (10 * 29 - 12) * 100;
                this.btype[this.t] = 105;
                this.bxtype[this.t] = 0;
                this.bco++;
                this.srco = 0;
                this.t = this.srco;
                this.sra[this.t] = 111 * 29 * 100;
                this.srb[this.t] = (8 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 5;
                this.sre[this.t] = -300;
                this.srco++;
                this.t = this.srco;
                this.sra[this.t] = 111 * 29 * 100;
                this.srb[this.t] = (0 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 5;
                this.sre[this.t] = -300;
                this.srco++;
                this.t = 10;
                this.sra[this.t] = 116 * 29 * 100;
                this.srb[this.t] = (4 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 1;
                this.sracttype[this.t] = 5;
                this.sre[this.t] = 300;
                this.srco++;
                this.t = 11;
                this.sra[this.t] = 116 * 29 * 100;
                this.srb[this.t] = (12 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 1;
                this.sracttype[this.t] = 5;
                this.sre[this.t] = 300;
                this.srco++;
                for (this.t = 0; this.t < stagedatex.Length - 1; this.t++)
                {
                    for (this.tt = 0; this.tt < stagedatex[this.t].Length - 1; this.tt++)
                    {
                        this.stagedate[this.t][this.tt] = 0;
                        this.stagedate[this.t][this.tt] = stagedatex[this.t][this.tt];
                    }
                }
            }

            if (this.sta == 1 && this.stb == 2 && this.stc == 2)
            {
                this.resources.ChangeMusic(17);
                this.scrollx = 900 * 100;
                this.ma = 7500;
                this.mb = 3000 * 9;

                byte[][] stagedatex;
                stagedatex = new byte[17][];
                stagedatex[0] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[1] = new byte[]
                                    {
                                        0, 82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0
                                    };
                stagedatex[2] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        99, 0, 0, 0, 0, 0, 0, 0, 0, 0, 82, 0, 0, 0, 0, 0
                                    };
                stagedatex[3] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[4] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[5] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[6] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[7] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[8] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0
                                    };
                stagedatex[9] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0
                                    };
                stagedatex[10] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 83, 0, 0
                                     };
                stagedatex[11] = new byte[]
                                     {
                                         0, 0, 40, 0, 0, 0, 4, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0
                                     };
                stagedatex[12] = new byte[]
                                     {
                                         0, 0, 41, 0, 0, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0,
                                         1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 81
                                     };
                stagedatex[13] = new byte[]
                                     {
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 5,
                                         5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 0, 5, 5, 5, 5, 5, 5, 5
                                     };
                stagedatex[14] = new byte[]
                                     {
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 6,
                                         6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
                                         6, 6, 6, 6, 6, 6, 6, 0, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0
                                     };
                stagedatex[15] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };

                this.t = this.sco;
                this.enemyX[this.t] = 5 * 29 * 100 + 500;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 3000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 102;
                this.sxtype[this.t] = 8;
                this.sco++;
                this.t = 28;
                this.enemyX[this.t] = 44 * 29 * 100 + 500;
                this.enemyY[this.t] = (10 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 9000 - 200;
                this.stype[this.t] = 50;
                this.sco++;
                this.bco = 0;
                this.t = this.bco;
                this.ba[this.t] = 19 * 29 * 100;
                this.bb[this.t] = (2 * 29 - 12) * 100;
                this.btype[this.t] = 85;
                this.bxtype[this.t] = 0;
                this.bco++;

                for (this.t = 0; this.t < stagedatex.Length - 1; this.t++)
                {
                    for (this.tt = 0; this.tt < stagedatex[this.t].Length - 1; this.tt++)
                    {
                        this.stagedate[this.t][this.tt] = 0;
                        this.stagedate[this.t][this.tt] = stagedatex[this.t][this.tt];
                    }
                }
            }

            if (this.sta == 1 && this.stb == 3 && this.stc == 6)
            {
                this.stc = 0;
            }

            if (this.sta == 1 && this.stb == 3 && this.stc == 0)
            {
                this.resources.ChangeMusic(17);
                this.scrollx = 3900 * 100;
                byte[][] stagedatex;
                stagedatex = new byte[17][];
                stagedatex[0] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 97, 0, 0, 0, 0, 0, 97, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[1] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 97, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 84, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 57, 0, 0, 0, 84, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 84, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[2] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        54, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 84, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 51, 0,
                                        0, 0, 84, 0, 0, 0, 0, 0, 99, 0, 0, 0, 0, 0, 0, 82, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[3] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
                                        1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[4] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[5] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 97, 0, 0, 0, 0, 0, 0, 57, 0, 0, 0, 0, 0, 0, 0, 97, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 58, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[6] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[7] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[8] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 56, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[9] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 1, 0, 0, 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 84, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[10] = new byte[]
                                     {
                                         0, 83, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 84, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 83, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[11] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 97, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 97, 0,
                                         0, 0, 0, 0, 0, 1, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 85, 85, 0, 0, 0, 0, 0, 0, 0,
                                         97, 0, 0, 0, 0, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[12] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 81, 0, 0, 0, 0, 0, 0, 0, 0, 0, 81, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 81,
                                         0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 81, 0, 0, 0, 0, 50, 0, 50, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 81, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[13] = new byte[]
                                     {
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 0, 0,
                                         0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5,
                                         5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5,
                                         5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[14] = new byte[]
                                     {
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 0, 0,
                                         0, 6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6,
                                         6, 6, 6, 6, 6, 6, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 6,
                                         6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0
                                     };
                stagedatex[15] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };

                this.tco = 0;
                this.tyobi(22 * 29, 3 * 29 - 12, 1);
                this.tyobi(54 * 29, 9 * 29 - 12, 116);

                this.tyobi(18 * 29, 14 * 29 - 12, 117);
                this.tyobi(19 * 29, 14 * 29 - 12, 117);
                this.tyobi(20 * 29, 14 * 29 - 12, 117);
                this.txtype[this.tco] = 1;
                this.tyobi(61 * 29, 9 * 29 - 12, 101);
                this.tyobi(74 * 29, 9 * 29 - 12, 7);

                this.txtype[this.tco] = 2;
                this.tyobi(28 * 29, 9 * 29 - 12, 300);
                this.txtype[this.tco] = 3;
                this.tyobi(7 * 29, 9 * 29 - 12, 101);
                this.txtype[this.tco] = 4;
                this.tyobi(70 * 29, 8 * 29 - 12, 300);

                this.txtype[this.tco] = 1;
                this.tyobi(58 * 29, 13 * 29 - 12, 115);
                this.txtype[this.tco] = 1;
                this.tyobi(59 * 29, 13 * 29 - 12, 115);
                this.txtype[this.tco] = 1;
                this.tyobi(60 * 29, 13 * 29 - 12, 115);

                this.txtype[this.tco] = 0;
                this.tyobi(111 * 29, 6 * 29 - 12, 301);
                this.txtype[this.tco] = 0;
                this.tyobi(114 * 29, 9 * 29 - 12, 120);

                this.bco = 0;
                this.t = this.bco;
                this.ba[this.t] = 101 * 29 * 100;
                this.bb[this.t] = (5 * 29 - 12) * 100;
                this.btype[this.t] = 4;
                this.bxtype[this.t] = 1;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 146 * 29 * 100;
                this.bb[this.t] = (10 * 29 - 12) * 100;
                this.btype[this.t] = 6;
                this.bxtype[this.t] = 1;
                this.bco++;

                this.t = this.sco;
                this.enemyX[this.t] = 9 * 29 * 100;
                this.enemyY[this.t] = (13 * 29 - 12) * 100;
                this.sc[this.t] = 9000 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 52;
                this.sco++;

                this.t = this.sco;
                this.enemyX[this.t] = 65 * 29 * 100 + 500;
                this.enemyY[this.t] = (10 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 9000 - 200;
                this.stype[this.t] = 50;
                this.sxtype[this.t] = 1;
                this.sco++;

                this.t = this.sco;
                this.enemyX[this.t] = 74 * 29 * 100;
                this.enemyY[this.t] = (8 * 29 - 12) * 100 - 1500;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 103;
                this.sxtype[this.t] = 1;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 96 * 29 * 100 - 3000;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 9000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 102;
                this.sxtype[this.t] = 10;
                this.sco++;

                this.t = this.sco;
                this.enemyX[this.t] = 131 * 29 * 100 - 1500;
                this.enemyY[this.t] = (1 * 29 - 12) * 100 - 3000;
                this.sc[this.t] = 15000;
                this.sd[this.t] = 14000;
                this.stype[this.t] = 104;
                this.sco++;

                this.t = this.bco;
                this.ba[this.t] = 10 * 29 * 100 + 100;
                this.bb[this.t] = (11 * 29 - 12) * 100;
                this.btype[this.t] = 105;
                this.bxtype[this.t] = 1;
                this.bco++;

                this.t = this.bco;
                this.ba[this.t] = 43 * 29 * 100;
                this.bb[this.t] = (11 * 29 - 12) * 100;
                this.btype[this.t] = 82;
                this.bxtype[this.t] = 1;
                this.bco++;

                this.t = this.bco;
                this.ba[this.t] = 1 * 29 * 100;
                this.bb[this.t] = (2 * 29 - 12 + 10) * 100 - 1000;
                this.btype[this.t] = 80;
                this.bxtype[this.t] = 0;
                this.bco++;

                this.srco = 0;
                this.t = this.srco;
                this.sra[this.t] = 33 * 29 * 100;
                this.srb[this.t] = (3 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 0;
                this.sre[this.t] = 0;
                this.srsp[this.t] = 1;
                this.srco++;
                this.t = this.srco;
                this.sra[this.t] = 39 * 29 * 100 - 2000;
                this.srb[this.t] = (6 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 1;
                this.sre[this.t] = 0;
                this.srco++;
                this.t = this.srco;
                this.sra[this.t] = 45 * 29 * 100 + 1500;
                this.srb[this.t] = (10 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 0;
                this.sre[this.t] = 0;
                this.srsp[this.t] = 2;
                this.srco++;

                this.t = this.srco;
                this.sra[this.t] = 95 * 29 * 100;
                this.srb[this.t] = (7 * 29 - 12) * 100;
                this.src[this.t] = 180 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 0;
                this.sre[this.t] = 0;
                this.srsp[this.t] = 10;
                this.srco++;
                this.t = this.srco;
                this.sra[this.t] = 104 * 29 * 100;
                this.srb[this.t] = (9 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 0;
                this.sre[this.t] = 0;
                this.srsp[this.t] = 12;
                this.srco++;
                this.t = this.srco;
                this.sra[this.t] = 117 * 29 * 100;
                this.srb[this.t] = (3 * 29 - 12) * 100;
                this.src[this.t] = 90 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 1;
                this.sre[this.t] = 0;
                this.srsp[this.t] = 15;
                this.srco++;
                this.t = this.srco;
                this.sra[this.t] = 124 * 29 * 100;
                this.srb[this.t] = (5 * 29 - 12) * 100;
                this.src[this.t] = 210 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 0;
                this.sre[this.t] = 0;
                this.srsp[this.t] = 10;
                this.srco++;

                if (this.stagepoint == 1)
                {
                    this.stagepoint = 0;
                    this.ma = 4500;
                    this.mb = -3000;
                    this.tyuukan = 0;
                }

                for (this.t = 0; this.t < stagedatex.Length - 1; this.t++)
                {
                    for (this.tt = 0; this.tt < stagedatex[this.t].Length - 1; this.tt++)
                    {
                        this.stagedate[this.t][this.tt] = 0;
                        this.stagedate[this.t][this.tt] = stagedatex[this.t][this.tt];
                    }
                }
            }

            if (this.sta == 1 && this.stb == 3 && this.stc == 1)
            {
                this.resources.ChangeMusic(18);
                this.scrollx = 0 * 100;
                this.ma = 6000;
                this.mb = 6000;
                this.stagecolor = 2;
                byte[][] stagedatex;
                stagedatex = new byte[17][];
                stagedatex[0] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[1] = new byte[] { 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
                stagedatex[2] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
                stagedatex[3] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
                stagedatex[4] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
                stagedatex[5] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
                stagedatex[6] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
                stagedatex[7] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
                stagedatex[8] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 };
                stagedatex[9] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
                stagedatex[10] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
                stagedatex[11] = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
                stagedatex[12] = new byte[] { 1, 54, 0, 54, 0, 54, 0, 54, 0, 54, 0, 54, 0, 54, 0, 54, 1, 0 };
                stagedatex[13] = new byte[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1, 8, 8, 8, 8 };
                stagedatex[14] = new byte[]
                                     {
                                         6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[15] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };

                this.tco = 0;
                this.stc = 0;
                for (this.t = 0; this.t < stagedatex.Length - 1; this.t++)
                {
                    for (this.tt = 0; this.tt < stagedatex[this.t].Length - 1; this.tt++)
                    {
                        this.stagedate[this.t][this.tt] = 0;
                        this.stagedate[this.t][this.tt] = stagedatex[this.t][this.tt];
                    }
                }
            }

            if (this.sta == 1 && this.stb == 3 && this.stc == 5)
            {
                this.stagecolor = 3;
                this.resources.ChangeMusic(19);

                this.scrollx = 0 * 100;
                this.ma = 3000;
                this.mb = 33000;
                this.stagepoint = 1;

                byte[][] stagedatex;

                stagedatex = new byte[17][];
                stagedatex[0] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[1] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[2] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[3] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[4] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[5] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[6] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[7] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[8] = new byte[] { 0, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 0, 0, 0, 0, 0 };
                stagedatex[9] = new byte[] { 0, 0, 0, 9, 0, 9, 0, 9, 0, 9, 0, 0, 0, 0, 0 };
                stagedatex[10] = new byte[] { 0, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 0, 0, 0 };
                stagedatex[11] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[12] = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                stagedatex[13] = new byte[] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 0, 0, 8, 8, 8, 8, 8 };
                stagedatex[14] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[15] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };

                this.sco = 0;
                this.t = this.sco;
                this.enemyX[this.t] = 14 * 29 * 100 - 5;
                this.enemyY[this.t] = (11 * 29 - 12) * 100;
                this.sc[this.t] = 6000;
                this.sd[this.t] = 15000 - 200;
                this.stype[this.t] = 50;
                this.sxtype[this.t] = 1;
                this.sco++;

                this.txtype[this.tco] = 0;
                this.tyobi(12 * 29, 4 * 29 - 12, 112);

                this.txtype[this.tco] = 3;
                this.tyobi(12 * 29, 8 * 29 - 12, 300);

                for (this.t = 0; this.t < stagedatex.Length - 1; this.t++)
                {
                    for (this.tt = 0; this.tt < stagedatex[this.t].Length - 1; this.tt++)
                    {
                        this.stagedate[this.t][this.tt] = 0;
                        this.stagedate[this.t][this.tt] = stagedatex[this.t][this.tt];
                    }
                }
            }

            if (this.sta == 1 && this.stb == 4 && this.stc == 0)
            {
                this.resources.ChangeMusic(20);
                this.scrollx = 4400 * 100;
                this.ma = 12000;
                this.mb = 6000;
                this.stagecolor = 4;

                byte[][] stagedatex;
                stagedatex = new byte[17][];
                stagedatex[0] = new byte[]
                                    {
                                        5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[1] = new byte[]
                                    {
                                        5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                        5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5,
                                        5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 7, 7, 7, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5,
                                        5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5,
                                        5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[2] = new byte[]
                                    {
                                        5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0
                                    };
                stagedatex[3] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0
                                    };
                stagedatex[4] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0
                                    };
                stagedatex[5] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0
                                    };
                stagedatex[6] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 50, 0, 5, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0
                                    };
                stagedatex[7] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 5, 3, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 30, 0, 0, 0, 0,
                                        0, 0, 5, 5, 5, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0
                                    };
                stagedatex[8] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0
                                    };
                stagedatex[9] = new byte[]
                                    {
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 3, 0, 0, 0, 5, 5, 0,
                                        0, 0, 0, 0, 7, 7, 2, 2, 7, 5, 5, 5, 5, 0, 0, 0, 3, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0,
                                        0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 0,
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                        0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0
                                    };
                stagedatex[10] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 59, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 5,
                                         5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5,
                                         5, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0
                                     };
                stagedatex[11] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 0, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 5,
                                         5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5,
                                         5, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0,
                                         0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0
                                     };
                stagedatex[12] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 59, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 5,
                                         5, 5, 5, 5, 0, 59, 0, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5,
                                         5, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0,
                                         0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 40, 0, 5, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0
                                     };
                stagedatex[13] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 5, 5, 5, 5,
                                         5, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 5, 5, 5, 5, 0, 0, 0, 0,
                                         0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 41, 0, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[14] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 86, 0, 0, 86, 0, 5, 5, 5, 5, 5, 86, 0, 0, 86, 0,
                                         0, 86, 0, 0, 86, 0, 0, 86, 0, 0, 86, 0, 0, 86, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                                         5, 5, 5, 5, 5, 5, 86, 0, 0, 86, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 86, 5,
                                         5, 5, 5, 5, 86, 0, 0, 86, 0, 0, 5, 5, 5, 5, 5, 5, 5, 86, 0, 0, 86, 5, 5, 5, 5,
                                         86, 0, 0, 86, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 86, 0, 5, 5, 86, 0, 0, 86, 0, 0,
                                         86, 0, 0, 86, 0, 0, 86, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 41, 0,
                                         5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0
                                     };
                stagedatex[15] = new byte[]
                                     {
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                     };

                this.sco = 0;
                this.t = this.sco;
                this.enemyX[this.t] = 35 * 29 * 100 - 1500 + 750;
                this.enemyY[this.t] = (8 * 29 - 12) * 100 - 1500;
                this.sc[this.t] = 1500;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 105;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 67 * 29 * 100;
                this.enemyY[this.t] = (4 * 29 - 12) * 100;
                this.sc[this.t] = 9000 - 1;
                this.sd[this.t] = 3000 * 1 - 1;
                this.stype[this.t] = 51;
                this.sxtype[this.t] = 3;
                this.sgtype[this.t] = 0;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 73 * 29 * 100;
                this.enemyY[this.t] = (13 * 29 - 12) * 100;
                this.sc[this.t] = 3000 * 1 - 1;
                this.sd[this.t] = 3000;
                this.stype[this.t] = 52;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 123 * 29 * 100;
                this.enemyY[this.t] = (1 * 29 - 12) * 100;
                this.sc[this.t] = 30 * 6 * 100 - 1 + 0;
                this.sd[this.t] = 3000 - 200;
                this.stype[this.t] = 51;
                this.sxtype[this.t] = 10;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 124 * 29 * 100 + 3000;
                this.enemyY[this.t] = (2 * 29 - 12) * 100;
                this.sc[this.t] = 3000 * 1 - 1;
                this.sd[this.t] = 300000;
                this.stype[this.t] = 102;
                this.sxtype[this.t] = 20;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 148 * 29 * 100 + 1000;
                this.enemyY[this.t] = (-12 * 29 - 12) * 100;
                this.sc[this.t] = 3000 * 1 - 1;
                this.sd[this.t] = 300000;
                this.stype[this.t] = 102;
                this.sxtype[this.t] = 30;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 100 * 29 * 100 + 1000;
                this.enemyY[this.t] = -6000;
                this.sc[this.t] = 3000;
                this.sd[this.t] = 70000;
                this.stype[this.t] = 102;
                this.sxtype[this.t] = 12;
                this.sco++;

                this.t = this.sco;
                this.enemyX[this.t] = 0 * 29 * 100 - 0;
                this.enemyY[this.t] = 9 * 29 * 100 + 1700;
                this.sc[this.t] = 3000 * 7 - 1;
                this.sd[this.t] = 3000 * 5 - 1;
                this.stype[this.t] = 200;
                this.sxtype[this.t] = 0;
                this.sco++;
                this.t = this.sco;
                this.enemyX[this.t] = 11 * 29 * 100;
                this.enemyY[this.t] = -1 * 29 * 100 + 1700;
                this.sc[this.t] = 3000 * 8 - 1;
                this.sd[this.t] = 3000 * 4 - 1;
                this.stype[this.t] = 200;
                this.sxtype[this.t] = 0;
                this.sco++;

                this.bco = 0;
                this.t = this.bco;
                this.ba[this.t] = 8 * 29 * 100 - 1400;
                this.bb[this.t] = (2 * 29 - 12) * 100 + 500;
                this.btype[this.t] = 86;
                this.bxtype[this.t] = 0;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 42 * 29 * 100 - 1400;
                this.bb[this.t] = (-2 * 29 - 12) * 100 + 500;
                this.btype[this.t] = 86;
                this.bxtype[this.t] = 0;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 29 * 29 * 100 + 1500;
                this.bb[this.t] = (7 * 29 - 12) * 100 + 1500;
                this.btype[this.t] = 87;
                this.bxtype[this.t] = 105;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 47 * 29 * 100 + 1500;
                this.bb[this.t] = (9 * 29 - 12) * 100 + 1500;
                this.btype[this.t] = 87;
                this.bxtype[this.t] = 110;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 70 * 29 * 100 + 1500;
                this.bb[this.t] = (9 * 29 - 12) * 100 + 1500;
                this.btype[this.t] = 87;
                this.bxtype[this.t] = 105;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 66 * 29 * 100 + 1501;
                this.bb[this.t] = (4 * 29 - 12) * 100 + 1500;
                this.btype[this.t] = 87;
                this.bxtype[this.t] = 101;
                this.bco++;
                this.t = this.bco;
                this.ba[this.t] = 85 * 29 * 100 + 1501;
                this.bb[this.t] = (4 * 29 - 12) * 100 + 1500;
                this.btype[this.t] = 87;
                this.bxtype[this.t] = 105;
                this.bco++;

                this.t = this.bco;
                this.ba[this.t] = 57 * 29 * 100;
                this.bb[this.t] = (2 * 29 - 12 + 10) * 100 - 500;
                this.btype[this.t] = 80;
                this.bxtype[this.t] = 1;
                this.bco++;

                this.t = this.bco;
                this.ba[this.t] = 77 * 29 * 100;
                this.bb[this.t] = (5 * 29 - 12) * 100;
                this.btype[this.t] = 82;
                this.bxtype[this.t] = 2;
                this.bco++;

                this.t = this.bco;
                this.ba[this.t] = 130 * 29 * 100;
                this.bb[this.t] = (8 * 29 - 12) * 100;
                this.btype[this.t] = 30;
                this.bxtype[this.t] = 0;
                this.bco++;

                this.t = this.bco;
                this.ba[this.t] = 142 * 29 * 100;
                this.bb[this.t] = (10 * 29 - 12) * 100;
                this.btype[this.t] = 31;
                this.bxtype[this.t] = 0;
                this.bco++;

                this.nco = 0;
                this.na[this.nco] = 7 * 29 * 100 - 300;
                this.nb[this.nco] = 14 * 29 * 100 - 1200;
                this.ntype[this.nco] = 6;
                this.nco++;
                if (this.nco >= this.nmax) this.nco = 0;
                this.na[this.nco] = 41 * 29 * 100 - 300;
                this.nb[this.nco] = 14 * 29 * 100 - 1200;
                this.ntype[this.nco] = 6;
                this.nco++;
                if (this.nco >= this.nmax) this.nco = 0;
                this.na[this.nco] = 149 * 29 * 100 - 1100;
                this.nb[this.nco] = 10 * 29 * 100 - 600;
                this.ntype[this.nco] = 6;
                this.nco++;
                if (this.nco >= this.nmax) this.nco = 0;

                this.tco = 0;
                this.txtype[this.tco] = 1;
                this.tyobi(29 * 29, 3 * 29 - 12, 130);
                this.tyobi(34 * 29, 9 * 29 - 12, 5);
                this.tyobi(35 * 29, 9 * 29 - 12, 5);
                this.tyobi(55 * 29 + 15, 6 * 29 - 12, 7);
                this.txtype[this.tco] = 10;
                this.tyobi(50 * 29, 9 * 29 - 12, 114);
                this.txtype[this.tco] = 5;
                this.tyobi(1 * 29, 5 * 29 - 12, 300);
                this.txtype[this.tco] = 3;
                this.tyobi(86 * 29, 9 * 29 - 12, 101);
                this.txtype[this.tco] = 2;
                this.tyobi(86 * 29, 6 * 29 - 12, 117);

                for (this.t = 0; this.t <= 2; this.t++)
                {
                    this.txtype[this.tco] = 3;
                    this.tyobi((79 + this.t) * 29, 13 * 29 - 12, 115);
                }

                this.txtype[this.tco] = 3;
                this.tyobi(105 * 29, 11 * 29 - 12, 120);
                this.txtype[this.tco] = 3;
                this.tyobi(109 * 29, 7 * 29 - 12, 102);
                this.txtype[this.tco] = 4;
                this.tyobi(111 * 29, 7 * 29 - 12, 101);
                this.tyobi(132 * 29, 8 * 29 - 12 - 3, 140);
                this.tyobi(131 * 29, 9 * 29 - 12, 141);
                this.tyobi(161 * 29, 12 * 29 - 12, 142);
                this.tyobi(66 * 29, 4 * 29 - 12, 124);

                this.srco = 0;
                this.t = this.srco;
                this.sra[this.t] = 93 * 29 * 100;
                this.srb[this.t] = (10 * 29 - 12) * 100;
                this.src[this.t] = 60 * 100;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 1;
                this.sre[this.t] = 0;
                this.srco++;
                this.t = 20;
                this.sra[this.t] = 119 * 29 * 100 + 300;
                this.srb[this.t] = (10 * 29 - 12) * 100;
                this.src[this.t] = 12 * 30 * 100 + 1000;
                this.srtype[this.t] = 0;
                this.sracttype[this.t] = 0;
                this.srsp[this.t] = 21;
                this.sre[this.t] = 0;
                this.srco++;

                this.stc = 0;

                for (this.t = 0; this.t < stagedatex.Length - 1; this.t++)
                {
                    for (this.tt = 0; this.tt < stagedatex[this.t].Length - 1; this.tt++)
                    {
                        this.stagedate[this.t][this.tt] = 0;
                        this.stagedate[this.t][this.tt] = stagedatex[this.t][this.tt];
                    }
                }
            }
        }

        protected void str(string message, int x, int y)
        {
            this.spriteBatch.DrawString(this.resources.returnFont(), message, new Vector2(x, y), this.fontColor);
        }

        protected void ttmsg()
        {
            this.xx[1] = 6000 / 100;
            this.xx[2] = 4000 / 100;
            if (this.tmsgtype == 1 || this.tmsgtype == 2)
            {
                this.setc0();
                this.fillrect(this.xx[1], this.xx[2], 360, this.tmsgy / 100);
                this.setc1();
                this.drawrect(this.xx[1], this.xx[2], 360, this.tmsgy / 100);
            }

            if (this.tmsgtype == 2)
            {
                if (this.tmsg == 0)
                {
                    this.setc1();
                    this.txmsg("Message 67", 0);
                }

                if (this.tmsg == 1)
                {
                    this.setc1();
                    this.txmsg("Message 68", 0);
                    this.txmsg("Message 69", 1);
                    this.txmsg("Message 70", 2);
                    this.txmsg("Message 71", 4);
                    this.txmsg("Message 72", 6);
                }

                if (this.tmsg == 2)
                {
                    this.txmsg("Message 73", 3);
                    this.txmsg("Message 74", 6);
                }

                if (this.tmsg == 3)
                {
                    this.txmsg("Message 75", 3);
                    this.txmsg("Message 76", 6);
                }

                if (this.tmsg == 4)
                {
                    this.txmsg("Message 77", 2);
                    this.txmsg("Message 78", 4);
                }

                if (this.tmsg == 5)
                {
                    this.txmsg("Message 79", 0);
                    this.txmsg("Message 80", 1);
                    this.txmsg("Message 81", 3);
                    this.txmsg("Message 82", 6);
                }

                if (this.tmsg == 80)
                {
                    this.txmsg("Message 83", 1);
                    this.txmsg("Message 84", 2);
                    this.txmsg("Message 85", 5);
                }

                if (this.tmsg == 100)
                {
                    this.txmsg("Message 86", 0);
                    this.txmsg("Message 87", 2);
                    this.txmsg("Message 88", 3);
                    this.txmsg("Message 89", 5);
                    this.txmsg("Message 90", 6);
                }
            }

            if (this.tmsgtype == 3)
            {
                this.xx[5] = (((15 - 1) * 1200 + 1500) / 100 - this.tmsgy / 100);
                if (this.xx[5] > 0)
                {
                    this.setc0();
                    this.fillrect(this.xx[1], this.xx[2] + this.tmsgy / 100, 360, this.xx[5]);
                    this.setc1();
                    this.drawrect(this.xx[1], this.xx[2] + this.tmsgy / 100, 360, this.xx[5]);
                }
            }
        }

        protected void tyobi(int x, int y, int type)
        {
            this.ta[this.tco] = x * 100;
            this.tb[this.tco] = y * 100;
            this.ttype[this.tco] = type;
            this.tco++;
            if (this.tco >= this.tmax)
            {
                this.tco = 0;
            }
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (this.paused == false)
            {
                this.MainProgram(gameTime);
            }
            else
            {
                if (this.interval == -1)
                {
                    if (Keyboard.GetState().IsKeyDown(Keys.Enter))
                    {
                        this.paused = false;
                    }
                }
                else if (this.interval > 0)
                {
                    this.interval -= gameTime.ElapsedGameTime.Milliseconds;
                    if (this.interval < 0)
                    {
                        this.interval = 0;
                    }
                }
                else
                {
                    this.paused = false;
                }
            }

            base.Update(gameTime);
        }

        protected void wait(int i)
        {
            this.interval = i;
            this.paused = true;
        }

        protected void wait2(long stime, long etime, int FLAME_TIME)
        {
            if (etime - stime < FLAME_TIME)
            {
                this.wait(FLAME_TIME - (int)(etime - stime));
            }
        }

        protected void WaitKey()
        {
            this.interval = -1;
            this.paused = true;
        }

        private void stage()
        {
            this.scrollx = 3600 * 100;
            this.stagep();
            for (this.tt = 0; this.tt <= 1000; this.tt++)
            {
                for (this.t = 0; this.t <= 16; this.t++)
                {
                    this.xx[10] = 0;
                    if (this.stagedate[this.t][this.tt] >= 1 && this.stagedate[this.t][this.tt] <= 255)
                    {
                        this.xx[10] = this.stagedate[this.t][this.tt];
                    }

                    this.xx[21] = this.tt * 29;
                    this.xx[22] = this.t * 29 - 12;
                    this.xx[23] = this.xx[10];
                    if (this.xx[10] >= 1 && this.xx[10] <= 19 && this.xx[10] != 9)
                    {
                        this.tyobi(this.tt * 29, this.t * 29 - 12, this.xx[10]);
                    }

                    if (this.xx[10] >= 20 && this.xx[10] <= 29)
                    {
                        this.sra[this.srco] = this.xx[21] * 100;
                        this.srb[this.srco] = this.xx[22] * 100;
                        this.src[this.srco] = 3000;
                        this.srtype[this.srco] = 0;
                        this.srco++;
                        if (this.srco >= this.srmax)
                        {
                            this.srco = 0;
                        }
                    }

                    if (this.xx[10] == 30)
                    {
                        this.enemyX[this.sco] = this.xx[21] * 100;
                        this.enemyY[this.sco] = this.xx[22] * 100;
                        this.sc[this.sco] = 3000;
                        this.sd[this.sco] = 6000;
                        this.stype[this.sco] = 500;
                        this.sco++;
                        if (this.sco >= this.smax)
                        {
                            this.sco = 0;
                        }
                    }

                    if (this.xx[10] == 40)
                    {
                        this.enemyX[this.sco] = this.xx[21] * 100;
                        this.enemyY[this.sco] = this.xx[22] * 100;
                        this.sc[this.sco] = 6000;
                        this.sd[this.sco] = 3000;
                        this.stype[this.sco] = 1;
                        this.sco++;
                        if (this.sco >= this.smax)
                        {
                            this.sco = 0;
                        }
                    }

                    if (this.xx[10] == 41)
                    {
                        this.enemyX[this.sco] = this.xx[21] * 100 + 500;
                        this.enemyY[this.sco] = this.xx[22] * 100;
                        this.sc[this.sco] = 5000;
                        this.sd[this.sco] = 3000;
                        this.stype[this.sco] = 2;
                        this.sco++;
                        if (this.sco >= this.smax)
                        {
                            this.sco = 0;
                        }
                    }

                    if (this.xx[10] == 43)
                    {
                        this.enemyX[this.sco] = this.xx[21] * 100;
                        this.enemyY[this.sco] = this.xx[22] * 100 + 500;
                        this.sc[this.sco] = 2900;
                        this.sd[this.sco] = 5300;
                        this.stype[this.sco] = 1;
                        this.sco++;
                        if (this.sco >= this.smax)
                        {
                            this.sco = 0;
                        }
                    }

                    if (this.xx[10] == 44)
                    {
                        this.enemyX[this.sco] = this.xx[21] * 100;
                        this.enemyY[this.sco] = this.xx[22] * 100 + 700;
                        this.sc[this.sco] = 3900;
                        this.sd[this.sco] = 5000;
                        this.stype[this.sco] = 5;
                        this.sco++;
                        if (this.sco >= this.smax)
                        {
                            this.sco = 0;
                        }
                    }

                    if (this.xx[10] >= 50 && this.xx[10] <= 79)
                    {
                        this.ba[this.bco] = this.xx[21] * 100;
                        this.bb[this.bco] = this.xx[22] * 100;
                        this.btype[this.bco] = this.xx[23] - 50;
                        this.bco++;
                        if (this.bco >= this.bmax)
                        {
                            this.bco = 0;
                        }
                    }

                    if (this.xx[10] >= 80 && this.xx[10] <= 89)
                    {
                        this.na[this.nco] = this.xx[21] * 100;
                        this.nb[this.nco] = this.xx[22] * 100;
                        this.ntype[this.nco] = this.xx[23] - 80;
                        this.nco++;
                        if (this.nco >= this.nmax)
                        {
                            this.nco = 0;
                        }
                    }

                    if (this.xx[10] == 9)
                    {
                        this.tyobi(this.tt * 29, this.t * 29 - 12, 800);
                    }

                    if (this.xx[10] == 99)
                    {
                        this.enemyX[this.sco] = this.xx[21] * 100;
                        this.enemyY[this.sco] = this.xx[22] * 100;
                        this.sc[this.sco] = 3000;
                        this.sd[this.sco] = (12 - this.t) * 3000;
                        this.stype[this.sco] = 300;
                        this.sco++;
                        if (this.sco >= this.smax)
                        {
                            this.sco = 0;
                        }
                    }
                }
            }

            if (this.tyuukan >= 1)
            {
                this.xx[17] = 0;
                for (this.t = 0; this.t < this.smax; this.t++)
                {
                    if (this.stype[this.t] == 500 && this.tyuukan >= 1)
                    {
                        this.screenX = this.enemyX[this.t] - fxmax / 2;
                        this.fzx = this.screenX;
                        this.ma = this.enemyX[this.t] - this.screenX;
                        this.mb = this.enemyY[this.t] - this.screenY;
                        this.tyuukan--;
                        this.xx[17]++;

                        this.enemyX[this.t] = -80000000;
                    }
                }

                this.tyuukan += this.xx[17];
            }
        }

        private void tekizimen()
        {
            for (this.tt = 0; this.tt < this.smax; this.tt++)
            {
                if (this.enemyX[this.tt] - this.screenX + this.sc[this.tt] >= -12010
                    && this.enemyX[this.tt] - this.screenX <= fxmax + 12100 && this.stype[this.tt] <= 99)
                {
                    this.xx[0] = 200;
                    this.xx[2] = 1000;
                    this.xx[1] = 2000;
                    this.xx[8] = this.enemyX[this.tt] - this.screenX;
                    this.xx[9] = this.enemyY[this.tt] - this.screenY;
                    if (this.aa[this.t] + this.anobia[this.t] - this.screenX > this.xx[8] - this.xx[0]
                        && this.aa[this.t] - this.screenX < this.xx[8] + this.xx[2]
                        && this.ab[this.t] + this.anobib[this.t] - this.screenY > this.xx[9] + this.xx[1] * 3 / 4
                        && this.ab[this.t] - this.screenY < this.xx[9] + this.sd[this.tt] - this.xx[2])
                    {
                        // Collision detection between the goomba and right side
                        this.aa[this.t] = this.xx[8] - this.xx[0] - this.anobia[this.t] + this.screenX;
                        this.amuki[this.t] = 0;
                    }

                    if (this.aa[this.t] + this.anobia[this.t] - this.screenX
                        > this.xx[8] + this.sc[this.tt] - this.xx[0]
                        && this.aa[this.t] - this.screenX < this.xx[8] + this.sc[this.tt] + this.xx[0]
                        && this.ab[this.t] + this.anobib[this.t] - this.screenY > this.xx[9] + this.xx[1] * 3 / 4
                        && this.ab[this.t] - this.screenY < this.xx[9] + this.sd[this.tt] - this.xx[2])
                    {
                        // Collision detection between the goomba and right side
                        this.aa[this.t] = this.xx[8] + this.sc[this.tt] + this.xx[0] + this.screenX;
                        this.amuki[this.t] = 1;
                    }

                    if (this.aa[this.t] + this.anobia[this.t] - this.screenX > this.xx[8] + this.xx[0]
                        && this.aa[this.t] - this.screenX < this.xx[8] + this.sc[this.tt] - this.xx[0]
                        && this.ab[this.t] + this.anobib[this.t] - this.screenY > this.xx[9]
                        && this.ab[this.t] + this.anobib[this.t] - this.screenY
                        < this.xx[9] + this.sd[this.tt] - this.xx[1] && this.ad[this.t] >= -100)
                    {
                        this.ab[this.t] = this.enemyY[this.tt] - this.screenY - this.anobib[this.t] + 100
                                                                                                    + this.screenY;
                        this.ad[this.t] = 0;
                        this.axzimen[this.t] = 1;
                    }

                    if (this.aa[this.t] + this.anobia[this.t] - this.screenX > this.xx[8] + this.xx[0]
                        && this.aa[this.t] - this.screenX < this.xx[8] + this.sc[this.tt] - this.xx[0]
                        && this.ab[this.t] - this.screenY > this.xx[9] + this.sd[this.tt] - this.xx[1]
                        && this.ab[this.t] - this.screenY < this.xx[9] + this.sd[this.tt] + this.xx[0])
                    {
                        this.ab[this.t] = this.xx[9] + this.sd[this.tt] + this.xx[0] + this.screenY;
                        if (this.ad[this.t] < 0)
                        {
                            this.ad[this.t] = -this.ad[this.t] * 2 / 3;
                        }
                    }
                }
            }

            for (this.tt = 0; this.tt < this.tmax; this.tt++)
            {
                this.xx[0] = 200;
                this.xx[1] = 3000;
                this.xx[2] = 1000;
                this.xx[8] = this.ta[this.tt] - this.screenX;
                this.xx[9] = this.tb[this.tt] - this.screenY;
                if (this.ta[this.tt] - this.screenX + this.xx[1] >= -12010
                    && this.ta[this.tt] - this.screenX <= fxmax + 12000)
                {
                    if (this.atype[this.t] != 86 && this.atype[this.t] != 90 && this.ttype[this.tt] != 140)
                    {
                        if (this.ttype[this.tt] != 7)
                        {
                            if (!(this.ttype[this.tt] == 117))
                            {
                                if (this.aa[this.t] + this.anobia[this.t] - this.screenX > this.xx[8] + this.xx[0]
                                    && this.aa[this.t] - this.screenX < this.xx[8] + this.xx[1] - this.xx[0] * 1
                                    && this.ab[this.t] + this.anobib[this.t] - this.screenY > this.xx[9]
                                    && this.ab[this.t] + this.anobib[this.t] - this.screenY < this.xx[9] + this.xx[1]
                                    && this.ad[this.t] >= -100)
                                {
                                    this.ab[this.t] = this.xx[9] - this.anobib[this.t] + 100 + this.screenY;
                                    this.ad[this.t] = 0;
                                    this.axzimen[this.t] = 1;
                                    if (this.ttype[this.tt] == 120)
                                    {
                                        this.ad[this.t] = -1600;
                                        this.azimentype[this.t] = 30;
                                    }
                                }
                            }
                        }

                        if (this.ttype[this.tt] != 117)
                        {
                            if (this.aa[this.t] + this.anobia[this.t] - this.screenX > this.xx[8] + this.xx[0]
                                && this.aa[this.t] - this.screenX < this.xx[8] + this.xx[1] - this.xx[0] * 1
                                && this.ab[this.t] - this.screenY > this.xx[9] + this.xx[1] - this.xx[1]
                                && this.ab[this.t] - this.screenY < this.xx[9] + this.xx[1] + this.xx[0])
                            {
                                this.ab[this.t] = this.xx[9] + this.xx[1] + this.xx[0] + this.screenY;
                                if (this.ad[this.t] < 0)
                                {
                                    this.ad[this.t] = 0;
                                }
 // =-ad[t]*2/3;}
                            }
                        }

                        this.xx[27] = 0;
                        if ((this.atype[this.t] >= 100
                             || (this.ttype[this.tt] != 7 || this.ttype[this.tt] == 7 && this.atype[this.t] == 2))
                            && this.ttype[this.tt] != 117)
                        {
                            if (this.aa[this.t] + this.anobia[this.t] - this.screenX > this.xx[8]
                                && this.aa[this.t] - this.screenX < this.xx[8] + this.xx[2]
                                && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                > this.xx[9] + this.xx[1] / 2 - this.xx[0]
                                && this.ab[this.t] - this.screenY < this.xx[9] + this.xx[2])
                            {
                                this.aa[this.t] = this.xx[8] - this.anobia[this.t] + this.screenX;
                                this.ac[this.t] = 0;
                                this.amuki[this.t] = 0;
                                this.xx[27] = 1;
                            }

                            if (this.aa[this.t] + this.anobia[this.t] - this.screenX
                                > this.xx[8] + this.xx[1] - this.xx[0] * 2
                                && this.aa[this.t] - this.screenX < this.xx[8] + this.xx[1]
                                && this.ab[this.t] + this.anobib[this.t] - this.screenY
                                > this.xx[9] + this.xx[1] / 2 - this.xx[0]
                                && this.ab[this.t] - this.screenY < this.xx[9] + this.xx[2])
                            {
                                this.aa[this.t] = this.xx[8] + this.xx[1] + this.screenX;
                                this.ac[this.t] = 0;
                                this.amuki[this.t] = 1;
                                this.xx[27] = 1;
                            }

                            if (this.xx[27] == 1 && (this.ttype[this.tt] == 7 || this.ttype[this.tt] == 1)
                                                 && this.atype[this.t] == 2)
                            {
                                if (this.ttype[this.tt] == 7)
                                {
                                    this.resources.PlaySound(2);
                                    this.ttype[this.tt] = 3;
                                    this.eyobi(
                                        this.ta[this.tt] + 10,
                                        this.tb[this.tt],
                                        0,
                                        -800,
                                        0,
                                        40,
                                        3000,
                                        3000,
                                        0,
                                        16);
                                }
                                else if (this.ttype[this.tt] == 1)
                                {
                                    this.resources.PlaySound(1);
                                    this.eyobi(
                                        this.ta[this.tt] + 1200,
                                        this.tb[this.tt] + 1200,
                                        300,
                                        -1000,
                                        0,
                                        160,
                                        1000,
                                        1000,
                                        1,
                                        120);
                                    this.eyobi(
                                        this.ta[this.tt] + 1200,
                                        this.tb[this.tt] + 1200,
                                        -300,
                                        -1000,
                                        0,
                                        160,
                                        1000,
                                        1000,
                                        1,
                                        120);
                                    this.eyobi(
                                        this.ta[this.tt] + 1200,
                                        this.tb[this.tt] + 1200,
                                        240,
                                        -1400,
                                        0,
                                        160,
                                        1000,
                                        1000,
                                        1,
                                        120);
                                    this.eyobi(
                                        this.ta[this.tt] + 1200,
                                        this.tb[this.tt] + 1200,
                                        -240,
                                        -1400,
                                        0,
                                        160,
                                        1000,
                                        1000,
                                        1,
                                        120);
                                    this.brockbreak(this.tt);
                                }
                            }
                        }
                    }

                    if (this.atype[this.t] == 86 || this.atype[this.t] == 90)
                    {
                        if (this.aa[this.t] + this.anobia[this.t] - this.screenX > this.xx[8]
                            && this.aa[this.t] - this.screenX < this.xx[8] + this.xx[1]
                            && this.ab[this.t] + this.anobib[this.t] - this.screenY > this.xx[9]
                            && this.ab[this.t] - this.screenY < this.xx[9] + this.xx[1])
                        {
                            this.resources.PlaySound(1);
                            this.eyobi(
                                this.ta[this.tt] + 1200,
                                this.tb[this.tt] + 1200,
                                300,
                                -1000,
                                0,
                                160,
                                1000,
                                1000,
                                1,
                                120);
                            this.eyobi(
                                this.ta[this.tt] + 1200,
                                this.tb[this.tt] + 1200,
                                -300,
                                -1000,
                                0,
                                160,
                                1000,
                                1000,
                                1,
                                120);
                            this.eyobi(
                                this.ta[this.tt] + 1200,
                                this.tb[this.tt] + 1200,
                                240,
                                -1400,
                                0,
                                160,
                                1000,
                                1000,
                                1,
                                120);
                            this.eyobi(
                                this.ta[this.tt] + 1200,
                                this.tb[this.tt] + 1200,
                                -240,
                                -1400,
                                0,
                                160,
                                1000,
                                1000,
                                1,
                                120);
                            this.brockbreak(this.tt);
                        }
                    }
                }

                if (this.ttype[this.tt] == 140)
                {
                    if (this.ab[this.t] - this.screenY > this.xx[9] - this.xx[0] * 2 - 2000
                        && this.ab[this.t] - this.screenY < this.xx[9] + this.xx[1] - this.xx[0] * 2 + 2000
                        && this.aa[this.t] + this.anobia[this.t] - this.screenX > this.xx[8] - 400
                        && this.aa[this.t] - this.screenX < this.xx[8] + this.xx[1])
                    {
                        this.ta[this.tt] = -800000;
                        this.sracttype[20] = 1;
                        this.sron[20] = 1;
                    }
                }
            }
        }

        private void txmsg(string x, int a)
        {
            int xx = 6;
            this.str(x, 60 + xx, 40 + xx + a * 24);
        }
    }
}