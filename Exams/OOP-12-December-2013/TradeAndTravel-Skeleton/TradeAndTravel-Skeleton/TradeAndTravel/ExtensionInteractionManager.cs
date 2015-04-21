using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class ExtensionInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "armor":
                    {
                        item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                        break;
                    }
                case "wood":
                    {
                        item = new Wood(itemNameString, itemLocation);
                        break;
                    }
                case "iron":
                    {
                        item = new Iron(itemNameString, itemLocation);
                        break;
                    }
                case "weapon":
                    {
                        item = new Weapon(itemNameString, itemLocation);
                        break;
                    }
                default:
                    break;

            }
            return item;
        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
                Location location = null;
                switch (locationTypeString)
                {
                    case "town":
                        {
                            location = base.CreateLocation(locationTypeString, locationName);
                            break;
                        }
                    case "forest":
                        {
                            location = new Forest(locationName);
                            break;
                        }
                    case "mine":
                        {
                            location = new Mine(locationName);
                            break;
                        }
                    default: break;
                }
                return location;
        }
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "shopkeeper":
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
                case "traveller":
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
                case "merchant":
                    {
                        person = new Merchant(personNameString, personLocation);
                        break;
                    }
                default:
                    break;
            }
            return person;
        }
        protected override void HandleItemCreation(string itemTypeString, string itemNameString, string itemLocationString)
        {
            base.HandleItemCreation(itemTypeString, itemNameString, itemLocationString);
        }
        protected override void HandleLocationCreation(string locationTypeString, string locationName)
        {
            base.HandleLocationCreation(locationTypeString, locationName);
        }
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch(commandWords[1])
            {
                case "gather":
                    {
                        HandleGatherInteraction(actor, commandWords);
                        break;
                    }
                case "craft":
                    {
                        HandleCraftInteraction(actor, commandWords);
                        break;
                    }
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }

        }
        protected override void HandlePersonCreation(string personTypeString, string personNameString, string personLocationString)
        {
            base.HandlePersonCreation(personTypeString, personNameString, personLocationString);
        }
        
    private void  HandleGatherInteraction(Person actor, string[]commandWords)
        {
        
             if(actor.Location is Forest)
                {
                     if(actor.ListInventory().Any(x=>x is Weapon))
                    {
                         Wood item = new Wood(commandWords[2]);
                         actor.AddToInventory(item);
                         this.ownerByItem.Add(item,actor);
                    }
               
                 }else
             if(actor.Location is Mine)
                 {
                     if(actor.ListInventory().Any(x=>x is Armor))
                     {
                         Iron item = new Iron(commandWords[2]);
                         actor.AddToInventory(item);
                         this.ownerByItem.Add(item, actor);
                     }

                 }
        
        }
    
        private void  HandleCraftInteraction(Person actor, string[]commandWords)
    {
            if(commandWords[2]=="weapon")
            {
                if(actor.ListInventory().Any(x=>x is Iron) && actor.ListInventory().Any(x=>x is Wood))
                {
                    Weapon item = new Weapon(commandWords[3]);
                    actor.AddToInventory(item );
                    this.ownerByItem.Add(item, actor);
                    
                }
            }else
                if(commandWords[2]=="armor")
                {
                    if(actor.ListInventory().Any(x=>x is Iron))
                    {
                        Armor item = new Armor(commandWords[3]);
                        actor.AddToInventory(item);
                        this.ownerByItem.Add(item, actor);
                    }
                }
    }
    }
}
