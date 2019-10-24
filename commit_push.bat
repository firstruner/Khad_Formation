@echo off
@echo Add
git add *
@echo Commit
git commit -m "Commit du %date% %time%"
@echo Push
git push
@echo Operation terminee
pause