using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReservationProject.Domain;
using ReservationProject.Domain.Repos;
using ReservationProject.Facade;
using ReservationProject.Pages;



namespace ReservationProject.Tests.Pages
{
    [TestClass]
    public class ReservationsModelTests : BasePageTests<ReservationEntity, ReservationView>
    {
        private class TestReservationRepo : TestRepo<ReservationEntity>, IReservationsRepo { }

        [TestInitialize]
        public void TestInitialize()
        {
            MockRepo = new TestReservationRepo();
            PageModel = new ReservationsPage((IReservationsRepo) MockRepo);
        }
    }
}