namespace ActionResult
{
    public static class ActionResultExtensions
    {
        /// <summary>
        /// Returns the ActionResult Value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="actionResult"></param>
        /// <returns></returns>
        public static T? Unwrap<T, E>(this ActionResult<T, E> actionResult)
        {
            return actionResult.Value;
        }

        /// <summary>
        /// Returns the ActionResult Value if not null, else returns defaultValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="actionResult"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T UnwrapOr<T, E>(this ActionResult<T, E> actionResult, T defaultValue)
        {
            return (actionResult.IsSuccess && actionResult.Value is not null)
                ? actionResult.Value
                : defaultValue;
        }

        /// <summary>
        /// Returns the ActionResult error
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="actionResult"></param>
        /// <returns></returns>
        public static E? UnwrapErr<T, E>(this ActionResult<T, E> actionResult)
        {
            return actionResult.Error;
        }
    }
}
