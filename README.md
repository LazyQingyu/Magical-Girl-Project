# Pour rappel

`Git` est un système de contrôle de version qui permet aux développeurs de suivre les modifications apportées au code et de collaborer plus efficacement sur des projets. Il enregistre l'historique des modifications dans un dépôt (repository), permettant de revenir à des versions antérieures du code si nécessaire. Git est largement utilisé dans le développement logiciel pour gérer les versions et faciliter le travail d'équipe grâce à des branches et des fusions (merges).
‍<br><br><br><br><br><br>
# 1. Définitions
<br><br>
### 1. Les bases :
<br><br><br>
`Local repo ou repository (dépôt)` : Le répertoire contenant le code et les fichiers du projet.


`Remote repository` : Version en ligne du repository contenant le code et les fichiers du projet, hébergée sur des services comme $\color{teal}{\textsf{GitHub}}$ ou $\color{orange}{\textsf{GitLab}}$.



`Clonage (Cloning)` : Copie d'un dépôt dans un nouveau répertoire.


`Commit` : Point de sauvegarde du projet auquel vous pouvez revenir à tout moment (effectués à certains points d’étapes).


`Branch` : Une copie du projet utilisée pour travailler dans un environnement indépendant sans affecter le projet principal.


`Git merge` : Le fait de fusionner deux branches ensemble.
<br><br>
### 2. Définitions avancées :
<br><br><br>
 `Fichier .gitignore` : Fichier qui liste d'autres fichiers que Git ne doit pas suivre (Comme de grands dossiers de données, des informations privées ou tous les fichiers locaux qui ne devraient pas être vus par le public).
    
`Zone de staging` (Staging area) : Un cache qui contient les modifications que vous souhaitez commit ensuite.
    
`Git stash` : Un autre type de cache qui contient des modifications que vous pourriez vouloir récupérer plus tard afin de les finaliser.
    
`Commit ID or hash` : Un identifiant unique pour chaque commit, utilisé pour basculer vers différents points de sauvegarde.
    
`HEAD` : Un nom de référence pour le dernier commit, pour éviter d'avoir à taper les commit ID. La syntaxe HEAD~n est utilisée pour se référer aux commits plus anciens (par exemple, HEAD~2 se réfère à l'avant-dernier commit).

‍<br><br><br><br><br><br>
# 2. Les bases

Un repository permet l’exécution du code sans erreurs. Un repo local est généralement un répertoire sur votre machine, tandis qu'un remote est hébergé sur des serveurs comme GitHub.  

<br><br>
### 1. Créer dans un repository local :
<br><br><br>
 Cloner un repo depuis des hébergeurs distants (GitHub, GitLab, DagsHub, etc.) 
    
    $ git clone <url_du_repo_en_ligne>
<br>
    
Initialiser le suivi Git dans le répertoire actuel 
    
    $ git init
<br>
    
Créer un repo suivi par Git dans un nouveau répertoire 
    
    $ git init [nom_du_répertoire]
<br>
    
Cloner uniquement une branche spécifique 
    
    $ git clone -branch <nom_de_branche><url_du_repo>
<br>
    
Cloner dans un répertoire spécifié 
    
    $ git clone <url_du_repo><nom_du_répertoire>
<br><br>
### 2. Clonage :
<br><br><br>
Il existe deux façons de cloner un repository, par HTTPS (plus courant, plus simple) et par SSH (plus sécurisé).
‍

HTTPS 

    $ git clone https://github.com/votre_username/nom_du_repo.get
<br>
SSH 

    $ git clone git@github.com:username/nom_du_repo.git
    
<br><br>
### 3. Gestion des remote repositories :
<br><br><br>
Lister les remote repo

    $ git remote
    
<br>
Créer une nouvelle connexion nommée “remote” à un repository en ligne sur des serveurs GitHub, GitLab, etc.
    
    $ git remote add <remote><url_du_repo_en_ligne>
    
<br> 
Supprimer une connexion à un repository en ligne appelée “remote” 
    
    $ git remote rm <remote>
    
<br>
Renommer une connexion distante
    
    $ git remote rename <ancien_nom><nouveau_nom>
<br><br><br><br><br><br>
# 3. Travailler sur les fichiers

<br><br><br><br>

### 1. Ajouter et supprimer des fichiers :
<br><br><br>
Ajouter un fichier ou un répertoire à Git pour le suivi 
    
    $ git add <nom_fichier_ou_répertoire>
    
<br>
Ajouter tous les fichiers suivis et non suivis dans le répertoire actuel sur Git
    
    $ git add .
    
<br>
Supprimer un fichier d'un répertoire de travail ou de la zone de staging 
    
    $ git rm <nom_fichier_ou_répertoire>
    
<br><br>

### 2. Enregistrer et travailler avec les changements :
<br><br><br>
Voir les changements dans le repo local 
    
    $ git status
<br>
Enregistrer un commit des changements avec un message personnalisé
    
    $ git commit -m "[Message du commit]"
<br>
Modifier le message du dernier commit 
    
    $ git commit --amend -m "[Nouveau message de commit]"
<br><br>
### 3. Stash :
<br><br><br>
Sauvegarder les changements staged et non staged dans un stash pour une utilisation ultérieure 
    
    $ git stash
<br>
Sauvegarder tous les changements, y compris les fichiers non staged et non suivis
    
    $ git stash -u
<br>
Sauvegarder tous les changements, y compris les fichiers ignorés 

    $ git stash --all
<br>
Réappliquer le stach précédent et vider le stash 
    
    $ git stash pop
<br>
Réappliquer le stach précédent et conserver le stash actuel 
    
    $ git stash apply
<br>
Afficher les changements non commis depuis le dernier commit 
    
    $ git diff
<br>
Afficher les différences entre deux commits
    
    $ git diff <id_commit_1><id_commit_2>
<br><br>

### 4. Récupérer les changements :
<br><br><br>
Télécharger tous les commits et branches depuis le repo en ligne sans les appliquer au repo local 

    $ git fetch <remote>
<br>
Télécharger uniquement la branche spécifiée “branch” depuis le repo distant “remote”

    $ git fetch <remote><branch>
<br>    
Fusionner les changements récupérés si acceptés 
    
    $ git merge <remote>/<branch>
<br>
Une version plus agressive de fetch qui fetch et merge simultanément 
    
    $ git pull <remote>
<br>
