# linux
- Shell em computação é uma interface de usuário para acessar os serviços de um sistema operacional.
- Script é uma linguagem de programação que executa os sistema em tempod e execução, muito utilizado para automação.
# basic commands
```shell
$ whoami
$ date

## pwd - print working directory
$ pwd

## cd - change directory
$ cd /       : root director
$ cd .       : current directory
$ cd ..      : directory above
$ cd ~       : home folder
$ cd -       : previous folder

## ls - list directory
$ ls
$ ls -a      : list hidden files/directory
$ ls -l      : detailed list
$ ls -R      : recursively
$ ls -r      : reverse list while order
$ ls -t      : sort by modification tyme, newest first
$ ls -s      : list content with allocated size of each file, in block	

## touch
$ touch myfile    : create a new empty file
$ touch -a myfile : altera hora de acesso
$ touch -m myfile : altera hora da modificação
$ touch -c myfile: altera hora de acesso sem criar um novo arquivo 
$ touch -t 202110051822.30 myfile : define hora especifaca de acesso e modificação
# CCYYMMDDhhmm.ss
# CC     : dois primeiros digitos do ano
# YY     : dois ultimos digitos do ano
# MM     : mês
# DD     : dia
# hh     : horas
# mm     : minutos
# ss     : segundos

# file
$ file myfile   : show a description of the file

# cat - concatenate - read one or multiple files
# para parar rolagem da tela e permitir navegação use |
$ cat myFile_01
$ cat myFile_01 myFile_02
# Copia conteúdo do myfile para myfile_02
$ cat myfile > myfile_02

# mv - move/renomeia arquivos e diretórios 
# flags: 
# -i: confirme antes de substituir
# -n: sem substituição
# -b: substituindo pelo backup
# -u: substitua se o arquvo de destino for antigo ou não existir

```
## cp
Permite copiar arquivos ou diretórios para outro local.
-i: confirma existênciab
-v: exibe saida do processo
-r: necessário para copiar pastas
-l: criar hard links em vez de copiar os arquivos
-s: cria links simbólicos em vez de copiar os arquivos
-u: copia apanes quando o arquivo de origem for mais novo do que o arquivo de destino ou quando o arquivo de destino não existir

## mkdir
Cria diretórios

## rm
Remove arquivos
-f: remove os arquivos sem confirmação

## find
```shell
# f = file
find ./ -type f -name "pesquisa"
# d = directory
find ./ -type d -name "pesquisa"
```

## diff
Faz comparação entre arquivos.
```shell
diff file.ext file2.ext
```

## rmdir, rm -rf
rmdir: remove diretórios vazil.
rm -rf: remove diretório recursivamente.

## env
Variáveis de ambiente.
PS1: Prompt da linha de comando
HOME: Diretório "/home" de usuário
PATH: Lista de diretórios vasculhados quando um comando é executado. 

```shell
# atribuindo valor a váriavel
minhaVariavel = valorDaVariavel

# exporta para variável de ambiente
export minhaVariavel

# mostra todas as váriaveis do ambiente
env

# utilizando variável
$minhaVariavel
```
