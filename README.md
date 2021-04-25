# Simpleidserver core

[![Build status](https://ci.appveyor.com/api/projects/status/shtqlxhbda6gtdag?svg=true)](https://ci.appveyor.com/project/simpleidserver/simpleidserver)
[![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.OpenID.svg)](http://myget.org/gallery/advance-ict)
[![Documentation Status](https://readthedocs.org/projects/simpleidserver/badge/?version=latest)](https://simpleidserver.readthedocs.io/en/latest/)

SimpleIdServer is an open source framework enabling the support of OPENID, OAUTH2.0, SCIM2.0 and UMA2.0. It streamlines development, configuration and deployment of custom access control servers. 
Thanks to its modularity and extensibility, SimpleIdServer can be customized to the specific needs of your organization for authentication, authorization and more.

For project documentation, please visit [readthedocs](https://simpleidserver.readthedocs.io/en/latest/).

## Packages

|                         			 						|      																															  																					|																																								|																																								|
| --------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `SimpleIdServer.OpenID` 			 						| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.OpenID.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.OpenID)												| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.OpenID.svg)](https://nuget.org/packages/SimpleIdServer.OpenID) 										| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.OpenID.svg)](https://nuget.org/packages/SimpleIdServer.OpenID) 										|
| `SimpleIdServer.OpenID.Bootstrap4` 						| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.OpenID.Bootstrap4.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.OpenID.Bootstrap4)							| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.OpenID.Bootstrap4.svg)](https://nuget.org/packages/SimpleIdServer.OpenID.Bootstrap4) 					| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.OpenID.Bootstrap4.svg)](https://nuget.org/packages/SimpleIdServer.OpenID.Bootstrap4) 				|
| `SimpleIdServer.UI.Authenticate.LoginPassword.Bootstrap4` | [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.UI.Authenticate.LoginPassword.Bootstrap4.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.OpenID.Bootstrap4)	| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.OpenID.Bootstrap4.svg)](https://nuget.org/packages/SimpleIdServer.OpenID.Bootstrap4) 					| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.OpenID.Bootstrap4.svg)](https://nuget.org/packages/SimpleIdServer.OpenID.Bootstrap4) 				|
| `SimpleIdServer.OAuth`  			 						| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.OAuth.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.OAuth) 													| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.OAuth.svg)](https://nuget.org/packages/SimpleIdServer.OAuth) 											| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.OAuth.svg)](https://nuget.org/packages/SimpleIdServer.OAuth) 										|
| `SimpleIdServer.Scim`   			 						| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.Scim.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.Scim) 													| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.Scim.svg)](https://nuget.org/packages/SimpleIdServer.Scim) 											| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.Scim.svg)](https://nuget.org/packages/SimpleIdServer.Scim) 											|
| `SimpleIdServer.Scim.Persistence.EF`   		 			| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.Scim.Persistence.EF.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.Scim.Persistence.EF) 						| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.Scim.Persistence.EF.svg)](https://nuget.org/packages/SimpleIdServer.Scim.Persistence.EF) 				| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.Scim.Persistence.EF.svg)](https://nuget.org/packages/SimpleIdServer.Scim.Persistence.EF)				|
| `SimpleIdServer.Scim.Persistence.MongoDB`   				| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.Scim.Persistence.MongoDB.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.Scim.Persistence.MongoDB) 			| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.Scim.Persistence.MongoDB.svg)](https://nuget.org/packages/SimpleIdServer.Scim.Persistence.MongoDB) 	| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.Scim.Persistence.MongoDB.svg)](https://nuget.org/packages/SimpleIdServer.Scim.Persistence.MongoDB)	|
| `SimpleIdServer.Scim.SqlServer`			   				| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.Scim.SqlServer.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.Scim.SqlServer) 								| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.Scim.SqlServer.svg)](https://nuget.org/packages/SimpleIdServer.Scim.SqlServer) 						| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.Scim.SqlServer.svg)](https://nuget.org/packages/SimpleIdServer.Scim.SqlServer)						|
| `SimpleIdServer.Scim.Swashbuckle`			   				| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.Scim.Swashbuckle.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.Scim.Swashbuckle) 							| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.Scim.Swashbuckle.svg)](https://nuget.org/packages/SimpleIdServer.Scim.Swashbuckle) 					| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.Scim.Swashbuckle.svg)](https://nuget.org/packages/SimpleIdServer.Scim.Swashbuckle)					|
| `SimpleIdServer.Uma.Bootstrap4`   			 			| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.Uma.Bootstrap4.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.Uma.Bootstrap4) 								| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.Uma.Bootstrap4.svg)](https://nuget.org/packages/SimpleIdServer.Uma.Bootstrap4) 						| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.Uma.Bootstrap4.svg)](https://nuget.org/packages/SimpleIdServer.Uma.Bootstrap4)						|
| `SimpleIdServer.OpenBankingApi`							| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.OpenBankingApi.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.OpenBankingApi) 								| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.OpenBankingApi.svg)](https://nuget.org/packages/SimpleIdServer.OpenBankingApi) 						| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.OpenBankingApi.svg)](https://nuget.org/packages/SimpleIdServer.OpenBankingApi)						|
| `SimpleIdServer.OpenBankingApi.Domains`					| [![MyGet (dev)](https://img.shields.io/myget/advance-ict/v/SimpleIdServer.OpenBankingApi.Domains.svg)](https://www.myget.org/feed/advance-ict/package/nuget/SimpleIdServer.OpenBankingApi.Domains) 				| [![NuGet](https://img.shields.io/nuget/v/SimpleIdServer.OpenBankingApi.Domains.svg)](https://nuget.org/packages/SimpleIdServer.OpenBankingApi.Domains)		| [![NuGet](https://img.shields.io/nuget/dt/SimpleIdServer.OpenBankingApi.Domains.svg)](https://nuget.org/packages/SimpleIdServer.OpenBankingApi.Domains)		|

## Certifications

SimpleIdServer implements the following OPENID conformance profiles :

### OpenID provider

| Profile      	    | Test plans                                                                                                                                                                                                                                                                                     |
| ----------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Basic OP     	    | [Link](https://www.certification.openid.net/plan-detail.html?plan=TcDgVIcSJLFHg&public=true)                                                                                                                                                                                                   |
| Implicit OP  	    | [Link](https://www.certification.openid.net/plan-detail.html?plan=ELzlUw0Ml4Cdi&public=true)                                                                                                                                                                                                   |
| Hybrid OP    	    | [Link](https://www.certification.openid.net/plan-detail.html?plan=hyaf2Ji4pt8c4&public=true)                                                                                                                                                                                                   |
| Config OP    	    | [Link](https://www.certification.openid.net/log-detail.html?log=eLluAN1FEGFibyC&public=true)                                                                                                                                                                                                   |
| Dynamic OP   	    | [Link](https://www.certification.openid.net/plan-detail.html?plan=rD0K7iYAcQBDV&public=true)                                                                                                                                                                                                   |
| Form POST OP   	| [Link 1](https://www.certification.openid.net/plan-detail.html?plan=TcDgVIcSJLFHg&public=true), [Link 2](https://www.certification.openid.net/plan-detail.html?plan=WyVmp1Gj6wJ9p&public=true), [Link 3](https://www.certification.openid.net/plan-detail.html?plan=VB4UtJystIKk8&public=true) |
| 3rd Party-Init OP | [Link](https://www.certification.openid.net/plan-detail.html?plan=HqBg2tU5qmAFB&public=true)                                                                                                                                                                                                   |

### OpenID provider for logout profile

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Live demo

Live demo : [http://simpleidserver.northeurope.cloudapp.azure.com/simpleidserver](http://simpleidserver.northeurope.cloudapp.azure.com/simpleidserver/).

Administrator credentials :

| Property      |      Value      |
|---------------|-----------------|
| login         | administrator   |
| value         | password        |