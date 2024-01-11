namespace VStay_Backend.Config
{
    public static class DatabaseConfig
    {
        /// <summary>
        /// The configuration inject.
        /// </summary>
        private static IConfiguration? _configuration;


        /// <summary>
        /// Intilialize the configuration interface.
        /// </summary>
        /// <param name="configuration">The configuration DI.</param>
        public static void Intitialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Gets the connection value to connect database.
        /// </summary>
        /// <param name="key">The key in the file appsetting.json, by default the key is "VStayDatabase"</param>
        /// <returns>The connection string database.</returns>
        public static string GetConnectionString(string key = "VStayDatabase")
        {
            return _configuration.GetConnectionString(key);
        }

    }
}
