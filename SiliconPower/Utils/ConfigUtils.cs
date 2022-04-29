namespace SiliconPower.Utils
{
    public class ConfigUtils
    {
        private static IConfigurationRoot _configuration;
        public static IConfigurationRoot Configuration
        {
            get
            {
                if (_configuration == null)
                {
                    var configurationBuilder = new ConfigurationBuilder();
                    configurationBuilder.AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true);
                    _configuration = configurationBuilder.Build();
                }
                return _configuration;
            }
        }

        public static string DSN => Configuration.GetValue<string>("DSN");
        public static bool IsDebug => Configuration.GetValue("Debug", false);
       
    }
}
