namespace WSGYG63.Shared.Functions
{
    public class Log
    {
        public static void write(string data, string path, string nameController, bool initLog = false, bool finalLog = false)
        {
            string appPath = $"{path}\\DOCUMENTOS\\LOGS\\";
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(appPath + "LOG_WSGYG63_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true);

                if (initLog)
                    writer.WriteLine("************************************************************************************************************************");
                else
                    writer.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");

                writer.WriteLine("Fecha: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff"));
                writer.WriteLine(data);

                if (finalLog)
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
