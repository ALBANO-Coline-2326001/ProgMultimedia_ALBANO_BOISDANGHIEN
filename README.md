# 🚀 PROJET MULTIMÉDIA : MODÉLISATION 3D ET JEU VIDÉO UNITY

Ce dépôt contient l'ensemble des travaux de modélisation 3D réalisés sur Blender ainsi que le projet de jeu vidéo 3D développé sous Unity.

---


## 🎨 Partie I : Modélisation Blender (Assets 3D)

Les fichiers sources Blender (`.blend`) sont stockés dans des dossiers individuels pour séparer le travail de chaque contributeur. Les modèles exportés (`.fbx`) sont prêts à être utilisés dans le projet Unity.

### 📁 Structure des Assets Blender

* **`Blender_Coline/`** : Contient tous les fichiers sources Blender et les exports de Coline.
    * **Pièce, Tonneau :** Modèles + Export `.fbx`.
    * **Suzanne :** 2 Cycles Renderings, Textures, UV Map.
    * **Gros Objet (Arche) :** 1 Cycle Rendering.
* **`Blender_Evan/`** : Contient tous les fichiers sources Blender et les exports d'Evan.
    * 

---

## 🎮 Partie II : Projet Jeu Vidéo (Unity)

Le dossier `JeuVideo/` contient l'intégralité du projet Unity.

* **Moteur :** Unity 2022.3.36f1 (LTS)

### ⚠️ IMPORTANT : Clonage et Synchronisation

Ce dépôt utilise **Git Large File Storage (Git LFS)** pour gérer les fichiers lourds (modèles 3D, textures).

Pour vous assurer que le projet fonctionne :

1.  **Installez Git LFS** avant de cloner le dépôt.
2.  Après le `git pull`, assurez-vous que les fichiers `.blend`, `.fbx`, et `.png` ne sont pas des pointeurs (fichiers texte). Si c'est le cas, lancez :
    ```bash
    git lfs pull
    ```

