
namespace ArmyOfCreatures.Extended
{
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Creatures;

    public class ExtendCreaturesFactory:CreaturesFactory
    {
        public ExtendCreaturesFactory():base()
        {

        }

        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Goblin":
                    return new Goblin();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new WolfRaider();
                default:
                    return base.CreateCreature(name);
            }
        }
    }
}
