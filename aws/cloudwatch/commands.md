# AWS CloudWatch commands

## Table of Contents

- [AWS CloudWatch commands](#aws-cloudwatch-commands)
  - [Table of Contents](#table-of-contents)
  - [Get metric data](#get-metric-data)
    - [AWS/EC2](#awsec2)
      - [Explicit parameters](#explicit-parameters)
      - [Implicit parameters](#implicit-parameters)
    - [AWS/MediaLive](#awsmedialive)
      - [Explicit parameters](#explicit-parameters-1)
      - [Implicit parameters](#implicit-parameters-1)
  - [Get metric statistics](#get-metric-statistics)
    - [AWS/EC2](#awsec2-1)
    - [AWS/MediaLive](#awsmedialive-1)

## Get metric data

---

### AWS/EC2

#### Explicit parameters

```bash
aws cloudwatch get-metric-data --metric-data-queries file://files/input/metric-data-queries-ec2.json --start-time 2023-11-09T04:00:00Z --end-time 2023-11-09T04:30:00Z --profile your_profile > files/output/metric-data-result-ec2.json
```

#### Implicit parameters

```bash
aws cloudwatch get-metric-data --cli-input-json file://files/input/metric-data-queries-ec2-input.json --profile your_profile > files/output/metric-data-result-ec2.json
```

---

### AWS/MediaLive

#### Explicit parameters

```bash
aws cloudwatch get-metric-data --metric-data-queries file://files/input/metric-data-queries-live.json --start-time 2023-11-06T23:18:00Z --end-time 2023-11-09T23:18:00Z --profile your_profile > files/output/metric-data-result-live.json
```

#### Implicit parameters

```bash
aws cloudwatch get-metric-data --cli-input-json file://files/input/metric-data-queries-live-input.json --profile your_profile > files/output/metric-data-result-live.json
```

---

## Get metric statistics

### AWS/EC2

```bash
aws cloudwatch get-metric-statistics --metric-name CPUUtilization --start-time 2023-11-06T23:18:00Z --end-time 2023-11-09T23:18:00Z --period 3600 --namespace AWS/EC2 --statistics Average --dimensions Name=InstanceId,Value=i-j432j9fsds9n32nds --profile your_profile
```

### AWS/MediaLive

```bash
aws cloudwatch get-metric-statistics --metric-name NetworkIn --start-time 2023-11-06T23:18:00Z --end-time 2023-11-09T23:18:00Z --period 3600 --namespace AWS/MediaLive --statistics Average --dimensions Name=ChannelId,Value=7430321 Name=Pipeline,Value=0 --profile your_profile
```

---
