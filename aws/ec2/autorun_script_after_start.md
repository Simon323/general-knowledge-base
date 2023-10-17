## Run command after start
The following instructions describe how to run the chii-app process

1. Create work dir
```bash
cd /home/ec2-user/
mkdir ~/my-chii
```
2. Go to system
```bash
cd /etc/systemd/system/
```
3. Open nano
```bash
sudo nano /etc/systemd/system/my-chii.service
```
4. Paste config file contetn
```bash
[Unit]
Description=Chii Service

[Service]
ExecStart=npx chii start -p 2444 -d example.domain
WorkingDirectory=/home/ec2-user/my-chii
User=ec2-user
Group=ec2-user
Restart=always

[Install]
WantedBy=multi-user.target
```
5. Enabled autostart service
```bash
sudo systemctl enable my-chii
```
6. Run service
```bash
sudo systemctl start my-chii
```
7. Check status
```bash
sudo systemctl status my-chii
```
8. If you change something
```bash
sudo systemctl daemon-reload
```
9. Apply chnages
```bash
sudo systemctl restart my-chii
```
10. Log diary
```bash
journalctl -u my-chii
```