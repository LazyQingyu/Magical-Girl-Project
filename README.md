# Gestion des branches au sein de votre référentiel

Créez de nouvelles branches pour le développement et supprimez les branches inutilisées directement sur GitHub.

## Création d’une branche

Créez une branche afin de disposer d’un espace distinct pour travailler sur des modifications avant d’ouvrir une pull request.

> \[!NOTE]
> Vous ne pouvez créer qu’une branche dans un référentiel auquel vous avez accès en écriture.

### Créer une branche via l’aperçu des branches

1. Sur GitHub, accédez à la page principale du référentiel.
2. Dans l’arborescence de fichiers à gauche, sélectionnez le menu déroulant de branches <svg version="1.1" width="16" height="16" viewBox="0 0 16 16" class="octicon octicon-git-branch" aria-label="git-branch" role="img"><path d="M9.5 3.25a2.25 2.25 0 1 1 3 2.122V6A2.5 2.5 0 0 1 10 8.5H6a1 1 0 0 0-1 1v1.128a2.251 2.251 0 1 1-1.5 0V5.372a2.25 2.25 0 1 1 1.5 0v1.836A2.493 2.493 0 0 1 6 7h4a1 1 0 0 0 1-1v-.628A2.25 2.25 0 0 1 9.5 3.25Zm-6 0a.75.75 0 1 0 1.5 0 .75.75 0 0 0-1.5 0Zm8.25-.75a.75.75 0 1 0 0 1.5.75.75 0 0 0 0-1.5ZM4.25 12a.75.75 0 1 0 0 1.5.75.75 0 0 0 0-1.5Z"></path></svg>, puis cliquez sur **Afficher toutes les branches**. Vous trouverez également le menu déroulant de branches en haut de l’éditeur de fichiers intégré.

   ![Capture d’écran de l’arborescence de fichiers d’un dépôt. Un menu déroulant pour les branches est développé et mis en évidence avec un encadré orange foncé.](/assets/images/help/repository/file-tree-view-branch-dropdown-expanded.png)
3. Cliquez sur **Nouvelle branche**.

   ![Capture d’écran de la page « Branches » d’un dépôt. Un bouton vert, intitulé « Nouvelle branche », est mis en évidence avec un encadré orange.](/assets/images/help/branches/new-branch-button.png)
4. Sous « Nouveau nom de branche », tapez un nom pour la branche.
5. Sous « Source », choisissez la branche sur laquelle baser votre nouvelle branche.
6. Cliquez sur **Créer une branche**.

### Création d’une branche à l’aide de la liste déroulante des branches

1. Sur GitHub, accédez à la page principale du référentiel.

2. Sélectionnez le menu déroulant de branche <svg version="1.1" width="16" height="16" viewBox="0 0 16 16" class="octicon octicon-git-branch" aria-label="git-branch" role="img"><path d="M9.5 3.25a2.25 2.25 0 1 1 3 2.122V6A2.5 2.5 0 0 1 10 8.5H6a1 1 0 0 0-1 1v1.128a2.251 2.251 0 1 1-1.5 0V5.372a2.25 2.25 0 1 1 1.5 0v1.836A2.493 2.493 0 0 1 6 7h4a1 1 0 0 0 1-1v-.628A2.25 2.25 0 0 1 9.5 3.25Zm-6 0a.75.75 0 1 0 1.5 0 .75.75 0 0 0-1.5 0Zm8.25-.75a.75.75 0 1 0 0 1.5.75.75 0 0 0 0-1.5ZM4.25 12a.75.75 0 1 0 0 1.5.75.75 0 0 0 0-1.5Z"></path></svg>, dans la vue de l’arborescence des fichiers ou en haut de l’éditeur de fichiers intégré.

   ![Capture d’écran de l’arborescence de fichiers d’un dépôt. Un menu déroulant pour les branches est encadré en orange foncé.](/assets/images/help/branches/file-tree-view-branch-dropdown.png)

3. Si vous le souhaitez, pour créer la nouvelle branche à partir d’une branche autre que la branche par défaut du référentiel, cliquez sur une autre branche. Ensuite, sélectionnez à nouveau le menu déroulant de branche.

4. Dans le champ de texte « Rechercher ou créer une branche... », tapez un nom unique pour votre nouvelle branche et cliquez sur **Créer une branche**.

   ![Capture d’écran du menu déroulant du sélecteur de branche. « Créer une branche : new-branch » est surligné avec un encadré orange.](/assets/images/help/branches/create-branch-text.png)

### Création d’une branche pour un problème

Vous pouvez créer une branche pour travailler sur un problème directement à partir de la page du problème. Consultez « [Création d’une branche pour travailler sur un problème](/fr/issues/tracking-your-work-with-issues/using-issues/creating-a-branch-for-an-issue) ».

