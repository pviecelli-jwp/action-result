namespace ActionResult
{
    public class IsOk<T, E> : ActionResult<T, E>
    {
        internal IsOk(T value) : base(value)
        {
        }
    }
}