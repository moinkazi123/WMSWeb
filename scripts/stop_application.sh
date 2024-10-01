#!/bin/bash
# Stop any running instance of the application
if pgrep -f "dotnet.*WebApplication2.dll" > /dev/null; then
    pkill -f "dotnet.*WebApplication2.dll"
    echo "Application stopped"
else
    echo "Application is not running"
fi
