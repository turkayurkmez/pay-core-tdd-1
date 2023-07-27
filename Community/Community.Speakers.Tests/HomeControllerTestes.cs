using Comminity.Speakers.API.Controllers;
using Community.Application;
using Community.Entities;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Community.Speakers.Tests
{
    public class HomeControllerTestes
    {

        /*
         * As a [Role]
         * I want to
         * So that
         * 
         * Bir konferans organiztörü olarak
         * Uygun konuşmacıları aramak istiyorum
         * Böylece, onlarla organizasyon için iletişim kurabilirim.
         * 
         * Given...(Ben bir konf. organiztörüyüm)  
         *         (Düşündüğüm bir konuşmacı var)
         * When... (Konuşmacıları ada göre aradığımda) 
         * Then ... (Adında aradığım isim olan konuşmacılar gelecek )
         * 
         * 
         *  Given...(Ben bir konf. organiztörüyüm)  
         *         (Düşündüğüm bir konuşmacı var)
         * When... (Konuşmacıları ada göre aradığımda) 
         * Then ... (Soyadında aradığım isim olan konuşmacılar gelecek )
         *
         * 
         */
        //[Fact]
        //public void ItExists()
        //{
        //    var controller = new Comminity.Speakers.API.Controllers.SpeakerController();
        //    var result = controller.Search("M");
        //}
        SpeakerController speakerController;
        Mock<ISpeakerService> mockSpeakerService;

        public HomeControllerTestes()
        {
            Speaker speaker = new Speaker { FirstName = "Mock", LastName = "Speaker" };

            //Tamamen test için kullanılacak çalışıyormuş gibi yapacak fakat aslında DI için kullanacağnız sahte bir nesne:
            mockSpeakerService = new Mock<ISpeakerService>();
            //ve hangi metodu çağırırsan nasıl davranacak:
            mockSpeakerService.Setup(sp => sp.GetSpeakersByName(It.IsAny<string>())).Returns(() => new List<Speaker>() { speaker });
            speakerController = new SpeakerController(mockSpeakerService.Object);
        }
        [Fact]
        public void It_Return_OkObjectResult()
        {

            var result = speakerController.Search("M");

            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void It_Returns_Collection()
        {

            var result = speakerController.Search("M") as OkObjectResult;

            Assert.NotNull(result);
            Assert.NotNull(result.Value);
            Assert.IsType<List<Speaker>>(result.Value);

        }

        [Fact]
        public void Given_FullMatch_Name_Then_One_Speaker_In_Collection()
        {

            var result = speakerController.Search("Mock") as OkObjectResult;

            var speakers = ((IEnumerable<Speaker>)result.Value).ToList();

            Assert.Equal(1, speakers.Count);
            Assert.Equal("Mock", speakers[0].FirstName);
            //Assert.IsType<List<Speaker>>(result.Value);

        }



    }
}