# PizzaRDM
## RDM_Decrypt
#### Description
Ce tool vous permet de décoder ce type de code:
```ActionScript
lfc = new (getDefinitionByName(§_a_-_---§.§_a_--_--§(-1820302793)) as Class)();
lfc[§_a_-_---§.§_a_--_--§(-1820302787)][§_a_-_---§.§_a_--_--§(-1820302790)](§_a_-_---§.§_a_--_--§(-1820302815),function(param1:*):void
```

en

```ActionScript
lfc = new getDefinitionByName("flash.display.Loader"); // flash.display.Loader
lfc["contentLoaderInfo"]["addEventListener"]("complete",function(param1:*):void
```

#### Fonctionnement
* Lancer le programme RDM_Decrypt.exe
* Entrer le chemin du fichier HumanCheck.as
* Entrer le chemin de sortie du fichier HumanCheck.as décodé

#### TODO
- [x] Décodage des définitions
- [x] Décodage automatique du fichier HumanCheck.as

## DecRDM
#### Description
Ce tool vous permet de décoder ce type de code:
```ActionScript
if((dofusClassDesc.@name.toString() == dec("PFmDRk0=","eDblMz4=") && dofusClassDesc.@base.toString() == dec("WayFi0h6xE3NXVOhncIaB9BW11la","P8Dk+CBUoCS+LQ==") && dofusClassDesc.@isDynamic.toString() == "false" && dofusClassDesc.@isFinal.toString() == "false" && dofusClassDesc.@isStatic.toString() == "false" && _loc3_.@declaredBy.toString() == dec("VHURGC9Ia1ZHKl54CVF9ImZMRDZTYD8JLQNsSw==","Mhlwa0dmDz80Wg==")) != function():Boolean
            {
```

en

```ActionScript
if((dofusClassDesc.@name.toString() == "Dofus" && dofusClassDesc.@base.toString() == "flash.display::Sprite" && dofusClassDesc.@isDynamic.toString() == "false" && dofusClassDesc.@isFinal.toString() == "false" && dofusClassDesc.@isStatic.toString() == "false" && _loc3_.@declaredBy.toString() == "flash.display::DisplayObject") != function():Boolean
            {
```
            
#### Fonctionnement
* Lancer le programme DecRDM.exe
* Entrer le chemin du fichier HumanCheck.as
* Entrer le chemin de sortie du fichier HumanCheck.as décodé

#### TODO
- [x] Décodage des strings
- [x] Décodage automatique du fichier HumanCheck.as

## ClassIdentifier
#### Description
Ce tool vous permet d'identifier les classes avec le nom obfu:
```ActionScript
var _loc12_:_SDEDEOIEOML = new _SDEDEOIEOML();
         var _loc13_:_SMOHLXWELH = new _SMOHLXWELH(new _SEWLWDOGGEI(new _SEXGEGLIGWO(_loc11_),_loc12_));
         var _loc14_:ByteArray = new getDefinitionByName("flash.utils.ByteArray")();
         _loc14_["writeUTF"](!!_loc2_["getInstance"]()["gameServerTicket"]?_loc2_["getInstance"]()["gameServerTicket"]:"");
         _loc14_["writeBytes"](getDefinitionByName("by.blooddy.crypto.MD5")["hash"](_loc10_));
```

en

```ActionScript
var _loc12_:TLSPad = new TLSPad();
         var _loc13_:SimpleIVMode = new SimpleIVMode(new CBCMode(new AESKey(_loc11_),_loc12_));
         var _loc14_:ByteArray = new getDefinitionByName("flash.utils.ByteArray")();
         _loc14_["writeUTF"](!!_loc2_["getInstance"]()["gameServerTicket"]?_loc2_["getInstance"]()["gameServerTicket"]:"");
         _loc14_["writeBytes"](getDefinitionByName("by.blooddy.crypto.MD5")["hash"](_loc10_));
```

#### Fonctionnement
* Lancer le programme Program.exe
* Entrer le chemin du fichier HumanCheck.as
* Entrer le chemin de sortie du fichier HumanCheck.as renommé

#### TODO
- [x] Identification des classes
- [x] Renommer les classes automatiquement

## FunctionReplace
#### Description
Ce tool vous permet de remplacer les fonctions comme ceci:
```ActionScript
 var _AESKey:Class = lfc["contentLoaderInfo"]["applicationDomain"]["getDefinition"]("com.hurlant.crypto.symmetric.AESKey") as Class;
           ```
           
en

```ActionScript
var _AESKey:Class = lfc.contentLoaderInfo.applicationDomain.getDefinition("com.hurlant.crypto.symmetric.AESKey") as Class;
            ```

#### Fonctionnement
* Lancer le programme Program.exe
* Entrer le chemin du fichier HumanCheck.as
* Entrer le chemin de sortie du fichier HumanCheck.as avec les fonctions remplacées

#### TODO
- [x] Remplacé le nom des fonctions
- [x] Automatiser

WTF AN**AMA: https://pastebin.com/iH4fCdC1
