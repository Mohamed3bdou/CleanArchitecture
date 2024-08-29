namespace CleanArchitecture.Data.AppMetaData
{
    public class Router
    {
        public const string root = "api";
        public const string version = "V1";
        public const string Rule = root + "/" + version;
        public static class StudentRouting
        {
            public const string Prefix = Rule + "/" + "Student";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + "/{id}";
            public const string Create = Prefix + "/Create";
            public const string Update = Prefix + "/Update";
            public const string Delete = Prefix + "/{id}";
        }
    }
}
