namespace Game.ActorModel.Messages
{
    public sealed class JoinGameMessage
    {
        public string PlayerName { get; private set; }

        public JoinGameMessage(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
