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

request body





