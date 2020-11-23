namespace Application.UseCases.GetUser
{
    /// <summary>
    ///     Output Port.
    /// </summary>
    public interface IOutputPort
    {
        /// <summary>
        ///     Invalid input.
        /// </summary>
        void Invalid();

        /// <summary>
        ///     Account closed.
        /// </summary>
        void NotFound();

        /// <summary>
        ///     Account closed.
        /// </summary>
        void Ok(UserModel account);
    }
}