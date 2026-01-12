FROM mcr.microsoft.com/dotnet/sdk:8.0

# インストール
RUN apt-get update && apt-get install -y \
    git \
    curl \
    && rm -rf /var/lib/apt/lists/*

# VS Code用ユーザー作成
RUN useradd -m -s /bin/bash vscode

# ワークスペース設定
WORKDIR /workspace

# 実行ユーザー
USER vscode
