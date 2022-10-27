namespace WSGYG63.Shared.Functions
{
    public class CheckDate
    {
        public bool IsExpired(DateTime? expired)
        {
            bool success = false;

            if (expired != null)
            {
                try
                {
                    double seconds = ((DateTime)expired - DateTime.Now).TotalSeconds - 60;
                    success = seconds < 0 ? true : false;
                }
                catch (Exception e) // error en verificar tiempo, refresco token
                {
                    success = true;
                }
            } else 
                success = true;

            return success;
        }
    }
}
