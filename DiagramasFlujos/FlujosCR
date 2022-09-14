# Diagrama de Flujos

![Workflow](img/Workflow.jpeg)

## Flujo 113

1. Se obtendra el archivo en **C:\Signature\Queues\ExtractorReceiver** en caso de no tener esa carpeta es necesario crearla

2. Su Assembly es **TF.Integration.Datasource.SAP3** y su metodo es **ProcessExtractor**

![Workflow](img/flow%20113.png)

![Workflow](img/main%20flow%20113.png)

## Flujos

| Flujo       | Descripcion |
| ----------- | ----------- |
| 113         | Flujo para procesar los IDOCS recibidos       |
| 11201   | Firmar TODOS los documentos de Costa Rica        |
| 11101           | Validar TODOS los documentos de Costa Rica |
|11301| Imprime TODOS los documentos de Costa Rica|
|11401| Distribuye TODOS los documentos de Costa Rica|
|11501|Manda TODOS los documentos de Costa Rica al DGT|
|11601| Verifica TODOS los documentos de Costa Rica
|11701| Manda el Acuse de Recivido de TODOS los documentos de Costa rica

## Flujos en RTC y CS

| Flujo       | Descripcion | Ubicacion   |
| ----------- | ----------- | ----------- |
| 113         | JSON File processing  | RTC |
| 11001       | Mapping               | RTC |
| 11101       | Validation            | RTC |
| 11201       | Signing               | RTC |
| 11301       | PDF generation        | CS  |
| 11401       | Distribution (Email and FTP | CS |
| 11501       | Send the Invoice to DGT | CS |
| 11601       | Check the Invoice status | CS |
| 11701 | Acuse Inbound actions | CS |
| 505 | Add Aditional Inbound Attachments (it's necessary if you want to use multiple emails for Acuse) |CS |	
	
