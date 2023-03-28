# Store

We have predefined two stores: IShareStore and IGlobalStore.

*IShareStore* is a scoped service, which means that there will be only one instance for each scope. If you are using server-side Blazor, then every connection will have only one instance by default. So you can use it to share data between different components for a single connection/session.

*IGlobalStore* is a singleton service, which means that there will be only one instance for the whole application. So, if you are using server-side Blazor, then you can use it to share data between different users. However, it is not distributed. If you are running in IIS with multiple process enabled or in k8s with multiple PODs running, then you cannot use it to share data between different users. For those cases, you will need to implement your own implementation.

Here's a demo of IGlobalStore:

{{GlobalStoreDemo}}