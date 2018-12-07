using VSpackages.Models;
using Xunit;

namespace VSPacages.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCHangeProductName()
        {
            // �����������
            var p = new Product { Name = "Test", Price = 100M };
            // ��������
            p.Name = "New Name";
            // �����������
            Assert.Equal("New Name", p.Name);
        }
        [Fact]
        public void CanChangeProductPrice()
        {
            // org
            var p = new Product { Name = "TEst", Price = 100M };
            // do
            p.Price = 200M;
            // answer
            Assert.Equal(200M, p.Price);
        }
    }
}
