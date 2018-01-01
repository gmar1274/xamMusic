# IO.Swagger.Model.FieldSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The API name of the field. | [optional] 
**Label** | **string** | The displayable label for the field. | [optional] 
**Type** | **string** | The DreamFactory abstract data type for this field. | [optional] 
**DbType** | **string** | The native database type used for this field. | [optional] 
**Length** | **int?** | The maximum length allowed (in characters for string, displayed for numbers). | [optional] 
**Precision** | **int?** | Total number of places for numbers. | [optional] 
**Scale** | **int?** | Number of decimal places allowed for numbers. | [optional] 
**DefaultValue** | **string** | Default value for this field. | [optional] 
**Required** | **bool?** | Is a value required for record creation. | [optional] 
**AllowNull** | **bool?** | Is null allowed as a value. | [optional] 
**FixedLength** | **bool?** | Is the length fixed (not variable). | [optional] 
**SupportsMultibyte** | **bool?** | Does the data type support multibyte characters. | [optional] 
**AutoIncrement** | **bool?** | Does the integer field value increment upon new record creation. | [optional] 
**IsPrimaryKey** | **bool?** | Is this field used as/part of the primary key. | [optional] 
**IsForeignKey** | **bool?** | Is this field used as a foreign key. | [optional] 
**RefTable** | **string** | For foreign keys, the referenced table name. | [optional] 
**RefField** | **string** | For foreign keys, the referenced table field name. | [optional] 
**Validation** | **List&lt;string&gt;** | validations to be performed on this field. | [optional] 
**Value** | **List&lt;string&gt;** | Selectable string values for client menus and picklist validation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

