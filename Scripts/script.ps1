# URL репозитория
$REPO_URL = "https://github.com/thebrokenblow/Calculator.git"

# Директория для клонирования репозитория
$CLONE_DIR = "Calculator"

# Функция для клонирования репозитория
function Clone-Repo {
    if (Test-Path $CLONE_DIR) {
        Write-Output "Removing existing directory $CLONE_DIR..."
        Remove-Item $CLONE_DIR -Recurse -Force
    }
    Write-Output "Cloning repository $REPO_URL into $CLONE_DIR..."
    git clone $REPO_URL $CLONE_DIR
    if ($LASTEXITCODE -ne 0) {
        Write-Output "Clone failed for $REPO_URL"
        exit 1
    }
}

# Функция для сборки проекта
function Build-Project {
    param (
        [string]$projectDir
    )
    Write-Output "Building $projectDir..."
    Set-Location $projectDir
    # Замените эту команду на ту, которая используется для сборки вашего проекта
    # Например, для C# проектов это может быть dotnet build или msbuild
    dotnet build
    if ($LASTEXITCODE -ne 0) {
        Write-Output "Build failed for $projectDir"
        exit 1
    }
    Set-Location ..
}

# Функция для запуска тестов
function Run-Tests {
    param (
        [string]$testProjectDir
    )
    Write-Output "Running tests in $testProjectDir..."
    Set-Location $testProjectDir
    # Замените эту команду на ту, которая используется для запуска тестов вашего проекта
    # Например, для C# проектов это может быть dotnet test
    dotnet test
    if ($LASTEXITCODE -ne 0) {
        Write-Output "Tests failed in $testProjectDir"
        exit 1
    }
    Set-Location ..
}

# Основной скрипт
Write-Output "Starting CI process..."

# Клонирование репозитория
Clone-Repo

# Переход в директорию клонирования
Set-Location $CLONE_DIR

# Сборка проектов в указанном порядке
Build-Project "Calculator.Model"
Build-Project "Calculator.ViewModel"
Build-Project "Calculator.View"

# Запуск тестов
Run-Tests "TestProject"

Write-Output "CI process completed successfully."