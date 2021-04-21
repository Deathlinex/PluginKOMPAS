﻿using System;
using NUnit.Framework;
using KompasAPI.Model;

namespace UnitTests
{
    [TestFixture]
    class ORSAPRModelTests
    {
        /// <summary>
        /// Создание тестовых параметров
        /// </summary>
        public ModelParameters CreateTestParameters()
        {
            var sourceParameters = new ModelParameters();
            return sourceParameters;
        }

        [Test(Description = "Позитивный тест параметров ")]
        public void Parameters_ReturnsSameValue()
        {
            var sourceParameters = CreateTestParameters();
            var expectedParameters = new ModelParameters();
            var actualParameters = sourceParameters;
            
            Assert.AreEqual(expectedParameters.DoorHeight.Value,
                actualParameters.DoorHeight.Value,
                "Значения DoorHeight не совпадают");
            Assert.AreEqual(expectedParameters.CaseDepth.Value,
                actualParameters.CaseDepth.Value,
                "Значения CaseDepth не совпадают");
            Assert.AreEqual(expectedParameters.DiameterOfButtons.Value,
                actualParameters.DiameterOfButtons.Value,
                "Значения DiameterOfButtons не совпадают");
            Assert.AreEqual(expectedParameters.DoorLength.Value,
                actualParameters.DoorLength.Value,
                "Значения DoorLength не совпадают");
            Assert.AreEqual(expectedParameters.CaseLength.Value,
                actualParameters.CaseLength.Value,
                "Значения CaseLength не совпадают");
            Assert.AreEqual(expectedParameters.CaseHeight.Value,
                actualParameters.CaseHeight.Value,
                "Значения CaseHeight не совпадают");
            Assert.AreEqual(expectedParameters.ButtonLength.Value,
                actualParameters.ButtonLength.Value,
                "Значения ButtonLength не совпадают");
            Assert.AreEqual(expectedParameters.ButtonHeight.Value,
                actualParameters.ButtonHeight.Value,
                "Значения ButtonHeight не совпадают");
        }

        [Test(Description = "Негативный тест параметра длины дверцы")]
        public void Parameter_DoorLengthRange()
        {
            var sourceParameters = new ModelParameters(
                300,
                30,
                500,
                250,
                100,
                50);
            Assert.Throws<ArgumentException>(() =>
                {sourceParameters.DoorLength.Value = 2000;},
                "Длина дверцы входит в допустимый диапазон");
        }
        [Test(Description = "Негативный тест параметра высоты дверцы")]
        public void Parameter_DoorHeightRange()
        {
            var sourceParameters = new ModelParameters(
                300,
                30,
                500,
                250,
                100,
                50);
            Assert.Throws<ArgumentException>(() =>
                {sourceParameters.DoorHeight.Value = 1000;},
                "Высота дверцы входит в допустимый диапазон");
        }

        /// <summary>
        /// Создание тестового параметра
        /// </summary>
        public Parameter CreateTestParameter()
        {
            var sourceParameter = new Parameter(
                "Параметр первый",
                250,
                100,
                500);
            return sourceParameter;
        }

        [Test(Description = "Позитивный тест параметра")]
        public void Parameter_ReturnsSameValue()
        {
            var sourceParameter = CreateTestParameter();
            var expectedParameter = new Parameter(
                "Параметр первый",
                250,
                100,
                500);
            var actualParameter = sourceParameter;

            Assert.AreEqual(expectedParameter.Name,
                actualParameter.Name,
                "Значения Name не совпадают");
            Assert.AreEqual(expectedParameter.Value,
                actualParameter.Value,
                "Значения Value не совпадают");
            Assert.AreEqual(expectedParameter.Min,
                actualParameter.Min,
                "Значения Min не совпадают");
            Assert.AreEqual(expectedParameter.Max,
                actualParameter.Max,
                "Значения Max не совпадают");
        }

        [Test(Description = "Негативный тест корректности параметра")]
        public void Parameter_CheckRange()
        {
            Assert.Throws<ArgumentException>(() =>
                {var parameter = new Parameter(
                    "Параметр первый",
                    155,
                    90,
                    100);}, "Параметр корректный");
        }
    }
}
