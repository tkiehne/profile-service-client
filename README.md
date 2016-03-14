# .NET Profile Service API Client (profile-service-client)

An example of an API wrapper that enables a .NET Web application to consume a REST-based user profile management API.  The API that is consumed by this client was developed on behalf of a major US corporation.

At the time of this writing (2016-03-14) the API is about to be deprecated, [documentation](https://profiles.purina.com/apiconsole.html) still exists however.

The source was built in Visual Studio 2012 with .NET Framework 4.5

## Usage

1. Build the dll from source
2. Import the dll into your .NET project and add 'PProfileAPIClient' as a reference 
3. Create the API object as follows:

    ApiClient(string clientId, string clientSecret, bool uat = false)

4. Perform operations against the API object as desired

Note: API keys are provided by the API vendor