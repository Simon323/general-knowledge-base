# How generate & use SSH github
1. Git Bash -> Default location
2. cd .ssh
3. ssh-keygen
4. Copy: cat /c/Users/info/.ssh/id_rsa.pub
5. Paste in SSH and GPG keys
6. Remember pass in mind

# Set shh in existing repo
1. git remote -v
2. git remote set-url origin git@github.com:username/repo.git

# How to add another account
1. Git Bash -> Default location
2. cd .ssh
3. ssh-keygen -f another_account_id_rsa
4. Copy: cat /c/Users/info/.ssh/another_account_id_rsa.pub
5. Paste in SSH and GPG keys
6. Remember pass in mind
7. Create `config` file in .ssh
```bash
#Account1
Host github.com
 HostName github.com
 IdentityFile ~/.ssh/id_rsa

#Account2
Host github.com-another_account
  HostName github.com
  IdentityFile ~/.ssh/another_account_id_rsa
```
