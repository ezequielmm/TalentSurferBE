FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY EY.TalentSurfer.Api/EY.TalentSurfer.Api.csproj EY.TalentSurfer.Api/
COPY EY.TalentSurfer.Dto/EY.TalentSurfer.Dto.csproj EY.TalentSurfer.Dto/
COPY EY.TalentSurfer.Support.Persistence/EY.TalentSurfer.Support.Persistence.csproj EY.TalentSurfer.Support.Persistence/
COPY EY.TalentSurfer.Support.Persistence.Sql/EY.TalentSurfer.Support.Persistence.Sql.csproj EY.TalentSurfer.Support.Persistence.Sql/
COPY EY.TalentSurfer.Domain/EY.TalentSurfer.Domain.csproj EY.TalentSurfer.Domain/
COPY EY.TalentSurfer.Support/EY.TalentSurfer.Support.csproj EY.TalentSurfer.Support/
COPY EY.TalentSurfer.Support.Api/EY.TalentSurfer.Support.Api.csproj EY.TalentSurfer.Support.Api/
COPY EY.TalentSurfer.Services/EY.TalentSurfer.Services.csproj EY.TalentSurfer.Services/
RUN dotnet restore EY.TalentSurfer.Api/EY.TalentSurfer.Api.csproj
COPY . .
WORKDIR /src/EY.TalentSurfer.Api
RUN dotnet build EY.TalentSurfer.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish EY.TalentSurfer.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EY.TalentSurfer.Api.dll"]
