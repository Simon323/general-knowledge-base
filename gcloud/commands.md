## Table of Contents

- [Table of Contents](#table-of-contents)
- [Init](#init)
- [Config list](#config-list)
- [Set region](#set-region)
- [List projects](#list-projects)
- [Set project](#set-project)
- [Auth list](#auth-list)
- [Login](#login)
- [List components / install / use / update](#list-components--install--use--update)
- [Local credentials](#local-credentials)
- [Auth token](#auth-token)
- [List functions](#list-functions)
- [Invoke function](#invoke-function)

## Init

```bash
gcloud init
```

## Config list

```bash
gcloud config list
```

## Set region

```bash
gcloud config set compute/region europe-west1
```

## List projects

```bash
gcloud projects list
```

## Set project

```bash
gcloud config set project PROJECT_ID
```

## Auth list

```bash
gcloud auth list
```

## Login

```bash
gcloud auth login your@email.com
```

## List components / install / use / update

```bash
gcloud components list
gcloud components install component_name_id
gcloud component_name_id
gcloud components update
```

## Local credentials

```bash
gcloud auth application-default login
```

## Auth token

```bash
gcloud auth print-access-token
```

## List functions

```bash
gcloud functions list
```

## Invoke function

```bash
gcloud functions call function_name --data={} --region=europe-west3
```
