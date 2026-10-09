# FAQ

## `taskflow` wird nicht gefunden

Meist liegt das Installationsverzeichnis nicht im `PATH`. Probiere:

```bash
python -m taskflow --version
```

## Wo liegen meine Daten?

Standardmäßig in `~/.taskflow/tasks.db`. Du kannst die Datei einfach kopieren, um ein Backup zu erstellen.

## Kann ich mehrere Datenbanken nutzen?

Ja. Setze die Umgebungsvariable `TASKFLOW_DATABASE` auf einen anderen Pfad (siehe [Konfiguration](/seiten/konfiguration.md)).

## Die API ist von außen nicht erreichbar

Standardmäßig lauscht sie nur auf `127.0.0.1`. Setze `api.host` auf `0.0.0.0`, wenn andere Rechner zugreifen sollen.

?> Bitte beachte, dass die API keine Authentifizierung besitzt. Öffne sie nur in vertrauenswürdigen Netzwerken.