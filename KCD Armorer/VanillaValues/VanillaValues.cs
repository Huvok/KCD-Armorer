using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//                                                          // AUTHOR: Hugo Garcia
//                                                          // CO-AUTHOR: Diana Contreras
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
        //                                                  // LL = Light Leather, HL = Heavy Leather, C = Chain,
        //                                                  //      P = Plate
        //                                                  // B = Body, H = Head, A = Arm, L = Leg, HA = Hand
        //                                                  // ST = Stab, SM = Smash, SL = Slash

        //                                                  // Plate Armor
        private static double NUM_P_B_ST = 1.8;
        private static double NUM_P_H_ST = 1.66;
        private static double NUM_P_A_ST = 1.57;
        private static double NUM_P_L_ST = 1.51;
        private static double NUM_P_HA_ST = 1.46;

        private static double NUM_P_B_SM = .75;
        private static double NUM_P_H_SM = .8;
        private static double NUM_P_A_SM = .83;
        private static double NUM_P_L_SM = .85;
        private static double NUM_P_HA_SM = .88;

        private static double NUM_P_B_SL = 2.0;
        private static double NUM_P_H_SL = 1.84;
        private static double NUM_P_A_SL = 1.74;
        private static double NUM_P_L_SL = 1.68;
        private static double NUM_P_HA_SL = 1.62;

        //--------------------------------------------------------------------------------------------------------------
        //                                                  // VARIABLES AND PROPERTIES
        private static Dictionary<String, Tuple<double, double, double>> mapstrnumVanillaValues;

        //--------------------------------------------------------------------------------------------------------------
        //                                                  //CONSTRUCTORS
        static VanillaValues()
        {
            mapstrnumVanillaValues = new Dictionary<String, Tuple<double, double, double>>
            {
                // Light Leather Armor

                // Heavy Leather Armor

                // Plate Armor
                { "4d0691f6-632e-f5fd-0b5e-349509655698", Tuple.Create(1.914 / NUM_P_B_ST, 0.3652 / NUM_P_B_SM, 1.914 / NUM_P_B_SL) },
                { "4038ccc9-976c-efd3-014c-0cc80a6695b5", Tuple.Create(1.914 / NUM_P_B_ST, 0.3652 / NUM_P_B_SM, 1.914 / NUM_P_B_SL) },
                { "45e0883f-b164-edce-8f8a-4df43039759d", Tuple.Create(2.61 / NUM_P_B_ST, 0.498 / NUM_P_B_SM, 2.61/ NUM_P_B_SL) },
                { "49692af5-b44e-f166-b6cf-27bf9874bcac", Tuple.Create(2.61 / NUM_P_B_ST, 0.498 / NUM_P_B_SM, 2.61/ NUM_P_B_SL) },
                { "431fac2f-58f6-38e8-953e-5738656f1a87", Tuple.Create(2.4864 / NUM_P_B_ST, 0.5032 / NUM_P_B_SM, 2.4864 / NUM_P_B_SL) },
                { "4b3dae7a-eb8a-c312-3afe-b5e0db85d7b2", Tuple.Create(3.2592 / NUM_P_B_ST, 0.6596 / NUM_P_B_SM, 3.2592 / NUM_P_B_SL) },
                { "40324632-16c8-5979-2c76-e38210ee2a9b", Tuple.Create(2.4864 / NUM_P_B_ST, 0.5032 / NUM_P_B_SM, 2.4864 / NUM_P_B_SL) },
                { "4b50992e-c69e-37da-366e-dc0c804536ac",Tuple.Create(1.3104 / NUM_P_B_ST, 0.2652 / NUM_P_B_SM, 1.3104 / NUM_P_B_SL) },
                { "4f7541b9-7854-2e70-27e0-89029dda2782", Tuple.Create(1.3104 / NUM_P_B_ST / 0.3162 / NUM_P_B_SM, 1.3104 / NUM_P_B_SL)},
                { "42c0a17c-123a-6416-8620-56fcf1a5199c", Tuple.Create(1.3104 / NUM_P_B_ST, 0.2652/ NUM_P_B_SM, 1.3104 / NUM_P_B_SL)},
                { "4f36ba66-e139-fca3-42d5-b5d8bcaf91b9", Tuple.Create(1.3104 / NUM_P_B_ST, 0.2652/ NUM_P_B_SM, 1.3104 / NUM_P_B_SL)},
                { "487ff48f-5ecc-86f9-fb0f-cbbb2c9b6788", Tuple.Create(1.3104 / NUM_P_B_ST , 0.2652/ NUM_P_B_SM, 1.3104 / NUM_P_B_SL)},
                { "45143b21-88c0-6217-1848-099a680d26b9", Tuple.Create(1.3104 / NUM_P_B_ST, 0.2652 / NUM_P_B_SM, 1.3104 / NUM_P_B_SL)},
                { "4d3ef67e-9a67-38aa-c6f1-0285338aa583", Tuple.Create(1.3104 / NUM_P_B_ST, 0.2652/ NUM_P_B_SM, 1.3104 / NUM_P_B_SL)},

                { "421f173c-99b2-f030-cedd-0ba2a25270ac", Tuple.Create(4.2136 / NUM_P_B_ST, 0.7328 / NUM_P_B_SM, 4.2136 / NUM_P_B_SL)},
                { "f86783e8-b406-44c9-b659-858f94ce2189", Tuple.Create(2.30 / NUM_P_B_ST, 0.345/ NUM_P_B_SM, 2.30 / NUM_P_B_SL)},
                { "48a827cd-c6ea-4976-9561-327a122326b7", Tuple.Create(3.3936 / NUM_P_B_ST, 0.6868/ NUM_P_B_SM, 3.3936/ NUM_P_B_SL)},
                { "4516652a-7e40-d46d-cdd7-62ea97c3bb83", Tuple.Create(3.654 / NUM_P_B_ST, 0.6972/ NUM_P_B_SM, 3.654 / NUM_P_B_SL)},
                { "424d9151-9ccb-989f-7bd8-3c690a9e4393", Tuple.Create(1.782 / NUM_P_B_ST, 0.3872/ NUM_P_B_SM, 1.782/ NUM_P_B_SL)},
                { "45cacc1b-dc58-a1c0-9873-d954e7cf3ebc", Tuple.Create(2.576 / NUM_P_B_ST, 0.448/ NUM_P_B_SM, 2.576/ NUM_P_B_SL)},
                { "436b6b1d-1471-da5f-ad03-f64bafbd8bb6", Tuple.Create(2.576 / NUM_P_B_ST, 0.448/ NUM_P_B_SM, 2.576/ NUM_P_B_SL)},
                { "48146c21-3bc0-fc8c-24b3-cd0f0427dc8c", Tuple.Create(3.1832 / NUM_P_B_ST, 0.5536/ NUM_P_B_SM, 3.1832/ NUM_P_B_SL)},
                { "40bafc6f-ea0f-d9d2-57f7-0da666d60083", Tuple.Create(2.7784 / NUM_P_B_ST, 0.4832/ NUM_P_B_SM, 2.7784/ NUM_P_B_SL)},
                { "4b858ce9-030d-b78a-e138-a29d53466ba4", Tuple.Create(2.352 / NUM_P_B_ST, 0.476/ NUM_P_B_SM, 2.352/ NUM_P_B_SL)},
                { "464c250d-7e30-e71e-85cd-37a67b9641a7", Tuple.Create(2.352 / NUM_P_B_ST, 0.476/ NUM_P_B_SM, 2.352/ NUM_P_B_SL)},
                { "403f6db2-1285-31da-81c6-db426db9d6a5", Tuple.Create(1.863 / NUM_P_B_ST,0.4048/ NUM_P_B_SM, 1.863/ NUM_P_B_SL)},
                { "4af19514-66e8-1a2b-67d5-6528225681b4", Tuple.Create(1.1408 / NUM_P_B_ST, 0.1984/ NUM_P_B_SM, 1.1408/ NUM_P_B_SL)},
                { "4da1a54a-4d69-d13d-6b38-de37a88e14b3", Tuple.Create(1.6968 / NUM_P_B_ST, 0.3434/ NUM_P_B_SM, 1.6968/ NUM_P_B_SL)},
                { "48aa8949-fd2a-39af-8a69-0d81290f42ae", Tuple.Create(1.6968 / NUM_P_B_ST, 0.3434/ NUM_P_B_SM, 1.6968/ NUM_P_B_SL)},
                { "449e796c-59b4-7ceb-1f61-4162b0caf4aa", Tuple.Create(1.7172 / NUM_P_B_ST, 0.37312/ NUM_P_B_SM, 1.7172 / NUM_P_B_SL)},
                { "44dc0755-74c4-582d-c92c-4a54990da4b9", Tuple.Create(2.1712 / NUM_P_B_ST, 0.3776/ NUM_P_B_SM, 2.1712 / NUM_P_B_SL)},
                { "45f96751-8f3b-09dd-a06d-d75bb80e8e9c", Tuple.Create(3.06 / NUM_P_B_ST, 0.459/ NUM_P_B_SM, 3.06 / NUM_P_B_SL)},
                { "44e4e7ba-05b1-fd0f-5aac-2e6f8d8cf682", Tuple.Create(3.3856 / NUM_P_B_ST, 0.5888/ NUM_P_B_SM, 3.3856 / NUM_P_B_SL)},
                { "4ef8618b-a87c-f25f-dd1d-94558fceab8d", Tuple.Create(0.9936 / NUM_P_B_ST, 0.1728/ NUM_P_B_SM, 0.9936 / NUM_P_B_SL)},
                { "4582224b-55b8-82f8-4230-371ca1093db3", Tuple.Create(0.62 / NUM_P_B_ST, 0.1984/ NUM_P_B_SM, 0.62 / NUM_P_B_SL)},
                { "4da8f74d-dd58-6895-e0b0-bf94a31a5b92", Tuple.Create(2.1712 / NUM_P_B_ST, 0.3776 / NUM_P_B_SM, 2.1712 / NUM_P_B_SL)},
                { "4aa23d07-ef96-e285-2cec-c7eb93ec4999", Tuple.Create(2.3736 / NUM_P_B_ST, 0.4128 / NUM_P_B_SM, 2.3736 / NUM_P_B_SL)},
                { "40c05582-26f8-b1dc-f0ba-80e717a8869e", Tuple.Create(4.26 / NUM_P_B_ST, 0.639 / NUM_P_B_SM, 4.26 / NUM_P_B_SL)},
                { "498ca985-c074-886b-af88-aec5b12dc7ad", Tuple.Create(2.9808 / NUM_P_B_ST, 0.5184 / NUM_P_B_SM, 2.9808 / NUM_P_B_SL)},
                { "4e8bfdae-a38a-fae5-1177-b513733f1c90", Tuple.Create(2.1712 / NUM_P_B_ST, 0.3776 / NUM_P_B_SM, 2.1712 / NUM_P_B_SL)},
                { "4cd854dd-7c7c-3050-27e4-8b67b1d1338c", Tuple.Create(2.9808 / NUM_P_B_ST, 0.5184 / NUM_P_B_SM, 2.9808 / NUM_P_B_SL)},
                { "4135abae-bcce-b9f7-7fff-9139b57aebbe", Tuple.Create(2.9808 / NUM_P_B_ST, 0.5184 / NUM_P_B_SM, 2.9808 / NUM_P_B_SL)},
                { "416efa2d-68db-6dfb-3d5d-98489f638bad", Tuple.Create(2.9808 / NUM_P_B_ST, 0.5184 / NUM_P_B_SM, 2.9808 / NUM_P_B_SL)},
                { "457922f9-5c5b-8caa-5df0-7449097cff90", Tuple.Create(3.6064 / NUM_P_B_ST, 0.6272 / NUM_P_B_SM, 3.6064 / NUM_P_B_SL)},
                { "413a23a3-3d34-de11-abeb-2dfc9af846a9", Tuple.Create(3.6064 / NUM_P_B_ST, 0.6272 / NUM_P_B_SM, 3.6064 / NUM_P_B_SL)},

                { "4651e310-5ad4-cf89-7f57-9755e344ed84", Tuple.Create(3.66 / NUM_P_B_ST, 0.549 / NUM_P_B_SM, 3.66 / NUM_P_B_SL)},
                { "4a0b54a0-f893-122d-5171-74ac68e933ad", Tuple.Create(4.0112 / NUM_P_B_ST, 0.6976 / NUM_P_B_SM, 4.0112 / NUM_P_B_SL)},
                { "481b929a-0e8e-05da-54c5-2939bd72e594", Tuple.Create(3.8088 / NUM_P_B_ST, 0.6624 / NUM_P_B_SM, 3.8088 / NUM_P_B_SL)},
                { "0082de35-b635-4b85-a9ec-95024713f3ab", Tuple.Create(3.68 / NUM_P_B_ST, 1.44 / NUM_P_B_SM, 3.68 / NUM_P_B_SL)},
                { "4a16b1e8-f30f-eea1-4329-aa3030891bbb", Tuple.Create(1.7664 / NUM_P_B_ST, 0.3072 / NUM_P_B_SM, 1.7664 / NUM_P_B_SL)},
                { "4a2e6701-7c43-b97a-0823-6e22ea1d8fb3", Tuple.Create(1.9688 / NUM_P_B_ST, 0.3424 / NUM_P_B_SM, 1.9688 / NUM_P_B_SL)},
                { "41c9dee4-7f56-917c-cf8d-3482bbb3ad9a", Tuple.Create(1.7664 / NUM_P_B_ST, 0.3072 / NUM_P_B_SM, 1.7664 / NUM_P_B_SL)},
                { "47d11f76-1007-00c0-1c63-cfb2b02b0c80", Tuple.Create(4.4 / NUM_P_B_ST, 0.66 / NUM_P_B_SM, 4.4 / NUM_P_B_SL)},
                { "4206570b-ab9b-a407-e693-29b90e475d81", Tuple.Create(1.8468 / NUM_P_B_ST, 0.40128 / NUM_P_B_SM, 1.8468 / NUM_P_B_SL)},
                { "44059610-696d-7039-c0ee-c69a92217392", Tuple.Create(2.262 / NUM_P_B_ST, 0.4316 / NUM_P_B_SM, 2.262 / NUM_P_B_SL)},
                { "43c6062f-7a46-aa6a-ce45-9f8b90adb7a9", Tuple.Create(1.5456 / NUM_P_B_ST, 0.2688 / NUM_P_B_SM, 1.5456 / NUM_P_B_SL)},
                { "47b8a5a6-0912-c070-49b9-d126e8c55bbd", Tuple.Create(4.56 / NUM_P_B_ST, 0.684 / NUM_P_B_SM, 4.56 / NUM_P_B_SL)},
                { "40cda4e4-8741-4f52-e43c-71fec6d81a96", Tuple.Create(1.8306 / NUM_P_B_ST, 0.39776 / NUM_P_B_SM, 1.8306 / NUM_P_B_SL)},
                { "4dc120cc-1a9c-aaf4-939a-c843e2ea2394", Tuple.Create(3.528 / NUM_P_B_ST, 0.714 / NUM_P_B_SM, 3.528 / NUM_P_B_SL)},
                { "42ed6b9c-19c5-0b8c-5feb-bfe0d7001997", Tuple.Create(4.002 / NUM_P_B_ST, 0.7636 / NUM_P_B_SM, 4.002 / NUM_P_B_SL)},
                { "51d21693-820d-423a-bac5-fae8d370dcbe", Tuple.Create(2.05712 / NUM_P_B_ST, 0.3776 / NUM_P_B_SM, 2.05712 / NUM_P_B_SL)},
                { "f12b7150-9e2c-4442-9070-2cde6a32b1a1", Tuple.Create(0.9936 / NUM_P_B_ST, 0.1728 / NUM_P_B_SM, 0.9936 / NUM_P_B_SL)},
                { "480b95cf-9c92-3b6f-df51-1e9a84701f8b", Tuple.Create(2.8728 / NUM_P_B_ST, 0.5814 / NUM_P_B_SM, 2.8728 / NUM_P_B_SL)},
                { "47a86203-78c8-463a-6ce6-4b22754786ba", Tuple.Create(3.828 / NUM_P_B_ST, 0.7304 / NUM_P_B_SM, 3.828 / NUM_P_B_SL)},
                { "4ab8c97d-6977-4b6c-4d66-86b471549483", Tuple.Create(4.1 / NUM_P_B_ST, 0.615 / NUM_P_B_SM, 4.1 / NUM_P_B_SL)},
                { "4769ab73-cf6a-ce13-d43a-c549a39980b6", Tuple.Create(1.7982 / NUM_P_B_ST, 0.39072 / NUM_P_B_SM, 1.7982 / NUM_P_B_SL)},
                { "4fc634a9-798c-d6ab-6db1-c586e55d468a", Tuple.Create(3.1416 / NUM_P_B_ST, 0.6358 / NUM_P_B_SM, 3.1416 / NUM_P_B_SL)},
                { "422917fc-435a-f436-3245-a356367f8881", Tuple.Create(3.48 / NUM_P_B_ST, 0.664 / NUM_P_B_SM, 3.48 / NUM_P_B_SL)},
                { "4c71ff43-0696-66e4-71d9-45f30cf05392", Tuple.Create(4.7 / NUM_P_B_ST, 0.705 / NUM_P_B_SM, 4.7 / NUM_P_B_SL)},
                { "45bc3e68-adc8-b03d-29e3-93e044472fbf", Tuple.Create(3.2592 / NUM_P_B_ST, 0.6596 / NUM_P_B_SM, 3.2592 / NUM_P_B_SL)},
                { "46f0f01a-ec0e-82af-8947-fc15bcf1df82", Tuple.Create(1.8954 / NUM_P_B_ST, 0.41184 / NUM_P_B_SM, 1.8954 / NUM_P_B_SL)},
                { "434098fa-7f58-be87-9524-dc2b5ba11ca3", Tuple.Create(1.8954 / NUM_P_B_ST, 0.41184 / NUM_P_B_SM, 1.8954 / NUM_P_B_SL)},
                { "4de13cf6-e7b7-c058-23e1-baf4717c4a8a", Tuple.Create(1.7334 / NUM_P_B_ST, 0.37664 / NUM_P_B_SM, 1.7334 / NUM_P_B_SL)},
                { "45ff9e32-ee90-4051-f963-1058dd4360a4", Tuple.Create(3.0072 / NUM_P_B_ST, 0.6086 / NUM_P_B_SM, 3.0072 / NUM_P_B_SL)},
                { "4af53552-ba45-84fc-7dea-aabc594a55a0", Tuple.Create(2.958 / NUM_P_B_ST, 0.5644 / NUM_P_B_SM, 2.958 / NUM_P_B_SL)},
                { "40edf98e-f577-4192-67cd-4f1776d14ea4", Tuple.Create(5.0 / NUM_P_B_ST, 0.75 / NUM_P_B_SM, 5.0 / NUM_P_B_SL)},
                { "4ad02fe1-d15c-db1f-1981-59ac21854e9c", Tuple.Create(0.736 / NUM_P_B_ST, 0.128 / NUM_P_B_SM, 0.736 / NUM_P_B_SL)},
                { "4b808fa2-b621-57b3-e973-b695ce96e9b2", Tuple.Create(1.8312 / NUM_P_B_ST, 0.3706 / NUM_P_B_SM, 1.8312 / NUM_P_B_SL)},
                { "417fd467-dbb9-0016-6e6d-89ce0b507fbe", Tuple.Create(2.088 / NUM_P_B_ST, 0.3984 / NUM_P_B_SM, 2.088 / NUM_P_B_SL)},
                { "4d60338a-8a13-40f8-9002-fcbc79fc36b1", Tuple.Create(2.3736 / NUM_P_B_ST, 0.4128 / NUM_P_B_SM, 2.3736 / NUM_P_B_SL)},
                { "40af7f97-143c-95a5-5e0b-01efbfac29b6", Tuple.Create(1.1745 / NUM_P_B_ST, 0.2241 / NUM_P_B_SM, 1.1745 / NUM_P_B_SL)},
                { "491e4460-878a-20aa-3d69-5a9d88d75795", Tuple.Create(0.696 / NUM_P_B_ST, 0.1328 / NUM_P_B_SM, 0.696 / NUM_P_B_SL)},
                { "40317a13-b96c-e894-3334-e5d70b9420bb", Tuple.Create(1.49856 / NUM_P_B_ST, 0.4488 / NUM_P_B_SM, 1.49856  / NUM_P_B_SL)},
                { "46425a75-bfd9-1824-6cf9-d87632030d88", Tuple.Create(1.49856 / NUM_P_B_ST, 0.4488 / NUM_P_B_SM, 1.49856  / NUM_P_B_SL)},
                { "4bffbc58-792a-e84d-1665-797d31cbc486", Tuple.Create(3.66 / NUM_P_B_ST,0.549 / NUM_P_B_SM, 3.66 / NUM_P_B_SL)},
                { "4f24ba2e-3b5d-9e11-a55f-1861ef8b1098", Tuple.Create(2.61 / NUM_P_B_ST, 0.498 / NUM_P_B_SM, 2.61 / NUM_P_B_SL)},
                { "498d3f6d-49a2-6f80-e1ae-d07cd1d4d08f", Tuple.Create(3.2 / NUM_P_B_ST, 0.48 / NUM_P_B_SM, 3.2 / NUM_P_B_SL)},
                { "4347d1c1-1035-f342-4447-eae73bd785a7", Tuple.Create(2.2176 / NUM_P_B_ST, 0.4488 / NUM_P_B_SM, 2.2176 / NUM_P_B_SL)},
                { "464ae38b-89f3-57f0-760d-7a1b7458d5bc", Tuple.Create(2.0832 / NUM_P_B_ST, 0.4216 / NUM_P_B_SM, 2.0832 / NUM_P_B_SL)},
                { "4c831cd1-9484-7eb7-8165-f441b38b439d", Tuple.Create(2.0832 / NUM_P_B_ST, 0.4216 / NUM_P_B_SM, 2.0832 / NUM_P_B_SL)},
                { "406d2498-5b1e-90dc-4beb-37a0a67ce5a4", Tuple.Create(2.2176 / NUM_P_B_ST, 0.4488 / NUM_P_B_SM, 2.2176 / NUM_P_B_SL)},
                { "40b60983-804f-22fc-8259-ab4a6820829b", Tuple.Create(2.2176 / NUM_P_B_ST, 0.4488 / NUM_P_B_SM, 2.2176 / NUM_P_B_SL)},
                { "49ca1a1b-be96-f994-be7f-2adaa73d37b8", Tuple.Create(2.2176 / NUM_P_B_ST, 0.4488 / NUM_P_B_SM, 2.2176 / NUM_P_B_SL)},
                { "49a405c2-4cb7-997d-9ebf-e13b0a9325be", Tuple.Create(2.2176 / NUM_P_B_ST, 0.4488 / NUM_P_B_SM, 2.2176 / NUM_P_B_SL)},
                { "44a86f03-1c17-1efb-966f-2202f6360c88", Tuple.Create(2.2176 / NUM_P_B_ST, 0.4488 / NUM_P_B_SM, 2.2176 / NUM_P_B_SL)},
                { "4d56566c-5d57-9795-ca45-139668a75195", Tuple.Create(2.7384 / NUM_P_B_ST, 0.5542 / NUM_P_B_SM, 2.7384 / NUM_P_B_SL)},
                { "45f87e26-cda3-9d99-4591-a7f7e6968f92", Tuple.Create(1.2636 / NUM_P_B_ST, 0.27456 / NUM_P_A_SM, 1.2636 / NUM_P_B_SL)},
                { "4a9c8bc3-759d-f9a4-87f8-77cd31481e9b", Tuple.Create(2.436 / NUM_P_B_ST, 0.4648 / NUM_P_B_SM, 2.436 / NUM_P_B_SL)},
                { "4e969bae-648a-194c-5d9d-3e52a0225597", Tuple.Create(2.436 / NUM_P_B_ST, 0.4648 / NUM_P_B_SM, 2.436 / NUM_P_B_SL)},
                { "40129e7b-b9e0-a193-1145-d53292caf7a1", Tuple.Create(2.6208 / NUM_P_B_ST, 0.5304 / NUM_P_B_SM, 2.6208 / NUM_P_B_SL)},
                { "4396554c-2efb-6a68-f490-eee58844a7b5", Tuple.Create(2.6208 / NUM_P_B_ST, 0.5304 / NUM_P_B_SM, 2.6208 / NUM_P_B_SL)},
                { "4405924b-de8b-e31b-72f1-29bb227ff1b1", Tuple.Create(2.6208 / NUM_P_B_ST, 0.5304 / NUM_P_B_SM, 2.6208 / NUM_P_B_SL)},
                { "44ee56de-46f9-0169-0d72-606c82576b97", Tuple.Create(2.784 / NUM_P_B_ST, 0.5312 / NUM_P_B_SM, 2.784 / NUM_P_B_SL)},
                { "44501763-1d31-6b8b-fb85-a57b3fce9596", Tuple.Create(1.5456 / NUM_P_B_ST, 0.2688 / NUM_P_B_SM, 1.5456 / NUM_P_B_SL)},
                { "49cbb237-9280-ba16-cfe4-3d05bacb85a3", Tuple.Create(3.8 / NUM_P_B_ST, 0.57 / NUM_P_B_SM, 3.8 / NUM_P_B_SL)},
                { "4b82dda9-7cfe-4c26-01c7-c1322b7fc8b4", Tuple.Create(3.132 / NUM_P_B_ST, 0.5976 / NUM_P_B_SM, 3.132 / NUM_P_B_SL)} ,
                { "441979f2-838e-9f91-36ef-64fd17735492", Tuple.Create(0.9384 / NUM_P_B_ST, 0.1632 / NUM_P_B_SM, 0.9384 / NUM_P_B_SL)},
                { "447acc02-8ee6-ff70-1cb3-ccafd3ba01b3", Tuple.Create(1.3432 / NUM_P_B_ST, 0.2336 / NUM_P_B_SM, 1.3432 / NUM_P_B_SL)},
                { "4fedd7a1-ac86-40b1-ba0b-847e602df774", Tuple.Create(4.7 / NUM_P_B_ST, 0.705 / NUM_P_B_SM, 4.7 / NUM_P_B_SL)},
                { "42c04555-15cb-ac3a-aef4-e377a125aca5", Tuple.Create(1.7496 / NUM_P_B_ST, 0.38016 / NUM_P_B_SM, 1.7496 / NUM_P_B_SL)},
                { "41a9ea6a-eed1-471c-754a-196d368245a6", Tuple.Create(2.4864 / NUM_P_B_ST, 0.5032 / NUM_P_B_SM,  2.4864 / NUM_P_B_SL)},
                { "4e86424c-a3db-64e9-e7f9-c8108f1686a2", Tuple.Create(1.6968 / NUM_P_B_ST, 0.3434 / NUM_P_B_SM, 1.6968 / NUM_P_B_SL)},
                { "481cfd5b-b646-1c6b-ff58-af749941cf9e", Tuple.Create(4.416 / NUM_P_B_ST, 0.76 / NUM_P_B_SM, 4.416 / NUM_P_B_SL)},
                { "44f5058a-a445-887b-d443-32fe726b528c", Tuple.Create(2.088 / NUM_P_B_ST, 0.3984 / NUM_P_B_SM, 2.088 / NUM_P_B_SL) }
            };
        }
    }
}

//======================================================================================================================