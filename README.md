# Synchroxyz
Solution nests functions for transfer data to tdm365. There are 3 different flows. Developted by CSoft Kazan

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
`POST` api/GPPtransferDocResponse

request json body:

```js
{
	Completed: true, // status of reading XML in flow 1. true or false
	SystemName:"TDM365", // name of system sended request
	Result:"Операция выполнена успешно", // some comment for user
	Date:"13.12.2021 16:22:44", // import xml date
	FolderGuid:"{014B9F82-CD2D-4B0B-80AE-732208C63684}", // GUID of OBJECT_Folder from extarnal system
	O_Package_Unload:"{E940818C-2F4C-4889-A15F-1EAD22F205D0}" // GUID of O_Package_Unload from XML
}
```
ed




