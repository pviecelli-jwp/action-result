namespace ActionResult
{
    public class IsErr<T, E> : ActionResult<T, E>
    {
        internal IsErr(E error) : base(error)
        {
        }
    }
}