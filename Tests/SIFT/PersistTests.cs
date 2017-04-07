﻿using NUnit.Framework;
using SiftSharp.SIFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiftSharp.SIFT.Tests
{
    [TestFixture()]
    public class PersistTests
    {
        [Test()]
        public void EncodeDecode_ShouldBeEqual()
        {
            Feature test = new Feature();
            test.x = 451.575160571694;
            test.y = 366.77342066339;
            test.scale = 1.99511026318034;
            test.orientation = 0.75;
            test.octave = 0;
            test.level = 3;
            test.xLayer = 451;
            test.yLayer = 366;

            test.descr = new double[]
            {
                0,0,0,0,0,0,0,0,0.0755553404371678,0.211180717734466,0.167280546138982,
                0.00289388677239093,0,0,0.000525255936947905,0.0182594648467349,
                0.0471685592786868,0.0206017634159631,7.76522833183316E-05,0,
                9.89392722183202E-05,0.00149258450978343,0.0455242894558371,
                0.0894163615667451,0.0404629578175058,0.00641476551263103,0.00108268212476634,
                0.000323326704442345,0.0111579217314342,0.0150937306238397,0.0240291202729335,
                0.0396087864039016,0,0,0,0,0,0,0,0,0.31148818873259,0.279609220564967
                ,0.0697620308377403,0.00025730489431978,0,0.00160141934557435,0.0114787019272094,
                0.137536891002821,0.0578491670027818,0.00272824785237527,0,5.47897707858155E-05,
                0.0089953616631052,0.0869411341064941,0.0756190587909646,0.104772533273557,
                0.000193845624150667,0.00015202788198261,0.0023557064176567,0.00715438446565004,
                0.0210069721607597,0.0777169772164705,0.0384354217481203,0.00773412034526422,
                0,0,0,0,0,0,0,0,0.190084930097043,0.0043214008678957,0.000321473181366964,
                0.00185976018352199,0.0581172830238651,0.0354073962145599,0.0439789157006153,
                0.056982253505958,0.000627331019186178,0,0.0011906299649813,0.0232243407009787,
                0.297241086526238,0.138302269808704,0.0259317324158164,0.004898381740788,0,
                0.0080272008343184,0.0734306755722255,0.107613002237405,0.134042489572016,
                0.0509458379248572,0.00343891515844387,0.000442307055331824,0,0,0,0,0,0,0,0,
                0.00323188837694108,9.67259588061903E-05,0.00103301958264708,0.0187536837485211,
                0.31148818873259,0.0606888760062172,0.00308799418113101,0.00207668456919777,0,
                0,0.0126977116398841,0.165612212516775,0.31148818873259,0.0994693384340248,
                0.00129492678339682,0,0.000178879474618521,0.0531789154338618,0.31148818873259,
                0.31148818873259,0.21164829739367,0.00448434351716808,0,0
            };

            byte[] byteTest = Persist.EncodeFeature(test);
            Feature decodeTest = Persist.DecodeFeature(byteTest);
            Assert.AreEqual(test.descr[10], decodeTest.descr[10]);
        }
    }
}