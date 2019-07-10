namespace ApiJson.Common
{
    using SqlSugar;
    public class DbOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public DbType DbType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ConnectionString { get; set; }
    }
}
