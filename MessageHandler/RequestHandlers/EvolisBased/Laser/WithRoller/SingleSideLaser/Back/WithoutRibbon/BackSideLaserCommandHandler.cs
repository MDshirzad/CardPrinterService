﻿using CSharpFunctionalExtensions;
using MessageHandler.Contracts;

namespace MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.SingleSideLaser.Back.WithoutRibbon
{
    internal class BackSideLaserCommandHandler : ICommandHandler<BackSideLaserCommand>
    {
        public Task<Result<MessageResult>> Handle(BackSideLaserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
