namespace Game.ActorModel.Messages
{
    public sealed class AttackPlayerMessage
    {
        public string PlayerName { get; private set; }

        public AttackPlayerMessage(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
