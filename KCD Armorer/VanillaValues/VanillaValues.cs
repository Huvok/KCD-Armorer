using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//                                                          // AUTHOR: Hugo Garcia
//                                                          // DATE: 27/3/2018
//                                                          // PURPOSE: Original values based on URO mod (since its
//                                                          //      armor.xml is already sorted, unlike vanilla, so the
//                                                          //      values need to be converted back to the vanilla ones
//                                                          //      using the constants. I had to add item by item since
//                                                          //      in armor.xml there is no way to tell the item armor
//                                                          //      subtype.

//======================================================================================================================
namespace KCD_Armorer.VanillaValues
{

    //------------------------------------------------------------------------------------------------------------------
    static class VanillaValues
    {

        //--------------------------------------------------------------------------------------------------------------
        //                                                  // CONSTANTS
        //                                                  // B = Body, H = Head, A = Arm, L = Leg, Ha = Hand
        //                                                  // ST = Stab, Sm = Smash, Sl = Slash
        private static double NUM_B_ST = 1.8;

        //--------------------------------------------------------------------------------------------------------------
        //                                                  // VARIABLES AND PROPERTIES
        private static Dictionary<String, Double> mapstrnumStab;

        //--------------------------------------------------------------------------------------------------------------
        //                                                  //CONSTRUCTORS
        static VanillaValues()
        {
            mapstrnumStab.Add("452300f5-105e-0360-bf37-1ade46d98bae", 1.914 / NUM_B_ST);
        }
    }
}

//======================================================================================================================