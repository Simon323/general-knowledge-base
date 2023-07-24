# Useful sources during chromecast app development

### Open devtools
  - chrome://inspect
  - topic https://developers.google.com/cast/docs/debugging/remote_debugger

### Force update
  - Invoke-WebRequest -Method Post -ContentType "application/json" -Body '{"params": "ota foreground"}' -Uri "http://[chromecast_IP]/setup/reboot" -Verbose -UserAgent "curl"