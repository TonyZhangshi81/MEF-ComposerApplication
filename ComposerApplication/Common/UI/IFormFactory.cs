
namespace Tony.Common.UI
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFormFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sysMarker"></param>
        /// <param name="formKey"></param>
        /// <returns></returns>
        FormBase GetFormInstance(string sysMarker, string formKey);
    }
}
