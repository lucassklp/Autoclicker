using System.Drawing;

namespace Autoclicker.Game
{
    public static class GameObjectExtension
    {
        public static Bitmap AsBitmap(this GameObject obj)
        {
            return new Bitmap($@"Images\{obj}.bmp");
        }
    }



    public enum GameObject
    {
        /*-- Portrait/Races --*/
        MaleCent,
        FemaleMage,
        FemaleBorg,
        FemaleCent,
        MaleHuman,
        MaleMage,
        MaleBorg,
        FemaleHuman,

        /*-- Itens --*/
        FemaleHuman_Shoe,
        FemaleHuman_Weap,
        FemaleHuman_Armor,
        FemaleHuman_Helm,

        FemaleMage_Shoe,
        FemaleMage_Weap,
        FemaleMage_Armor,
        FemaleMage_Helm,

        FemaleBorg_Shoe,
        FemaleBorg_Weap,
        FemaleBorg_Armor,
        FemaleBorg_Helm,

        FemaleCent_Shoe,
        FemaleCent_Weap,
        FemaleCent_Armor,
        FemaleCent_Helm,

        MaleHuman_Shoe,
        MaleHuman_Weap,
        MaleHuman_Armor,
        MaleHuman_Helm,

        MaleMage_Shoe,
        MaleMage_Weap,
        MaleMage_Armor,
        MaleMage_Helm,

        MaleBorg_Shoe,
        MaleBorg_Weap,
        MaleBorg_Armor,
        MaleBorg_Helm,

        MaleCent_Shoe,
        MaleCent_Weap,
        MaleCent_Armor,
        MaleCent_Helm,


        /*Skills*/
        Protect,
        Protect_I,
        Protect_II,
        Protect_III,
        Protect_IV,

        Enhance,
        Enhance_I,
        Enhance_II,
        Enhance_III,
        Enhance_IV,

        Drain,
        Drain_I,
        Drain_II,
        Drain_III,
        Drain_IV,

        PhysicalMirror,
        PhysicalMirror_I,
        PhysicalMirror_II,
        PhysicalMirror_III,
        PhysicalMirror_IV,

        MagicalMirror,
        MagicalMirror_I,
        MagicalMirror_II,
        MagicalMirror_III,
        MagicalMirror_IV,

        PurgueStun,
        PurgueStun_I,
        PurgueStun_II,
        PurgueStun_III,
        PurgueStun_IV,

        PurgueChaos,
        PurgueChaos_I,
        PurgueChaos_II,
        PurgueChaos_III,
        PurgueChaos_IV,

        Heal,
        Heal_I,
        Heal_II,
        Heal_III,
        Heal_IV,

        Speed,
        Speed_I,
        Speed_II,
        Speed_III,
        Speed_IV,

        Multishot,
        Multishot_I,
        Multishot_II,
        Multishot_III,
        Multishot_IV,

        Poison,
        Poison_I,
        Poison_II,
        Poison_III,
        Poison_IV,

        Frailty,
        Frailty_I,
        Frailty_II,
        Frailty_III,
        Frailty_IV,

        Hypnotize,
        Hypnotize_I,
        Hypnotize_II,
        Hypnotize_III,
        Hypnotize_IV,

        Stun,
        Stun_I,
        Stun_II,
        Stun_III,
        Stun_IV,

        Chaos,
        Chaos_I,
        Chaos_II,
        Chaos_III,
        Chaos_IV,

        Ice,
        Ice_I,
        Ice_II,
        Ice_III,
        Ice_IV,

        Fire,
        Fire_I,
        Fire_II,
        Fire_III,
        Fire_IV,

        Dark,
        Dark_I,
        Dark_II,
        Dark_III,
        Dark_IV,

        Flash,
        Flash_I,
        Flash_II,
        Flash_III,
        Flash_IV,

        Death,
        Death_I,
        Death_II,
        Death_III,
        Death_IV,


        /*Interface*/
        Give_Button,
        Confirm_Button,
        Message_Box,
        Empty_Slot,
        Auto_Button,
        Auto_Button_Activated,
        Map_Button,
        Inventory_Button,
        Out_Of_Battle,
        CloseButton,

        FirstInventory_Activated,
        FirstInventory_Desactivated,
        SecondInventory_Activated,
        SecondInventory_Desactivated,

        /*NPC's*/
        Drowcrusher,
        Existent,
        
        /* Toll Itens */
        ConvenienceStore,

        /*Robbers*/
        Robber_1,
        Robber_2,
        Robber_3,
        Robber_4,

        /*Crabs*/
        Crab,

        /*Festival Treasure*/
        TreasureSelected,
        TreasureNotSelected,


    }
}