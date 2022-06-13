namespace ActionResult
{
    public class IsErr<T, E> : ActionResult<T, E>
    {
        public IsErr(E error) : base(error)
        {
        }

        public static IsErr<T, E> Failure(E error)
        {
            return new IsErr<T, E>(error);
        }
    }
}