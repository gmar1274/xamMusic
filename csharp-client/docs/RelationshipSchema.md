# IO.Swagger.Model.RelationshipSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the relationship. | [optional] 
**Alias** | **string** | Alias to use in the API to override the name the relationship. | [optional] 
**Label** | **string** | Label for the relationship. | [optional] 
**Description** | **string** | Description of the relationship. | [optional] 
**Type** | **string** | Relationship type - belongs_to, has_many, many_many. | [optional] 
**Field** | **string** | The current table field that is used in the relationship. | [optional] 
**RefTable** | **string** | The table name that is referenced by the relationship. | [optional] 
**RefField** | **string** | The field name that is referenced by the relationship. | [optional] 
**JunctionTable** | **string** | The intermediate junction table used for many_many relationships. | [optional] 
**JunctionField** | **string** | The intermediate junction table field used for many_many relationships. | [optional] 
**JunctionRefField** | **string** | The intermediate joining table referencing field used for many_many relationships. | [optional] 
**AlwaysFetch** | **bool?** | Always fetch this relationship when querying the parent table. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

