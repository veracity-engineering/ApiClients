@ECHO OFF

REM Tranform openapi/swagger json file
REM lprun6 transform-openapi.linq

REM Call autorest to generate API Client code. --version 3.0.6373 is the latest working version

lprun6 transform-openapi.linq DataApi.json
autorest DataApi.autorest.yml --version:3.5

lprun6 transform-openapi.linq ProvisionApi.json
autorest ProvisionApi.autorest.yml --version:3.5

lprun6 transform-openapi.linq DataValidatorApi.json
autorest DataValidatorApi.autorest.yml --version:3.5

autorest EgestApi.autorest.yml --version:3.5
autorest IngestApi.autorest.yml --version:3.5
