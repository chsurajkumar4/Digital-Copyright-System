# Digital-Copyright-System
# COPYRIGHT-SYSTEM
This is a Desktop based App which is used to store the COPYRIGHT details of any product over Flo BLOCKCHAIN.
User need to go through login process for connecting the app to the Flo Core Wallet and proceeding for further transactions.
# REQUIREMENTS
Flo Core Wallet,VIsual Studio 2017 with c# and .net framework installed in it.
# Installation
STEP1-Just download the repository and and extract it in according to ur preferred directory.
STEP2-Open the COPYRIGHT-SYSTEM folder the open the Copyright-System.sln file using VIsual Studio
STEP3-Expand the Solution Explorer on the right corner then open the App.Config file and then change 
      the credentials according to ur Flo.Conf file of ur FLo Core Wallet in order to access the wallet for transaction purpose.
      ![screenshot 37](https://user-images.githubusercontent.com/39794980/47282055-61da3c80-d5fb-11e8-9f2d-5ac4ec24f796.png)
STEP4-Now you need to connect the database file to the project... connect to the .mdf file from the folder where the .sln file is stored.
      ![screenshot 11](https://user-images.githubusercontent.com/39794980/50694744-bde02900-1060-11e9-904a-5dd946704ce7.png)
and now browse the folder wherever you downloaded teh project.
      ![screenshot 12](https://user-images.githubusercontent.com/39794980/50694919-31823600-1061-11e9-9e8c-14ecb2260496.png)
STEP5-Now change the directory in the project of the database file. Go to solution explorer and and on every "usercontrol.cs" file
     change the sql conection data source...
     ![screenshot 10](https://user-images.githubusercontent.com/39794980/50695595-1b757500-1063-11e9-9fb4-784c8393f1f3.png)
     Now instead of that copy the Data String of the database there.
     STEP6-Now go the properties of the database and the copy the CONNECTION STRING and replace it in the place of data source of 
     SQLCONNECTION.
     ![screenshot 13](https://user-images.githubusercontent.com/39794980/50696380-495bb900-1065-11e9-935d-62529a0ac437.png)
     ![screenshot 14](https://user-images.githubusercontent.com/39794980/50696425-71e3b300-1065-11e9-9c99-ff38b02802d5.png)
