function Build-Project {
    param (
        [string]$projectDir
    )
    Write-Output "Building $projectDir..."
    Set-Location $projectDir
    dotnet build
    if ($LASTEXITCODE -ne 0) {
        Write-Output "Build failed for $projectDir"
        exit 1
    }
    Set-Location ..
}

function Run-Tests {
    param (
        [string]$testProjectDir
    )
    Write-Output "Running tests in $testProjectDir..."
    Set-Location $testProjectDir
    dotnet test
    if ($LASTEXITCODE -ne 0) {
        Write-Output "Tests failed in $testProjectDir"
        exit 1
    }
    Set-Location ..
}

Write-Output "Starting CI process..."

$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path

Set-Location $scriptDir

$projects = @("Calculator.Model", "Calculator.ViewModel", "Calculator.View")
foreach ($project in $projects) {
    $projectDir = Get-ChildItem -Directory -Filter $project -Recurse -ErrorAction SilentlyContinue | Select-Object -First 1
    if ($projectDir) {
        Build-Project $projectDir.FullName
    } else {
        Write-Output "Project $project not found."
        exit 1
    }
}

$testProjectDir = Get-ChildItem -Directory -Filter "TestProject" -Recurse -ErrorAction SilentlyContinue | Select-Object -First 1
if ($testProjectDir) {
    Run-Tests $testProjectDir.FullName
} else {
    Write-Output "Test project not found."
    exit 1
}

Write-Output "CI process completed successfully."