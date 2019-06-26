FROM microsoft/dotnet:sdk
RUN mkdir app
WORKDIR /app
COPY . .
ENV SQLSERVER_CONNECTIONSTRING='Server=sqlserver;Database=myapp;User=sa;Password=Password_123;MultipleActiveResultSets=true;'
# RUN chmod +x startup.sh
# CMD dotnet watch run --urls "http://0.0.0.0:5000;https://0.0.0.0:5001"
ENTRYPOINT ./startup.sh