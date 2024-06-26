# Example Code for Provisioning AWS IoT Core 'Things' using AWS SDK for .NET 

This example uses the [AWS SDK for .NET](https://docs.aws.amazon.com/sdk-for-net/) Version 3.0 to Create a Thing in IoT Core.

## API Reference

* [API Reference for the AmazonIoTClient](https://docs.aws.amazon.com/sdkfornet/v3/apidocs/items/IoT/TIoTClient.html)

## NUGET Packages

To build this example, add the following packages:

* [AWSSDK.IoT](https://www.nuget.org/packages/AWSSDK.IoT)
* [AWSSDK.SecurityToken](https://www.nuget.org/packages/AWSSDK.SecurityToken)

```
>  dotnet add package AWSSDK.IoT
>  dotnet add package AWSSDK.SecurityToken
```

## AWS Profile Setup

The AWS Provisioning Application requires the creation of a profile before it can it can used. The profile contains information on your account, region, authentication method etc. 

The easiest way to set up AWS profiles is via the [AWS CLI (Command Line Interface)](https://aws.amazon.com/cli/). Download and install on your machine.

To configure a profile for Single Sign On (SSO) execute the following
```
aws configure sso
``` 
Additional information can be found at [Single sign-on with the AWS SDK for .NET](https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/sso.html)
