using Tyuiu.MalcevDV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MalcevDV.Sprint0.Task2.V0.Test
{
    public class DeteServiceTest
    {
        [Fact]
        public void CheckGetMessageValid()
        {
            var name = "�����";
            var res = DataService.GetMessage(name);
            Assert.Equal("������, �����", res);
        }
    }
}