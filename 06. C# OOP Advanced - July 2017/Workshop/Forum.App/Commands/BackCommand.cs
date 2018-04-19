﻿namespace Forum.App.Commands
{
    using Contracts;
    public class BackCommand : ICommand
    {
        private ISession session;

        public BackCommand(ISession session)
        {
            this.session = session;
        }
        public IMenu Execute(params string[] args)
        {
            return this.session.Back();
        }
    }
}
