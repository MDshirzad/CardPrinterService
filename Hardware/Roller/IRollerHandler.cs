using CSharpFunctionalExtensions;
using static Hardware.Roller.RollerConstants;

namespace Hardware.Roller
{
    public interface IRollerHandler
    {
        public CardStatus GetStatus();
        public Result Eject();
        public Result Capture();
    }
}
