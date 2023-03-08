# TodoApiHostedAzure in memory

## httprepl
https://learn.microsoft.com/en-us/aspnet/core/web-api/http-repl/?view=aspnetcore-6.0&tabs=macos <br />
Use Dotnet 6.0 <br />

### commands in terminal
> export PATH="$HOME/.dotnet/tools:$PATH" <br />
> httprepl <br />
> httprepl https://https://jarnontodo.azurewebsites.net/api/todoitems/ <br />
> post -h Content-Type=application/json -c "{"name":"walk dog","isComplete":true,"secret":"you dont see this!"}" <br />
> post -h Content-Type=application/json -c "{"name":"go to forest","isComplete":true,"secret":"this is secret data!"}" <br />
> get <br />

## Postman
Use Postman to connection -> example post JSON <br />
POST: https://jarnontodo.azurewebsites.net/api/todoitems/ <br /><br />

´´´
{ 
    "name": "walk dog",
    "isComplete": true,
    "secret": "you dont see this!"
}
´´´

