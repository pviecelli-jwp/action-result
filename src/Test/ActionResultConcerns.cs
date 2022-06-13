using ActionResult;
using NUnit.Framework;

namespace Action_Result_Concerns
{
    public class When_the_unwrap_is_called
    {
        [Test]
        public void Success_Unwrap()
        {
            //var expected = 100;
            //var result = ActionResult<int, string>.Success(expected);

            //Assert.IsTrue(result.IsSuccess);
            //Assert.AreEqual(expected, result.Unwrap());
            //Assert.IsNull(result.UnwrapErr());
        }

        [Test]
        public void Success_UnwrapOrValue()
        {
            var expected = 100;
            //var result = new ActionResult<int, string>.Failure("Action failed");
            var result = IsErr<int, string>.Failure("Action failed");
            var result2 = new IsErr<int, string>("Action failed");

            Assert.IsFalse(result.IsSuccess);
            Assert.AreEqual(expected, result.UnwrapOr(expected));
            Assert.IsNotNull(result.UnwrapErr());
            Assert.AreEqual(default(int), result.Unwrap());
        }

        [Test]
        public void Success_UnwrapOrFunction()
        {
            //    var expected = 100;
            //    var result = ActionResult<int, string>.Failure("Action failed");

            //    Assert.IsFalse(result.IsSuccess);
            //    Assert.AreEqual(expected + 10, result.UnwrapOr(() => expected + 10));
            //    Assert.IsNotNull(result.UnwrapErr());
            //    Assert.AreEqual(default(int), result.Unwrap());
            //}

            [Test]
            public void Failure_UnwrapErr()
            {
                //var expected = "Action failed";
                //var result = ActionResult<int, string>.Failure(expected);

                //Assert.IsFalse(result.IsSuccess);
                //Assert.AreEqual(expected, result.UnwrapErr());
                //Assert.AreEqual(default(int), result.Unwrap());
            }
        }
    }