namespace WSGYG63.Shared.Functions
{
    public class Log
    {
        public static void write(string data, string path, string nameController)
        {
            string appPath = $"{path}\\DOCUMENTOS\\LOGS\\";
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(appPath + "LOG_WSGYG63_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true);
                writer.WriteLine("************************************************************************************************************************");

                writer.WriteLine($"Servicio actual: {nameController}");
                writer.WriteLine(data);

                writer.WriteLine("************************************************************************************************************************");

                writer.Flush();
            }
            catch (Exception ex2){ }
            finally
            {
                if (writer != null)
                {
                    try
                    {
                        writer.Close();
                    }
                    catch (Exception ex3){ }
                }
            }
        }
    }
}
