using System.Collections.Generic;

namespace WTelegram
{
    public class CustomDevice
    {
        /// <summary>
        /// iPhone 15 Pro Max
        /// </summary>
        public List<string> device_models { get; set; }
        /// <summary>
        /// 17.4
        /// </summary>
        public List<string> system_versions { get; set; }
        /// <summary>
        /// Telegram iOS (28429)
        /// </summary>
        public List<string> app_versions { get; set; }


        ///// <summary>
        ///// 17.4
        ///// </summary>
        //public string system_version { get; set; }
        ///// <summary>
        ///// Telegram iOS (28429)
        ///// </summary>
        //public string app_version { get; set; }
    }
}
