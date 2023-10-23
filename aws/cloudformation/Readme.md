# Create S3 with CloudFront

- [Create S3 with CloudFront](#create-s3-with-cloudfront)
  - [Create stack](#create-stack)
  - [Update stack](#update-stack)
  - [Check status](#check-status)

---

## Create stack
```bash
aws cloudformation create-stack --stack-name S3AndCloudFrontStack --template-body file://s3_cloudfront.yaml --parameters ParameterKey=BucketName,ParameterValue=my-static-bucket  --profile your_profile
```

## Update stack
```bash
aws cloudformation update-stack --stack-name S3AndCloudFrontStack --template-body file://s3_cloudfront.yaml --profile your_profile
```

## Check status
```bash
aws cloudformation describe-stacks --stack-name S3AndCloudFrontStack --profile your_profile
```
