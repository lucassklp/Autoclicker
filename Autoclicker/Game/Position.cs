using System.Drawing;

namespace Autoclicker.Game
{
    public class Position
    {
        private static Point Adjust(Point point)
        {
            point.Offset(0, 30);
            return point;
        }

        //Posição dos aliados e inimigos
        #region Fight Positions
        public static Point Enemy1 => Adjust(new Point(225, 110));

        public static Point Enemy2 => Adjust(new Point(330, 110));
                             
        public static Point Enemy3 => Adjust(new Point(185, 180));

        public static Point Enemy4 => Adjust(new Point(280, 175));
        
        public static Point Enemy5 => Adjust(new Point(120, 250));
        
        public static Point Enemy6 => Adjust(new Point(235, 255));

        public static Point Enemy7 => Adjust(new Point(85, 325));
        
        public static Point Enemy8 => Adjust(new Point(181, 326));
        
        public static Point Enemy9 => Adjust(new Point(30, 395));

        public static Point Enemy10 => Adjust(new Point(130, 395));

        public static Point Ally5 => Adjust(new Point(662, 234));
        
        #endregion


        #region Interface Positions

        //Calculadora da posição da skill na lista
        public static Point GetSkillPosition(int skill, int level)
        {
            int pos = (4 * (skill - 1) + (level - 1));
            return new Point(346, 116 + (18 * pos));
        }


        //Posição dos botões da barra de batalha
        #region Battle Screen Positions
        public static Point AtackButton => Adjust(new Point(633, 475));

        public static Point SkillButton => Adjust(new Point(657, 475));
        
        public static Point BagButton => Adjust(new Point(681, 475));
        
        public static Point DefButton => Adjust(new Point(705, 475));
        
        public static Point DogdeButton => Adjust(new Point(728, 475));
        
        public static Point CTUButton => Adjust(new Point(754, 475));
        
        public static Point ESCButton => Adjust(new Point(777, 475));
        
        public static Point Pet_AtackButton => Adjust(new Point(633, 535));
        
        public static Point Pet_SkillButton => Adjust(new Point(657, 535));
        
        public static Point Pet_BagButton => Adjust(new Point(681, 535));
        
        public static Point Pet_DefButton => Adjust(new Point(705, 535));

        public static Point Pet_DogdeButton => Adjust(new Point(728, 535));
        
        public static Point Pet_RecallButton => Adjust(new Point(754, 535));
        
        public static Point Pet_ChangeButton => Adjust(new Point(777, 535));
        
        public static Point AutomaticButton => Adjust(new Point(410, 525));
        
        #endregion

        //Posição dos botões fora de combate
        #region Interface Buttons
        public static Point MapButton => Adjust(new Point(785, 56));
        public static Point InventoryButton => Adjust(new Point(418, 571));
        public static Point GiveButton => Adjust(new Point(622, 571));


        #endregion

        //Posição das opções das caixas de dialogo.
        #region Dialog Box Positions
        public static Point Vival_GetPrizesButton => Adjust(new Point(292, 253));
        
        public static Point Vival_ContinueButton => Adjust(new Point(285, 272));
        
        public static Point Vival_StartNowButton => Adjust(new Point(285, 290));
        
        public static Point Robber_Start => Adjust(new Point(400, 300));
        
        public static Point ConvenienceShop_CentStore => Adjust(new Point(295, 291));
        public static Point ConvenienceShop_MageStore => Adjust(new Point(290, 313));

        public static Point CloseConvenienceShop => Adjust(new Point(670, 145));
        public static Point ConfirmPurchaseConvinienceStore => Adjust(new Point(640, 390));

        public static Point StartTreasureEvent => Adjust(new Point(363, 288));
        public static Point ConfirmGiveItem => Adjust(new Point(625, 450));
        
        public static Point ClosePopup => Adjust(new Point(410, 250));  

        public static Point SaintPatrolConfirm => Adjust(new Point(365, 290));



        #endregion

        #endregion




        public static Point IWantToRedeemNow => Adjust(new Point(313, 273));
        public static Point ImSureToExchangeIt => Adjust(new Point(332, 254));
        public static Point ArmorOfDream => Adjust(new Point(307, 273));
        public static Point TollItem => Adjust(new Point(290, 310));

        public static Point MoonHelderTrouble => Adjust(new Point(325, 270));
        public static Point IllFindRedRope => Adjust(new Point(330, 255));
        public static Point Hurricane9 => Adjust(new Point(490, 255));
        public static Point Spot6 => Adjust(new Point(275, 330));
        public static Point WalkCloserToRobberChief => Adjust(new Point(290, 90));
        public static Point GiveMeTheRedRope => Adjust(new Point(330, 235));
        public static Point RedTeleport_Wood => Adjust(new Point(290, 253));

        public static Point Minimap_MoonElder => Adjust(new Point(369, 207));

    }
}