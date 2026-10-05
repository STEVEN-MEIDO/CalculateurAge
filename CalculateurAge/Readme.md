# Calculateur d'âge — TP1 (.NET MAUI)

Application mobile .NET MAUI réalisée dans le cadre de l'Atelier de développement mobile (UQAR).
L'utilisateur saisit son nom et sa date de naissance, et l'application calcule son âge.

## Étapes du projet
- **Phase A** : version code-behind
- **Phase B** : seconde page (ResultatPage) et navigation avec Shell
- **Phase C** : réécriture selon le patron MVVM (BaseViewModel, RelayCommand, CalculateurViewModel)
- **Activité 6** : fonctionnalités ajoutées

## Fonctionnalités ajoutées (Activité 6)
1. Affichage « Majeur » ou « Mineur »
2. Refus d'une date de naissance future (message d'erreur, bouton Calculer désactivé)
3. Nombre de jours avant le prochain anniversaire
4. Bouton Effacer qui remet tous les champs à zéro

Toute la logique est dans le ViewModel : aucun code métier dans le code-behind.

## Lancer le projet
1. Ouvrir la solution dans Visual Studio (charge de travail .NET MAUI)
2. Choisir **Windows Machine** ou un émulateur Android
3. Cliquer sur ▶
