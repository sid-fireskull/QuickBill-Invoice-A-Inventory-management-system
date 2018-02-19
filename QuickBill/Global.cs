using System;
using System.Data.SqlServerCe;
using System.Reflection;
using System.Text;

namespace QuickBill
{
    internal static class Global
    {
        
        public static readonly String DB_NAME_PREFIX ;
        public static readonly string ROOT_DATA_FOLDER;
        static Global()
        {
            DB_NAME_PREFIX = AssemblyTitle + "-QB";
            ROOT_DATA_FOLDER = AssemblyTitle + "-Data";
        }
        public static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }
        public static string getExceptionText(Exception ex)
        {
            if (ex == null)
            {
                return string.Empty;
            }

            if (ex.GetType() == typeof(SqlCeException))
            {
                return getSQLCEExceptionText((SqlCeException)ex);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(string.IsNullOrWhiteSpace(ex.Message) ? "" : ex.Message);

            string str;
            while ((ex = ex.InnerException) != null)
            {
                str = ex.Message;
                if (!string.IsNullOrWhiteSpace(str))
                {
                    sb.Append("\n" + str);
                }
            }
            return sb.ToString();
        }

        private static string getSQLCEExceptionText(SqlCeException ex)
        {
            if (ex == null)
            {
                throw new ArgumentNullException("Argument can't be null");
            }

            StringBuilder sb = new StringBuilder();
            foreach (SqlCeError error in ex.Errors)
            {
                sb.AppendLine(error.Message);
            }

            return sb.ToString();
        }

        
    }
}
