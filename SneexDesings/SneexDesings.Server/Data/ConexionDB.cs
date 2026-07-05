namespace SneexDesings.Server.Data
{
    public class ConexionDB
    {
        private static string _server = "ep-polished-voice-atpcakcx-pooler.c-9.us-east-1.aws.neon.tech";
        private static string _database = "DesingsDB";
        private static string _port = "5432";
        private static string _user = "neondb_owner";
        private static string _pass = "npg_LpNdhQ2DMlR9";
        private static string _cadena = $"server={_server};port={_port};user id={_user};password={_pass};database={_database};";

        public static string GetConnection()
        {
            return _cadena;
        }
    }
}
