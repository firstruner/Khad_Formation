@echo off
                        @echo Dossier %CD%
                        @echo Add
                        git add *
                        @echo Commit
                        git commit -m "%computername%-%username% (%date% %time%)"
                        @echo Push
                        git push
                        @echo Operation terminee