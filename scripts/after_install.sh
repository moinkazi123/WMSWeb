#!/bin/bash
# Set permissions
sudo chown -R ec2-user:ec2-user /var/www/webapplication

# Change to the application directory
cd /var/www/webapplication

# List directory contents (for debugging)
echo "Current directory contents:"
ls -la

# Check if the DLL exists
if [ -f WebApplication2.dll ]; then
    echo "WMSCOREAPI.dll found"
else
    echo "WMSCOREAPI.dll not found"
    echo "Searching for DLL:"
    find . -name "*.dll"
fi

# No need to run dotnet restore for a published application
echo "Skipping dotnet restore as this is a published application"
