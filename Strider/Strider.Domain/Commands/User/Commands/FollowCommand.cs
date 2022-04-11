﻿using Strider.Domain.Commands.Contracts;
using System;

namespace Strider.Domain.Commands.User.Commands
{
    public class FollowCommand : Command
    {
        public Guid UserId { get; set; }
        public Guid UserFollowId { get; set; }
    }
}
