addto=Přidat nové direktivy do,1,1-SQL nebo LDAP databáze,0-Konfiguračního souboru
restart_cmd=Příkaz pro restartování procesů,3,Ihned poslat HUP signál
after_cmd=Příkaz spuštěný po změně pravidel,3,Nic
line0=Konfigurační soubory a programy,11
dbglobal=Tag pro globální nastavení v SQL databází,3,Výchozí (<tt>@GLOBAL</tt>)
procmail_cmd=Příkaz SpamAssassinu pro konfiguraci Procmailu,10,*-Detekovat automaticky
base=LDAP základna DN,3,Není potřeba
server=Hostname LDAP nebo SQL serveru,0
mode=Uložit nastavení SpamAssassinu do,1,0-Konfiguračních souborů,1-MySQL databáze,2-PostgreSQL databáze,3-LDAP databáze
db=Název SQL databáze,3,Není potřeba
before_cmd=Příkaz spuštěný před změnou pravidel,3,Nic
attr=LDAP atribut pro SpamAssassin preference,3,Výchozí (<tt>spamassassin</tt>)
processes=Názvy procesu SpamAssassin démona,0
uid=LDAP atribut pro uživatelská jména,3,Výchozí (<tt>uid</tt>)
warn_procmail=Zobrazit varování v případě, kdy není SpamAssassin nastaven?,1,1-Ano,0-Ne
local_cf=Konfigurační soubor nebo adresář SpamAssassinu,0
user=Přihlášení k LDAP nebo SQL serveru,0
procmailrc=Konfigurační soubor Procmailu,3,Z modulu Procmailu
port=Port LDAP nebo SQL serveru,3,Výchozí
spamassassin=Úplná cesta pro příkaz SpamAssassin,0
line1=Volby pro LDAP a SQL server,11
pass=Heslo pro LDAP nebo SQL server,0
sa_learn=Úplná cesta pro příkaz sa-learn,0
