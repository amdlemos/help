# Git e GitHub

## Chaves SSH e Tokens
- Chave SSH
Configurações > Settings > SSH e GPG Keys > Add New

Dar um nome para a maquina e no campo abaixo adicionar a chave pública gerada com o comando abaixo.

Necessário gerar a chave na sua maquina, com esse comando ele será gerado em /user/.ssh
```shell
ssh-keygen -t ed25519 ed -C meuemail@host.com 
cat /home/usr/.ssh/id_ed25519 
```

Após criar a chave no GitHub rodar o seguinte comando
```shell
eval $(ssh-agent -s)
ssh-add path/key (ex:  id_ed33434)
```
Quando estiver com o ssh configurado clonar os repositórios via SSH e não HTTPS 

- Token
Developers Settingns > persnal access tokens > new personal access token

## Iniciando o Git
- git init
    inicializa um repositório
- git add 
    add arquivos ao repositório local
    modified -> staged
- git commit
    staged -> unmodified

Após o git init é necessário configurar o seu usuário: 
```shell
git config --global user.email "meu@email.com"
git config --global user.name "name"
```
## Tracked
- Unmodified
- Modified
- Staged

- git restore --staged <file> ... to unstage

- git config --list
- git config --global --unset user.email
- git config --global --unset user.name

## Link repositório local ao remoto
- Crie o repositório no github
- Vá a pasta do ser repositório local e faça o apontamento:
    ```shell
    git remote add origin linkGeradoPeloGitRub
    # lista repositórios remotos
    git remote -v
    git push origin master
    ```

- git pull (puxa os códigos)
- git push (empurra os códigos)