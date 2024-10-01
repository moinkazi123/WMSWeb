#!/bin/bash 
# Set permissions
sudo chown -R ec2-user:ec2-user /var/www/webapplication

# Navigate to the web application directory
cd /var/www/webapplication

# Restore dependencies if necessary
dotnet restore

# Start the application in the background
nohup dotnet WMSCOREAPI.dll > /var/log/webapplication.log 2>&1 &

# Optionally, you can print the PID of the process
echo $! > /var/run/wmscoreapi.pid
