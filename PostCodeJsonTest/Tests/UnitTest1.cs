using System;
using NUnit.Framework;

namespace PostCodeJsonTest
{
    [TestFixture]
    public class UnitTest1
    {
        PostcodeService postcodeService = new PostcodeService();
        [Test]
        public void CheckStatus()
        {
            Assert.AreEqual(200, postcodeService.postCodeDTO.PostCode.status);
        }

        [Test]
        public void CheckPostCode()
        {
            Assert.AreEqual(typeof(string), postcodeService.postCodeDTO.Results.postcode.GetType());
            Assert.AreEqual(true, postcodeService.PostCodeFormat(postcodeService.postCodeDTO.Results.postcode));
            
        }

        [Test]
        public void CheckQuality()
        {
            Assert.AreEqual(typeof(int), postcodeService.postCodeDTO.Results.quality.GetType());
            Assert.AreEqual(true, postcodeService.QualityBetween1And9(postcodeService.postCodeDTO.Results.quality));
        }

        [Test]
        public void CheckEastings()
        {
            Assert.AreEqual(true, postcodeService.StringOrInt(postcodeService.postCodeDTO.Results.eastings));
        }

        [Test]
        public void CheckNorthings()
        {
            Assert.AreEqual(true, postcodeService.StringOrInt(postcodeService.postCodeDTO.Results.northings));
        }

        [Test]
        public void CheckCountry()
        {
            Assert.AreEqual(typeof(string), postcodeService.postCodeDTO.Results.country.GetType());
            Assert.AreEqual(true,postcodeService.CountryChecker(postcodeService.postCodeDTO.Results.country));
        }

        [Test]
        public void CheckNhs()
        {
            Assert.AreEqual(true, postcodeService.StringOrNull(postcodeService.postCodeDTO.Results.nhs_ha));
            Assert.AreEqual("London", postcodeService.postCodeDTO.Results.nhs_ha);
        }

        [Test]
        public void CheckCounty()
        {
            Assert.AreEqual(true, postcodeService.StringOrNull(postcodeService.postCodeDTO.Results.admin_county));
        }

        [Test]
        public void CheckLongitude()
        {
            Assert.AreEqual(true, postcodeService.CheckDecimalPlaces(postcodeService.postCodeDTO.Results.longitude));
        }

        [Test]
        public void CheckLatitude()
        {
            Assert.AreEqual(true, postcodeService.CheckDecimalPlaces(postcodeService.postCodeDTO.Results.latitude));
        }
    }
}
