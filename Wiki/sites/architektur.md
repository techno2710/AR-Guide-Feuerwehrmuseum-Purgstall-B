# Architektur

TaskFlow besteht aus drei Schichten, die jeweils nur die darunterliegende kennen.

## Überblick

| Schicht        | Modul                | Aufgabe                          |
|----------------|----------------------|----------------------------------|
| Oberfläche     | `taskflow.cli`       | Kommandozeilenbefehle            |
|                | `taskflow.api`       | REST-Schnittstelle               |
| Logik          | `taskflow.core`      | Regeln, Validierung, Filter      |
| Speicherung    | `taskflow.storage`   | Zugriff auf SQLite               |

## Datenfluss

```
CLI / API  →  core  →  storage  →  SQLite-Datei
```

## Das Datenmodell

```python
@dataclass
class Task:
id: int
title: str
done: bool = False
tags: list[str] = field(default_factory=list)
due: date | None = None
```

## Designentscheidungen

- **SQLite statt Server-Datenbank:** keine Installation nötig, ideal für ein persönliches Werkzeug.
- **Logik getrennt von Oberfläche:** CLI und API nutzen dieselben Funktionen aus `core`, dadurch gibt es keine doppelte Geschäftslogik.
- **Keine globalen Zustände:** Die Datenbankverbindung wird explizit übergeben, das erleichtert Tests.