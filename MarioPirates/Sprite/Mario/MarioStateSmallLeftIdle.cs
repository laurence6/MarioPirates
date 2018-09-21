namespace MarioPirates
{

    public class MarioStateSmallLeftIdle : MarioStateSmall
    {
        public MarioStateSmallLeftIdle(Mario mario) : base(mario)
        {
        }

        public override void Left()
        {
            mario.State = new MarioStateSmallLeftRun(mario);
        }

        public override void Right()
        {
            mario.State = new MarioStateSmallRightIdle(mario);
        }

        public override void Jump()
        {
            mario.State = new MarioStateSmallLeftJump(mario);
        }

        public override void Crouch()
        {
            mario.State = new MarioStateSmallLeftCrouch(mario);
        }

        public override void Small()
        {
        }

        public override void Big()
        {
            mario.State = new MarioStateBigLeftIdle(mario);
        }

        public override void Fire()
        {
            mario.State = new MarioStateFireLeftIdle(mario);
        }

        public override void Update()
        {
            mario.DrawSrc.X = 150;
            mario.DrawSrc.Y = 0;
            mario.DrawSrc.Width = marioWidth;
            mario.DrawSrc.Height = marioHeight;
            mario.DrawDst.Width = marioWidth * zoom;
            mario.DrawDst.Height = marioHeight * zoom;
        }
    }

}
