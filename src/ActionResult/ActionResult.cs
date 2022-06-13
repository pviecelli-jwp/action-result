namespace ActionResult
{
    public class ActionResult<T, E>
    {
        internal T? Value { get; set; }
        internal E? Error { get; set; }
        public bool IsSuccess { get; }

        internal ActionResult(E error)
        {
            Value = default;
            IsSuccess = false;
            Error = error;
        }

        internal ActionResult(T value)
        {
            Value = value;
            IsSuccess = true;
            Error = default;
        }

        public static ActionResult<T, E> Success(T value)
        {
            return new ActionResult<T, E>(value);
        }

        public static ActionResult<T, E> Failure(E result)
        {
            return new ActionResult<T, E>(result);
        }
    }
}