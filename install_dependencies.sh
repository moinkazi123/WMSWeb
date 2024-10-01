#!/bin/bash
# Install .NET SDK 8.0 if not already installed
if ! dotnet --list-sdks | grep -q "8.0"; then
  echo "Installing .NET SDK 8.0..."
  wget https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm -O packages-microsoft-prod.rpm
  sudo rpm -Uvh packages-microsoft-prod.rpm
  sudo yum install -y dotnet-sdk-8.0
else
  echo ".NET SDK 8.0 is already installed."
fi
