namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
        Assert.True(true);
    }
    
    [Fact]
    public void Test2()
    {
        //this was bad
        Assert.False(false);
        //or not
    }
}
