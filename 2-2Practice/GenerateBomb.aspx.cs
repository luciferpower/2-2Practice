using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class GenerateBomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[,] ia_Map = new int[10, 10];
            int[] ia_Bomb = new int[10]
                            { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            for (int i = 0; i<ia_Bomb.Length ; i++ )
            {
                int i_Row = ia_Bomb[i] / 10 ;
                int i_Col = ia_Bomb[i] % 10 ;
                ia_Map[i_Row, i_Col] = -1;
            }


            for (int i_Ct=0; i_Ct< ia_Bomb.Length; i_Ct++ ) {
                int i_Row = ia_Bomb[i_Ct] / 10;
                int i_Col = ia_Bomb[i_Ct] % 10;
                
                //Top

                if ((i_Row - 1) > 0 && (i_Col - 1) >0) {
                    if (ia_Map[(i_Row - 1), (i_Col - 1)] != -1) {                    
                        ia_Map[(i_Row - 1), (i_Col - 1)]++;
                    }
                }

                if ((i_Row - 1) > 0 ){
                    if (ia_Map[(i_Row - 1), i_Col] != -1) {
                        ia_Map[(i_Row - 1), i_Col]++;
                    }                    
                }

                if ((i_Row - 1) > 0 && (i_Col + 1) < 10)
                {
                    ia_Map[(i_Row - 1), (i_Col + 1)]++;
                }


                if ( (i_Col - 1) > 0)
                {
                    ia_Map[i_Row , (i_Col - 1)]++;
                }

                if ( (i_Col + 1) < 10)
                {
                    ia_Map[i_Row, (i_Col + 1)]++;
                }

                if ( (i_Row + 1) <10  && (i_Col - 1) > 0 )
                {
                    ia_Map[(i_Row + 1), (i_Col - 1)]++;
                }

                if ((i_Row + 1) < 10)
                {
                    ia_Map[(i_Row + 1), i_Col]++;
                }

                if ( (i_Row + 1) < 10 && (i_Col + 1) < 10)
                {
                    ia_Map[(i_Row + 1), (i_Col + 1)]++;
                }

            }
            /*for (int i=0; i< 10; i++) {
                for (int j=0; j< 10; j++) {
                    Response.Write(ia_Map[i, j]);
                }
                Response.Write("<br />");
            }*/
        }
    }
}