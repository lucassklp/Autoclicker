using System.Drawing;

namespace Autoclicker.Game
{
    public class Position
    {
        //Posição dos aliados e inimigos
        #region Fight Positions
        public static Point Enemy1 => new Point(225, 110 + 25);

        public static Point Enemy2 => new Point(330, 110 + 25);
                             
        public static Point Enemy3 => new Point(185, 180 + 25);

        public static Point Enemy4 => new Point(280, 175 + 25);
        
        public static Point Enemy5 => new Point(120, 250 + 25);
        
        public static Point Enemy6 => new Point(235, 255 + 25);

        public static Point Enemy7 => new Point(85, 325 + 25);
        
        public static Point Enemy8 => new Point(181, 326 + 25);
        
        public static Point Enemy9 => new Point(30, 395 + 25);

        public static Point Enemy10 => new Point(130, 395 + 25);



        public static Point Ally5()
        {
            return new Point(662, 234 + 25);
        }

        #endregion

        #region Interface Positions

        //Calculadora da posição da skill na lista
        public static Point GetSkillPosition(int skill, int level)
        {
            int pos = (4 * (skill - 1) + (level - 1));
            return new Point(346, 116 + 25 + (18 * pos));
        }

        //Posição dos botões da barra de batalha
        #region Battle Screen Positions
        public static Point AtackButton()
        {
            return new Point(633, 475 + 25);
        }
        public static Point SkillButton()
        {
            return new Point(657, 475 + 25);
        }
        public static Point BagButton()
        {
            return new Point(681, 475 + 25);
        }
        public static Point DefButton()
        {
            return new Point(705, 475 + 25);
        }
        public static Point DogdeButton()
        {
            return new Point(728, 475 + 25);
        }
        public static Point CTUButton()
        {
            return new Point(754, 475 + 25);
        }
        public static Point ESCButton()
        {
            return new Point(777, 475 + 25);
        }

        public static Point Pet_AtackButton()
        {
            return new Point(633, 535 + 25);
        }
        public static Point Pet_SkillButton()
        {
            return new Point(657, 535 + 25);
        }
        public static Point Pet_BagButton()
        {
            return new Point(681, 535 + 25);
        }
        public static Point Pet_DefButton()
        {
            return new Point(705, 535 + 25);
        }
        public static Point Pet_DogdeButton()
        {
            return new Point(728, 535 + 25);
        }
        public static Point Pet_RecallButton()
        {
            return new Point(754, 535 + 25);
        }
        public static Point Pet_ChangeButton()
        {
            return new Point(777, 535 + 25);
        }

        public static Point AutomaticButton()
        {
            return new Point(410, 525 + 25);
        }



        #endregion

        //Posição dos botões fora de combate
        #region Interface Buttons
        public static Point MapButton()
        {
            return new Point(785, 56 + 25);
        }
        public static Point InventoryButton()
        {
            return new Point(418, 571 + 25);
        }


        #endregion

        //Posição das opções das caixas de dialogo.
        #region Dialog Box Positions
        public static Point Vival_GetPrizesButton()
        {
            return new Point(292, 253 + 25);
        }
        public static Point Vival_ContinueButton()
        {
            return new Point(285, 272 + 25);
        }
        public static Point Vival_StartNowButton()
        {
            return new Point(285, 290 + 25);
        }

        public static Point Robber_Start()
        {
            return new Point(400, 300 + 25);
        }
        public static Point ConvenienceShop_Cent()
        {
            return new Point(295, 291 + 25);
        }
        public static Point CloseConvenienceShop()
        {
            return new Point(670, 145 + 25);
        }
        public static Point StartTreasureEvent()
        {
            return new Point(363, 288 + 25);
        }
        #endregion

        #endregion
    }
}