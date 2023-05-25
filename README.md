# Calculate speedwork workouts for running.

1. Start with `dotnet run`
2. Open Chrome to `localhost:<port>/swagger`

# Documentation

## Creating .NET app
1. dotnet new webapi -o {ProjectName}
2. cd {ProjectName}
3. dotnet add package Microsoft.EntityFrameworkCore.InMemory
## Trust development cert.
1. dotnet dev-certs https --trust

## Adding packages for unit tests.
1. dotnet add package Moq
2. dotnet add package xUnit

# Progress Notes
Calculate endpoint is in place and accepting requests. As of now, it seems it is only responding with a workout of all zeros/nulls. This is difficult to debug by just hitting the endpoint through swagger, so I began writing a unit test to test this. However, I don't know how unit testing for a dotnet API works, so I need to do some reading up on that to get the tests running properly. When that is done, I can then finish the test I have in place which will hopefully allow me to debug and get the API working properly and returning a correct workout.

Once the above is complete, I would like to get this API deployed in GCP, if possible. This means deploying it (in a project that is already setup), and hitting the endpoint via postman to confirm it is deployed and accepting requests. (Side note: will I need some sort of authentication in GCP so my endpoints are secure and not able to be hit by just anyone?)

After that, I would like to add all of the workouts that I do to the constants. Then it will be plausible to stand up a UI to start using this API.