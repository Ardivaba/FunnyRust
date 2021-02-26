using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyRust
{
    public class Player
    {
        public string Id;
        public string Helmet;
        public string Chest;
        public string HeldWeapon;
        public string Legs;
        public string Slot;
        public List<string> Wear;
    }

    public struct PlayerParserResponse
    {
        public List<Player> Players;
        public int Nakeds;
    }

    public static class PlayerParser
    {
        public static PlayerParserResponse Parse(List<Entity> entities)
        {
            var players = new List<Player>();

            foreach(var entity in entities)
            {
                if (entity.Name != "assets/prefabs/player/player_model.prefab")
                    continue;

                if (entity.Children.Count < 6)
                    continue;

                players.Add(ParsePlayer(entity));
            }

            return new PlayerParserResponse
            {
                Players = players,
                Nakeds = 0
            };
        }

        private static Player ParsePlayer(Entity entity)
        {
            var player = new Player();

            var weapons = entity.FindAllThatContains("assets/prefabs/weapons/");
            foreach(var weapon in weapons)
            {
                if (weapon.Parent.Name == "r_hand" || weapon.Parent.Name == "r_prop")
                {
                    player.HeldWeapon = CleanName(weapon.Name);
                }
            }

            var clothing = new string[]
            {
                "burlap",
                "hazmat",
                "vest.metal",
                "hoodie",
                "pants",
                "hide",
                "gloves"
            };

            var wearing = new List<string>();

            foreach(var child in entity.Children)
            {
                var found = false;
                foreach(var cloth in clothing)
                {
                    if (child.Name.Contains(cloth))
                        found = true;
                }
                if (found)
                {
                    wearing.Add(CleanName(child.Name));
                }
            }

            player.Wear = wearing;

            return player;
        }

        private static string CleanName(string name)
        {
            var split = name.Split('/');
            return split.Last().Replace(".prefab", "").Replace(".entity", "");
        }
    }
}
