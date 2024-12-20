#!/bin/bash
TABLES=$(aws dynamodb list-tables --no-sign-request --region eu-west-1 --endpoint-url=http://localhost:4666 --query 'TableNames[]' | jq -r '.[]')
for TABLE in $TABLES
do
  echo "Delete table $TABLE ..."
  aws dynamodb delete-table --table-name $TABLE --output text --no-sign-request --region eu-west-1 --endpoint-url=http://localhost:4666
done