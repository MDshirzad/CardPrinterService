﻿using CSharpFunctionalExtensions;
using MessageHandler.Contracts;

namespace MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.DoubleSideLaser.WithRibbon.YMCKO.DoubleSide
{
    internal class DoubleLaserDoubleSideYmckoCommandHandler : ICommandHandler<DoubleLaserDoubleSideYmckoCommand>
    {
        public Task<Result<MessageResult>> Handle(DoubleLaserDoubleSideYmckoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
