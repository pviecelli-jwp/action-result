namespace ActionResult
{
    public class IsOk<T, E> : ActionResult<T, E>
    {
        internal IsOk(T value) : base(value)
        {
        }

        public static IsOk<T, E> Success(T value)
        {
            return new IsOk<T, E>(value);
        }
    }
}