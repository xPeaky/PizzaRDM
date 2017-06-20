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
* Entrer un nombre comme par exemple: -1820302793
* Le programme retourne le contenu décodé. Ici: flash.display.Loader

#### TODO
- [x] Décodage des définitions
- [ ] Décodage automatique du fichier HumanCheck.as
