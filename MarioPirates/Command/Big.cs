﻿namespace MarioPirates.Commands
{
    public class Big : ICommand
    {
        private Mario mario;

        public Big(Mario mario)
        {
            this.mario = mario;
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
