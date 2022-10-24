using System.Reflection;

namespace WSGYG63.Shared.Functions
{
    public class ModelToDictionary
    {
        public Dictionary<string, string?>? Trasform<TRequest>(TRequest model) =>
            model?.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .ToDictionary(
                        prop => prop.Name,
                        prop => (string)prop.GetValue(model, null)
                    );
    }
}
