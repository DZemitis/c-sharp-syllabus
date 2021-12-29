using Exercise_6;
using Xunit;

namespace Exercise_6Tests
{
    public class MakeArrayTests
    {
        private readonly MakeArray _target;

        public MakeArrayTests()
        {
            _target = new MakeArray();
        }

        [Fact]
        public void ArraysAreRandom_Array1IsDifferentFromArray2_ShouldBeDifferent()
        {
            // Act
            var array1 = _target.RandomArray();
            var array2 = _target.RandomArray();

            // Assert
            Assert.NotEqual(array1, array2);
        }

        [Fact]
        public void CloneChangeLast_ArraysAreDifferent_ShouldBeDifferent()
        {
            // Act
            var array1 = _target.RandomArray();
            var array2 = _target.CloneChangeLastNegative7();

            // Assert
            Assert.NotEqual(array1, array2);
        }

        [Fact]
        public void CloneChangeLast_LastIndexIsNegative7_ShouldBeMatch()
        {
            // Act
            var array2 = _target.CloneChangeLastNegative7();

            // Assert
            Assert.Equal(-7, array2[9]);
        }

        [Fact]
        public void PrintArray_ArrayReturnString_ShouldPass()
        {
            // Act
            _target.PrintArray("Target");

            // Assert
            Assert.Contains("Target", _target.PrintArray("Target"));
        }
    }
}
