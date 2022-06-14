namespace ActionResult
{
    public static class ActionResultExtensions
    {
        /// <summary>
        /// Returns the IsOk Value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="actionResult"></param>
        /// <returns></returns>
        public static T? Unwrap<T, E>(this IsOk<T, E> actionResult)
        {
            if (actionResult is null)
            {
                throw new ArgumentNullException(nameof(actionResult));
            }
            return actionResult.Value;
        }

        /// <summary>
        /// Returns the IsOk Value if not null, else returns defaultValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="actionResult"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T? UnwrapOr<T, E>(this IsOk<T, E> actionResult, T? defaultValue = default)
        {
            if (actionResult is null)
            {
                throw new ArgumentNullException(nameof(actionResult));
            }
            return (actionResult.IsSuccess && actionResult.Value is not null)
                ? actionResult.Value
                : defaultValue;
        }

        /// <summary>
        /// Returns the IsOk Value if not null, else executes function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="E"></typeparam>
        /// <param name="actionResult"></param>
        /// <param name="fn"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T UnwrapOr<T, E>(this IsOk<T, E> actionResult, Func<T> fn)
        {
            if (actionResult is null)
            {
                throw new ArgumentNullException(nameof(actionResult));
            }
            if (fn is null)
            {
                throw new ArgumentNullException(nameof(fn));
            }
            return (actionResult.IsSuccess && actionResult.Value is not null)
                ? actionResult.Value
                : fn.Invoke();
        }

        /// <summary>
        /// Returns the IsErr error
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="actionResult"></param>
        /// <returns></returns>
        public static E? UnwrapErr<T, E>(this IsErr<T, E> actionResult)
        {
            if (actionResult is null)
            {
                throw new ArgumentNullException(nameof(actionResult));
            }
            return actionResult.Error;
        }
    }
}
