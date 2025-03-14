using Amazon.Lambda.Core;
using System.Text.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace GenAIInstructionsLambda;

public class Function
{
    public class Input
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
        // Add other properties as needed
    }

    /// <summary>
    /// A simple function that takes an input object and returns a greeting message.
    /// </summary>
    /// <param name="input">The event for the Lambda function handler to process.</param>
    /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>
    public string FunctionHandler(Input input, ILambdaContext context)
    {
        string serialized = JsonSerializer.Serialize(input);
        return ("Hello From Lambda: " + serialized);
    }
}