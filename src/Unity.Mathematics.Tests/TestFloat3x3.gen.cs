// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat3x3
    {
        [Test]
        public void float3x3_operator_equal_wide_wide()
        {
            float3x3 a0 = float3x3(492.1576f, -495.206329f, 227.457642f);
            float3x3 b0 = float3x3(192.568787f, -235.611023f, -254.043121f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3x3 a1 = float3x3(-147.374054f, -222.682f, 64.09375f);
            float3x3 b1 = float3x3(-412.624725f, 471.9048f, -6.47277832f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3x3 a2 = float3x3(-23.8904114f, -16.8197327f, 163.232117f);
            float3x3 b2 = float3x3(-339.102356f, 488.187561f, -379.5966f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3x3 a3 = float3x3(-165.271f, 470.8777f, -423.942566f);
            float3x3 b3 = float3x3(-308.417f, -82.333374f, -102.921082f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3x3_operator_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(-303.230072f, 451.5263f, -253.655884f);
            float b0 = (123.544556f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3x3 a1 = float3x3(-105.203644f, -426.192474f, 159.8761f);
            float b1 = (-500.6911f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3x3 a2 = float3x3(-59.55838f, -182.049744f, 406.513733f);
            float b2 = (-57.4773865f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3x3 a3 = float3x3(370.886f, 455.400024f, -11.3389893f);
            float b3 = (-172.035309f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3x3_operator_equal_scalar_wide()
        {
            float a0 = (-253.397278f);
            float3x3 b0 = float3x3(19.95221f, -185.791992f, 407.8136f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-87.2767f);
            float3x3 b1 = float3x3(-206.274689f, 160.503113f, -274.7708f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-2.63153076f);
            float3x3 b2 = float3x3(448.354553f, -410.035248f, 247.329041f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (355.539124f);
            float3x3 b3 = float3x3(-298.0667f, 414.1015f, -481.3026f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3x3_operator_not_equal_wide_wide()
        {
            float3x3 a0 = float3x3(430.842529f, 104.69f, 225.802429f);
            float3x3 b0 = float3x3(210.024719f, -55.20334f, -269.925354f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3x3 a1 = float3x3(-310.5702f, -418.619446f, 304.128174f);
            float3x3 b1 = float3x3(-234.546722f, 25.91742f, -63.72699f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3x3 a2 = float3x3(-509.3268f, -160.538086f, -203.301971f);
            float3x3 b2 = float3x3(-484.5537f, -425.3336f, -53.2743835f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3x3 a3 = float3x3(-505.763245f, 162.17218f, 1.156189f);
            float3x3 b3 = float3x3(328.1944f, 15.9631348f, 461.7141f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3x3_operator_not_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(-16.9145813f, 168.8341f, -462.713531f);
            float b0 = (-145.372772f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3x3 a1 = float3x3(130.307739f, -440.263275f, -197.12796f);
            float b1 = (214.501587f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3x3 a2 = float3x3(-169.099854f, -281.021f, -270.26886f);
            float b2 = (-386.611176f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3x3 a3 = float3x3(-403.9637f, 299.654236f, -71.7509155f);
            float b3 = (-269.805725f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3x3_operator_not_equal_scalar_wide()
        {
            float a0 = (275.795837f);
            float3x3 b0 = float3x3(-57.1969f, -382.432526f, 97.82037f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-161.463654f);
            float3x3 b1 = float3x3(-458.39563f, -499.617859f, 327.92218f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (367.571228f);
            float3x3 b2 = float3x3(59.786377f, -209.580688f, -62.5804443f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-479.974976f);
            float3x3 b3 = float3x3(-49.4945068f, -114.685211f, 109.93927f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3x3_operator_less_wide_wide()
        {
            float3x3 a0 = float3x3(196.84259f, 336.4098f, 251.963745f);
            float3x3 b0 = float3x3(-465.345032f, -256.1524f, -314.814026f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float3x3 a1 = float3x3(257.655945f, 430.0459f, -62.4196472f);
            float3x3 b1 = float3x3(364.5667f, 100.21051f, 182.560974f);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float3x3 a2 = float3x3(8.839233f, -333.8167f, 164.678833f);
            float3x3 b2 = float3x3(3.11700439f, -259.430481f, -437.3349f);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float3x3 a3 = float3x3(-350.9449f, 3.84143066f, 125.409729f);
            float3x3 b3 = float3x3(-456.043732f, -394.255981f, 401.9137f);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3x3_operator_less_wide_scalar()
        {
            float3x3 a0 = float3x3(-132.057312f, -192.465f, -66.8345947f);
            float b0 = (-156.010223f);
            bool3x3 r0 = bool3x3(false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float3x3 a1 = float3x3(-379.017517f, 20.9278564f, -158.240753f);
            float b1 = (-360.2824f);
            bool3x3 r1 = bool3x3(true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float3x3 a2 = float3x3(437.3459f, 225.2915f, 307.4842f);
            float b2 = (-20.4526062f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float3x3 a3 = float3x3(274.015259f, 398.523682f, 105.030151f);
            float b3 = (373.549683f);
            bool3x3 r3 = bool3x3(true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3x3_operator_less_scalar_wide()
        {
            float a0 = (-423.1174f);
            float3x3 b0 = float3x3(385.094849f, -123.933472f, 86.37659f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (133.4422f);
            float3x3 b1 = float3x3(161.457947f, 229.754272f, 222.5716f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (315.5312f);
            float3x3 b2 = float3x3(-447.203522f, 271.833862f, -393.605316f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (317.486877f);
            float3x3 b3 = float3x3(-164.6051f, -282.876038f, 296.979553f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_wide_wide()
        {
            float3x3 a0 = float3x3(483.5014f, 310.8156f, 106.966187f);
            float3x3 b0 = float3x3(-471.398f, -371.9853f, 36.9006958f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float3x3 a1 = float3x3(295.7353f, 116.957581f, -478.299774f);
            float3x3 b1 = float3x3(-316.7636f, 19.6830444f, 207.309143f);
            bool3x3 r1 = bool3x3(true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float3x3 a2 = float3x3(-14.8974f, -33.8174438f, -24.74054f);
            float3x3 b2 = float3x3(362.7975f, 324.95343f, 340.948059f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float3x3 a3 = float3x3(319.782654f, -120.158569f, -289.008575f);
            float3x3 b3 = float3x3(25.9860229f, -114.211121f, 240.803467f);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_wide_scalar()
        {
            float3x3 a0 = float3x3(64.31793f, -397.703461f, 431.8769f);
            float b0 = (305.859924f);
            bool3x3 r0 = bool3x3(false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float3x3 a1 = float3x3(85.703f, 197.491577f, 286.199463f);
            float b1 = (246.263062f);
            bool3x3 r1 = bool3x3(false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float3x3 a2 = float3x3(280.813354f, 171.565369f, -241.807281f);
            float b2 = (-405.7846f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float3x3 a3 = float3x3(333.5782f, -413.7014f, -356.592346f);
            float b3 = (370.279175f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_scalar_wide()
        {
            float a0 = (-282.6705f);
            float3x3 b0 = float3x3(358.099976f, -72.596405f, -232.163788f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (-60.7067261f);
            float3x3 b1 = float3x3(75.15662f, 150.883484f, 339.539185f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-498.196045f);
            float3x3 b2 = float3x3(459.7461f, -227.968719f, 335.862122f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (76.17883f);
            float3x3 b3 = float3x3(296.859924f, 177.48999f, -281.2012f);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3x3_operator_less_equal_wide_wide()
        {
            float3x3 a0 = float3x3(-438.523132f, 210.489441f, 4.87731934f);
            float3x3 b0 = float3x3(-474.814148f, 304.371033f, 234.824158f);
            bool3x3 r0 = bool3x3(false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3x3 a1 = float3x3(-137.297943f, 156.094116f, -363.924133f);
            float3x3 b1 = float3x3(-390.485443f, -297.175354f, -326.2924f);
            bool3x3 r1 = bool3x3(false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3x3 a2 = float3x3(-97.94849f, 437.2954f, 458.530273f);
            float3x3 b2 = float3x3(107.253906f, -413.131073f, 67.09442f);
            bool3x3 r2 = bool3x3(true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3x3 a3 = float3x3(-294.064758f, 23.62262f, -34.2840576f);
            float3x3 b3 = float3x3(470.075256f, -84.499115f, 392.784241f);
            bool3x3 r3 = bool3x3(true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3x3_operator_less_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(193.49585f, 168.915527f, -313.993073f);
            float b0 = (443.850525f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3x3 a1 = float3x3(81.8269653f, -0.3581848f, 241.361145f);
            float b1 = (18.5036011f);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3x3 a2 = float3x3(-463.8164f, -268.899475f, 398.991943f);
            float b2 = (-1.35775757f);
            bool3x3 r2 = bool3x3(true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3x3 a3 = float3x3(-471.253082f, 82.2583f, 11.2460327f);
            float b3 = (-264.9378f);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3x3_operator_less_equal_scalar_wide()
        {
            float a0 = (393.606262f);
            float3x3 b0 = float3x3(-75.6883545f, -44.2638855f, 125.864929f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (191.9649f);
            float3x3 b1 = float3x3(13.54303f, -197.051941f, -423.9451f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-330.0486f);
            float3x3 b2 = float3x3(420.165527f, 105.5473f, 174.821289f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (296.7176f);
            float3x3 b3 = float3x3(-469.7004f, 123.267212f, 112.996948f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_equal_wide_wide()
        {
            float3x3 a0 = float3x3(-507.9286f, 504.4975f, -385.4345f);
            float3x3 b0 = float3x3(-81.3465f, 297.666138f, 171.06543f);
            bool3x3 r0 = bool3x3(false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3x3 a1 = float3x3(-262.323425f, -37.5509338f, -111.595276f);
            float3x3 b1 = float3x3(-431.038055f, -6.85907f, 319.7257f);
            bool3x3 r1 = bool3x3(true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3x3 a2 = float3x3(-463.702026f, 387.448853f, 456.9688f);
            float3x3 b2 = float3x3(254.079163f, 396.5724f, 178.8393f);
            bool3x3 r2 = bool3x3(false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3x3 a3 = float3x3(-211.010162f, 182.411377f, -53.59604f);
            float3x3 b3 = float3x3(-447.063354f, 288.492676f, 474.889282f);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(465.152161f, -424.886078f, -209.2211f);
            float b0 = (-5.599884f);
            bool3x3 r0 = bool3x3(true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3x3 a1 = float3x3(58.7798462f, 140.12561f, 16.3533936f);
            float b1 = (-302.2691f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3x3 a2 = float3x3(-344.559967f, -315.701538f, 441.011536f);
            float b2 = (393.278076f);
            bool3x3 r2 = bool3x3(false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3x3 a3 = float3x3(-509.781555f, 494.8203f, -164.973938f);
            float b3 = (-36.9942932f);
            bool3x3 r3 = bool3x3(false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_equal_scalar_wide()
        {
            float a0 = (374.827026f);
            float3x3 b0 = float3x3(-1.60977173f, 338.615234f, -116.1814f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-332.157318f);
            float3x3 b1 = float3x3(-355.97937f, -468.901428f, 38.579895f);
            bool3x3 r1 = bool3x3(true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-332.347534f);
            float3x3 b2 = float3x3(2.89013672f, 467.777771f, 121.406372f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-305.023376f);
            float3x3 b3 = float3x3(-58.4288025f, -226.519562f, -47.0209961f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3x3_operator_add_wide_wide()
        {
            float3x3 a0 = float3x3(506.129028f, -501.779816f, 420.084778f);
            float3x3 b0 = float3x3(-28.7579956f, -337.135132f, -340.676819f);
            float3x3 r0 = float3x3(477.371033f, -838.9149f, 79.40796f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3x3 a1 = float3x3(-186.032074f, -9.312408f, 328.51178f);
            float3x3 b1 = float3x3(152.312012f, 423.66748f, 90.3740845f);
            float3x3 r1 = float3x3(-33.7200623f, 414.355072f, 418.885864f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3x3 a2 = float3x3(424.344055f, 87.79108f, 462.4137f);
            float3x3 b2 = float3x3(376.18866f, 1.76721191f, -120.185852f);
            float3x3 r2 = float3x3(800.5327f, 89.55829f, 342.227844f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3x3 a3 = float3x3(-46.17871f, 401.170044f, -454.124146f);
            float3x3 b3 = float3x3(-279.629364f, -344.6671f, 242.839172f);
            float3x3 r3 = float3x3(-325.808075f, 56.50293f, -211.284973f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3x3_operator_add_wide_scalar()
        {
            float3x3 a0 = float3x3(-194.514191f, 338.5484f, 246.971375f);
            float b0 = (124.121704f);
            float3x3 r0 = float3x3(-70.39249f, 462.6701f, 371.093079f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3x3 a1 = float3x3(100.510925f, -478.1113f, 30.9161377f);
            float b1 = (-45.72467f);
            float3x3 r1 = float3x3(54.7862549f, -523.835938f, -14.8085327f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3x3 a2 = float3x3(60.37433f, 82.50134f, 6.79937744f);
            float b2 = (-242.118744f);
            float3x3 r2 = float3x3(-181.744415f, -159.6174f, -235.319366f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3x3 a3 = float3x3(-484.6998f, -213.526733f, -267.7843f);
            float b3 = (-188.265015f);
            float3x3 r3 = float3x3(-672.964844f, -401.791748f, -456.049316f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3x3_operator_add_scalar_wide()
        {
            float a0 = (-340.354675f);
            float3x3 b0 = float3x3(511.362244f, -146.216644f, -106.210419f);
            float3x3 r0 = float3x3(171.007568f, -486.57132f, -446.5651f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-363.450256f);
            float3x3 b1 = float3x3(199.0896f, -27.1083984f, 419.849f);
            float3x3 r1 = float3x3(-164.360657f, -390.558655f, 56.3987427f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (284.955017f);
            float3x3 b2 = float3x3(-164.9242f, -249.190338f, 150.928162f);
            float3x3 r2 = float3x3(120.030823f, 35.76468f, 435.883179f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (298.1751f);
            float3x3 b3 = float3x3(-457.1534f, 424.718079f, -301.857483f);
            float3x3 r3 = float3x3(-158.9783f, 722.8932f, -3.682373f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3x3_operator_sub_wide_wide()
        {
            float3x3 a0 = float3x3(160.492249f, 11.223938f, 359.200134f);
            float3x3 b0 = float3x3(115.46875f, -130.9823f, 241.540833f);
            float3x3 r0 = float3x3(45.0235f, 142.206238f, 117.6593f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3x3 a1 = float3x3(-498.2283f, -355.253632f, -94.53485f);
            float3x3 b1 = float3x3(9.987061f, 419.895142f, 59.12445f);
            float3x3 r1 = float3x3(-508.215363f, -775.1488f, -153.6593f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3x3 a2 = float3x3(-410.46405f, -401.384644f, 317.706848f);
            float3x3 b2 = float3x3(-402.381653f, -75.37015f, 320.9796f);
            float3x3 r2 = float3x3(-8.082397f, -326.0145f, -3.272766f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3x3 a3 = float3x3(447.060425f, -489.074158f, -230.008392f);
            float3x3 b3 = float3x3(-73.90875f, -31.4447327f, -389.251953f);
            float3x3 r3 = float3x3(520.9692f, -457.629425f, 159.243561f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3x3_operator_sub_wide_scalar()
        {
            float3x3 a0 = float3x3(207.389587f, 248.457764f, -384.8239f);
            float b0 = (-36.1124878f);
            float3x3 r0 = float3x3(243.502075f, 284.570251f, -348.711426f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3x3 a1 = float3x3(-205.344757f, 191.642029f, 18.8562622f);
            float b1 = (-374.811554f);
            float3x3 r1 = float3x3(169.4668f, 566.4536f, 393.667816f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3x3 a2 = float3x3(-44.96161f, 16.3381958f, -366.865448f);
            float b2 = (480.857971f);
            float3x3 r2 = float3x3(-525.8196f, -464.519775f, -847.7234f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3x3 a3 = float3x3(-35.5231f, 439.077271f, 490.2223f);
            float b3 = (349.397766f);
            float3x3 r3 = float3x3(-384.920868f, 89.6795044f, 140.824524f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3x3_operator_sub_scalar_wide()
        {
            float a0 = (-86.00824f);
            float3x3 b0 = float3x3(466.4251f, 298.486938f, -300.9501f);
            float3x3 r0 = float3x3(-552.43335f, -384.495178f, 214.941864f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (315.38f);
            float3x3 b1 = float3x3(-381.092163f, -125.008362f, 58.4661865f);
            float3x3 r1 = float3x3(696.472168f, 440.388367f, 256.913818f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (214.7461f);
            float3x3 b2 = float3x3(-257.549438f, 480.2246f, -443.355072f);
            float3x3 r2 = float3x3(472.295532f, -265.478516f, 658.1012f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (260.795044f);
            float3x3 b3 = float3x3(29.6819458f, 139.857727f, -247.789948f);
            float3x3 r3 = float3x3(231.1131f, 120.937317f, 508.585f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3x3_operator_mul_wide_wide()
        {
            float3x3 a0 = float3x3(-482.7138f, -407.2935f, 137.700562f);
            float3x3 b0 = float3x3(-236.367889f, 260.7276f, -416.3863f);
            float3x3 r0 = float3x3(114098.047f, -106192.656f, -57336.625f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3x3 a1 = float3x3(208.541138f, 194.29657f, -484.242432f);
            float3x3 b1 = float3x3(-364.4956f, -253.147522f, -369.202881f);
            float3x3 r1 = float3x3(-76012.33f, -49185.6953f, 178783.7f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3x3 a2 = float3x3(183.9873f, -241.33548f, 45.8687744f);
            float3x3 b2 = float3x3(193.547913f, 169.0849f, 201.969666f);
            float3x3 r2 = float3x3(35610.36f, -40806.1836f, 9264.101f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3x3 a3 = float3x3(363.3261f, -328.118958f, -471.023071f);
            float3x3 b3 = float3x3(249.456055f, -308.193176f, -385.579651f);
            float3x3 r3 = float3x3(90633.9f, 101124.023f, 181616.9f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3x3_operator_mul_wide_scalar()
        {
            float3x3 a0 = float3x3(-96.31882f, -277.142273f, -239.93689f);
            float b0 = (-301.2072f);
            float3x3 r0 = float3x3(29011.9219f, 83477.25f, 72270.72f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3x3 a1 = float3x3(509.531433f, 215.7315f, -455.50827f);
            float b1 = (255.8581f);
            float3x3 r1 = float3x3(130367.742f, 55196.6523f, -116545.477f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3x3 a2 = float3x3(-389.2433f, 53.7962646f, 243.757324f);
            float b2 = (-338.29248f);
            float3x3 r2 = float3x3(131678.078f, -18198.8711f, -82461.27f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3x3 a3 = float3x3(135.354675f, -383.9396f, -31.4252319f);
            float b3 = (-207.3501f);
            float3x3 r3 = float3x3(-28065.8047f, 79609.9141f, 6516.025f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3x3_operator_mul_scalar_wide()
        {
            float a0 = (37.43219f);
            float3x3 b0 = float3x3(96.74756f, 492.185364f, -274.054565f);
            float3x3 r0 = float3x3(3621.473f, 18423.5762f, -10258.4629f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-452.870972f);
            float3x3 b1 = float3x3(420.853333f, 102.182922f, -114.948883f);
            float3x3 r1 = float3x3(-190592.25f, -46275.68f, 52057.01f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-351.120056f);
            float3x3 b2 = float3x3(-464.664978f, 444.084839f, 447.1053f);
            float3x3 r2 = float3x3(163153.188f, -155927.1f, -156987.641f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (130.829346f);
            float3x3 b3 = float3x3(-321.41333f, 445.301331f, 478.2436f);
            float3x3 r3 = float3x3(-42050.2969f, 58258.48f, 62568.2969f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3x3_operator_div_wide_wide()
        {
            float3x3 a0 = float3x3(-353.131439f, -102.799866f, 51.3191528f);
            float3x3 b0 = float3x3(-178.739563f, -302.096283f, -199.405823f);
            float3x3 r0 = float3x3(1.97567582f, 0.34028843f, -0.257360339f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3x3 a1 = float3x3(-191.871674f, 8.041809f, -128.73764f);
            float3x3 b1 = float3x3(278.850769f, 502.3376f, -361.484833f);
            float3x3 r1 = float3x3(-0.688080132f, 0.0160087738f, 0.356135666f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3x3 a2 = float3x3(-136.0596f, -370.471f, -237.69455f);
            float3x3 b2 = float3x3(353.121033f, -38.894928f, -75.76474f);
            float3x3 r2 = float3x3(-0.385305852f, 9.524919f, 3.1372714f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3x3 a3 = float3x3(-432.546875f, 200.2655f, 361.4416f);
            float3x3 b3 = float3x3(-195.217834f, -405.034f, -394.23f);
            float3x3 r3 = float3x3(2.215714f, -0.4944412f, -0.9168292f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3x3_operator_div_wide_scalar()
        {
            float3x3 a0 = float3x3(171.3424f, 0.103393555f, 57.8882446f);
            float b0 = (171.796814f);
            float3x3 r0 = float3x3(0.997355f, 0.000601836247f, 0.3369576f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3x3 a1 = float3x3(-256.130737f, -290.3869f, -127.4487f);
            float b1 = (95.66968f);
            float3x3 r1 = float3x3(-2.67724061f, -3.03530765f, -1.33217442f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3x3 a2 = float3x3(-79.7449f, -499.843567f, 58.68634f);
            float b2 = (146.466858f);
            float3x3 r2 = float3x3(-0.544456959f, -3.41267347f, 0.40068f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3x3 a3 = float3x3(-453.2058f, 481.738159f, 464.479065f);
            float b3 = (-205.033813f);
            float3x3 r3 = float3x3(2.21039557f, -2.34955478f, -2.26537776f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3x3_operator_div_scalar_wide()
        {
            float a0 = (-264.4425f);
            float3x3 b0 = float3x3(105.589111f, -142.349091f, -288.9489f);
            float3x3 r0 = float3x3(-2.50444865f, 1.85770416f, 0.9151877f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (39.644104f);
            float3x3 b1 = float3x3(-363.9914f, -149.718231f, -395.729126f);
            float3x3 r1 = float3x3(-0.108914949f, -0.264791429f, -0.100179896f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (258.7187f);
            float3x3 b2 = float3x3(-9.66626f, 117.725525f, -331.386536f);
            float3x3 r2 = float3x3(-26.76513f, 2.197643f, -0.780715764f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-509.986023f);
            float3x3 b3 = float3x3(427.896484f, 467.617126f, -407.124634f);
            float3x3 r3 = float3x3(-1.19184434f, -1.090606f, 1.25265336f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3x3_operator_mod_wide_wide()
        {
            float3x3 a0 = float3x3(-388.8125f, 181.681213f, -167.078735f);
            float3x3 b0 = float3x3(436.944153f, 58.9400635f, -201.116241f);
            float3x3 r0 = float3x3(-388.8125f, 4.861023f, -167.078735f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3x3 a1 = float3x3(432.820129f, -258.438965f, -170.110809f);
            float3x3 b1 = float3x3(279.289368f, -397.079773f, 377.899963f);
            float3x3 r1 = float3x3(153.530762f, -258.438965f, -170.110809f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3x3 a2 = float3x3(283.3183f, 122.716492f, 335.271f);
            float3x3 b2 = float3x3(174.693848f, -228.176514f, -317.060181f);
            float3x3 r2 = float3x3(108.624451f, 122.716492f, 18.2108154f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3x3 a3 = float3x3(-503.608521f, 191.022522f, 289.742676f);
            float3x3 b3 = float3x3(-417.4801f, -249.975952f, -397.571564f);
            float3x3 r3 = float3x3(-86.12842f, 191.022522f, 289.742676f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3x3_operator_mod_wide_scalar()
        {
            float3x3 a0 = float3x3(-244.499634f, -211.8193f, -145.926788f);
            float b0 = (39.63495f);
            float3x3 r0 = float3x3(-6.68994141f, -13.6445618f, -27.0219421f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3x3 a1 = float3x3(-304.9182f, -133.907776f, 281.309631f);
            float b1 = (155.479492f);
            float3x3 r1 = float3x3(-149.438721f, -133.907776f, 125.830139f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3x3 a2 = float3x3(-226.535767f, 101.706482f, 319.4715f);
            float b2 = (335.166138f);
            float3x3 r2 = float3x3(-226.535767f, 101.706482f, 319.4715f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3x3 a3 = float3x3(-285.4023f, 259.378f, -330.871948f);
            float b3 = (-355.846863f);
            float3x3 r3 = float3x3(-285.4023f, 259.378f, -330.871948f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3x3_operator_mod_scalar_wide()
        {
            float a0 = (-66.94504f);
            float3x3 b0 = float3x3(-249.7761f, -396.073761f, 386.492065f);
            float3x3 r0 = float3x3(-66.94504f, -66.94504f, -66.94504f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (168.939453f);
            float3x3 b1 = float3x3(-199.418243f, 261.7517f, 16.1274414f);
            float3x3 r1 = float3x3(168.939453f, 168.939453f, 7.665039f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (257.668152f);
            float3x3 b2 = float3x3(-75.78845f, 170.9563f, -242.858276f);
            float3x3 r2 = float3x3(30.3027954f, 86.71185f, 14.8098755f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (425.9453f);
            float3x3 b3 = float3x3(303.2724f, 3.033081f, -505.74353f);
            float3x3 r3 = float3x3(122.672913f, 1.31396484f, 425.9453f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3x3_operator_plus()
        {
            float3x3 a0 = float3x3(-418.829559f, -405.79895f, -34.04178f);
            float3x3 r0 = float3x3(-418.829559f, -405.79895f, -34.04178f);
            TestUtils.AreEqual(+a0, r0);

            float3x3 a1 = float3x3(236.999268f, 210.86145f, 293.742f);
            float3x3 r1 = float3x3(236.999268f, 210.86145f, 293.742f);
            TestUtils.AreEqual(+a1, r1);

            float3x3 a2 = float3x3(-373.015442f, 4.95440674f, -418.645264f);
            float3x3 r2 = float3x3(-373.015442f, 4.95440674f, -418.645264f);
            TestUtils.AreEqual(+a2, r2);

            float3x3 a3 = float3x3(504.474854f, 439.5594f, -478.7494f);
            float3x3 r3 = float3x3(504.474854f, 439.5594f, -478.7494f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float3x3_operator_neg()
        {
            float3x3 a0 = float3x3(148.461731f, -467.122681f, 132.04718f);
            float3x3 r0 = float3x3(-148.461731f, 467.122681f, -132.04718f);
            TestUtils.AreEqual(-a0, r0);

            float3x3 a1 = float3x3(183.522644f, -407.9911f, -54.95877f);
            float3x3 r1 = float3x3(-183.522644f, 407.9911f, 54.95877f);
            TestUtils.AreEqual(-a1, r1);

            float3x3 a2 = float3x3(-382.9898f, -383.014069f, 407.709778f);
            float3x3 r2 = float3x3(382.9898f, 383.014069f, -407.709778f);
            TestUtils.AreEqual(-a2, r2);

            float3x3 a3 = float3x3(168.735474f, 171.902466f, -280.558319f);
            float3x3 r3 = float3x3(-168.735474f, -171.902466f, 280.558319f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float3x3_operator_prefix_inc()
        {
            float3x3 a0 = float3x3(-139.842072f, -56.7436523f, -381.955322f);
            float3x3 r0 = float3x3(-138.842072f, -55.7436523f, -380.955322f);
            TestUtils.AreEqual(++a0, r0);

            float3x3 a1 = float3x3(509.796326f, 210.319885f, -392.7315f);
            float3x3 r1 = float3x3(510.796326f, 211.319885f, -391.7315f);
            TestUtils.AreEqual(++a1, r1);

            float3x3 a2 = float3x3(-300.1941f, 401.6148f, 130.90918f);
            float3x3 r2 = float3x3(-299.1941f, 402.6148f, 131.90918f);
            TestUtils.AreEqual(++a2, r2);

            float3x3 a3 = float3x3(-450.230164f, 46.1920166f, -41.4972839f);
            float3x3 r3 = float3x3(-449.230164f, 47.1920166f, -40.4972839f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float3x3_operator_postfix_inc()
        {
            float3x3 a0 = float3x3(-396.669739f, 511.20752f, 249.111267f);
            float3x3 r0 = float3x3(-396.669739f, 511.20752f, 249.111267f);
            TestUtils.AreEqual(a0++, r0);

            float3x3 a1 = float3x3(-128.817322f, 278.008179f, -81.39343f);
            float3x3 r1 = float3x3(-128.817322f, 278.008179f, -81.39343f);
            TestUtils.AreEqual(a1++, r1);

            float3x3 a2 = float3x3(66.71973f, 147.94397f, -326.1076f);
            float3x3 r2 = float3x3(66.71973f, 147.94397f, -326.1076f);
            TestUtils.AreEqual(a2++, r2);

            float3x3 a3 = float3x3(41.03357f, 73.15558f, -60.1323853f);
            float3x3 r3 = float3x3(41.03357f, 73.15558f, -60.1323853f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float3x3_operator_prefix_dec()
        {
            float3x3 a0 = float3x3(123.128723f, 256.84375f, 156.330811f);
            float3x3 r0 = float3x3(122.128723f, 255.84375f, 155.330811f);
            TestUtils.AreEqual(--a0, r0);

            float3x3 a1 = float3x3(461.737427f, 392.015625f, 187.874146f);
            float3x3 r1 = float3x3(460.737427f, 391.015625f, 186.874146f);
            TestUtils.AreEqual(--a1, r1);

            float3x3 a2 = float3x3(-236.225189f, 469.844727f, 45.5366821f);
            float3x3 r2 = float3x3(-237.225189f, 468.844727f, 44.5366821f);
            TestUtils.AreEqual(--a2, r2);

            float3x3 a3 = float3x3(376.046875f, -22.0289612f, 248.7901f);
            float3x3 r3 = float3x3(375.046875f, -23.0289612f, 247.7901f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float3x3_operator_postfix_dec()
        {
            float3x3 a0 = float3x3(379.6883f, 302.692871f, -176.07135f);
            float3x3 r0 = float3x3(379.6883f, 302.692871f, -176.07135f);
            TestUtils.AreEqual(a0--, r0);

            float3x3 a1 = float3x3(-291.2527f, -402.925964f, -63.65515f);
            float3x3 r1 = float3x3(-291.2527f, -402.925964f, -63.65515f);
            TestUtils.AreEqual(a1--, r1);

            float3x3 a2 = float3x3(355.2611f, -100.761841f, 156.14032f);
            float3x3 r2 = float3x3(355.2611f, -100.761841f, 156.14032f);
            TestUtils.AreEqual(a2--, r2);

            float3x3 a3 = float3x3(479.9452f, -445.026947f, 407.420349f);
            float3x3 r3 = float3x3(479.9452f, -445.026947f, 407.420349f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
