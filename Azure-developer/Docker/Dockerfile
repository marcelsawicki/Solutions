FROM microsoft/aspnetcore:latest
WORKDIR /apps/ContonsoApp
COPY ./ .
RUN powershell ./setupScript.ps1
CMD ["dotnet", "ContonsoApp.dll"]