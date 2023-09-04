using BitArrayItemsIntersection.Library;

namespace BitArrayItemsIntersection.Testing;

public class CustomBooleanArrayTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestContentByDefault_TestCase_1()
    {
        const byte dimensionLength_X = 3;
        const byte dimensionLength_Y = 3;

        bool[,] actualResult = new CustomBooleanArray(
            dimensionLength_X, dimensionLength_Y).Content;

        bool[,] expectedResult = new[,]
        {
            { false, false, false },
            { false, false, false },
            { false, false, false }
        };

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void TestContentByDefault_TestCase_2()
    {
        Assert.That(
            actual: new CustomBooleanArray(
                dimension_X: 7, dimension_Y: 4)
                    .Content,
            expression: Is.EqualTo(new bool[,]
                {
                    { false, false, false, false },
                    { false, false, false, false },
                    { false, false, false, false },
                    { false, false, false, false },
                    { false, false, false, false },
                    { false, false, false, false },
                    { false, false, false, false }
                }
            )
        );
    }

    [Test]
    public void TestContentByDefault_TestCase_3()
    {
        Assert.That(
            actual: new CustomBooleanArray(
                dimension_X: 4, dimension_Y: 7)
                    .Content,
            expression: Is.EqualTo(new bool[,]
                {
                    { false, false, false, false, false, false, false },
                    { false, false, false, false, false, false, false },
                    { false, false, false, false, false, false, false },
                    { false, false, false, false, false, false, false }
                }
            )
        );
    }
}