using ActionResult;
using NUnit.Framework;

namespace Action_Result_Concerns
{
    public class When_the_unwrap_is_called
    {
        [Test]
        public void Success_Unwrap()
        {
            var expected = 100;
            var result = ActionResult<int, string>.Success(expected);

            Assert.IsTrue(result.IsSuccess);
            if (result is IsOk<int, string> isOk)
            {
                Assert.AreEqual(expected, isOk.Unwrap());
            }
            else Assert.Fail("result is not IsOk type", result);
        }

        [Test]
        public void Success_UnwrapOrValue()
        {
            var expected = 100;
            var result = ActionResult<int?, string>.Success(null);

            Assert.IsTrue(result.IsSuccess);
            if (result is IsOk<int?, string> isOk)
            {
                Assert.AreEqual(expected, isOk.UnwrapOr(expected));
            }
            else Assert.Fail("result is not IsOk type", result);

        }

        [Test]
        public void Success_UnwrapOrFunction()
        {
            var expected = 100;
            var result = ActionResult<int?, string>.Success(null);

            Assert.IsTrue(result.IsSuccess);
            if (result is IsOk<int?, string> isOk)
            {
                Assert.AreEqual(expected + 10, isOk.UnwrapOr(() => expected + 10));
            }
            else Assert.Fail("result is not IsOk type", result);
        }

        [Test]
        public void Failure_UnwrapErr()
        {
            var expected = "Action failed";
            var result = ActionResult<int, string>.Failure(expected);

            Assert.IsFalse(result.IsSuccess);
            if (result is IsErr<int, string> isErr)
            {
                Assert.AreEqual(expected, isErr.UnwrapErr());
            }
            else Assert.Fail("result is not IsErr type", result);
        }
    }
}