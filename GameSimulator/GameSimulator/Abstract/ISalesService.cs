using GameSimulator.Entities;

namespace GameSimulator.Concrete

{
    internal interface ISalesService
    {
        public void Buy(Player player, Game game );
        public void Buy2(Player player, Game game, Campaign campaign);

    }
}