#!/bin/bash
# Navigate to the application directory
cd /var/www/dotnetapp

# Stop any existing application running (optional)
pkill dotnet || true

# Start the application (assuming WMSCOREAPI.dll is the entry point)
nohup dotnet WMSCOREAPI.dll > /dev/null 2>&1 &
