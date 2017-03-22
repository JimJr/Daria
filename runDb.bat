@echo off
cls
title MongoRun
echo Running mongo DB instance
for /F "tokens=3 delims=: " %%H in ('sc query "MongoDb" ^| findstr "        STATE"') do (
  if /I "%%H" NEQ "RUNNING" (
   net start "MongoDb"
  )
)