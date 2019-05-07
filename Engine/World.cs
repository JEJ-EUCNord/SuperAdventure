using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public static class World
    {
        private static readonly List<Item> _items = new List<Item>();
        private static readonly List<Monster> _monsters = new List<Monster>();
        private static readonly List<Quest> _quests = new List<Quest>();
        private static readonly List<Location> _locations = new List<Location>();

        public const int UNSELLABLE_ITEM_PRICE = -1;

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_BEASTS_HORN = 11;
        public const int ITEM_ID_KEY_OF_POWER = 12;
        public const int ITEM_ID_KEY_OF_GREED = 13;
        public const int ITEM_ID_KEY_OF_JEALOUSY = 14;
        public const int ITEM_ID_KEY_OF_PAIN = 15;
        public const int ITEM_ID_KEY_OF_LUST = 16;
        public const int ITEM_ID_KEY_OF_GRIEF = 17;
        public const int ITEM_ID_KEY_OF_CHAOS = 18;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_GATHER_KEYS_OF_EMOTION = 3;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_NOTHERN_WOODS = 10;
        public const int LOCATION_ID_LIGHTS_LANDING = 11;
        public const int LOCATION_ID_SHOP_OF_LIGHT = 12;
        public const int LOCATION_ID_TAVERN = 13;
        public const int LOCATION_ID_FOREST_OF_SOULS = 14;
        public const int LOCATION_ID_THE_TICKING_FOREST = 15;
        public const int LOCATION_ID_TICKING_HOUSE_OF_GREED = 16;
        public const int LOCATION_ID_LIGHTS_EDGE = 17;
        public const int LOCATION_ID_THE_MARKET_AT_THE_END_OF_LIGHT = 18;
        public const int LOCATION_ID_LIGHT_END = 19;
        public const int LOCATION_ID_THE_VOID = 20;
        public const int LOCATION_ID_BEASTS_DEN = 21;
        public const int LOCATION_ID_FOREST_OF_LIGHT_SOULS = 22;
        public const int LOCATION_ID_BROKEN_PORTAL = 23;
        public const int LOCATION_ID_LIGHTNERS_HAVEN = 24;
        public const int LOCATION_ID_LIGHTNERS_MINE = 25;
        public const int LOCATION_ID_MAGICAL_FOREST = 26;
        public const int LOCATION_ID_HOWLING_CLIFFS = 27;
        public const int LOCATION_ID_THE_SILENT_CLIFF = 28;
        public const int LOCATION_ID_WIZARDS_LAIR = 29;
        public const int LOCATION_ID_FIELD_OF_LIGHT = 30;
        public const int LOCATION_ID_ABYSS_OF_PURE_LIGHT = 31;
        public const int LOCATION_ID_SEA_OF_PERFECTLY_INSTILLED_LIGHT = 32;
        public const int LOCATION_ID_GUARDS_OF_LIGHT = 33;
        public const int LOCATION_ID_GUARDIAN_OF_LIGHT = 34;
        public const int LOCATION_ID_GOD_OF_LIGHT = 35;
        public const int LOCATION_ID_LUST_FOR_POWER = 36;
        public const int LOCATION_ID_LACK_OF_MEANING = 37;
        public const int LOCATION_ID_HOLLOW_PLACEMENTS = 38;
        public const int LOCATION_ID_AN_EMPTY_TOMB = 39;
        public const int LOCATION_ID_DARKNESS_INCARNATE = 40;
        public const int LOCATION_ID_WORSHIPPERS_LAIR = 41;
        public const int LOCATION_ID_DEATHS_BRINGER = 42;
        public const int LOCATION_ID_A_HIDDEN_TUNNEL = 43;
        public const int LOCATION_ID_SINNERS_PALACE = 44;
        public const int LOCATION_ID_LACK_OF_LIGHT = 45;
        public const int LOCATION_ID_A_SILENT_CORRIDOR = 46;
        public const int LOCATION_ID_DARK_HEART = 47;
        public const int LOCATION_ID_KEY_OF_GREED = 48;
        public const int LOCATION_ID_KEY_OF_JEALOUSY = 49;
        public const int LOCATION_ID_KEY_OF_POWER = 50;
        public const int LOCATION_ID_GREEDS_SEED = 51;
        public const int LOCATION_ID_SINFUL_GRAVEYARD = 52;
        public const int LOCATION_ID_KEY_OF_LUST = 53;
        public const int LOCATION_ID_KEY_OF_GRIEF = 54;
        public const int LOCATION_ID_KEY_OF_PAIN = 55;
        public const int LOCATION_ID_THE_CALM_BEFORE_THE_STORM = 56;
        public const int LOCATION_ID_SHRIEKING_SILENCE = 57;
        public const int LOCATION_ID_COMPLETE_AND_UTTER_SILENCE = 58;
        public const int LOCATION_ID_DARK = 59;
        public const int LOCATION_ID_DARKER = 60;
        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            _items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5, 5));
            _items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", 1));
            _items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", 1));
            _items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs", 1));
            _items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 2));
            _items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10, 8));
            _items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5, 3));
            _items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs", 1));
            _items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks", 1));
            _items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes", UNSELLABLE_ITEM_PRICE));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            _monsters.Add(rat);
            _monsters.Add(snake);
            _monsters.Add(giantSpider);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the alchemist's garden",
                    "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.", 20, 20);

            Quest gatherKeysOfEmotion =
               new Quest(QUEST_ID_GATHER_KEYS_OF_EMOTION, "Gather the keys of emotion", "You must gather all the keys, and then you'll gain the Key of Chaos. I'll throw in 20 gold pieces as well.", 20, 20);


            gatherKeysOfEmotion.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KEY_OF_GREED), 1));
            gatherKeysOfEmotion.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KEY_OF_JEALOUSY), 1));
            gatherKeysOfEmotion.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KEY_OF_POWER), 1));
            gatherKeysOfEmotion.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KEY_OF_LUST), 1));
            gatherKeysOfEmotion.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KEY_OF_GRIEF), 1));
            gatherKeysOfEmotion.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KEY_OF_PAIN), 1));

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            gatherKeysOfEmotion.RewardItem = ItemByID(ITEM_ID_KEY_OF_CHAOS);
            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            _quests.Add(clearAlchemistGarden);
            _quests.Add(clearFarmersField);
            _quests.Add(gatherKeysOfEmotion);

        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.");

            Vendor bobTheRatCatcher = new Vendor("Bob the Rat-Catcher");
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_PIECE_OF_FUR), 5);
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_RAT_TAIL), 3);

            townSquare.VendorWorkingHere = bobTheRatCatcher;

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.AddMonster(MONSTER_ID_RAT, 100);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.");
            farmersField.AddMonster(MONSTER_ID_RAT, 20);
            farmersField.AddMonster(MONSTER_ID_SNAKE, 80);
            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.");
            spiderField.AddMonster(MONSTER_ID_GIANT_SPIDER, 100);
           
            Location nothernWoods = new Location(LOCATION_ID_NOTHERN_WOODS, "Nothern woods", "You see a portal. Will you  jump in? (THERE'S NO GOING BACK)");

            Location lightsLanding = new Location(LOCATION_ID_LIGHTS_LANDING, "Lights Landing", "You woke up seeing nothing but light. What happpened?");

            Location shopOfLight = new Location(LOCATION_ID_SHOP_OF_LIGHT, "A magical shop", "A lot of weapons for sale... Also a spider eye.");

            Location tavern = new Location(LOCATION_ID_TAVERN, "CT's tavern", "You might do better in combat when drunk");

            Location forestOfSouls = new Location(LOCATION_ID_FOREST_OF_SOULS, "Forest of souls", "A forest full of souls. Huh.");

            Location forestOfLightSouls = new Location(LOCATION_ID_FOREST_OF_LIGHT_SOULS, "Forest of light souls", "More like dark souls amirite?");

            Location tickingForest = new Location(LOCATION_ID_THE_TICKING_FOREST, "Ticking forest", "Are the trees... ticking?");

            Location lightsEdge = new Location(LOCATION_ID_LIGHTS_EDGE, "Light's Edge", "A town located at the edge of Light's kingdom");

            Location lightsEnd = new Location(LOCATION_ID_LIGHT_END, "Light's End", "Darkness on one side, light on another. You feel at peace, for just a single moment");

            Location theVoid = new Location(LOCATION_ID_THE_VOID, "The Void", "The Positive emotions slowly leave your body", ItemByID(ITEM_ID_BEASTS_HORN));

            Location theCalmBeforeTheStorm = new Location(LOCATION_ID_THE_CALM_BEFORE_THE_STORM, "The calm before the storm", "Fear grows within you.", ItemByID(ITEM_ID_KEY_OF_CHAOS));

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            // Add the locations to the static list
            _locations.Add(home);
            _locations.Add(townSquare);
            _locations.Add(guardPost);
            _locations.Add(alchemistHut);
            _locations.Add(alchemistsGarden);
            _locations.Add(farmhouse);
            _locations.Add(farmersField);
            _locations.Add(bridge);
            _locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            return _items.SingleOrDefault(x => x.ID == id);
        }

        public static Monster MonsterByID(int id)
        {
            return _monsters.SingleOrDefault(x => x.ID == id);
        }

        public static Quest QuestByID(int id)
        {
            return _quests.SingleOrDefault(x => x.ID == id);
        }

        public static Location LocationByID(int id)
        {
            return _locations.SingleOrDefault(x => x.ID == id);
        }
    }
}
