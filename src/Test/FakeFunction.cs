using ActionResult;
using NUnit.Framework;

namespace FakeFunction
{
    internal class ActionResult_Inside_A_Function
    {
        private static ActionResult<int, string> OddOrEven(int i)
        {
            return (i % 2 == 0)
                ? ActionResult<int, string>.Success(i)
                : ActionResult<int, string>.Failure("I'm odd");
        }

        [Test]
        public void Function_returns_IsOk()
        {
            var expected = 100;

            var result = OddOrEven(expected);

            Assert.IsInstanceOf<IsOk<int, string>>(result);
            Assert.IsTrue(result.IsSuccess);

            if (result is IsOk<int, string> isOk)
            {
                Assert.AreEqual(expected, isOk.Unwrap());
            }
            else Assert.Fail("result is not IsOk type", result);
        }

        [Test]
        public void Function_returns_IsErr()
        {
            var expected = "I'm odd";

            var result = OddOrEven(99);

            Assert.IsInstanceOf<IsErr<int, string>>(result);
            Assert.IsFalse(result.IsSuccess);

            if (result is IsErr<int, string> isErr)
            {
                Assert.AreEqual(expected, isErr.UnwrapErr());
            }
            else Assert.Fail("result is not IsErr type", result);
        }
    }
}
