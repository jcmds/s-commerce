using System;

namespace SC.Core.Commands
{
    public abstract class CommandResult : ICommandResult
    {
        protected CommandResult() => Executed = DateTime.Now;

        public bool Success { get; protected set; }

        public DateTime Executed { get; }
    }
}