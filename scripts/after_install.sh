#!/bin/bash
# Set permissions
sudo chown -R ec2-user:ec2-user /var/www/webapplication

# Install any dependencies (if needed)
cd /var/www/webapplication
dotnet restore
