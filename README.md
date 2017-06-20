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
#### Descrpition
Ce tool vous permet de décoder ce type de code:
```ActionScript
if((dofusClassDesc.@name.toString() == dec("PFmDRk0=","eDblMz4=") && dofusClassDesc.@base.toString() == dec("WayFi0h6xE3NXVOhncIaB9BW11la","P8Dk+CBUoCS+LQ==") && dofusClassDesc.@isDynamic.toString() == "false" && dofusClassDesc.@isFinal.toString() == "false" && dofusClassDesc.@isStatic.toString() == "false" && _loc3_.@declaredBy.toString() == dec("VHURGC9Ia1ZHKl54CVF9ImZMRDZTYD8JLQNsSw==","Mhlwa0dmDz80Wg==")) != function():Boolean
            {```
           
en

```ActionScript
if((dofusClassDesc.@name.toString() == "Dofus" && dofusClassDesc.@base.toString() == "flash.display::Sprite" && dofusClassDesc.@isDynamic.toString() == "false" && dofusClassDesc.@isFinal.toString() == "false" && dofusClassDesc.@isStatic.toString() == "false" && _loc3_.@declaredBy.toString() == "flash.display::DisplayObject") != function():Boolean
            {```
            
#### Fonctionnement
* Lancer le programme DecRDM.exe
* Entrer le chemin du fichier HumanCheck.as
* Entrer le chemin de sortie du fichier HumanCheck.as décodé

#### TODO
- [x] Décryptage des strings
- [x] Décryptage automatique du fichier HumanCheck.as
