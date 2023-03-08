# TodoApiHostedAzure in memory

## httprepl
https://learn.microsoft.com/en-us/aspnet/core/web-api/http-repl/?view=aspnetcore-6.0&tabs=macos
Use Dotnet 6.0

### commands in terminal
> export PATH="$HOME/.dotnet/tools:$PATH"
> httprepl
> httprepl https://https://jarnontodo.azurewebsites.net/api/todoitems/
> post -h Content-Type=application/json -c "{"name":"walk dog","isComplete":true,"secret":"you dont see this!"}"
> post -h Content-Type=application/json -c "{"name":"go to forest","isComplete":true,"secret":"this is secret data!"}"
> get

## Postman
Use Postman to connection -> example post JSON
POST: https://jarnontodo.azurewebsites.net/api/todoitems/

>{
>    "name": "walk dog",
>    "isComplete": true,
>    "secret": "you dont see this!"
>}

