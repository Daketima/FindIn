namespace RefreshClaimsParts
{
    /// <summary>
    /// Access to the timestor part of the ExtraAuthorixerDbContext
    /// </summary>
    public interface ITimeStore
    {
        /// <summary>
        /// This reads the tiestore entry with the given key
        /// </summary>
        /// <param name="key"> the cache key</param>
        /// <returns></returns>
        long? GetValueFromStore(string key);

        /// <summary>
        /// This adds or updates the TimeStore entry defined b the key
        /// </summary>
        /// <param name="key">the cche key</param>
        /// <param name="ticks">the new DateTime ticks value</param>
        void AddUpdateValue(string key, long ticks);
    }
}
