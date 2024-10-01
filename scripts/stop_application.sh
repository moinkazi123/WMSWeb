#!/bin/bash
# Stop any running instance of the application
if pgrep -f "dotnet.*WMSCOREAPI.dll" > /dev/null; then
    pkill -f "dotnet.*WMSCOREAPI.dll"
    echo "Application stopped"
else
    echo "Application is not running"
fi
