FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder

WORKDIR /app

COPY AnimalsOOP.sln ./
COPY ./src/ ./src/

RUN dotnet restore \
	&& dotnet build AnimalsOOP.sln -c Release -o ./bin/Release/Release

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runner

COPY --from=builder /app/bin/Release/Release/ProgrammingFundamentals.AnimalsOOP.dll ./ProgrammingFundamentals.AnimalsOOP.dll

CMD ["dotnet", "run", "ProgrammingFundamentals.AnimalsOOP.dll"]