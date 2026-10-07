# Konfiguration

TaskFlow liest seine Einstellungen aus der Datei `~/.taskflow/config.json`.
Fehlt die Datei, werden die Standardwerte verwendet.

## Beispiel

```json
{
"database": "~/.taskflow/tasks.db",
"default_tag": "allgemein",
"api": {
"host": "127.0.0.1",
"port": 8080
}
}
```

## Optionen

| Option         | Typ    | Standard                | Beschreibung                    |
|----------------|--------|-------------------------|---------------------------------|
| `database`     | String | `~/.taskflow/tasks.db`  | Pfad zur SQLite-Datei           |
| `default_tag`  | String | `allgemein`             | Tag für neue Aufgaben           |
| `api.host`     | String | `127.0.0.1`             | Adresse, auf der die API lauscht|
| `api.port`     | Zahl   | `8080`                  | Port der API                    |

## Umgebungsvariablen

Einstellungen lassen sich auch per Umgebungsvariable überschreiben:

```bash
export TASKFLOW_DATABASE=/tmp/test.db
export TASKFLOW_API_PORT=9000
```

!> Umgebungsvariablen haben immer Vorrang vor der Konfigurationsdatei.