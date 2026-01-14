FROM mcr.microsoft.com/dotnet/sdk:8.0

# インストール
RUN apt-get update && apt-get install -y \
    git \
    curl \
    sudo \
    && rm -rf /var/lib/apt/lists/*

# ワークスペース設定
WORKDIR /workspace