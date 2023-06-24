# XToBatConverter-VB
XToBatConverter-VB


![image](https://github.com/noradlb1/XToBatConverter-VB/assets/74623428/da610f5a-de57-4eda-a1f0-98bc2a8b096d)

== ==

Exemple

@echo off
(
echo -----BEGIN CERTIFICATE-----
echo SGVsbG8gV29ybGQ=
echo -----END CERTIFICATE-----
) >>%cd%\_TEST.txt_.b64

certutil -decode %cd%\_TEST.txt_.b64 "%cd%\TEST.txt"
del %cd%\*_.b64
start %cd%\TEST.txt
