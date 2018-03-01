namespace BrowserHistoryDemoLib.ViewModels
{
    using System.Collections.Generic;

    /// <summary>
    /// Implements a sample location item that demos how a location
    /// can be recorded, handled, and logged in an application.
    /// </summary>
    public class LocationItem : IEqualityComparer<LocationItem>
    {
        #region ctors
        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="path"></param>
        public LocationItem(string path)
            : this()
        {
            Path = path;
        }

        /// <summary>
        /// Hidden class constructor.
        /// </summary>
        protected LocationItem()
        {
        }
        #endregion ctors

        /// <summary>
        /// Gets a path to a location that is indicated by this object.
        /// </summary>
        public string Path { get; }

        #region methods
        /// <summary>
        /// Determines whether 2 objects are in holding the same information or not.
        /// Implements the <see cref="IEqualityComparer{T}"/> interface.
        /// 
        /// Method is used in the <see cref="IBrowseHistory{T}"/>.Forward() method
        /// implementation to reduce redundancies in multiple requests for browsing
        /// to the same (current) loaction. The equality is used here too determine
        /// what the same location is and stop adding another location when the previously
        /// added location is the same as the current location.
        /// </summary>
        /// <param name="parx"></param>
        /// <param name="pary"></param>
        /// <returns></returns>
        public bool Equals(LocationItem parx, LocationItem pary)
        {
            if (parx == null && pary != null || parx != null && pary == null)
                return false;

            return string.Compare(parx.Path, pary.Path, true) == 0;
        }

        /// <summary>
        /// Gets the hashcode of this object.
        /// Implements the <see cref="IEqualityComparer{T}"/> interface.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(LocationItem obj)
        {
            return obj.GetHashCode();
        }

        /// <summary>
        /// Determines whether 2 objects are holding the same information or not.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public new bool Equals(object x, object y)
        {
            return Equals(x as LocationItem, y as LocationItem);
        }

        /// <summary>
        /// Gets the hashcode of this object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(object obj)
        {
            return GetHashCode(obj as LocationItem);
        }
        #endregion methods
    }
}
