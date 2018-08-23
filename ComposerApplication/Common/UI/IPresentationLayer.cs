using System;

namespace Tony.Common.UI
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPresentationLayer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="controlId"></param>
        /// <returns></returns>
        string GetControlValue(string controlId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        object GetFormProperty(string propertyName);
    }
}
