# Changelog from git

## Simple way

### 1. Log
Use this command:
```bash
$ git log
```

Output:
```bash
commit 97fcec635de4357c60758b00435d89fcf03e3302 (HEAD -> main, origin/main)
Author: Szymon Miękus <miekusoft@gmail.com>
Date:   Wed Jul 26 23:29:16 2023 +0200

    asp - validator samples

commit 78506ea4d4d648fc77ff36442d6158074b0f8324
Author: Szymon Miękus <miekusoft@gmail.com>
Date:   Mon Jul 24 22:28:58 2023 +0200

    add license
```

-----------

### 2. Decorated log
Use this command:
```bash
$ git log --oneline --decorate
```

Output:
```bash
97fcec6 (HEAD -> main, origin/main) asp - validator samples
78506ea add license
5a33ee0 add readme.md
45863eb youtube - table of contents test
a57e02e chromecast - useful sources
d46f79e bootstrap - useful classes
3333fb6 youtube - new dotnet content
7519787 youtube - dotnet & fix format
2bc3c23 youtube - Fix formating
32d3b53 youtube - Fix link
9b2ba46 youtube - Useful links
```

----

### 3. Log pretty short
Use this command:
```bash
$ git log --pretty="- %s" > CHANGELOG.md"
```

Output:
```bash
asp - validator samples
add license
add readme.md
youtube - table of contents test
chromecast - useful sources
bootstrap - useful classes
youtube - new dotnet content
youtube - dotnet & fix format
youtube - Fix formating
youtube - Fix link
youtube - Useful links
```

---

## Sophisticated way

### Auto generated changelog
Install this node package:
```bash
npm install generate-changelog -g 
```

Generate changelog:
```bash
$ changelog generate
```

Read this: https://github.com/lob/generate-changelog
In changelog you will find instruction how should describe your commits.