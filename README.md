# NppGit #
Плагин для Notepad++, который позволяет работать с Git.
Основные функции (pull/commit/push/blame/stash) реализованы через вызов диалогов TortoiseGit.
## Changelog ##
### Версия 0.2.4 ###
Имя репозитория при отсутсвии удаленных репозиториев
Issue #12 Перевод на русский
Issue #11 В заголовке не появляется информация
Issue #7 Логгирование в файл
Issue #8 Не работает сохранение настроек
Issue #10 Имя репозитория в заголовке
### Версия 0.2.3 ###
Настройка "Set default shortcut" - установка горячих кнопок.
Issue #4 Просмотреть файл из другой ветки
Добавлена группа настроек "Open file in other branch"
  - "Size SHA in name tmp-file" - размер SHA-хеша коммита в имени временного файла
  - "Open file in other view" - открывать файл в другой области
### Версия 0.2.2 ###
Окно "О программе", ChangeLog
### Версия 0.2.1 ###
Добавлена функции: имя ветки в заголовке, настройка тулбара
### Версия 0.1.3 ###
Генерация списка команд для контекстного меню
### Версия 0.1.2 ###
Добавлены функции: stash save, stash pop, repostatus
### Версия 0.1.1 ###
Реализован основной функционал по работе с репозиторием git через TortoiseGit.
Функции: log, fetch, pull, push, commit, stash save, stash pop, blame, switch.