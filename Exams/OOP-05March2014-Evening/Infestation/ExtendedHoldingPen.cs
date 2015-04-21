
namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public   class ExtendedHoldingPen:HoldingPen
    {
        public ExtendedHoldingPen():base()
        {

        }


        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {

            Unit unit = this.GetUnit(commandWords[2]);

            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    {
                        unit.AddSupplement(new PowerCatalyst());
                        break;
                    }
                case "AggressionCatalyst":
                    {
                        unit.AddSupplement(new AggressionCatalyst());
                        break;
                    }
                case "HealthCatalyst":
                    {
                        unit.AddSupplement(new HealthCatalyst());
                        break;
                    }
                case "Weapon":
                    {
                        unit.AddSupplement(new Weapon());
                        break;
                    }
                default:
                    {
                        base.ExecuteAddSupplementCommand(commandWords);
                        break;

                    }

            }


        }
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
            base.ExecuteInsertUnitCommand(commandWords);
        }
     
        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit targetUnit = this.GetUnit(interaction.TargetUnit);
                    Unit sourceUnit = this.GetUnit(interaction.SourceUnit);
                    if (CheckForInfesting(sourceUnit, targetUnit))
                    {
                        targetUnit.AddSupplement(new InfestationSpores());                     
                    }
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }

        private bool CheckForInfesting(Unit sourceUnit,Unit targetUnit)
        {
            if (targetUnit.UnitClassification == sourceUnit.UnitClassification && 
                targetUnit.UnitClassification == UnitClassification.Biological)
            {
                return true;
            }
            else
                if (sourceUnit.UnitClassification == UnitClassification.Psionic && 
                    (targetUnit.UnitClassification == UnitClassification.Mechanical || 
                    targetUnit.UnitClassification == UnitClassification.Psionic))
                {
                    return true;
                }
                else
                    return false;
              
        }
    }
}
