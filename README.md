# Synchroxyz
Solution contents functions for transfer data to tdm365 system and exchange WBS formatted structured data to external system. 
Solutiona nests list of components at client version of TDMS eather list of controller at TDMS App Server.
Developed by CSoft Kazan

#### List of components

type|name|sysname|note
-|-|-|-
command|Отправить в 365|CMD_SEND_TO_365
object|Пакет выгрузки|O_Package_Unload
command|master|CMD_master|test command
object|Реестр замечаний|O_ClaimRegistry
object|Замечание реестра|O_DocClaim
attribute|URL 365|a_url_365|string
attribute|Папка обмена 365|a_folder_path_365|string
attribute|Адрес сервера|a_url_own|string

#### Methods
`POST` **api/wbscreate** Create new project structure
```js
{
	projectGUID: "{2B1C6ED4-17B0-4553-8756-B631F640BB9A}",

}

`POST` **api/GPPtransferDocResponse**

request json body:
```js
{
	Completed: true, // status of reading XML in flow 1. true or false
	SystemName:"TDM365", // name of system sended request
	Result:"Операция выполнена успешно", // some comment for user
	Date:"13.12.2021 16:22:44", // import xml date
	FolderGuid:"{014B9F82-CD2D-4B0B-80AE-732208C63684}", // GUID of OBJECT_Folder from tdm365
	O_Package_Unload:"{E940818C-2F4C-4889-A15F-1EAD22F205D0}" // GUID of O_Package_Unload from XML
}
```

`POST` **api/GPPgetClaimRegistry**

request json body:
```js
{
	A_Str_GUID_External: "{014B9F82-CD2D-4B0B-80AE-732208C63684}", // GUID of OBJECT_Registry from tdm365
	SystemName:"TDM365", // name of system sended request
	A_Ref_Doc: "{014B9F82-CD2D-4B0B-80AE-732208C63684}", // GUID of Document object linked 
	A_Date_Create:"13.12.2021 16:22:44", // OBJECT_Registry date create
	FolderGuid:"{014B9F82-CD2D-4B0B-80AE-732208C63684}", // GUID of OBJECT_Folder from extarnal system
	O_Package_Unload:"{E940818C-2F4C-4889-A15F-1EAD22F205D0}" // GUID of O_Package_Unload from XML
}