# WebHookRecieverSample
## Overview
This is a sample project that can be used to setup a service to use with DirectScale's Web Hooks service.
Feedback is always welcome, but this project is provided as-is and is only the boiler plate code necessary to get
started implementing a .NET Core 2.0 service to receive Events Web Hooks.  The scope of this solution is 
intentionally restricted to basic functionality and does not include certain things that will likely be 
desired, such as authentication for loading the swagger page, logging, a complete API versioning strategy, 
and other elements which typically accompany a mature enterprise solution.  The intent is to provide a 
starting point for implementing a service which can be used to receive notifications from DirectScale's 
Event WebHooks service.

In order to make reasonable use of this code you'll need to have your own development staff to do the work.
The presence of this code is not meant to imply that DirectScale is available to consult on your implementation
of this service.  You should assume that the structure/content of the data being sent by DirectScale will change
from time to time.  Wherever possible, such changes will be released by means of creating a newer version hook which
you can provide a new API endpoint to DirectScale in order to start receiving the newer format data.  This should
prevent an established API from being disrupted, but will require additional work to receive new data from time
to time.

## What Should I Do With This Project?
1. Before you can do anything you'll likely need to setup a build pipeline and hosting for this service.
How you do that is outside the scope of this document and is entirely up to you to accomplish.

2. You probably will want to implement some kind of authentication so that your Swagger page is not openly
accessible.  However, as of this writing the API endpoints you provide DirectScale for each of the types of
events must accept POST data without requiring any authentication or authorization.

## Available Events To Receive
### Enrollment Event V1
The Enrollment Event is fired any time a new customer or distributor is enrolled.

```csharp
public class Enrollment
{
    public string DistributorId { get; set; }
    public string DistributorType { get; set; }
    public string DistributorStatus { get; set; }
    public string DistributorCountry { get; set; }
    public string SponsorId { get; set; }
    public DateTime EnrollmentDateUtc { get; set; }
    public DateTime EventDateUtc { get; set; }
}
```

### Order Event V1
The Order Event is fired any time an order is placed and includes autoship orders as well as incidental orders.

```csharp
public class Order
{
    public string OrderId { get; set; }
    public DateTime OrderDateUtc { get; set; }
    public string DistributorId { get; set; }
    public string OrderType { get; set; }
    public double OrderTotal { get; set; }
    public string OrderCountry { get; set; }
    public string OrderCurrency { get; set; }
    public string OrderStatus { get; set; }
    public DateTime EventDateUtc { get; set; }
}
```

### Create Associate Event V1 & Update Associate Event V1
The CreateAssociateEvent is fired any time a new associate is created.
The UpdateAssociateEvent is fired any time an associates' record is updated.
Both the CreateAssociateEvent and UpdateAssociateEvent share the same data model.

```csharp
public class Associate
{
    public int AssociateId { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CompanyName { get; set; }
    public string EmailAddress { get; set; }
    public int AssociateStatus { get; set; }
    public int AssociateType { get; set; }
    public string[] WebAliases { get; set; }
    public string BackOfficeId { get; set; }
    public string ExternalReferenceId { get; set; }
    public DateTime EventDateUtc { get; set; }
}
```


### Create Subscription Event V1 & Update Subscription Event V1
The CreateSubscriptionEvent and UpdateSubscriptionEvent share the same data model.

```csharp
public class Subscription
{
    public int AssociateId { get; set; }
    public int SubscriptionId { get; set; }
    public string SubscriptionName { get; set; }
    public DateTime ExpirationDateUtc { get; set; }
    public bool IsVoid { get; set; }
    public DateTime EventDateUtc { get; set; }
}
```