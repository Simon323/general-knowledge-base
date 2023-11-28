# AWS CloudWatch commands

- [AWS CloudWatch commands](#aws-cloudwatch-commands)
  - [List multipart uploads](#list-multipart-uploads)
  - [Complete multipart upload](#complete-multipart-upload)
    - [Generate cli skeleton](#generate-cli-skeleton)
    - [Implicit parameters](#implicit-parameters)

## List multipart uploads

```bash
aws s3api list-multipart-uploads --bucket your_bucket_name --profile your_profile > files/output/list-multipart-uploads.json
```

---

## Complete multipart upload

### Generate cli skeleton

```bash
aws s3api complete-multipart-upload --generate-cli-skeleton
```

### Implicit parameters

```bash
aws s3api complete-multipart-upload --cli-input-json file://files/input/complete-multipart-upload.json --profile your_profile
```

---
