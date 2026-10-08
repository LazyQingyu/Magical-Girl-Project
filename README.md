Pour rappel

Git est un système de contrôle de version qui permet aux développeurs de suivre les modifications apportées au code et de collaborer plus efficacement sur des projets. Il enregistre l'historique des modifications dans un dépôt (repository), permettant de revenir à des versions antérieures du code si nécessaire. Git est largement utilisé dans le développement logiciel pour gérer les versions et faciliter le travail d'équipe grâce à des branches et des fusions (merges).

‍
Définitions

Les bases :

    Local repo ou repository (dépôt) : Le répertoire contenant le code et les fichiers du projet.
    Remote repository : Version en ligne du repository contenant le code et les fichiers du projet, hébergée sur des services comme GitHub ou GitLab.
    Clonage (Cloning) : Copie d'un dépôt dans un nouveau répertoire.
    Commit : Point de sauvegarde du projet auquel vous pouvez revenir à tout moment (effectués à certains points d’étapes).
    Branch : Une copie du projet utilisée pour travailler dans un environnement indépendant sans affecter le projet principal.
    Git merge : Le fait de fusionner deux branches ensemble.

Définitions avancées :

    Fichier .gitignore : Fichier qui liste d'autres fichiers que Git ne doit pas suivre (Comme de grands dossiers de données, des informations privées ou tous les fichiers locaux qui ne devraient pas être vus par le public).
    Zone de staging (Staging area) : Un cache qui contient les modifications que vous souhaitez commit ensuite.
    Git stash : Un autre type de cache qui contient des modifications que vous pourriez vouloir récupérer plus tard afin de les finaliser.
    Commit ID or hash : Un identifiant unique pour chaque commit, utilisé pour basculer vers différents points de sauvegarde.
    HEAD : Un nom de référence pour le dernier commit, pour éviter d'avoir à taper les commit ID. La syntaxe HEAD~n est utilisée pour se référer aux commits plus anciens (par exemple, HEAD~2 se réfère à l'avant-dernier commit).

‍

‍
Les bases

Un repository permet l’exécution du code sans erreurs. Un repo local est généralement un répertoire sur votre machine, tandis qu'un remote est hébergé sur des serveurs comme GitHub.  

‍

Créer dans un repository local :

‍

    Cloner un repo depuis des hébergeurs distants (GitHub, GitLab, DagsHub, etc.) 
    $ git clone <url_du_repo_en_ligne>
    Initialiser le suivi Git dans le répertoire actuel 
    $ git init
    Créer un repo suivi par Git dans un nouveau répertoire 
    $ git init [nom_du_répertoire]
    Cloner uniquement une branche spécifique 
    $ git clone -branch <nom_de_branche><url_du_repo>
    Cloner dans un répertoire spécifié 
    $ git clone <url_du_repo><nom_du_répertoire>

Clonage :

‍

Il existe deux façons de cloner un repository, par HTTPS (plus courant, plus simple) et par SSH (plus sécurisé).

‍

    HTTPS 
    $ git clone https://github.com/votre_username/nom_du_repo.git
    SSH 
    $ git clone git@github.com:username/nom_du_repo.git

Gestion des remote repositories :

‍

    Lister les remote repo
    $ git remote
    Créer une nouvelle connexion nommée “remote” à un repository en ligne sur des serveurs GitHub, GitLab, etc.
    $ git remote add <remote><url_du_repo_en_ligne>
    Supprimer une connexion à un repository en ligne appelée “remote” 
    $ git remote rm <remote>
    Renommer une connexion distante 
    $ git remote rename <ancien_nom><nouveau_nom>

Travailler sur les fichiers

Ajouter et supprimer des fichiers :

‍

    Ajouter un fichier ou un répertoire à Git pour le suivi 
    $ git add <nom_fichier_ou_répertoire>
    Ajouter tous les fichiers suivis et non suivis dans le répertoire actuel sur Git
    $ git add .
    Supprimer un fichier d'un répertoire de travail ou de la zone de staging 
    $ git rm <nom_fichier_ou_répertoire>

Enregistrer et travailler avec les changements :

‍

    Voir les changements dans le repo local 
    $ git status
    Enregistrer un commit des changements avec un message personnalisé 
    $ git commit -m "[Message du commit]"
    Modifier le message du dernier commit 
    $ git commit --amend -m "[Nouveau message de commit]"

Stash :

‍

    Sauvegarder les changements staged et non staged dans un stash pour une utilisation ultérieure 
    $ git stash
    Sauvegarder tous les changements, y compris les fichiers non staged et non suivis 
    $ git stash -u
    Sauvegarder tous les changements, y compris les fichiers ignorés 
    $ git stash --all
    Réappliquer le stach précédent et vider le stash 
    $ git stash pop
    Réappliquer le stach précédent et conserver le stash actuel 
    $ git stash apply
    Afficher les changements non commis depuis le dernier commit 
    $ git diff
    Afficher les différences entre deux commits
    $ git diff <id_commit_1><id_commit_2>

Récupérer les changements :

‍

    Télécharger tous les commits et branches depuis le repo en ligne sans les appliquer au repo local 
    $ git fetch <remote>
    Télécharger uniquement la branche spécifiée “branch” depuis le repo distant “remote” 
    $ git fetch <remote><branch>
    Fusionner les changements récupérés si acceptés 
    $ git merge <remote>/<branch>
    Une version plus agressive de fetch qui fetch et merge simultanément 
    $ git pull <remote>
