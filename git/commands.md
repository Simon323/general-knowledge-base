# Git commands

## Table of Contents

- [Brancher](#branches)
- [Commit](#commit)
- [Cleaning](#cleaning)
- [Origin](#origin)
- [Merge](#merge)
- [Stash](#stash)
- [Config](#config)
- [Diff](#diff)
- [Log](#log)
- [Tag](#tag)
- [Pull](#pull)

------------------------------------------------------

## Branches

### List all branches:
```bash
$ git branch -a
```

### List only remote baranch
```bash
$ git branch -r
```

### New baranch checkout
```bash
$ git checkout -b ABS-760 remotes/origin/ABS-760
```

### Fetch new branches
```bash
$ git fetch -v --progress "origin"
```

### Clean branches localy
```bash
$ git remote prune origin --dry-run
$ git remote prune origin
```

### Delete remote branch
```bash
$ git push origin --delete my-branch-name
```

### Delete local branch
```bash
$ git branch -d my-branch-name
```

### Create new branch localy
```bash
$ git checkout -b my-branch-name
```

### Checkout to another local branch
```bash
$ git checkout my-branch-name
```

### Checkout to remote branch
```bash
$ git checkout --track origin/my-branch-name
```

### Push if branch not exists
```bash
$ git push -u origin local-branch:newest-remote-branch
```

### Push with creation
```bash
$ git push --set-upstream origin new_branch ???
$ git push origin master:new_branch
```

### Delete local baranch
```bash
$ git branch -d localBranchName
```

---------------------------------------------------------

## Commit

### Remove last commit from remote
```bash
$ git reset HEAD^
$ git push -u origin master --force
```

### Set commit date
```bash
$ git commit --date="2021-01-01 12:12:00 +0100" -m "message"
```

---------------------------------------------------------

## Cleaning

### Clean all, clone repo effect:
```bash
$ git clean -fx -d
```

### Git reset last commit local
```bash
$ git reset HEAD~ --soft
$ git reset --soft HEAD~1
$ git reset --hard commit_hash
```

---------------------------------------------------------

## Origin

### List origins
```bash
$ git remote -v
```

### Add origin
```bash
$ git remote add origin https://github.com/..../repos.git
```

---------------------------------------------------------

## Merge

### Merge
```bash
$ git merge my-baranch-name
```

### Abort merge
```bash
$ git merge --abort
```

---------------------------------------------------------

## Stash

### Stash changes
```bash
$ git stash
```

### List stash list
```bash
$ git stash list
```

### Apply stash changes
```bash
$ git stash apply
```

---------------------------------------------------------

## Config

### CRLF LF Issue
```bash
$ git config --global core.autocrlf true
```

### List configurations
```bash
$ git config -l
```
  
### Set user & email local
```bash
$ git config user.name "FIRST_NAME LAST_NAME"
$ git config user.email "MY_NAME@example.com"
```

### Set user & email global
```bash
$ git config --global user.name "FIRST_NAME LAST_NAME"
$ git config --global user.email "MY_NAME@example.com"
```

### Diff account in new repo:
```bash
$ git config --local credential.helper ""
```

---------------------------------------------------------

## Diff

### List lines with issues
```bash
$ git diff --check
```

### List conflict files
```bash
$ git diff --name-only --diff-filter=U
```

---------------------------------------------------------

## Log

### Rewrite git log info
```bash
$ git rebase -r --root --exec "git commit --amend --no-edit --reset-author"
```

### Git log
```bash
$ git log --oneline --decorate
$ git log --pretty="%s"
$ git log --pretty="- %s"
```

### Filter logs
```bash
git log --all --author="John Doe" --pretty=format:"%C(yellow)%h%C(reset) %C(green)%ad%C(reset) %C(cyan)%an%C(reset) %s" --date=short --since="2023-01-01" --until="2023-12-31"
```

---------------------------------------------------------

## Tag

### Create tag
```bash
$ git tag <tagname>
$ git push origin --tags
```

### Delete Tag
```bash
git tag -d tag_name
git push origin --delete tag_name
```

---------------------------------------------------------

## Pull

### Git pull
```bash
$ git.exe pull --progress -v --no-rebase "origin"
```
