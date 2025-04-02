using static Hardware.Roller.RollerConstants;

namespace Hardware.Roller
{
    public interface IRollerHandler
    {
        public CardStatus GetStatus();
        public bool Eject();
        public bool Capture();
    }
}
