# Store

We have predefined two stores (IShareStore/IGlobalStore).

IShareStore is a scoped service, it means there will be only one instance for each scope. If you are using server side blazor, then every connection will only have one instance by default. So you can use it to share data between different components for a single connection/session.

IGlobalStore is a singleton service, it means there will be only one instance for the whole application. So if you are using server side blazor, then you can use it to share data between different users. But of course it is not distributed, so if you are running in IIS with multiple process enabled or in k8s which with multiple PODs running, then you can not use it to share data between different users. For those cases, you will need to implement your own implementation.

{{GlobalStoreDemo}}