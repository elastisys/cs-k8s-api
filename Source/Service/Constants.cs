namespace Glasswall.CloudProxy.Api
{
    public static class Constants
    {
        public const string REPORT_XML_FILE_NAME = "report.xml";
        public const string TRANSACTION_STORE_PATH = "/mnt/stores/transactions";
        public const string STAR = "*";
        public const string CORS_POLICY = "GWApiPolicy";

        public static class Header
        {
            public const string FILE_ID = "X-Adaptation-File-Id";
            public const string VIA = "Via";
            public const string ACCESS_CONTROL_EXPOSE_HEADERS = "Access-Control-Expose-Headers";
            public const string ACCESS_CONTROL_ALLOW_HEADERS = "Access-Control-Allow-Headers";
            public const string ACCESS_CONTROL_ALLOW_ORIGIN = "Access-Control-Allow-Origin";
        }

        public static class EnvironmentVariables
        {
            public const string AWS_ACCESS_KEY_ID = "AwsAccessKeyId";
            public const string AWS_SECRET_ACCESS_KEY = "AwsSecretAccessKey";
        }
    }
}
