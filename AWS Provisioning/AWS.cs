using Amazon;
using Amazon.IoT;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using System;

public class AWSLibrary
{
    public AmazonIoTClient AWSClientAuthenication(string profilename)
    {
        // https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/creds-locate.html

        CredentialProfile basicProfile;
        AWSCredentials awsCredentials;
        var sharedFile = new SharedCredentialsFile();
        if (sharedFile.TryGetProfile(profilename, out basicProfile) &&
            AWSCredentialsFactory.TryGetAWSCredentials(basicProfile, sharedFile, out awsCredentials))
        {
            AmazonIoTClient client = new AmazonIoTClient(awsCredentials, basicProfile.Region);
            return client;
        }
        else
        {
            return null;
        }
    }
}
