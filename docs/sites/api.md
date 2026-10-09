# API-Referenz

Starte die API mit:

```bash
taskflow serve
```

Standardmäßig ist sie unter `http://127.0.0.1:8080` erreichbar.

## Aufgaben auflisten

`GET /tasks`

Optionale Parameter:

- `tag`: nur Aufgaben mit diesem Tag
- `done`: `true` oder `false`

```bash
curl "http://127.0.0.1:8080/tasks?tag=doku&done=false"
```

## Aufgabe anlegen

`POST /tasks`

```bash
curl -X POST http://127.0.0.1:8080/tasks \
-H "Content-Type: application/json" \
-d '{"title": "Wiki schreiben", "tags": ["doku"]}'
```

Antwort:

```json
{
"id": 1,
"title": "Wiki schreiben",
"done": false,
"tags": ["doku"],
"due": null
}
```

## Aufgabe abhaken

`PATCH /tasks/{id}`

```bash
curl -X PATCH http://127.0.0.1:8080/tasks/1 \
-H "Content-Type: application/json" \
-d '{"done": true}'
```

## Aufgabe löschen

`DELETE /tasks/{id}`

## Fehlercodes

| Code | Bedeutung                     |
|------|-------------------------------|
| 400  | Ungültige Eingabe             |
| 404  | Aufgabe nicht gefunden        |
| 500  | Interner Fehler               |