git clone https://github.com/chupino/dotnetkafka.git dotnet
cd dotnet

docker-compose up --build -d

if [ $? -eq 0 ]; then
    echo "bien"
else
    echo "mal"
    exit 1
fi

