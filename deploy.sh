#!/bin/bash

dotnet lambda deploy-serverless \
  --stack-name Dnw-TechDiamonds \
  --s3-bucket dnw-templates-2022

aws cloudfront create-invalidation \
  --distribution-id E10D91NRYYHNGF \
  --paths "/*"