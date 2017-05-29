using System;
using System.Configuration;
using System.IO;
using log4net;

namespace com.thingtrack.integration.service.util
{
	/// <summary>
	/// Summary description for Util.
	/// </summary>
	public class Util
	{
        private static readonly ILog log = LogManager.GetLogger(typeof(Util));

        /// <summary>
        /// Gets Values From The Config File.
        /// </summary>
        public static bool IsDirectoryPresent(string directory, bool create)
        {
            try
            {
                if (!Directory.Exists(directory))
                {
                    if (create == true)
                    {
                        Directory.CreateDirectory(directory);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.Error("Error recovering flag directory", ex);
                return false;
            }
            finally
            {
            }
        }

		/// <summary>
		/// Gets Values From The Config File.
		/// </summary>
		public static string GetSetting(string val)
		{
			try
			{
				return ConfigurationSettings.AppSettings[val];
			}
			catch (Exception ex)
			{
                log.Error("Error getting string", ex);
				return "";
			}
			finally
			{
			}
		}
	}
}
