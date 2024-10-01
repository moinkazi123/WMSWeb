#!/bin/bash
# Start the application
cd /var/www/webapplication
nohup dotnet WebApplication2.dll --urls "http://*:5100;http://localhost:5101" > /var/log/webapplication.log 2>&1 &

echo "Application started"
