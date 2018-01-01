# IO.Swagger.Api.Music_promoterApi

All URIs are relative to *https://52.90.138.148/api/v2/music_promoter*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallMusicPromoterStoredFunction**](Music_promoterApi.md#callmusicpromoterstoredfunction) | **GET** /_func/{function_name} | Call a stored function.
[**CallMusicPromoterStoredFunctionWithParams**](Music_promoterApi.md#callmusicpromoterstoredfunctionwithparams) | **POST** /_func/{function_name} | Call a stored function with parameters.
[**CallMusicPromoterStoredProcedure**](Music_promoterApi.md#callmusicpromoterstoredprocedure) | **GET** /_proc/{procedure_name} | Call a stored procedure.
[**CallMusicPromoterStoredProcedureWithParams**](Music_promoterApi.md#callmusicpromoterstoredprocedurewithparams) | **POST** /_proc/{procedure_name} | Call a stored procedure.
[**CreateMusicPromoterFields**](Music_promoterApi.md#createmusicpromoterfields) | **POST** /_schema/{table_name}/_field | Create table fields.
[**CreateMusicPromoterRecords**](Music_promoterApi.md#createmusicpromoterrecords) | **POST** /_table/{table_name} | Create one or more records.
[**CreateMusicPromoterRelationships**](Music_promoterApi.md#createmusicpromoterrelationships) | **POST** /_schema/{table_name}/_related | Create table relationships with the given properties.
[**CreateMusicPromoterTable**](Music_promoterApi.md#createmusicpromotertable) | **POST** /_schema/{table_name} | Create a table with the given properties and fields.
[**CreateMusicPromoterTables**](Music_promoterApi.md#createmusicpromotertables) | **POST** /_schema | Create one or more tables.
[**DeleteMusicPromoterField**](Music_promoterApi.md#deletemusicpromoterfield) | **DELETE** /_schema/{table_name}/_field/{field_name} | Remove the given field from the given table.
[**DeleteMusicPromoterFields**](Music_promoterApi.md#deletemusicpromoterfields) | **DELETE** /_schema/{table_name}/_field | Delete (aka drop) the given fields.
[**DeleteMusicPromoterRecord**](Music_promoterApi.md#deletemusicpromoterrecord) | **DELETE** /_table/{table_name}/{id} | Delete one record by identifier.
[**DeleteMusicPromoterRecords**](Music_promoterApi.md#deletemusicpromoterrecords) | **DELETE** /_table/{table_name} | Delete one or more records.
[**DeleteMusicPromoterRelationship**](Music_promoterApi.md#deletemusicpromoterrelationship) | **DELETE** /_schema/{table_name}/_related/{relationship_name} | Remove the given relationship from the given table.
[**DeleteMusicPromoterRelationships**](Music_promoterApi.md#deletemusicpromoterrelationships) | **DELETE** /_schema/{table_name}/_related | Delete the given table relationships.
[**DeleteMusicPromoterTable**](Music_promoterApi.md#deletemusicpromotertable) | **DELETE** /_schema/{table_name} | Delete (aka drop) the given table.
[**DescribeMusicPromoterField**](Music_promoterApi.md#describemusicpromoterfield) | **GET** /_schema/{table_name}/_field/{field_name} | Retrieve the definition of the given field for the given table.
[**DescribeMusicPromoterFields**](Music_promoterApi.md#describemusicpromoterfields) | **GET** /_schema/{table_name}/_field | Retrieve table field definitions for the given table.
[**DescribeMusicPromoterRelationship**](Music_promoterApi.md#describemusicpromoterrelationship) | **GET** /_schema/{table_name}/_related/{relationship_name} | Retrieve the definition of the given relationship for the given table.
[**DescribeMusicPromoterRelationships**](Music_promoterApi.md#describemusicpromoterrelationships) | **GET** /_schema/{table_name}/_related | Retrieve relationships definition for the given table.
[**DescribeMusicPromoterTable**](Music_promoterApi.md#describemusicpromotertable) | **GET** /_schema/{table_name} | Retrieve table definition for the given table.
[**GetMusicPromoterRecord**](Music_promoterApi.md#getmusicpromoterrecord) | **GET** /_table/{table_name}/{id} | Retrieve one record by identifier.
[**GetMusicPromoterRecords**](Music_promoterApi.md#getmusicpromoterrecords) | **GET** /_table/{table_name} | Retrieve one or more records.
[**GetMusicPromoterResources**](Music_promoterApi.md#getmusicpromoterresources) | **GET** / | Get resources for this service.
[**GetMusicPromoterSchemas**](Music_promoterApi.md#getmusicpromoterschemas) | **GET** /_schema | Retrieve one or more Schemas.
[**GetMusicPromoterStoredFunctions**](Music_promoterApi.md#getmusicpromoterstoredfunctions) | **GET** /_func | Retrieve one or more StoredFunctions.
[**GetMusicPromoterStoredProcedures**](Music_promoterApi.md#getmusicpromoterstoredprocedures) | **GET** /_proc | Retrieve one or more StoredProcedures.
[**GetMusicPromoterTables**](Music_promoterApi.md#getmusicpromotertables) | **GET** /_table | Retrieve one or more Tables.
[**ReplaceMusicPromoterField**](Music_promoterApi.md#replacemusicpromoterfield) | **PUT** /_schema/{table_name}/_field/{field_name} | Update one field by identifier.
[**ReplaceMusicPromoterFields**](Music_promoterApi.md#replacemusicpromoterfields) | **PUT** /_schema/{table_name}/_field | Update (replace) table fields with the given properties.
[**ReplaceMusicPromoterRecord**](Music_promoterApi.md#replacemusicpromoterrecord) | **PUT** /_table/{table_name}/{id} | Replace the content of one record by identifier.
[**ReplaceMusicPromoterRecords**](Music_promoterApi.md#replacemusicpromoterrecords) | **PUT** /_table/{table_name} | Update (replace) one or more records.
[**ReplaceMusicPromoterRelationship**](Music_promoterApi.md#replacemusicpromoterrelationship) | **PUT** /_schema/{table_name}/_related/{relationship_name} | Update one relationship by identifier.
[**ReplaceMusicPromoterRelationships**](Music_promoterApi.md#replacemusicpromoterrelationships) | **PUT** /_schema/{table_name}/_related | Update (replace) table relationships with the given properties.
[**ReplaceMusicPromoterTable**](Music_promoterApi.md#replacemusicpromotertable) | **PUT** /_schema/{table_name} | Update (replace) a table with the given properties.
[**ReplaceMusicPromoterTables**](Music_promoterApi.md#replacemusicpromotertables) | **PUT** /_schema | Update (replace) one or more tables.
[**UpdateMusicPromoterField**](Music_promoterApi.md#updatemusicpromoterfield) | **PATCH** /_schema/{table_name}/_field/{field_name} | Update one field by identifier.
[**UpdateMusicPromoterFields**](Music_promoterApi.md#updatemusicpromoterfields) | **PATCH** /_schema/{table_name}/_field | Update (patch) table fields with the given properties.
[**UpdateMusicPromoterRecord**](Music_promoterApi.md#updatemusicpromoterrecord) | **PATCH** /_table/{table_name}/{id} | Update (patch) one record by identifier.
[**UpdateMusicPromoterRecords**](Music_promoterApi.md#updatemusicpromoterrecords) | **PATCH** /_table/{table_name} | Update (patch) one or more records.
[**UpdateMusicPromoterRelationship**](Music_promoterApi.md#updatemusicpromoterrelationship) | **PATCH** /_schema/{table_name}/_related/{relationship_name} | Update one relationship by identifier.
[**UpdateMusicPromoterRelationships**](Music_promoterApi.md#updatemusicpromoterrelationships) | **PATCH** /_schema/{table_name}/_related | Update (patch) a table with the given properties.
[**UpdateMusicPromoterTable**](Music_promoterApi.md#updatemusicpromotertable) | **PATCH** /_schema/{table_name} | Update (patch) a table with the given properties.
[**UpdateMusicPromoterTables**](Music_promoterApi.md#updatemusicpromotertables) | **PATCH** /_schema | Update (patch) one or more tables.


<a name="callmusicpromoterstoredfunction"></a>
# **CallMusicPromoterStoredFunction**
> StoredFunctionResponse CallMusicPromoterStoredFunction (string functionName, string returns = null)

Call a stored function.

Call a stored function with no parameters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CallMusicPromoterStoredFunctionExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var functionName = functionName_example;  // string | Name of the stored function to call.
            var returns = returns_example;  // string | If returning a single value, use this to set the type of that value. (optional) 

            try
            {
                // Call a stored function.
                StoredFunctionResponse result = apiInstance.CallMusicPromoterStoredFunction(functionName, returns);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CallMusicPromoterStoredFunction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **functionName** | **string**| Name of the stored function to call. | 
 **returns** | **string**| If returning a single value, use this to set the type of that value. | [optional] 

### Return type

[**StoredFunctionResponse**](StoredFunctionResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="callmusicpromoterstoredfunctionwithparams"></a>
# **CallMusicPromoterStoredFunctionWithParams**
> StoredFunctionResponse CallMusicPromoterStoredFunctionWithParams (string functionName, string returns = null)

Call a stored function with parameters.

Call a stored function with parameters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CallMusicPromoterStoredFunctionWithParamsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var functionName = functionName_example;  // string | Name of the stored function to call.
            var returns = returns_example;  // string | If returning a single value, use this to set the type of that value. (optional) 

            try
            {
                // Call a stored function with parameters.
                StoredFunctionResponse result = apiInstance.CallMusicPromoterStoredFunctionWithParams(functionName, returns);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CallMusicPromoterStoredFunctionWithParams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **functionName** | **string**| Name of the stored function to call. | 
 **returns** | **string**| If returning a single value, use this to set the type of that value. | [optional] 

### Return type

[**StoredFunctionResponse**](StoredFunctionResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="callmusicpromoterstoredprocedure"></a>
# **CallMusicPromoterStoredProcedure**
> StoredProcedureResponse CallMusicPromoterStoredProcedure (string procedureName, string wrapper = null, string returns = null)

Call a stored procedure.

Call a stored procedure with no parameters. Set an optional wrapper for the returned data set. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CallMusicPromoterStoredProcedureExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var procedureName = procedureName_example;  // string | Name of the stored procedure to call.
            var wrapper = wrapper_example;  // string | Add this wrapper around the expected data set before returning. (optional) 
            var returns = returns_example;  // string | If returning a single value, use this to set the type of that value. (optional) 

            try
            {
                // Call a stored procedure.
                StoredProcedureResponse result = apiInstance.CallMusicPromoterStoredProcedure(procedureName, wrapper, returns);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CallMusicPromoterStoredProcedure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **procedureName** | **string**| Name of the stored procedure to call. | 
 **wrapper** | **string**| Add this wrapper around the expected data set before returning. | [optional] 
 **returns** | **string**| If returning a single value, use this to set the type of that value. | [optional] 

### Return type

[**StoredProcedureResponse**](StoredProcedureResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="callmusicpromoterstoredprocedurewithparams"></a>
# **CallMusicPromoterStoredProcedureWithParams**
> StoredProcedureResponse CallMusicPromoterStoredProcedureWithParams (string procedureName, string wrapper = null, string returns = null)

Call a stored procedure.

Call a stored procedure with parameters. Set an optional wrapper and schema for the returned data set. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CallMusicPromoterStoredProcedureWithParamsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var procedureName = procedureName_example;  // string | Name of the stored procedure to call.
            var wrapper = wrapper_example;  // string | Add this wrapper around the expected data set before returning. (optional) 
            var returns = returns_example;  // string | If returning a single value, use this to set the type of that value. (optional) 

            try
            {
                // Call a stored procedure.
                StoredProcedureResponse result = apiInstance.CallMusicPromoterStoredProcedureWithParams(procedureName, wrapper, returns);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CallMusicPromoterStoredProcedureWithParams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **procedureName** | **string**| Name of the stored procedure to call. | 
 **wrapper** | **string**| Add this wrapper around the expected data set before returning. | [optional] 
 **returns** | **string**| If returning a single value, use this to set the type of that value. | [optional] 

### Return type

[**StoredProcedureResponse**](StoredProcedureResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmusicpromoterfields"></a>
# **CreateMusicPromoterFields**
> Success CreateMusicPromoterFields (string tableName)

Create table fields.

Post data should be an array of fields and their properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMusicPromoterFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Create table fields.
                Success result = apiInstance.CreateMusicPromoterFields(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CreateMusicPromoterFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmusicpromoterrecords"></a>
# **CreateMusicPromoterRecords**
> RecordsResponse CreateMusicPromoterRecords (string tableName, List<string> fields = null, List<string> related = null, List<string> idField = null, List<string> idType = null, bool? _continue = null, bool? rollback = null, string X_HTTP_METHOD = null)

Create one or more records.

Posted data should be an array of records wrapped in a **record** element. By default, only the id property of the record is returned on success. Use **fields** parameter to return more info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMusicPromoterRecordsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var _continue = true;  // bool? | In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var rollback = true;  // bool? | In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var X_HTTP_METHOD = X_HTTP_METHOD_example;  // string | Override request using POST to tunnel other http request, such as DELETE or GET passing a payload. (optional) 

            try
            {
                // Create one or more records.
                RecordsResponse result = apiInstance.CreateMusicPromoterRecords(tableName, fields, related, idField, idType, _continue, rollback, X_HTTP_METHOD);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CreateMusicPromoterRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **_continue** | **bool?**| In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **rollback** | **bool?**| In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **X_HTTP_METHOD** | **string**| Override request using POST to tunnel other http request, such as DELETE or GET passing a payload. | [optional] 

### Return type

[**RecordsResponse**](RecordsResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmusicpromoterrelationships"></a>
# **CreateMusicPromoterRelationships**
> Success CreateMusicPromoterRelationships (string tableName)

Create table relationships with the given properties.

Post data should be an array of relationship properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMusicPromoterRelationshipsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Create table relationships with the given properties.
                Success result = apiInstance.CreateMusicPromoterRelationships(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CreateMusicPromoterRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmusicpromotertable"></a>
# **CreateMusicPromoterTable**
> Success CreateMusicPromoterTable (string tableName)

Create a table with the given properties and fields.

Post data should be an array of field properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMusicPromoterTableExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Create a table with the given properties and fields.
                Success result = apiInstance.CreateMusicPromoterTable(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CreateMusicPromoterTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmusicpromotertables"></a>
# **CreateMusicPromoterTables**
> TableSchemas CreateMusicPromoterTables ()

Create one or more tables.

Post data should be a single table definition or an array of table definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMusicPromoterTablesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();

            try
            {
                // Create one or more tables.
                TableSchemas result = apiInstance.CreateMusicPromoterTables();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.CreateMusicPromoterTables: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TableSchemas**](TableSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemusicpromoterfield"></a>
# **DeleteMusicPromoterField**
> Success DeleteMusicPromoterField (string tableName, string fieldName)

Remove the given field from the given table.

Careful, this drops the database table field/column and all of its contents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMusicPromoterFieldExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fieldName = fieldName_example;  // string | Name of the field to perform operations on.

            try
            {
                // Remove the given field from the given table.
                Success result = apiInstance.DeleteMusicPromoterField(tableName, fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DeleteMusicPromoterField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fieldName** | **string**| Name of the field to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemusicpromoterfields"></a>
# **DeleteMusicPromoterFields**
> Success DeleteMusicPromoterFields (string tableName)

Delete (aka drop) the given fields.

Careful, this drops the table column and all of its contents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMusicPromoterFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Delete (aka drop) the given fields.
                Success result = apiInstance.DeleteMusicPromoterFields(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DeleteMusicPromoterFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemusicpromoterrecord"></a>
# **DeleteMusicPromoterRecord**
> RecordResponse DeleteMusicPromoterRecord (string id, string tableName, List<string> fields = null, List<string> related = null, List<string> idField = null, List<string> idType = null)

Delete one record by identifier.

Use the **fields** parameter to return more deleted properties. By default, the id is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMusicPromoterRecordExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var id = id_example;  // string | Identifier of the record to retrieve.
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 

            try
            {
                // Delete one record by identifier.
                RecordResponse result = apiInstance.DeleteMusicPromoterRecord(id, tableName, fields, related, idField, idType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DeleteMusicPromoterRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the record to retrieve. | 
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 

### Return type

[**RecordResponse**](RecordResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemusicpromoterrecords"></a>
# **DeleteMusicPromoterRecords**
> RecordsResponse DeleteMusicPromoterRecords (string tableName, List<string> fields = null, List<string> related = null, List<int?> ids = null, List<string> idField = null, List<string> idType = null, bool? _continue = null, bool? rollback = null, string filter = null, bool? force = null)

Delete one or more records.

Set the **ids** parameter to a list of record identifying (primary key) values to delete specific records. Alternatively, to delete records by a large list of ids, pass the ids in the **body**. By default, only the id property of the record is returned on success, use **fields** to return more info. Set the **filter** parameter to a SQL WHERE clause to delete specific records, otherwise set **force** to true to clear the table. Alternatively, to delete by a complicated filter or to use parameter replacement, pass the filter with or without params as the **body**. By default, only the id property of the record is returned on success, use **fields** to return more info. Set the **body** to an array of records, minimally including the identifying fields, to delete specific records. By default, only the id property of the record is returned on success, use **fields** to return more info. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMusicPromoterRecordsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var ids = new List<int?>(); // List<int?> | Comma-delimited list of the identifiers of the records to retrieve. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var _continue = true;  // bool? | In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var rollback = true;  // bool? | In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var filter = filter_example;  // string | SQL-like filter to limit the records to retrieve. (optional) 
            var force = true;  // bool? | Set to true to delete all resources in the given table, folder, etc. (optional) 

            try
            {
                // Delete one or more records.
                RecordsResponse result = apiInstance.DeleteMusicPromoterRecords(tableName, fields, related, ids, idField, idType, _continue, rollback, filter, force);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DeleteMusicPromoterRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **ids** | [**List&lt;int?&gt;**](int?.md)| Comma-delimited list of the identifiers of the records to retrieve. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **_continue** | **bool?**| In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **rollback** | **bool?**| In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **filter** | **string**| SQL-like filter to limit the records to retrieve. | [optional] 
 **force** | **bool?**| Set to true to delete all resources in the given table, folder, etc. | [optional] 

### Return type

[**RecordsResponse**](RecordsResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemusicpromoterrelationship"></a>
# **DeleteMusicPromoterRelationship**
> Success DeleteMusicPromoterRelationship (string tableName, string relationshipName)

Remove the given relationship from the given table.

Removes the relationship between the tables given.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMusicPromoterRelationshipExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var relationshipName = relationshipName_example;  // string | Name of the relationship to perform operations on.

            try
            {
                // Remove the given relationship from the given table.
                Success result = apiInstance.DeleteMusicPromoterRelationship(tableName, relationshipName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DeleteMusicPromoterRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **relationshipName** | **string**| Name of the relationship to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemusicpromoterrelationships"></a>
# **DeleteMusicPromoterRelationships**
> Success DeleteMusicPromoterRelationships (string tableName)

Delete the given table relationships.

Removes the relationships between tables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMusicPromoterRelationshipsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Delete the given table relationships.
                Success result = apiInstance.DeleteMusicPromoterRelationships(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DeleteMusicPromoterRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemusicpromotertable"></a>
# **DeleteMusicPromoterTable**
> Success DeleteMusicPromoterTable (string tableName)

Delete (aka drop) the given table.

Careful, this drops the database table and all of its contents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMusicPromoterTableExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Delete (aka drop) the given table.
                Success result = apiInstance.DeleteMusicPromoterTable(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DeleteMusicPromoterTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="describemusicpromoterfield"></a>
# **DescribeMusicPromoterField**
> FieldSchema DescribeMusicPromoterField (string tableName, string fieldName, bool? refresh = null)

Retrieve the definition of the given field for the given table.

This describes the field and its properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DescribeMusicPromoterFieldExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fieldName = fieldName_example;  // string | Name of the field to perform operations on.
            var refresh = true;  // bool? | Refresh any cached resource list on the server. (optional) 

            try
            {
                // Retrieve the definition of the given field for the given table.
                FieldSchema result = apiInstance.DescribeMusicPromoterField(tableName, fieldName, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DescribeMusicPromoterField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fieldName** | **string**| Name of the field to perform operations on. | 
 **refresh** | **bool?**| Refresh any cached resource list on the server. | [optional] 

### Return type

[**FieldSchema**](FieldSchema.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="describemusicpromoterfields"></a>
# **DescribeMusicPromoterFields**
> FieldSchemas DescribeMusicPromoterFields (string tableName, bool? refresh = null)

Retrieve table field definitions for the given table.

This describes the table's fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DescribeMusicPromoterFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var refresh = true;  // bool? | Refresh any cached resource list on the server. (optional) 

            try
            {
                // Retrieve table field definitions for the given table.
                FieldSchemas result = apiInstance.DescribeMusicPromoterFields(tableName, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DescribeMusicPromoterFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **refresh** | **bool?**| Refresh any cached resource list on the server. | [optional] 

### Return type

[**FieldSchemas**](FieldSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="describemusicpromoterrelationship"></a>
# **DescribeMusicPromoterRelationship**
> RelationshipSchema DescribeMusicPromoterRelationship (string tableName, string relationshipName, bool? refresh = null)

Retrieve the definition of the given relationship for the given table.

This describes the relationship and its properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DescribeMusicPromoterRelationshipExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var relationshipName = relationshipName_example;  // string | Name of the relationship to perform operations on.
            var refresh = true;  // bool? | Refresh any cached resource list on the server. (optional) 

            try
            {
                // Retrieve the definition of the given relationship for the given table.
                RelationshipSchema result = apiInstance.DescribeMusicPromoterRelationship(tableName, relationshipName, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DescribeMusicPromoterRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **relationshipName** | **string**| Name of the relationship to perform operations on. | 
 **refresh** | **bool?**| Refresh any cached resource list on the server. | [optional] 

### Return type

[**RelationshipSchema**](RelationshipSchema.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="describemusicpromoterrelationships"></a>
# **DescribeMusicPromoterRelationships**
> RelationshipSchemas DescribeMusicPromoterRelationships (string tableName, bool? refresh = null)

Retrieve relationships definition for the given table.

This describes the table relationships to other tables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DescribeMusicPromoterRelationshipsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var refresh = true;  // bool? | Refresh any cached resource list on the server. (optional) 

            try
            {
                // Retrieve relationships definition for the given table.
                RelationshipSchemas result = apiInstance.DescribeMusicPromoterRelationships(tableName, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DescribeMusicPromoterRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **refresh** | **bool?**| Refresh any cached resource list on the server. | [optional] 

### Return type

[**RelationshipSchemas**](RelationshipSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="describemusicpromotertable"></a>
# **DescribeMusicPromoterTable**
> TableSchema DescribeMusicPromoterTable (string tableName, bool? refresh = null)

Retrieve table definition for the given table.

This describes the table, its fields and relations to other tables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DescribeMusicPromoterTableExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var refresh = true;  // bool? | Refresh any cached resource list on the server. (optional) 

            try
            {
                // Retrieve table definition for the given table.
                TableSchema result = apiInstance.DescribeMusicPromoterTable(tableName, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.DescribeMusicPromoterTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **refresh** | **bool?**| Refresh any cached resource list on the server. | [optional] 

### Return type

[**TableSchema**](TableSchema.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmusicpromoterrecord"></a>
# **GetMusicPromoterRecord**
> RecordResponse GetMusicPromoterRecord (string id, string tableName, List<string> fields = null, List<string> related = null, List<string> idField = null, List<string> idType = null)

Retrieve one record by identifier.

Use the **fields** parameter to limit properties that are returned. By default, all fields are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMusicPromoterRecordExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var id = id_example;  // string | Identifier of the record to retrieve.
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 

            try
            {
                // Retrieve one record by identifier.
                RecordResponse result = apiInstance.GetMusicPromoterRecord(id, tableName, fields, related, idField, idType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.GetMusicPromoterRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the record to retrieve. | 
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 

### Return type

[**RecordResponse**](RecordResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmusicpromoterrecords"></a>
# **GetMusicPromoterRecords**
> RecordsResponse GetMusicPromoterRecords (string tableName, List<string> fields = null, List<string> related = null, string filter = null, int? limit = null, int? offset = null, string order = null, string group = null, bool? countOnly = null, bool? includeCount = null, bool? includeSchema = null, List<int?> ids = null, List<string> idField = null, List<string> idType = null, bool? _continue = null, bool? rollback = null, string file = null)

Retrieve one or more records.

Set the **filter** parameter to a SQL WHERE clause (optional native filter accepted in some scenarios) to limit records returned or leave it blank to return all records up to the maximum limit. Set the **limit** parameter with or without a filter to return a specific amount of records. Use the **offset** parameter along with the **limit** parameter to page through sets of records. Set the **order** parameter to SQL ORDER_BY clause containing field and optional direction (field_name [ASC|DESC]) to order the returned records. Alternatively, to send the **filter** with or without **params** as posted data, use the getRecordsByPost() POST request and post a filter with or without params.Pass the identifying field values as a comma-separated list in the **ids** parameter. Use the **id_field** and **id_type** parameters to override or specify detail for identifying fields where applicable. Alternatively, to send the **ids** as posted data, use the getRecordsByPost() POST request. Use the **fields** parameter to limit properties returned for each record. By default, all fields are returned for all records. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMusicPromoterRecordsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var filter = filter_example;  // string | SQL-like filter to limit the records to retrieve. (optional) 
            var limit = 56;  // int? | Set to limit the filter results. (optional) 
            var offset = 56;  // int? | Set to offset the filter results to a particular record count. (optional) 
            var order = order_example;  // string | SQL-like order containing field and direction for filter results. (optional) 
            var group = group_example;  // string | Comma-delimited list of the fields used for grouping of filter results. (optional) 
            var countOnly = true;  // bool? | Return only the total number of filter results. (optional) 
            var includeCount = true;  // bool? | Include the total number of filter results in returned metadata. (optional) 
            var includeSchema = true;  // bool? | Include the schema of the table queried in returned metadata. (optional) 
            var ids = new List<int?>(); // List<int?> | Comma-delimited list of the identifiers of the records to retrieve. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var _continue = true;  // bool? | In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var rollback = true;  // bool? | In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var file = file_example;  // string | Download the results of the request as a file. **This is here for documentation purpose only. File will not download using API Docs.** (optional) 

            try
            {
                // Retrieve one or more records.
                RecordsResponse result = apiInstance.GetMusicPromoterRecords(tableName, fields, related, filter, limit, offset, order, group, countOnly, includeCount, includeSchema, ids, idField, idType, _continue, rollback, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.GetMusicPromoterRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **filter** | **string**| SQL-like filter to limit the records to retrieve. | [optional] 
 **limit** | **int?**| Set to limit the filter results. | [optional] 
 **offset** | **int?**| Set to offset the filter results to a particular record count. | [optional] 
 **order** | **string**| SQL-like order containing field and direction for filter results. | [optional] 
 **group** | **string**| Comma-delimited list of the fields used for grouping of filter results. | [optional] 
 **countOnly** | **bool?**| Return only the total number of filter results. | [optional] 
 **includeCount** | **bool?**| Include the total number of filter results in returned metadata. | [optional] 
 **includeSchema** | **bool?**| Include the schema of the table queried in returned metadata. | [optional] 
 **ids** | [**List&lt;int?&gt;**](int?.md)| Comma-delimited list of the identifiers of the records to retrieve. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **_continue** | **bool?**| In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **rollback** | **bool?**| In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **file** | **string**| Download the results of the request as a file. **This is here for documentation purpose only. File will not download using API Docs.** | [optional] 

### Return type

[**RecordsResponse**](RecordsResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmusicpromoterresources"></a>
# **GetMusicPromoterResources**
> MySqlDbs GetMusicPromoterResources (bool? asList = null, bool? asAccessList = null, bool? includeAccess = null, List<string> fields = null, List<string> idField = null, List<string> idType = null, bool? refresh = null)

Get resources for this service.

Return an array of the resources available.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMusicPromoterResourcesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var asList = true;  // bool? | Return only a list of the resource identifiers. (optional) 
            var asAccessList = true;  // bool? | Returns a list of the resources for role access designation. (optional) 
            var includeAccess = true;  // bool? | Include the access permissions for the returned resource. (optional) 
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var refresh = true;  // bool? | Refresh any cached resource list on the server. (optional) 

            try
            {
                // Get resources for this service.
                MySqlDbs result = apiInstance.GetMusicPromoterResources(asList, asAccessList, includeAccess, fields, idField, idType, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.GetMusicPromoterResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asList** | **bool?**| Return only a list of the resource identifiers. | [optional] 
 **asAccessList** | **bool?**| Returns a list of the resources for role access designation. | [optional] 
 **includeAccess** | **bool?**| Include the access permissions for the returned resource. | [optional] 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **refresh** | **bool?**| Refresh any cached resource list on the server. | [optional] 

### Return type

[**MySqlDbs**](MySqlDbs.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmusicpromoterschemas"></a>
# **GetMusicPromoterSchemas**
> TableSchemas GetMusicPromoterSchemas (List<string> fields = null, List<int?> ids = null)

Retrieve one or more Schemas.

Use the 'ids' parameter to limit records that are returned. By default, all records up to the maximum are returned. Use the 'fields' parameters to limit properties returned for each record. By default, all fields are returned for each record.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMusicPromoterSchemasExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var ids = new List<int?>(); // List<int?> | Comma-delimited list of the identifiers of the records to retrieve. (optional) 

            try
            {
                // Retrieve one or more Schemas.
                TableSchemas result = apiInstance.GetMusicPromoterSchemas(fields, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.GetMusicPromoterSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **ids** | [**List&lt;int?&gt;**](int?.md)| Comma-delimited list of the identifiers of the records to retrieve. | [optional] 

### Return type

[**TableSchemas**](TableSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmusicpromoterstoredfunctions"></a>
# **GetMusicPromoterStoredFunctions**
> StoredRoutineSchemas GetMusicPromoterStoredFunctions (List<string> fields = null, List<int?> ids = null)

Retrieve one or more StoredFunctions.

Use the 'ids' parameter to limit records that are returned. By default, all records up to the maximum are returned. Use the 'fields' parameters to limit properties returned for each record. By default, all fields are returned for each record.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMusicPromoterStoredFunctionsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var ids = new List<int?>(); // List<int?> | Comma-delimited list of the identifiers of the records to retrieve. (optional) 

            try
            {
                // Retrieve one or more StoredFunctions.
                StoredRoutineSchemas result = apiInstance.GetMusicPromoterStoredFunctions(fields, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.GetMusicPromoterStoredFunctions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **ids** | [**List&lt;int?&gt;**](int?.md)| Comma-delimited list of the identifiers of the records to retrieve. | [optional] 

### Return type

[**StoredRoutineSchemas**](StoredRoutineSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmusicpromoterstoredprocedures"></a>
# **GetMusicPromoterStoredProcedures**
> StoredRoutineSchemas GetMusicPromoterStoredProcedures (List<string> fields = null, List<int?> ids = null)

Retrieve one or more StoredProcedures.

Use the 'ids' parameter to limit records that are returned. By default, all records up to the maximum are returned. Use the 'fields' parameters to limit properties returned for each record. By default, all fields are returned for each record.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMusicPromoterStoredProceduresExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var ids = new List<int?>(); // List<int?> | Comma-delimited list of the identifiers of the records to retrieve. (optional) 

            try
            {
                // Retrieve one or more StoredProcedures.
                StoredRoutineSchemas result = apiInstance.GetMusicPromoterStoredProcedures(fields, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.GetMusicPromoterStoredProcedures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **ids** | [**List&lt;int?&gt;**](int?.md)| Comma-delimited list of the identifiers of the records to retrieve. | [optional] 

### Return type

[**StoredRoutineSchemas**](StoredRoutineSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmusicpromotertables"></a>
# **GetMusicPromoterTables**
> TableSchemas GetMusicPromoterTables (List<string> fields = null, List<int?> ids = null)

Retrieve one or more Tables.

Use the 'ids' parameter to limit records that are returned. By default, all records up to the maximum are returned. Use the 'fields' parameters to limit properties returned for each record. By default, all fields are returned for each record.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMusicPromoterTablesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var ids = new List<int?>(); // List<int?> | Comma-delimited list of the identifiers of the records to retrieve. (optional) 

            try
            {
                // Retrieve one or more Tables.
                TableSchemas result = apiInstance.GetMusicPromoterTables(fields, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.GetMusicPromoterTables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **ids** | [**List&lt;int?&gt;**](int?.md)| Comma-delimited list of the identifiers of the records to retrieve. | [optional] 

### Return type

[**TableSchemas**](TableSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemusicpromoterfield"></a>
# **ReplaceMusicPromoterField**
> Success ReplaceMusicPromoterField (string tableName, string fieldName)

Update one field by identifier.

Post data should be an array of field properties for the given field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMusicPromoterFieldExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fieldName = fieldName_example;  // string | Name of the field to perform operations on.

            try
            {
                // Update one field by identifier.
                Success result = apiInstance.ReplaceMusicPromoterField(tableName, fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.ReplaceMusicPromoterField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fieldName** | **string**| Name of the field to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemusicpromoterfields"></a>
# **ReplaceMusicPromoterFields**
> Success ReplaceMusicPromoterFields (string tableName)

Update (replace) table fields with the given properties.

Post data should be an array of fields and their properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMusicPromoterFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Update (replace) table fields with the given properties.
                Success result = apiInstance.ReplaceMusicPromoterFields(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.ReplaceMusicPromoterFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemusicpromoterrecord"></a>
# **ReplaceMusicPromoterRecord**
> RecordResponse ReplaceMusicPromoterRecord (string id, string tableName, List<string> fields = null, List<string> related = null, List<string> idField = null, List<string> idType = null)

Replace the content of one record by identifier.

Post data should be an array of fields for a single record. Use the **fields** parameter to return more properties. By default, the id is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMusicPromoterRecordExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var id = id_example;  // string | Identifier of the record to retrieve.
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 

            try
            {
                // Replace the content of one record by identifier.
                RecordResponse result = apiInstance.ReplaceMusicPromoterRecord(id, tableName, fields, related, idField, idType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.ReplaceMusicPromoterRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the record to retrieve. | 
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 

### Return type

[**RecordResponse**](RecordResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemusicpromoterrecords"></a>
# **ReplaceMusicPromoterRecords**
> RecordsResponse ReplaceMusicPromoterRecords (string tableName, List<string> fields = null, List<string> related = null, List<int?> ids = null, List<string> idField = null, List<string> idType = null, bool? _continue = null, bool? rollback = null, string filter = null)

Update (replace) one or more records.

Post data should be an array of records wrapped in a **resource** tag. If ids or filter is used, posted body should be a single record with name-value pairs to update, wrapped in a **resource** tag. Ids can be included via URL parameter or included in the posted body. Filter can be included via URL parameter or included in the posted body. By default, only the id property of the record is returned on success. Use **fields** parameter to return more info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMusicPromoterRecordsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var ids = new List<int?>(); // List<int?> | Comma-delimited list of the identifiers of the records to retrieve. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var _continue = true;  // bool? | In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var rollback = true;  // bool? | In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var filter = filter_example;  // string | SQL-like filter to limit the records to retrieve. (optional) 

            try
            {
                // Update (replace) one or more records.
                RecordsResponse result = apiInstance.ReplaceMusicPromoterRecords(tableName, fields, related, ids, idField, idType, _continue, rollback, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.ReplaceMusicPromoterRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **ids** | [**List&lt;int?&gt;**](int?.md)| Comma-delimited list of the identifiers of the records to retrieve. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **_continue** | **bool?**| In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **rollback** | **bool?**| In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **filter** | **string**| SQL-like filter to limit the records to retrieve. | [optional] 

### Return type

[**RecordsResponse**](RecordsResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemusicpromoterrelationship"></a>
# **ReplaceMusicPromoterRelationship**
> Success ReplaceMusicPromoterRelationship (string tableName, string relationshipName)

Update one relationship by identifier.

Post data should be an array of properties for the given relationship.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMusicPromoterRelationshipExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var relationshipName = relationshipName_example;  // string | Name of the relationship to perform operations on.

            try
            {
                // Update one relationship by identifier.
                Success result = apiInstance.ReplaceMusicPromoterRelationship(tableName, relationshipName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.ReplaceMusicPromoterRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **relationshipName** | **string**| Name of the relationship to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemusicpromoterrelationships"></a>
# **ReplaceMusicPromoterRelationships**
> Success ReplaceMusicPromoterRelationships (string tableName)

Update (replace) table relationships with the given properties.

Post data should be an array of relationship properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMusicPromoterRelationshipsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Update (replace) table relationships with the given properties.
                Success result = apiInstance.ReplaceMusicPromoterRelationships(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.ReplaceMusicPromoterRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemusicpromotertable"></a>
# **ReplaceMusicPromoterTable**
> Success ReplaceMusicPromoterTable (string tableName)

Update (replace) a table with the given properties.

Post data should be an array of field properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMusicPromoterTableExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Update (replace) a table with the given properties.
                Success result = apiInstance.ReplaceMusicPromoterTable(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.ReplaceMusicPromoterTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemusicpromotertables"></a>
# **ReplaceMusicPromoterTables**
> TableSchemas ReplaceMusicPromoterTables ()

Update (replace) one or more tables.

Post data should be a single table definition or an array of table definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMusicPromoterTablesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();

            try
            {
                // Update (replace) one or more tables.
                TableSchemas result = apiInstance.ReplaceMusicPromoterTables();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.ReplaceMusicPromoterTables: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TableSchemas**](TableSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemusicpromoterfield"></a>
# **UpdateMusicPromoterField**
> Success UpdateMusicPromoterField (string tableName, string fieldName)

Update one field by identifier.

Post data should be an array of field properties for the given field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMusicPromoterFieldExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fieldName = fieldName_example;  // string | Name of the field to perform operations on.

            try
            {
                // Update one field by identifier.
                Success result = apiInstance.UpdateMusicPromoterField(tableName, fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.UpdateMusicPromoterField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fieldName** | **string**| Name of the field to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemusicpromoterfields"></a>
# **UpdateMusicPromoterFields**
> Success UpdateMusicPromoterFields (string tableName)

Update (patch) table fields with the given properties.

Post data should be an array of field properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMusicPromoterFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Update (patch) table fields with the given properties.
                Success result = apiInstance.UpdateMusicPromoterFields(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.UpdateMusicPromoterFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemusicpromoterrecord"></a>
# **UpdateMusicPromoterRecord**
> RecordResponse UpdateMusicPromoterRecord (string id, string tableName, List<string> fields = null, List<string> related = null, List<string> idField = null, List<string> idType = null)

Update (patch) one record by identifier.

Post data should be an array of fields for a single record. Use the **fields** parameter to return more properties. By default, the id is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMusicPromoterRecordExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var id = id_example;  // string | Identifier of the record to retrieve.
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 

            try
            {
                // Update (patch) one record by identifier.
                RecordResponse result = apiInstance.UpdateMusicPromoterRecord(id, tableName, fields, related, idField, idType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.UpdateMusicPromoterRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the record to retrieve. | 
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 

### Return type

[**RecordResponse**](RecordResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemusicpromoterrecords"></a>
# **UpdateMusicPromoterRecords**
> RecordsResponse UpdateMusicPromoterRecords (string tableName, List<string> fields = null, List<string> related = null, List<int?> ids = null, List<string> idField = null, List<string> idType = null, bool? _continue = null, bool? rollback = null, string filter = null)

Update (patch) one or more records.

Post data should be an array of records containing at least the identifying fields for each record. Posted body should be a single record with name-value pairs to update wrapped in a **record** tag. Ids can be included via URL parameter or included in the posted body. Filter can be included via URL parameter or included in the posted body. By default, only the id property of the record is returned on success. Use **fields** parameter to return more info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMusicPromoterRecordsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var fields = new List<string>(); // List<string> | Comma-delimited list of properties to be returned for each resource, \"*\" returns all properties. If as_list, use this to override the default identifier. (optional) 
            var related = new List<string>(); // List<string> | Comma-delimited list of related names to retrieve for each resource. (optional) 
            var ids = new List<int?>(); // List<int?> | Comma-delimited list of the identifiers of the records to retrieve. (optional) 
            var idField = new List<string>(); // List<string> | Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var idType = new List<string>(); // List<string> | Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. (optional) 
            var _continue = true;  // bool? | In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var rollback = true;  // bool? | In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. (optional) 
            var filter = filter_example;  // string | SQL-like filter to limit the records to retrieve. (optional) 

            try
            {
                // Update (patch) one or more records.
                RecordsResponse result = apiInstance.UpdateMusicPromoterRecords(tableName, fields, related, ids, idField, idType, _continue, rollback, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.UpdateMusicPromoterRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of properties to be returned for each resource, \&quot;*\&quot; returns all properties. If as_list, use this to override the default identifier. | [optional] 
 **related** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of related names to retrieve for each resource. | [optional] 
 **ids** | [**List&lt;int?&gt;**](int?.md)| Comma-delimited list of the identifiers of the records to retrieve. | [optional] 
 **idField** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the fields used as identifiers, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **idType** | [**List&lt;string&gt;**](string.md)| Comma-delimited list of the field types used as identifiers for the table, used to override defaults or provide identifiers when none are provisioned. | [optional] 
 **_continue** | **bool?**| In batch scenarios where supported, continue processing even after one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **rollback** | **bool?**| In batch scenarios where supported, rollback all actions if one action fails. Default behavior is to halt and return results up to the first point of failure. | [optional] 
 **filter** | **string**| SQL-like filter to limit the records to retrieve. | [optional] 

### Return type

[**RecordsResponse**](RecordsResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemusicpromoterrelationship"></a>
# **UpdateMusicPromoterRelationship**
> Success UpdateMusicPromoterRelationship (string tableName, string relationshipName)

Update one relationship by identifier.

Post data should be an array of properties for the given relationship.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMusicPromoterRelationshipExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.
            var relationshipName = relationshipName_example;  // string | Name of the relationship to perform operations on.

            try
            {
                // Update one relationship by identifier.
                Success result = apiInstance.UpdateMusicPromoterRelationship(tableName, relationshipName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.UpdateMusicPromoterRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 
 **relationshipName** | **string**| Name of the relationship to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemusicpromoterrelationships"></a>
# **UpdateMusicPromoterRelationships**
> Success UpdateMusicPromoterRelationships (string tableName)

Update (patch) a table with the given properties.

Post data should be an array of relationship properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMusicPromoterRelationshipsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Update (patch) a table with the given properties.
                Success result = apiInstance.UpdateMusicPromoterRelationships(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.UpdateMusicPromoterRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemusicpromotertable"></a>
# **UpdateMusicPromoterTable**
> Success UpdateMusicPromoterTable (string tableName)

Update (patch) a table with the given properties.

Post data should be an array of field properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMusicPromoterTableExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();
            var tableName = tableName_example;  // string | Name of the table to perform operations on.

            try
            {
                // Update (patch) a table with the given properties.
                Success result = apiInstance.UpdateMusicPromoterTable(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.UpdateMusicPromoterTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to perform operations on. | 

### Return type

[**Success**](Success.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemusicpromotertables"></a>
# **UpdateMusicPromoterTables**
> TableSchemas UpdateMusicPromoterTables ()

Update (patch) one or more tables.

Post data should be a single table definition or an array of table definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMusicPromoterTablesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyUserSecret
            Configuration.Default.ApiKey.Add("user-secret-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("user-secret-api-key", "Bearer");
            // Configure API key authorization: SessionTokenHeader
            Configuration.Default.ApiKey.Add("X-DreamFactory-Session-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-DreamFactory-Session-Token", "Bearer");

            var apiInstance = new Music_promoterApi();

            try
            {
                // Update (patch) one or more tables.
                TableSchemas result = apiInstance.UpdateMusicPromoterTables();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Music_promoterApi.UpdateMusicPromoterTables: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TableSchemas**](TableSchemas.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyUserSecret](../README.md#ApiKeyUserSecret), [SessionTokenHeader](../README.md#SessionTokenHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

