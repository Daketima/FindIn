
namespace RefreshClaimsParts
{
    public interface IAuthenticationChanges
    {/// <summary>
    /// Ths returns true is thers is no ticksToCompare or the tickToCompare is earlier than the AuthenticationLastUpdate time
    /// </summary>
    /// <param name="cachkey"></param>
    /// <param name="tickToCompareString"></param>
    /// <param name="timestore">link to the DbContext tha  manages the cache store</param>
    /// <returns></returns>
        bool IsOutOfDateOrMissing(string cachkey, string tickToCompareString, ITimeStore timestore);

        /// <summary>
        /// This adds or updates the tiestor entry with the cachekey with the cachevalue (datetime as ticks)
        /// </summary>
        /// <param name="timestore"></param>
        void AddOrUpdate(ITimeStore timestore);
    }
}
