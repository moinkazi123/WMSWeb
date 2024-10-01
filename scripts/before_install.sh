#!/bin/bash
# Install .NET SDK if not already installed
if ! command -v dotnet &> /dev/null; then
    sudo rpm -Uvh https://packages.microsoft.com/config/rhel/7/packages-microsoft-prod.rpm
    sudo yum install -y dotnet-sdk-8.0
fi

# Create application directory if it doesn't exist
sudo mkdir -p /var/www/webapplication
