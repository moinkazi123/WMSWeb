#!/bin/bash
# Start the application
cd /var/www/webapplication

# Find the main DLL (assuming it's the only one or the first one found)
MAIN_DLL=$(find . -maxdepth 1 -name "*.dll" | head -n 1)

if [ -z "$MAIN_DLL" ]; then
    echo "No DLL found in the current directory"
    exit 1
else
    echo "Starting application with: $MAIN_DLL"
    nohup dotnet "$MAIN_DLL" --urls "http://*:5100;http://localhost:5101" > /var/log/webapplication.log 2>&1 &
fi

echo "Application started"
