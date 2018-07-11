// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat4x4
    {
        [Test]
        public void float4x4_operator_equal_wide_wide()
        {
            float4x4 a0 = float4x4(492.1576f, -495.206329f, 227.457642f, -147.374054f);
            float4x4 b0 = float4x4(192.568787f, -235.611023f, -254.043121f, -412.624725f);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x4 a1 = float4x4(-222.682f, 64.09375f, -23.8904114f, -16.8197327f);
            float4x4 b1 = float4x4(471.9048f, -6.47277832f, -339.102356f, 488.187561f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x4 a2 = float4x4(163.232117f, -165.271f, 470.8777f, -423.942566f);
            float4x4 b2 = float4x4(-379.5966f, -308.417f, -82.333374f, -102.921082f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x4 a3 = float4x4(109.6344f, 462.6903f, -335.38147f, 357.2345f);
            float4x4 b3 = float4x4(226.515747f, -356.9013f, -362.912781f, -427.898438f);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(-303.230072f, 451.5263f, -253.655884f, -105.203644f);
            float b0 = (123.544556f);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x4 a1 = float4x4(-500.6911f, 159.8761f, -59.55838f, -57.4773865f);
            float b1 = (-426.192474f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x4 a2 = float4x4(-182.049744f, 370.886f, -172.035309f, 455.400024f);
            float b2 = (406.513733f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x4 a3 = float4x4(-11.3389893f, -27.1505737f, -325.976074f, -290.359039f);
            float b3 = (363.938232f);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_equal_scalar_wide()
        {
            float a0 = (-253.397278f);
            float4x4 b0 = float4x4(19.95221f, -185.791992f, 407.8136f, -87.2767f);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-206.274689f);
            float4x4 b1 = float4x4(160.503113f, -274.7708f, -2.63153076f, 448.354553f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-410.035248f);
            float4x4 b2 = float4x4(247.329041f, 355.539124f, -298.0667f, 414.1015f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-481.3026f);
            float4x4 b3 = float4x4(196.55072f, 34.6010132f, 113.7616f, -386.453369f);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_wide_wide()
        {
            float4x4 a0 = float4x4(430.842529f, 104.69f, 225.802429f, -310.5702f);
            float4x4 b0 = float4x4(210.024719f, -55.20334f, -269.925354f, -234.546722f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x4 a1 = float4x4(-418.619446f, 304.128174f, -509.3268f, -160.538086f);
            float4x4 b1 = float4x4(25.91742f, -63.72699f, -484.5537f, -425.3336f);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x4 a2 = float4x4(-203.301971f, -505.763245f, 162.17218f, 1.156189f);
            float4x4 b2 = float4x4(-53.2743835f, 328.1944f, 15.9631348f, 461.7141f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x4 a3 = float4x4(65.66205f, 102.787781f, 172.930054f, 26.6210327f);
            float4x4 b3 = float4x4(-113.363037f, -240.072968f, 495.119141f, 203.55835f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(-16.9145813f, 168.8341f, -462.713531f, 130.307739f);
            float b0 = (-145.372772f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x4 a1 = float4x4(214.501587f, -197.12796f, -169.099854f, -386.611176f);
            float b1 = (-440.263275f);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x4 a2 = float4x4(-281.021f, -403.9637f, -269.805725f, 299.654236f);
            float b2 = (-270.26886f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x4 a3 = float4x4(-71.7509155f, -457.363129f, -13.5195923f, 273.873047f);
            float b3 = (-432.755737f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_scalar_wide()
        {
            float a0 = (275.795837f);
            float4x4 b0 = float4x4(-57.1969f, -382.432526f, 97.82037f, -161.463654f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-458.39563f);
            float4x4 b1 = float4x4(-499.617859f, 327.92218f, 367.571228f, 59.786377f);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-209.580688f);
            float4x4 b2 = float4x4(-62.5804443f, -479.974976f, -49.4945068f, -114.685211f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (109.93927f);
            float4x4 b3 = float4x4(-176.284821f, -347.4853f, 85.5409546f, -356.659546f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_less_wide_wide()
        {
            float4x4 a0 = float4x4(196.84259f, 336.4098f, 251.963745f, 257.655945f);
            float4x4 b0 = float4x4(-465.345032f, -256.1524f, -314.814026f, 364.5667f);
            bool4x4 r0 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x4 a1 = float4x4(430.0459f, -62.4196472f, 8.839233f, -333.8167f);
            float4x4 b1 = float4x4(100.21051f, 182.560974f, 3.11700439f, -259.430481f);
            bool4x4 r1 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x4 a2 = float4x4(164.678833f, -350.9449f, 3.84143066f, 125.409729f);
            float4x4 b2 = float4x4(-437.3349f, -456.043732f, -394.255981f, 401.9137f);
            bool4x4 r2 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x4 a3 = float4x4(-111.129944f, 70.00549f, 448.1983f, -419.987122f);
            float4x4 b3 = float4x4(313.439148f, 121.286682f, -28.0122986f, -282.965881f);
            bool4x4 r3 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_less_wide_scalar()
        {
            float4x4 a0 = float4x4(-132.057312f, -192.465f, -66.8345947f, -379.017517f);
            float b0 = (-156.010223f);
            bool4x4 r0 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x4 a1 = float4x4(-360.2824f, -158.240753f, 437.3459f, -20.4526062f);
            float b1 = (20.9278564f);
            bool4x4 r1 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x4 a2 = float4x4(225.2915f, 274.015259f, 373.549683f, 398.523682f);
            float b2 = (307.4842f);
            bool4x4 r2 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x4 a3 = float4x4(105.030151f, 109.670105f, -108.85318f, -44.9712524f);
            float b3 = (-58.0108948f);
            bool4x4 r3 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_less_scalar_wide()
        {
            float a0 = (-423.1174f);
            float4x4 b0 = float4x4(385.094849f, -123.933472f, 86.37659f, 133.4422f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (161.457947f);
            float4x4 b1 = float4x4(229.754272f, 222.5716f, 315.5312f, -447.203522f);
            bool4x4 r1 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (271.833862f);
            float4x4 b2 = float4x4(-393.605316f, 317.486877f, -164.6051f, -282.876038f);
            bool4x4 r2 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (296.979553f);
            float4x4 b3 = float4x4(-254.401154f, 365.6156f, -441.984253f, -131.42865f);
            bool4x4 r3 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_wide_wide()
        {
            float4x4 a0 = float4x4(483.5014f, 310.8156f, 106.966187f, 295.7353f);
            float4x4 b0 = float4x4(-471.398f, -371.9853f, 36.9006958f, -316.7636f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x4 a1 = float4x4(116.957581f, -478.299774f, -14.8974f, -33.8174438f);
            float4x4 b1 = float4x4(19.6830444f, 207.309143f, 362.7975f, 324.95343f);
            bool4x4 r1 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x4 a2 = float4x4(-24.74054f, 319.782654f, -120.158569f, -289.008575f);
            float4x4 b2 = float4x4(340.948059f, 25.9860229f, -114.211121f, 240.803467f);
            bool4x4 r2 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x4 a3 = float4x4(455.85144f, 144.706909f, 63.9320068f, -285.683044f);
            float4x4 b3 = float4x4(273.422424f, 325.515747f, 27.3410645f, 64.47955f);
            bool4x4 r3 = bool4x4(true, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_wide_scalar()
        {
            float4x4 a0 = float4x4(64.31793f, -397.703461f, 431.8769f, 85.703f);
            float b0 = (305.859924f);
            bool4x4 r0 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x4 a1 = float4x4(246.263062f, 286.199463f, 280.813354f, -405.7846f);
            float b1 = (197.491577f);
            bool4x4 r1 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x4 a2 = float4x4(171.565369f, 333.5782f, 370.279175f, -413.7014f);
            float b2 = (-241.807281f);
            bool4x4 r2 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x4 a3 = float4x4(-356.592346f, 396.645325f, 467.222046f, -240.013428f);
            float b3 = (-353.0313f);
            bool4x4 r3 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_scalar_wide()
        {
            float a0 = (-282.6705f);
            float4x4 b0 = float4x4(358.099976f, -72.596405f, -232.163788f, -60.7067261f);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (75.15662f);
            float4x4 b1 = float4x4(150.883484f, 339.539185f, -498.196045f, 459.7461f);
            bool4x4 r1 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-227.968719f);
            float4x4 b2 = float4x4(335.862122f, 76.17883f, 296.859924f, 177.48999f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-281.2012f);
            float4x4 b3 = float4x4(244.722839f, 137.328552f, -385.338257f, 443.163452f);
            bool4x4 r3 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_wide_wide()
        {
            float4x4 a0 = float4x4(-438.523132f, 210.489441f, 4.87731934f, -137.297943f);
            float4x4 b0 = float4x4(-474.814148f, 304.371033f, 234.824158f, -390.485443f);
            bool4x4 r0 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x4 a1 = float4x4(156.094116f, -363.924133f, -97.94849f, 437.2954f);
            float4x4 b1 = float4x4(-297.175354f, -326.2924f, 107.253906f, -413.131073f);
            bool4x4 r1 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x4 a2 = float4x4(458.530273f, -294.064758f, 23.62262f, -34.2840576f);
            float4x4 b2 = float4x4(67.09442f, 470.075256f, -84.499115f, 392.784241f);
            bool4x4 r2 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x4 a3 = float4x4(149.736511f, -418.8867f, -197.502533f, -88.2055054f);
            float4x4 b3 = float4x4(-263.531738f, 369.3009f, -333.3253f, 238.413452f);
            bool4x4 r3 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(193.49585f, 168.915527f, -313.993073f, 81.8269653f);
            float b0 = (443.850525f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x4 a1 = float4x4(18.5036011f, 241.361145f, -463.8164f, -1.35775757f);
            float b1 = (-0.3581848f);
            bool4x4 r1 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x4 a2 = float4x4(-268.899475f, -471.253082f, -264.9378f, 82.2583f);
            float b2 = (398.991943f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x4 a3 = float4x4(11.2460327f, 426.482239f, 56.3200073f, -196.2879f);
            float b3 = (424.704041f);
            bool4x4 r3 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_scalar_wide()
        {
            float a0 = (393.606262f);
            float4x4 b0 = float4x4(-75.6883545f, -44.2638855f, 125.864929f, 191.9649f);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (13.54303f);
            float4x4 b1 = float4x4(-197.051941f, -423.9451f, -330.0486f, 420.165527f);
            bool4x4 r1 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (105.5473f);
            float4x4 b2 = float4x4(174.821289f, 296.7176f, -469.7004f, 123.267212f);
            bool4x4 r2 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (112.996948f);
            float4x4 b3 = float4x4(495.143372f, -488.6579f, 388.539429f, -493.240784f);
            bool4x4 r3 = bool4x4(true, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_wide_wide()
        {
            float4x4 a0 = float4x4(-507.9286f, 504.4975f, -385.4345f, -262.323425f);
            float4x4 b0 = float4x4(-81.3465f, 297.666138f, 171.06543f, -431.038055f);
            bool4x4 r0 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x4 a1 = float4x4(-37.5509338f, -111.595276f, -463.702026f, 387.448853f);
            float4x4 b1 = float4x4(-6.85907f, 319.7257f, 254.079163f, 396.5724f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x4 a2 = float4x4(456.9688f, -211.010162f, 182.411377f, -53.59604f);
            float4x4 b2 = float4x4(178.8393f, -447.063354f, 288.492676f, 474.889282f);
            bool4x4 r2 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x4 a3 = float4x4(-309.570221f, -136.022491f, 280.736267f, -96.99588f);
            float4x4 b3 = float4x4(-321.750244f, -395.977234f, -158.692474f, 391.4887f);
            bool4x4 r3 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(465.152161f, -424.886078f, -209.2211f, 58.7798462f);
            float b0 = (-5.599884f);
            bool4x4 r0 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x4 a1 = float4x4(-302.2691f, 16.3533936f, -344.559967f, 393.278076f);
            float b1 = (140.12561f);
            bool4x4 r1 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x4 a2 = float4x4(-315.701538f, -509.781555f, -36.9942932f, 494.8203f);
            float b2 = (441.011536f);
            bool4x4 r2 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x4 a3 = float4x4(-164.973938f, -123.813751f, 215.651245f, 104.995728f);
            float b3 = (-466.1201f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_scalar_wide()
        {
            float a0 = (374.827026f);
            float4x4 b0 = float4x4(-1.60977173f, 338.615234f, -116.1814f, -332.157318f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-355.97937f);
            float4x4 b1 = float4x4(-468.901428f, 38.579895f, -332.347534f, 2.89013672f);
            bool4x4 r1 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (467.777771f);
            float4x4 b2 = float4x4(121.406372f, -305.023376f, -58.4288025f, -226.519562f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-47.0209961f);
            float4x4 b3 = float4x4(305.302673f, -427.401245f, 92.26367f, -497.178528f);
            bool4x4 r3 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_add_wide_wide()
        {
            float4x4 a0 = float4x4(506.129028f, -501.779816f, 420.084778f, -186.032074f);
            float4x4 b0 = float4x4(-28.7579956f, -337.135132f, -340.676819f, 152.312012f);
            float4x4 r0 = float4x4(477.371033f, -838.9149f, 79.40796f, -33.7200623f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x4 a1 = float4x4(-9.312408f, 328.51178f, 424.344055f, 87.79108f);
            float4x4 b1 = float4x4(423.66748f, 90.3740845f, 376.18866f, 1.76721191f);
            float4x4 r1 = float4x4(414.355072f, 418.885864f, 800.5327f, 89.55829f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x4 a2 = float4x4(462.4137f, -46.17871f, 401.170044f, -454.124146f);
            float4x4 b2 = float4x4(-120.185852f, -279.629364f, -344.6671f, 242.839172f);
            float4x4 r2 = float4x4(342.227844f, -325.808075f, 56.50293f, -211.284973f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x4 a3 = float4x4(69.19568f, -177.957336f, 299.604126f, 340.704834f);
            float4x4 b3 = float4x4(418.593079f, -23.3128052f, -95.0999451f, 147.9281f);
            float4x4 r3 = float4x4(487.788757f, -201.270142f, 204.504181f, 488.632935f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_add_wide_scalar()
        {
            float4x4 a0 = float4x4(-194.514191f, 338.5484f, 246.971375f, 100.510925f);
            float b0 = (124.121704f);
            float4x4 r0 = float4x4(-70.39249f, 462.6701f, 371.093079f, 224.632629f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x4 a1 = float4x4(-45.72467f, 30.9161377f, 60.37433f, -242.118744f);
            float b1 = (-478.1113f);
            float4x4 r1 = float4x4(-523.835938f, -447.19516f, -417.736969f, -720.230042f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x4 a2 = float4x4(82.50134f, -484.6998f, -188.265015f, -213.526733f);
            float b2 = (6.79937744f);
            float4x4 r2 = float4x4(89.30072f, -477.900421f, -181.465637f, -206.727356f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x4 a3 = float4x4(-267.7843f, 198.533569f, 187.536072f, -424.925659f);
            float b3 = (189.259949f);
            float4x4 r3 = float4x4(-78.52435f, 387.793518f, 376.796021f, -235.66571f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_add_scalar_wide()
        {
            float a0 = (-340.354675f);
            float4x4 b0 = float4x4(511.362244f, -146.216644f, -106.210419f, -363.450256f);
            float4x4 r0 = float4x4(171.007568f, -486.57132f, -446.5651f, -703.804932f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (199.0896f);
            float4x4 b1 = float4x4(-27.1083984f, 419.849f, 284.955017f, -164.9242f);
            float4x4 r1 = float4x4(171.9812f, 618.9386f, 484.044617f, 34.1654053f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-249.190338f);
            float4x4 b2 = float4x4(150.928162f, 298.1751f, -457.1534f, 424.718079f);
            float4x4 r2 = float4x4(-98.26218f, 48.98477f, -706.34375f, 175.52774f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-301.857483f);
            float4x4 b3 = float4x4(230.288879f, -423.5876f, -67.06003f, 68.72412f);
            float4x4 r3 = float4x4(-71.5686f, -725.445068f, -368.9175f, -233.133362f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_wide_wide()
        {
            float4x4 a0 = float4x4(160.492249f, 11.223938f, 359.200134f, -498.2283f);
            float4x4 b0 = float4x4(115.46875f, -130.9823f, 241.540833f, 9.987061f);
            float4x4 r0 = float4x4(45.0235f, 142.206238f, 117.6593f, -508.215363f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x4 a1 = float4x4(-355.253632f, -94.53485f, -410.46405f, -401.384644f);
            float4x4 b1 = float4x4(419.895142f, 59.12445f, -402.381653f, -75.37015f);
            float4x4 r1 = float4x4(-775.1488f, -153.6593f, -8.082397f, -326.0145f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x4 a2 = float4x4(317.706848f, 447.060425f, -489.074158f, -230.008392f);
            float4x4 b2 = float4x4(320.9796f, -73.90875f, -31.4447327f, -389.251953f);
            float4x4 r2 = float4x4(-3.272766f, 520.9692f, -457.629425f, 159.243561f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x4 a3 = float4x4(24.8754272f, 366.614441f, -107.374146f, -219.008148f);
            float4x4 b3 = float4x4(-375.028839f, 259.182739f, 276.648682f, -453.0692f);
            float4x4 r3 = float4x4(399.904266f, 107.4317f, -384.022827f, 234.061066f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_wide_scalar()
        {
            float4x4 a0 = float4x4(207.389587f, 248.457764f, -384.8239f, -205.344757f);
            float b0 = (-36.1124878f);
            float4x4 r0 = float4x4(243.502075f, 284.570251f, -348.711426f, -169.232269f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x4 a1 = float4x4(-374.811554f, 18.8562622f, -44.96161f, 480.857971f);
            float b1 = (191.642029f);
            float4x4 r1 = float4x4(-566.4536f, -172.785767f, -236.603638f, 289.215942f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x4 a2 = float4x4(16.3381958f, -35.5231f, 349.397766f, 439.077271f);
            float b2 = (-366.865448f);
            float4x4 r2 = float4x4(383.203644f, 331.342346f, 716.2632f, 805.942749f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x4 a3 = float4x4(490.2223f, -384.849426f, 189.05188f, 55.6027832f);
            float b3 = (195.024048f);
            float4x4 r3 = float4x4(295.198242f, -579.8735f, -5.972168f, -139.421265f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_scalar_wide()
        {
            float a0 = (-86.00824f);
            float4x4 b0 = float4x4(466.4251f, 298.486938f, -300.9501f, 315.38f);
            float4x4 r0 = float4x4(-552.43335f, -384.495178f, 214.941864f, -401.388245f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-381.092163f);
            float4x4 b1 = float4x4(-125.008362f, 58.4661865f, 214.7461f, -257.549438f);
            float4x4 r1 = float4x4(-256.0838f, -439.55835f, -595.838257f, -123.542725f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (480.2246f);
            float4x4 b2 = float4x4(-443.355072f, 260.795044f, 29.6819458f, 139.857727f);
            float4x4 r2 = float4x4(923.5797f, 219.429565f, 450.542664f, 340.366882f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-247.789948f);
            float4x4 b3 = float4x4(-248.466217f, 91.44513f, 86.3841553f, 373.8183f);
            float4x4 r3 = float4x4(0.676269531f, -339.235077f, -334.1741f, -621.6083f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_wide_wide()
        {
            float4x4 a0 = float4x4(-482.7138f, -407.2935f, 137.700562f, 208.541138f);
            float4x4 b0 = float4x4(-236.367889f, 260.7276f, -416.3863f, -364.4956f);
            float4x4 r0 = float4x4(114098.047f, -106192.656f, -57336.625f, -76012.33f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x4 a1 = float4x4(194.29657f, -484.242432f, 183.9873f, -241.33548f);
            float4x4 b1 = float4x4(-253.147522f, -369.202881f, 193.547913f, 169.0849f);
            float4x4 r1 = float4x4(-49185.6953f, 178783.7f, 35610.36f, -40806.1836f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x4 a2 = float4x4(45.8687744f, 363.3261f, -328.118958f, -471.023071f);
            float4x4 b2 = float4x4(201.969666f, 249.456055f, -308.193176f, -385.579651f);
            float4x4 r2 = float4x4(9264.101f, 90633.9f, 101124.023f, 181616.9f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x4 a3 = float4x4(-262.682556f, -379.262756f, -374.090576f, 481.4474f);
            float4x4 b3 = float4x4(-183.2796f, 22.2756348f, -265.521423f, -95.67746f);
            float4x4 r3 = float4x4(48144.3555f, -8448.318f, 99329.06f, -46063.6641f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_wide_scalar()
        {
            float4x4 a0 = float4x4(-96.31882f, -277.142273f, -239.93689f, 509.531433f);
            float b0 = (-301.2072f);
            float4x4 r0 = float4x4(29011.9219f, 83477.25f, 72270.72f, -153474.547f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x4 a1 = float4x4(255.8581f, -455.50827f, -389.2433f, -338.29248f);
            float b1 = (215.7315f);
            float4x4 r1 = float4x4(55196.6523f, -98267.4844f, -83972.04f, -72980.34f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x4 a2 = float4x4(53.7962646f, 135.354675f, -207.3501f, -383.9396f);
            float b2 = (243.757324f);
            float4x4 r2 = float4x4(13113.2334f, 32993.6953f, -50543.1055f, -93588.09f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x4 a3 = float4x4(-31.4252319f, 260.38385f, 176.867554f, 25.67212f);
            float b3 = (42.6761475f);
            float4x4 r3 = float4x4(-1341.10779f, 11112.18f, 7548.026f, 1095.58716f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_scalar_wide()
        {
            float a0 = (37.43219f);
            float4x4 b0 = float4x4(96.74756f, 492.185364f, -274.054565f, -452.870972f);
            float4x4 r0 = float4x4(3621.473f, 18423.5762f, -10258.4629f, -16951.9531f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (420.853333f);
            float4x4 b1 = float4x4(102.182922f, -114.948883f, -351.120056f, -464.664978f);
            float4x4 r1 = float4x4(43004.0234f, -48376.62f, -147770.047f, -195555.8f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (444.084839f);
            float4x4 b2 = float4x4(447.1053f, 130.829346f, -321.41333f, 445.301331f);
            float4x4 r2 = float4x4(198552.672f, 58099.33f, -142734.781f, 197751.563f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (478.2436f);
            float4x4 b3 = float4x4(358.571716f, -144.8901f, -438.893829f, -3.536438f);
            float4x4 r3 = float4x4(171484.625f, -69292.7656f, -209898.156f, -1691.27881f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_div_wide_wide()
        {
            float4x4 a0 = float4x4(-353.131439f, -102.799866f, 51.3191528f, -191.871674f);
            float4x4 b0 = float4x4(-178.739563f, -302.096283f, -199.405823f, 278.850769f);
            float4x4 r0 = float4x4(1.97567582f, 0.34028843f, -0.257360339f, -0.688080132f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x4 a1 = float4x4(8.041809f, -128.73764f, -136.0596f, -370.471f);
            float4x4 b1 = float4x4(502.3376f, -361.484833f, 353.121033f, -38.894928f);
            float4x4 r1 = float4x4(0.0160087738f, 0.356135666f, -0.385305852f, 9.524919f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x4 a2 = float4x4(-237.69455f, -432.546875f, 200.2655f, 361.4416f);
            float4x4 b2 = float4x4(-75.76474f, -195.217834f, -405.034f, -394.23f);
            float4x4 r2 = float4x4(3.1372714f, 2.215714f, -0.4944412f, -0.9168292f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x4 a3 = float4x4(-416.226135f, -450.0192f, -273.497437f, -286.908173f);
            float4x4 b3 = float4x4(-375.8277f, -121.245483f, 447.623352f, 338.286255f);
            float4x4 r3 = float4x4(1.107492f, 3.71163678f, -0.610999048f, -0.8481225f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_div_wide_scalar()
        {
            float4x4 a0 = float4x4(171.3424f, 0.103393555f, 57.8882446f, -256.130737f);
            float b0 = (171.796814f);
            float4x4 r0 = float4x4(0.997355f, 0.000601836247f, 0.3369576f, -1.49089336f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x4 a1 = float4x4(95.66968f, -127.4487f, -79.7449f, 146.466858f);
            float b1 = (-290.3869f);
            float4x4 r1 = float4x4(-0.3294559f, 0.438892722f, 0.274616063f, -0.504385233f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x4 a2 = float4x4(-499.843567f, -453.2058f, -205.033813f, 481.738159f);
            float b2 = (58.68634f);
            float4x4 r2 = float4x4(-8.517204f, -7.72250938f, -3.493723f, 8.2086935f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x4 a3 = float4x4(464.479065f, -158.505585f, -289.5822f, 494.1286f);
            float b3 = (-293.4635f);
            float4x4 r3 = float4x4(-1.582749f, 0.540120244f, 0.9867742f, -1.6837821f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_div_scalar_wide()
        {
            float a0 = (-264.4425f);
            float4x4 b0 = float4x4(105.589111f, -142.349091f, -288.9489f, 39.644104f);
            float4x4 r0 = float4x4(-2.50444865f, 1.85770416f, 0.9151877f, -6.670412f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-363.9914f);
            float4x4 b1 = float4x4(-149.718231f, -395.729126f, 258.7187f, -9.66626f);
            float4x4 r1 = float4x4(2.43117619f, 0.9197993f, -1.40690029f, 37.65587f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (117.725525f);
            float4x4 b2 = float4x4(-331.386536f, -509.986023f, 427.896484f, 467.617126f);
            float4x4 r2 = float4x4(-0.355251372f, -0.230840683f, 0.2751262f, 0.251756221f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-407.124634f);
            float4x4 b3 = float4x4(252.690735f, 444.599365f, -88.31329f, 199.955017f);
            float4x4 r3 = float4x4(-1.61115777f, -0.9157112f, 4.610004f, -2.036081f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_wide_wide()
        {
            float4x4 a0 = float4x4(-388.8125f, 181.681213f, -167.078735f, 432.820129f);
            float4x4 b0 = float4x4(436.944153f, 58.9400635f, -201.116241f, 279.289368f);
            float4x4 r0 = float4x4(-388.8125f, 4.861023f, -167.078735f, 153.530762f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x4 a1 = float4x4(-258.438965f, -170.110809f, 283.3183f, 122.716492f);
            float4x4 b1 = float4x4(-397.079773f, 377.899963f, 174.693848f, -228.176514f);
            float4x4 r1 = float4x4(-258.438965f, -170.110809f, 108.624451f, 122.716492f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x4 a2 = float4x4(335.271f, -503.608521f, 191.022522f, 289.742676f);
            float4x4 b2 = float4x4(-317.060181f, -417.4801f, -249.975952f, -397.571564f);
            float4x4 r2 = float4x4(18.2108154f, -86.12842f, 191.022522f, 289.742676f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x4 a3 = float4x4(-124.033722f, 259.274f, -274.358459f, -140.030792f);
            float4x4 b3 = float4x4(-358.745453f, -198.15921f, 208.737122f, -12.1194153f);
            float4x4 r3 = float4x4(-124.033722f, 61.1147766f, -65.62134f, -6.717224f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_wide_scalar()
        {
            float4x4 a0 = float4x4(-244.499634f, -211.8193f, -145.926788f, -304.9182f);
            float b0 = (39.63495f);
            float4x4 r0 = float4x4(-6.68994141f, -13.6445618f, -27.0219421f, -27.4735718f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x4 a1 = float4x4(155.479492f, 281.309631f, -226.535767f, 335.166138f);
            float b1 = (-133.907776f);
            float4x4 r1 = float4x4(21.5717163f, 13.49408f, -92.62799f, 67.3505859f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x4 a2 = float4x4(101.706482f, -285.4023f, -355.846863f, 259.378f);
            float b2 = (319.4715f);
            float4x4 r2 = float4x4(101.706482f, -285.4023f, -36.3753662f, 259.378f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x4 a3 = float4x4(-330.871948f, -102.683441f, -172.141754f, 206.41687f);
            float b3 = (-284.343567f);
            float4x4 r3 = float4x4(-46.52838f, -102.683441f, -172.141754f, 206.41687f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_scalar_wide()
        {
            float a0 = (-66.94504f);
            float4x4 b0 = float4x4(-249.7761f, -396.073761f, 386.492065f, 168.939453f);
            float4x4 r0 = float4x4(-66.94504f, -66.94504f, -66.94504f, -66.94504f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (-199.418243f);
            float4x4 b1 = float4x4(261.7517f, 16.1274414f, 257.668152f, -75.78845f);
            float4x4 r1 = float4x4(-199.418243f, -5.88894653f, -199.418243f, -47.84134f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (170.9563f);
            float4x4 b2 = float4x4(-242.858276f, 425.9453f, 303.2724f, 3.033081f);
            float4x4 r2 = float4x4(170.9563f, 170.9563f, 170.9563f, 1.10375977f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-505.74353f);
            float4x4 b3 = float4x4(461.957031f, 205.972778f, 270.040649f, -47.4807129f);
            float4x4 r3 = float4x4(-43.7865f, -93.79797f, -235.702881f, -30.9364014f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_plus()
        {
            float4x4 a0 = float4x4(-418.829559f, -405.79895f, -34.04178f, 236.999268f);
            float4x4 r0 = float4x4(-418.829559f, -405.79895f, -34.04178f, 236.999268f);
            TestUtils.AreEqual(+a0, r0);

            float4x4 a1 = float4x4(-459.8391f, 293.742f, -373.015442f, -386.059845f);
            float4x4 r1 = float4x4(-459.8391f, 293.742f, -373.015442f, -386.059845f);
            TestUtils.AreEqual(+a1, r1);

            float4x4 a2 = float4x4(4.95440674f, 504.474854f, -170.746521f, 439.5594f);
            float4x4 r2 = float4x4(4.95440674f, 504.474854f, -170.746521f, 439.5594f);
            TestUtils.AreEqual(+a2, r2);

            float4x4 a3 = float4x4(-478.7494f, 421.409668f, -258.596069f, 447.8661f);
            float4x4 r3 = float4x4(-478.7494f, 421.409668f, -258.596069f, 447.8661f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float4x4_operator_neg()
        {
            float4x4 a0 = float4x4(148.461731f, -467.122681f, 132.04718f, 183.522644f);
            float4x4 r0 = float4x4(-148.461731f, 467.122681f, -132.04718f, -183.522644f);
            TestUtils.AreEqual(-a0, r0);

            float4x4 a1 = float4x4(473.701f, -54.95877f, -382.9898f, -299.093384f);
            float4x4 r1 = float4x4(-473.701f, 54.95877f, 382.9898f, 299.093384f);
            TestUtils.AreEqual(-a1, r1);

            float4x4 a2 = float4x4(-383.014069f, 168.735474f, 466.441528f, 171.902466f);
            float4x4 r2 = float4x4(383.014069f, -168.735474f, -466.441528f, -171.902466f);
            TestUtils.AreEqual(-a2, r2);

            float4x4 a3 = float4x4(-280.558319f, 318.69635f, -39.9154053f, 140.340027f);
            float4x4 r3 = float4x4(280.558319f, -318.69635f, 39.9154053f, -140.340027f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float4x4_operator_prefix_inc()
        {
            float4x4 a0 = float4x4(-139.842072f, -56.7436523f, -381.955322f, 509.796326f);
            float4x4 r0 = float4x4(-138.842072f, -55.7436523f, -380.955322f, 510.796326f);
            TestUtils.AreEqual(++a0, r0);

            float4x4 a1 = float4x4(-222.896332f, -392.7315f, -300.1941f, 362.212769f);
            float4x4 r1 = float4x4(-221.896332f, -391.7315f, -299.1941f, 363.212769f);
            TestUtils.AreEqual(++a1, r1);

            float4x4 a2 = float4x4(401.6148f, -450.230164f, 243.546936f, 46.1920166f);
            float4x4 r2 = float4x4(402.6148f, -449.230164f, 244.546936f, 47.1920166f);
            TestUtils.AreEqual(++a2, r2);

            float4x4 a3 = float4x4(-41.4972839f, 154.356567f, -281.233276f, 200.706f);
            float4x4 r3 = float4x4(-40.4972839f, 155.356567f, -280.233276f, 201.706f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float4x4_operator_postfix_inc()
        {
            float4x4 a0 = float4x4(-396.669739f, 511.20752f, 249.111267f, -128.817322f);
            float4x4 r0 = float4x4(-396.669739f, 511.20752f, 249.111267f, -128.817322f);
            TestUtils.AreEqual(a0++, r0);

            float4x4 a1 = float4x4(-259.4903f, -81.39343f, 66.71973f, 167.852112f);
            float4x4 r1 = float4x4(-259.4903f, -81.39343f, 66.71973f, 167.852112f);
            TestUtils.AreEqual(a1++, r1);

            float4x4 a2 = float4x4(147.94397f, 41.03357f, 128.5304f, 73.15558f);
            float4x4 r2 = float4x4(147.94397f, 41.03357f, 128.5304f, 73.15558f);
            TestUtils.AreEqual(a2++, r2);

            float4x4 a3 = float4x4(-60.1323853f, -296.937836f, 267.293823f, 446.2293f);
            float4x4 r3 = float4x4(-60.1323853f, -296.937836f, 267.293823f, 446.2293f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float4x4_operator_prefix_dec()
        {
            float4x4 a0 = float4x4(123.128723f, 256.84375f, 156.330811f, 461.737427f);
            float4x4 r0 = float4x4(122.128723f, 255.84375f, 155.330811f, 460.737427f);
            TestUtils.AreEqual(--a0, r0);

            float4x4 a1 = float4x4(325.867981f, 187.874146f, -236.225189f, 125.109619f);
            float4x4 r1 = float4x4(324.867981f, 186.874146f, -237.225189f, 124.109619f);
            TestUtils.AreEqual(--a1, r1);

            float4x4 a2 = float4x4(469.844727f, 376.046875f, -363.0755f, -22.0289612f);
            float4x4 r2 = float4x4(468.844727f, 375.046875f, -364.0755f, -23.0289612f);
            TestUtils.AreEqual(--a2, r2);

            float4x4 a3 = float4x4(248.7901f, 168.265625f, -190.284729f, 166.945557f);
            float4x4 r3 = float4x4(247.7901f, 167.265625f, -191.284729f, 165.945557f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float4x4_operator_postfix_dec()
        {
            float4x4 a0 = float4x4(379.6883f, 302.692871f, -176.07135f, -291.2527f);
            float4x4 r0 = float4x4(379.6883f, 302.692871f, -176.07135f, -291.2527f);
            TestUtils.AreEqual(a0--, r0);

            float4x4 a1 = float4x4(470.567566f, -63.65515f, 355.2611f, -27.8892212f);
            float4x4 r1 = float4x4(470.567566f, -63.65515f, 355.2611f, -27.8892212f);
            TestUtils.AreEqual(a1--, r1);

            float4x4 a2 = float4x4(-100.761841f, 479.9452f, -200.304291f, -445.026947f);
            float4x4 r2 = float4x4(-100.761841f, 479.9452f, -200.304291f, -445.026947f);
            TestUtils.AreEqual(a2--, r2);

            float4x4 a3 = float4x4(407.420349f, 48.06018f, -209.667969f, -38.43506f);
            float4x4 r3 = float4x4(407.420349f, 48.06018f, -209.667969f, -38.43506f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
