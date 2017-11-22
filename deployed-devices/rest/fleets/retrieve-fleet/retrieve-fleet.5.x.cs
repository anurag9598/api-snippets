// Get the C# helper library from https://twilio.com/docs/libraries/csharp
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Preview.DeployedDevices;

public class Example
{
    public static void Main(string[] args)
    {
        // Get your Account SID and Auth Token from https://twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        TwilioClient.Init(accountSid, authToken);

        const string fleetSid = "FLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        var fleet = FleetResource.Fetch(fleetSid);

        Console.WriteLine(fleet.Sid);
    }
}
