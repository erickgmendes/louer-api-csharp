@echo off
@echo Executing Flyway command...
call flyway clean
call flyway migrate
@echo Done.
pause
exit
