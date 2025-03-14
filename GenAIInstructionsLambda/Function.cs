using Amazon.Lambda.Core;
using Newtonsoft.Json.Linq;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace GenAIInstructionsLambda;

public class Function
{
    public string FunctionHandler(JObject input, ILambdaContext context)
    {
        return ("Hello From Lambda: " + input.ToString());
    }
}