## Suppression d’une branche

Supprimez les branches dont vous n’avez plus besoin, par exemple les branches correspondant à des travaux fusionnés ou clôturés.

Vous pouvez supprimer automatiquement les branches principales après la fusion des demandes de tirage dans votre dépôt. Consultez « [Gestion de la suppression automatique des branches](/fr/repositories/configuring-branches-and-merges-in-your-repository/configuring-pull-request-merges/managing-the-automatic-deletion-of-branches) ».

> \[!NOTE]
> Si la branche que vous souhaitez supprimer est la branche par défaut du référentiel, choisissez d’abord une nouvelle branche par défaut. Consultez « [Changement de la branche par défaut](/fr/repositories/configuring-branches-and-merges-in-your-repository/managing-branches-in-your-repository/changing-the-default-branch) ».

Si la branche est associée à une demande de tirage ouverte, fusionnez ou fermez la demande de tirage avant de supprimer la branche.

1. Sur GitHub, accédez à la page principale du référentiel.
2. Dans l’arborescence de fichiers à gauche, sélectionnez le menu déroulant de branches <svg version="1.1" width="16" height="16" viewBox="0 0 16 16" class="octicon octicon-git-branch" aria-label="git-branch" role="img"><path d="M9.5 3.25a2.25 2.25 0 1 1 3 2.122V6A2.5 2.5 0 0 1 10 8.5H6a1 1 0 0 0-1 1v1.128a2.251 2.251 0 1 1-1.5 0V5.372a2.25 2.25 0 1 1 1.5 0v1.836A2.493 2.493 0 0 1 6 7h4a1 1 0 0 0 1-1v-.628A2.25 2.25 0 0 1 9.5 3.25Zm-6 0a.75.75 0 1 0 1.5 0 .75.75 0 0 0-1.5 0Zm8.25-.75a.75.75 0 1 0 0 1.5.75.75 0 0 0 0-1.5ZM4.25 12a.75.75 0 1 0 0 1.5.75.75 0 0 0 0-1.5Z"></path></svg>, puis cliquez sur **Afficher toutes les branches**. Vous trouverez également le menu déroulant de branches en haut de l’éditeur de fichiers intégré.

   ![Capture d’écran de l’arborescence de fichiers d’un dépôt. Un menu déroulant pour les branches est développé et mis en évidence avec un encadré orange foncé.](/assets/images/help/repository/file-tree-view-branch-dropdown-expanded.png)
3. En regard de la branche à supprimer, cliquez sur <svg version="1.1" width="16" height="16" viewBox="0 0 16 16" class="octicon octicon-trash" aria-label="The trash icon" role="img"><path d="M11 1.75V3h2.25a.75.75 0 0 1 0 1.5H2.75a.75.75 0 0 1 0-1.5H5V1.75C5 .784 5.784 0 6.75 0h2.5C10.216 0 11 .784 11 1.75ZM4.496 6.675l.66 6.6a.25.25 0 0 0 .249.225h5.19a.25.25 0 0 0 .249-.225l.66-6.6a.75.75 0 0 1 1.492.149l-.66 6.6A1.748 1.748 0 0 1 10.595 15h-5.19a1.75 1.75 0 0 1-1.741-1.575l-.66-6.6a.75.75 0 1 1 1.492-.15ZM6.5 1.75V3h3V1.75a.25.25 0 0 0-.25-.25h-2.5a.25.25 0 0 0-.25.25Z"></path></svg> .

   ![Capture d’écran d’une branche dans la liste des branches. Une icône représentant une poubelle est mise en évidence avec un encadré orange.](/assets/images/help/branches/branches-delete.png)
4. Si la branche est associée à au moins une demande de tirage ouverte, la suppression de la branche ferme les demandes de tirage. Lisez l’avertissement, puis cliquez sur **Supprimer**.

Si vous supprimez une branche de tête (head) une fois que sa demande de tirage a été fusionnée, GitHub recherche les demandes de tirage ouvertes du même dépôt qui spécifient la branche supprimée comme branche de base. GitHub met automatiquement à jour ces demandes de tirage, en remplaçant leur branche de base par la branche de base de la demande de tirage fusionnée.
Consultez « [Branches](/fr/pull-requests/reference/branches) ».

## Lectures complémentaires

* [Branches](/fr/pull-requests/reference/branches)
* [Visualisation des branches dans votre dépôt](/fr/repositories/configuring-branches-and-merges-in-your-repository/managing-branches-in-your-repository/viewing-branches-in-your-repository)
* [Suppression et restauration de branches dans un pull request](/fr/repositories/configuring-branches-and-merges-in-your-repository/managing-branches-in-your-repository/deleting-and-restoring-branches-in-a-pull-request)
