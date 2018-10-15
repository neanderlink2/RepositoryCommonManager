# RepositoryCommonManager
Plugin para criação de repositórios.

# Como usar
Criar pastas específicas em cada projeto. De preferência, criar um namespace único para a manipulação de repositórios.
Hierarquia:

  Assets
    -> Repositories
        ->Entidades (Onde ficarão as classes para trasformar em JSON)
        ->Repository (Classes que serão usadas para acessar os arquivos JSON)
          ->Interfaces (Interfaces específicas de cada classe)
        ->ScriptableObject (Estarão aqui todas as classes usadas pelo Inspector dentro do Unity. Os dados serão usados dentro do jogo)
    -> Whatever
